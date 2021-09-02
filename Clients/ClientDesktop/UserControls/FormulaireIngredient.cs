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
    public partial class FormulaireIngredient : UserControl
    {
        int page = 1;
        int pageSize = 10;
        int maxPage = 1;
        private BindingSource bindingsourceIngredient = new BindingSource();
        RestaurantService ingredientService = new RestaurantService();
        Ingredient ingredient = new Ingredient();

        public FormulaireIngredient()
        {
            InitializeComponent();
            grisageBouton();
            Afficher();
        }


        private async void bntCreerIngredient_Click(object sender, EventArgs e)
        {
           
            ingredient.Nom = txtNomIngredient.Text;
            ingredient.Prix = float.Parse(txtPrixIngredient.Text);

            var reponse = await ingredientService.CreateIngredient(ingredient);
            if (reponse.Nom != null)
            {
                MessageBox.Show("Le Nom" + reponse.Nom + "De l'ingredient a été ajouté dans la base de donées");
            }
            else
            {
                MessageBox.Show("erreur dinsertion en base de données base");
            }
        }

        private async void btnModifierIngredient_Click(object sender, EventArgs e)
        {        
            ingredient.Nom = txtNomIngredient.Text;            
            ingredient.Prix = float.Parse(txtPrixIngredient.Text);
            ingredient.Id_ingredient = (int)dataGridViewIngredient.CurrentRow.Cells["id"].Value;
         
            var reponse = await ingredientService.ModifyIngredient(ingredient);
            if (reponse.Id_ingredient!= 0)
            {
                MessageBox.Show("L'identifient" + reponse.Id_ingredient.ToString() + "De l'ingredient a été modifié dans la base de données");
                Afficher();
            }
            else
            {
                MessageBox.Show("erreur d'insertion en base de données base");
            }
        }

        private async void bntSupprimerIngredient_Click(object sender, EventArgs e)
        {
            Ingredient ingredientSupp = bindingsourceIngredient.Current as Ingredient;
            try
            {
                await ingredientService.RemoveIngredientById(ingredientSupp);
                MessageBox.Show("Ingredient supprimer");
            }
            catch (Exception)
            {
                MessageBox.Show("erreur de suppression!!");
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
                var reponse = await ingredientService.GetAllIngredients(pageRequest);
                maxPage = reponse.TotalPages.GetValueOrDefault();
                lblPage.Text = "Page " + reponse.Page.ToString();
                bindingsourceIngredient.DataSource = reponse.Data;
                dataGridViewIngredient.DataSource = bindingsourceIngredient;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }

        private void btnActivationBtn_Click(object sender, EventArgs e)
        {
            degrisageBouton();
        }
        private void grisageBouton()
        {
            
            btnModifierIngredient.Enabled = false;
            bntCreerIngredient.Enabled = false;
            bntSupprimerIngredient.Enabled = false;

        }
        private void degrisageBouton()
        {
            btnModifierIngredient.Enabled = true;
            bntCreerIngredient.Enabled = true;
            bntSupprimerIngredient.Enabled = true;
        }
    }
}
