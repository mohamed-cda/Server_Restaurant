using BLLC.Services;
using BO.DTO;
using BO.DTO.Responses;
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
    public partial class FormulairePlat : UserControl
    {
        int page = 1;
        int pageSize = 10;
        int maxPage = 1;
        private BindingSource bindingsourcePlat = new BindingSource();
        RestaurantService platService = new RestaurantService();
       
        public FormulairePlat()
        {
            InitializeComponent();
            grisageBouton();
            Afficher();
        }

        private async Task Afficher()
        {
            PageRequest pageRequest = new PageRequest(page, pageSize);
           
            try
            {
                var reponse = await platService.GetAllPlats(pageRequest);
                maxPage = reponse.TotalPages.GetValueOrDefault();
                lblPage.Text = "Page " + reponse.Page.ToString();
                dataGridViewPlat.DataSource = reponse.Data;
                bindingsourcePlat.DataSource = reponse.Data;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }


        private async void bntCreerPlat_Click(object sender, EventArgs e)
        {
            RestaurantService platService = new RestaurantService();
            Plat plat = new Plat();
           
            plat.Nom = txtNomPlat.Text;
            if (radioBtnEntree.Checked)
            {
                plat.Id_Type = 1;

            }
            else if (radioBtnPlat.Checked)
            {
                plat.Id_Type = 2;
            }
            else if(radioBtnDessert.Checked)
            {
                plat.Id_Type =3;
            }

            var reponse = await platService.CreatePlat(plat);
            if (reponse.Id_plat != 0)
            {
                MessageBox.Show("L'identifien" + reponse.Id_plat.ToString() + "Du plat a été ajouté dans la base de donées");
               await Afficher();
            }
            else
            {
                MessageBox.Show("erreur dinsertion en base de données base");
            }
        }

        private async void btnModifierPlat_Click(object sender, EventArgs e)
        {
            Plat plat = new Plat();
            plat.Nom = txtNomPlat.Text;
            if (radioBtnEntree.Checked)
            {
                plat.Id_Type =1;

            }
            else if (radioBtnPlat.Checked)
            {
                plat.Id_Type = 2;
            }
            else if (radioBtnDessert.Checked)
            {
                plat.Id_Type = 3;
            }

            plat.Id_plat = (int)dataGridViewPlat.CurrentRow.Cells["id"].Value;
           
            var reponse = await platService.ModifyPlat(plat);
            if (reponse.Id_plat != 0)
            {
                MessageBox.Show("L'identifien" + reponse.Id_plat.ToString() + "Du plat a été modifié dans la base de donées");
                await Afficher();
            }
            else
            {
                MessageBox.Show("erreur d'insertion en base de données base");
            }
        }

        private async void bntSupprimerPlat_Click(object sender, EventArgs e)
        {
            Plat suppPlat = bindingsourcePlat.Current as Plat;
            try
            {
                await platService.RemovePlatById(suppPlat);
                MessageBox.Show("le plat a été supprimé!!");
              await  Afficher();

            }
            catch (Exception)
            {

                MessageBox.Show("erreur de suppression!!");
            }
        }
        private void grisageBouton()
        {

            panPlatCrud.Enabled = false;

        }
        private void degrisageBouton()
        {
            panPlatCrud.Enabled = true;
        }

        private void btnActivationCrud_Click(object sender, EventArgs e)
        {
            degrisageBouton();
        }

        private async void bntSuivant_Click(object sender, EventArgs e)
        {
            if (page < maxPage)
            {
                page++;
                await Afficher();
            }
        }

        private async void btnPrec_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                await Afficher();
            }
        }

        private async void btnPlatIng_Click(object sender, EventArgs e)
        {
            RestaurantService platService = new RestaurantService();
            int id = 28;
            try
            {
                var reponse = await platService.GetAsync(id);
                
                dataGridViewPlat.DataSource = reponse.Ingredient;
                //bindingsourcePlat.DataSource = reponse.Data;
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
            }

        }
    }
    }

