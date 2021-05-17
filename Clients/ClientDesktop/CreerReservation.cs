using API.BusinessObject;
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
    public partial class CreerReservation : Form
    {
        public CreerReservation()
        {
            InitializeComponent();
            listBox1.Items.Add("Entree");
            listBox1.Items.Add("Dessert");
            listBox1.Items.Add("Plat");
            listBox1.Items.Add("Entree Plat");
            listBox1.Items.Add("Plat Dessert");
        }

        private async void btnValiderAjout_Click(object sender, EventArgs e)
        {
        //    bool M_S ;
        //    if(radioBtnMidi.Checked)
        //    {
        //        M_S = true;
        //    }
        //    else
        //    {
        //        M_S = false;
        //    }
        //    int Qte = 0;
        //    int.TryParse(textQuantiteReservation.Text, out Qte);
        //    ReservationService reservationService = new ReservationService();
        //   // public Reservation(int id_reservation, DateTime date, string nom, string prenom, string telephone, bool midi_Soir, int quantite, string formule)
        //    var newReservation = await reservationService.ModernPostReservation(new Reservation() { Nom = textNomReservation.Text, Prenom = textPrenomReservation.Text, Date =dateTimePicker1.Value, Telephone =textTelephoneReservation.Text, Quantite =Qte , Midi_Soir =M_S,Formule =listBox1.SelectedItem.ToString() });
        }
    }
}
