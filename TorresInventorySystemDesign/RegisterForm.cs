using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TorresInventorySystemDesign
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Paki-fill up ang lahat ng fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Hindi nagtutugma ang Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=sampledb.accdb;";
            string query = "INSERT INTO Users (FullName, Username, [Password]) VALUES (?, ?, ?)";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", txtFullName.Text);
                        cmd.Parameters.AddWithValue("?", txtUsername.Text);
                        cmd.Parameters.AddWithValue("?", txtPassword.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Matagumpay na nakapag-register!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        SignInForm loginForm = new SignInForm();
                        loginForm.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("May error sa pag-save: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}