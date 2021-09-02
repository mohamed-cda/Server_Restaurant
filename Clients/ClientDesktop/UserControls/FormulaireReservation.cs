using BLLC.Services;
using BO.DTO;
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
    public partial class FormulaireReservation : UserControl
    {
        public FormulaireReservation()
        {
            InitializeComponent();
            Afficher();
        }

        
        private async Task Afficher()
        {
            int page = 1;
            int pageSize = 10;
            int maxPage = 1;
            
            PageRequest pageRequest = new PageRequest(page, pageSize);
            ReservationService reservationService = new ReservationService();
            try
            {
                var reponse = await reservationService.GetAllReservations(pageRequest);
                maxPage = reponse.TotalPages.GetValueOrDefault();
                lblPage.Text = "Page " + reponse.Page.ToString();
                dataGridResrvation.DataSource = reponse.Data;
                
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }

    }
}
