using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TorresInventorySystemDesign
{
    public partial class DashboardForm : Form
    {
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=sampledb.accdb;";
        private int selectedProductId = -1;

        public DashboardForm()
        {
            InitializeComponent();
            EnsureProductsTable();
            LoadProducts();
        }

        public DashboardForm(string username) : this()
        {
            lblWelcomeUser.Text = "Welcome, " + username;
        }

        private void EnsureProductsTable()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    DataTable schema = conn.GetSchema("Tables", new string[] { null, null, "Products", "TABLE" });
                    if (schema.Rows.Count == 0)
                    {
                        string createTableQuery = @"
                            CREATE TABLE Products (
                                ProductID AUTOINCREMENT PRIMARY KEY,
                                ProductName VARCHAR(255),
                                Category VARCHAR(100),
                                Quantity INT,
                                UnitPrice CURRENCY,
                                ReorderLevel INT
                            )";
                        using (OleDbCommand cmd = new OleDbCommand(createTableQuery, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sa paggawa ng Products table: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadProducts(string keyword = "")
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = string.IsNullOrWhiteSpace(keyword)
                        ? "SELECT ProductID, ProductName, Category, Quantity, UnitPrice, ReorderLevel FROM Products ORDER BY ProductID ASC"
                        : "SELECT ProductID, ProductName, Category, Quantity, UnitPrice, ReorderLevel FROM Products WHERE ProductName LIKE ? OR Category LIKE ? ORDER BY ProductID ASC";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(keyword))
                        {
                            cmd.Parameters.AddWithValue("?", "%" + keyword + "%");
                            cmd.Parameters.AddWithValue("?", "%" + keyword + "%");
                        }

                        using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dt.Columns.Add("Status", typeof(string));
                            int lowStockCount = 0;
                            int outOfStockCount = 0;

                            foreach (DataRow row in dt.Rows)
                            {
                                int qty = Convert.ToInt32(row["Quantity"]);
                                int reorder = Convert.ToInt32(row["ReorderLevel"]);

                                if (qty == 0)
                                {
                                    row["Status"] = "Out of Stock";
                                    outOfStockCount++;
                                }
                                else if (qty <= reorder)
                                {
                                    row["Status"] = "Low Stock";
                                    lowStockCount++;
                                }
                                else
                                {
                                    row["Status"] = "In Stock";
                                }
                            }

                            dgvProducts.DataSource = dt;
                            lblTotalItems.Text = dt.Rows.Count.ToString();
                            lblLowStock.Text = lowStockCount.ToString();
                            lblOutOfStock.Text = outOfStockCount.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sa pag-load ng products: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInputs(out int qty, out decimal price, out int reorder)
        {
            qty = 0;
            price = 0;
            reorder = 0;

            if (string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Paki-fill up ang Product Name at Category!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out qty) || qty < 0)
            {
                MessageBox.Show("Maglagay ng tamang numero para sa Quantity.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out price) || price < 0)
            {
                MessageBox.Show("Maglagay ng tamang halaga para sa Unit Price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtReorderLevel.Text.Trim(), out reorder) || reorder < 0)
            {
                MessageBox.Show("Maglagay ng tamang numero para sa Reorder Level.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            selectedProductId = -1;
            lblSelectedId.Text = "Selected ID: None";
            txtProductName.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbCategory.Text = "";
            txtQuantity.Clear();
            txtUnitPrice.Clear();
            txtReorderLevel.Clear();
            dgvProducts.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out int qty, out decimal price, out int reorder)) return;

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Products (ProductName, Category, Quantity, UnitPrice, ReorderLevel) VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", txtProductName.Text.Trim());
                        cmd.Parameters.AddWithValue("?", cmbCategory.Text.Trim());
                        cmd.Parameters.AddWithValue("?", qty);
                        cmd.Parameters.AddWithValue("?", price);
                        cmd.Parameters.AddWithValue("?", reorder);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sa pag-add ng product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value != null)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                selectedProductId = Convert.ToInt32(row.Cells["ProductID"].Value);
                lblSelectedId.Text = "Selected ID: " + selectedProductId;

                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                cmbCategory.Text = row.Cells["Category"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
                txtReorderLevel.Text = row.Cells["ReorderLevel"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductId == -1)
            {
                MessageBox.Show("Pumili muna ng product sa table na i-u-update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs(out int qty, out decimal price, out int reorder)) return;

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Products SET ProductName = ?, Category = ?, Quantity = ?, UnitPrice = ?, ReorderLevel = ? WHERE ProductID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", txtProductName.Text.Trim());
                        cmd.Parameters.AddWithValue("?", cmbCategory.Text.Trim());
                        cmd.Parameters.AddWithValue("?", qty);
                        cmd.Parameters.AddWithValue("?", price);
                        cmd.Parameters.AddWithValue("?", reorder);
                        cmd.Parameters.AddWithValue("?", selectedProductId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sa pag-update ng product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == -1)
            {
                MessageBox.Show("Pumili muna ng product sa table na i-de-delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Sigurado ka bang gusto mong burahin ang product na ito?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Products WHERE ProductID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", selectedProductId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sa pag-delete ng product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text.Trim());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text.Trim());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ClearFields();
            LoadProducts();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                SignInForm signIn = new SignInForm();
                signIn.Show();
                this.Hide();
            }
        }
    }
}