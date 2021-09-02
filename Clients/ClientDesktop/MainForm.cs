using BLLC.Services;
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
          
        }


        private void btnGestResrvation_Click(object sender, EventArgs e)
        {
           
           
        }

    }
}
