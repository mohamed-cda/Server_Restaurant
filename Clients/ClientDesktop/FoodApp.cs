
using ClientDesktop.UserControls;
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
    public partial class FoodApp : Form
    {


        public FoodApp()
        {
            InitializeComponent();
        }

       

        
        private void btnReservation_Click(object sender, EventArgs e)
        {
            panForm.Controls.Clear();
            panForm.Controls.Add(new FormulaireReservation());
        }

        private void btnIngredient_Click(object sender, EventArgs e)
        {
            panForm.Controls.Clear();
            panForm.Controls.Add(new FormulaireIngredient());
        }

        private void btnPlat_Click(object sender, EventArgs e)
        {
            panForm.Controls.Clear();
            panForm.Controls.Add(new FormulairePlat());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panForm.Controls.Clear();
            
            panForm.Controls.Add(new FormulaireMenu());
        }

        private void panForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntAccueil_Click(object sender, EventArgs e)
        {
            panForm.Controls.Clear();
            panForm.Controls.Add(new Bandeau());
        }

        private void btnComposezMenuJ_Click(object sender, EventArgs e)
        {
            panForm.Controls.Clear();

            panForm.Controls.Add(new ComposezMenu());
        }
    }
}
