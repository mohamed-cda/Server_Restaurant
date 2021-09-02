using BLLC.Services;
using BO.DTO;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDesktop.UserControls
{
    public partial class FormulaireMenu : UserControl
    {
        int page = 1;
        int pageSize = 10;
        int maxPage = 1;
        private BindingSource bindingsourceMenu = new BindingSource();
        RestaurantService menuService = new RestaurantService();
        
        public FormulaireMenu()
        {
            InitializeComponent();

            Afficher();
            grisageBouton();

        }

        private async void btnCreerMenu_Click(object sender, EventArgs e)
        {
            RestaurantService menuService = new RestaurantService();
            Menu menu = new Menu();
            menu.Date = dateTimePickerDateMenu.Value;
            if (radioBtnMidi.Checked)
            {
                menu.IsMidi= true;

            }
            else if (radioBtnSoir.Checked)
            {
                menu.IsMidi = false;
            }

            var reponse = await menuService.PostMenu(menu);
            if (reponse.Id_menu != 0)
            {
                MessageBox.Show("L'identifien" + reponse.Id_menu.ToString() + "Du menu a été ajouté dans la base de donées");
                await Afficher();
            }
            else
            {
                MessageBox.Show("erreur dinsertion en base de données base");
            }
        }
   

        private async void btnModifMenu_Click(object sender, EventArgs e)
        {

            Menu menu = new Menu();
            menu.Date = dateTimePickerDateMenu.Value;
            if (radioBtnMidi.Checked)
            {
                menu.IsMidi=true;

            }
            else if (radioBtnSoir.Checked)
            {
                menu.IsMidi =false;
            }
            menu.Id_menu = (int)dataGridViewMenu.CurrentRow.Cells["id_menu"].Value;
            // menu = dataGridViewMenu.SelectedRows;
            var reponse = await menuService.ModifyMenu(menu);
            if (reponse.Id_menu != 0)
            {
                MessageBox.Show("L'identifien" + reponse.Id_menu.ToString() + "Du menu a été modifié dans la base de donées");
                await Afficher();
            }
            else
            {
                MessageBox.Show("erreur d'insertion en base de données base");
            }

        }

        private async void btnSuppMenu_Click(object sender, EventArgs e)
        {
            Menu menusupp = bindingsourceMenu.Current as Menu;
            try
            {
                await menuService.RemoveMenuById(menusupp);
                MessageBox.Show("Menu supprimé!!");
                await Afficher();
            }
            catch (Exception)
            {

                MessageBox.Show("erreur de supression du menu!!");
            }
        }


        private async void btnPrecedent_Click(object sender, EventArgs e)
        {
            
                if (page > 1)
                {
                    page--;
                    await Afficher();
                }
        }

        private async void bntSuivant_Click(object sender, EventArgs e)
        {
            if (page < maxPage)
            {
                page++;
                await Afficher();
            }
        }
        private async Task Afficher()
        {

            PageRequest pageRequest = new PageRequest(page, pageSize);
            
            try
            {
                var reponse = await menuService.GetAllMenus(pageRequest);
                maxPage = reponse.TotalPages.GetValueOrDefault();
                
                lblPage.Text = "Page " + reponse.Page.ToString();
                dataGridViewMenu.DataSource = reponse.Data;

                bindingsourceMenu.DataSource = reponse.Data;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
        private void grisageBouton()
        {

            panCrud.Enabled = false;

        }
        private void degrisageBouton()
        {
            panCrud.Enabled = true;
        }

        private void btnActivationCrud_Click(object sender, EventArgs e)
        {
            degrisageBouton();
        }
    }
}
