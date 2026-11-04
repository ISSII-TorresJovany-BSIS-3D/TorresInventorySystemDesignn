using System;
using System.Windows.Forms;
using System.Data.OleDb;
using ADOX; 

namespace TorresInventorySystemDesign
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            CreateDatabase(); 
        }

        
        private void CreateDatabase()
        {
            string dbName = "sampledb.accdb";
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbName};";

            
            if (!System.IO.File.Exists(dbName))
            {
                try
                {
                    
                    Catalog cat = new Catalog();
                    cat.Create(connectionString);

                    
                    using (OleDbConnection conn = new OleDbConnection(connectionString))
                    {
                        conn.Open();
                        string createTableQuery = @"
                            CREATE TABLE Users (
                                UserID AUTOINCREMENT PRIMARY KEY,
                                FullName VARCHAR(255),
                                Username VARCHAR(255),
                                [Password] VARCHAR(255)
                            )";
                        using (OleDbCommand cmd = new OleDbCommand(createTableQuery, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Success! Nagawa na ang sampledb.accdb at Users table nang kusa.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Paki-fill up ang Username at Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=sampledb.accdb;";
            string query = "SELECT COUNT(*) FROM Users WHERE Username = ? AND [Password] = ?";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("?", txtPassword.Text.Trim());

                        int count = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);

                        if (count > 0)
                        {
                            MessageBox.Show("Login Successful! Welcome to Inventory System.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            string currentUsername = txtUsername.Text.Trim();
                            DashboardForm dash = new DashboardForm(currentUsername);
                            dash.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Maling Username o Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sa pag-connect sa database: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}