using API.BO;
using BLLC.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDesktop
{
    public partial class RestuarateurApp : Form
    {
        public RestuarateurApp()
        {
            InitializeComponent();
            listTypePlat.Items.Add("Entree");
            listTypePlat.Items.Add("Dessert");
            listTypePlat.Items.Add("Plat");
            listTypePlat.Items.Add("Entree Plat");
            listTypePlat.Items.Add("Plat Dessert");
        }

        private async void btnCreerPlat_Click(object sender, EventArgs e)

        {
            List<string> lesIngredient = new List<string>();
            lesIngredient.Add("Carotte");
            lesIngredient.Add("Patate");
            lesIngredient.Add("Courgette");
            lesIngredient.Add("Haricot");
            lesIngredient.Add("Tomate");

            RestaurantService restaurantService = new RestaurantService();
            // public Reservation(int id_reservation, DateTime date, string nom, string prenom, string telephone, bool midi_Soir, int quantite, string formule)
            var newPlat = await restaurantService.ModernPostPlat(new Plat() { Nom =textNomPlat.Text, TypePlat = listTypePlat.SelectedItem.ToString(), IngedientListe= lesIngredient });
        }
    }
 }

