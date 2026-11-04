using System;
using System.Windows.Forms;

namespace TorresInventorySystemDesign
{
    public partial class DashboardForm : Form
    {
        private string loggedUser;

        
        public DashboardForm(string username)
        {
            InitializeComponent();
            loggedUser = username;

            
            lblWelcome.Text = "Welcome, " + loggedUser + "!";
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Optional load event
        }

        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            SignInForm login = new SignInForm();
            login.Show();
            this.Close();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}