using API.BusinessObject;
using BLLC.Services;
using BO.DTO.Requests;
using BO.DTO.Responses;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClientDesktop
   
{
    public partial class MainForm : Form
    {   private readonly IRestaurantService _restaurantService; 
        private int currentPage = 1;
        private int defaultPageSize = 50;
        int maxPage;
        private BindingSource bindingSource = new BindingSource();
        public MainForm()
        {
            _restaurantService = new RestaurantService();
            var test = new RestaurantService();
            
            InitializeComponent();
            LoadMenu();
        }
        private async void LoadMenu()
        {
            
            Task<PageResponse<Menu>> MenuPageTask = _restaurantService.GetAllReservations(new PageRequest(currentPage, defaultPageSize));
            try
            {
                await reservationsPageTask;
                PageResponse<Reservation> reservationPage = await reservationsPageTask;
                maxPage = reservationPage.TotalPages.GetValueOrDefault();
                bindingSource.DataSource = reservationPage.Data;
                reservationDataGridView.DataSource = bindingSource;
            }
            catch (Exception e)
            {

               if (DialogResult.OK == MessageBox.Show("Message" + e.Message))
                {
                    MessageBox.Show("La fenetre va fermer");
                }
                
            }
           
        }

        private void preview_Click(object sender, EventArgs e)
        {
            if (currentPage >1)
            {
                currentPage--;
                LblNumPage.Text = currentPage.ToString();
                LoadReservations();
            }

        }

        private void next_Click(object sender, EventArgs e)
        {
            if (currentPage < maxPage)
            {
                currentPage++;
                LblNumPage.Text = currentPage.ToString();
                LoadReservations();
            }
        }

        private void reoadBtn_Click(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            CreerReservation fen = new CreerReservation();
            fen.Show();
        }

        private void btnClientDesktop_Click(object sender, EventArgs e)
        {
            RestuarateurApp restau = new RestuarateurApp();
            restau.Show();
        }
    }
}
