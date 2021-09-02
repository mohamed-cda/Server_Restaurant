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
    public partial class ComposezMenu : UserControl
    {
        
        private BindingSource bindingSourceMenuDuJour = new BindingSource();
        RestaurantService platDuJour = new RestaurantService();
        public ComposezMenu()
        {
            InitializeComponent();
           
        }

        private void btnComposezMenu_Click(object sender, EventArgs e)
        {
            Afficher();
        }
        private async Task Afficher()
        {

            DateTime dateMenu = dateTimePickerMenu.Value;
            bool IsMidi=true;
            if (chekMidi.Checked)
            {
                IsMidi = true;
            }
            else if(chekSoir.Checked)
            {
                IsMidi=true;
            }
            try
            {
                var reponse = await platDuJour.GetMenuByDate(dateMenu, IsMidi);

                bindingSourceMenuDuJour.DataSource = reponse.Plats;

                
                dataGridListeMenu.DataSource = bindingSourceMenuDuJour;



            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            

        }

        private void bntCreerMenuDuJour_Click(object sender, EventArgs e)
             
        {
            
            //menuDuJour
        }
    }
}
