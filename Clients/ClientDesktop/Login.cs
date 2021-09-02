using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLC.Services;

namespace ClientDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
			 string login = textLogin.Text;
				string motdepasse = textPassword.Text;

            var result = await AuthentificationService.Getinstance().SignIn(login, motdepasse);

            if (result)
            {
                MainForm mainform = new MainForm();
                Login log = new Login();
                mainform.Show();
                log.Close();
                
            }
            else
            {
                MessageBox.Show("Veuillez entrer des identifiants valides");
            }


        }
    }
}
