namespace TorresInventorySystemDesign
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnNavSettings = new Button();
            btnNavSales = new Button();
            btnNavSuppliers = new Button();
            btnNavInventory = new Button();
            btnNavDashboard = new Button();
            lblWelcomeUser = new Label();
            lblAdminTitle = new Label();
            lblHeaderTitle = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            pnlTotalItems = new Panel();
            lblTotalItems = new Label();
            lblTotalItemsTitle = new Label();
            pnlLowStock = new Panel();
            lblLowStock = new Label();
            lblLowStockTitle = new Label();
            pnlOutOfStock = new Panel();
            lblOutOfStock = new Label();
            lblOutOfStockTitle = new Label();
            pnlInputs = new Panel();
            lblSelectedId = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtReorderLevel = new TextBox();
            lblReorderLevel = new Label();
            txtUnitPrice = new TextBox();
            lblUnitPrice = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            dgvProducts = new DataGridView();
            pnlSidebar.SuspendLayout();
            pnlTotalItems.SuspendLayout();
            pnlLowStock.SuspendLayout();
            pnlOutOfStock.SuspendLayout();
            pnlInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(34, 96, 62);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnNavSettings);
            pnlSidebar.Controls.Add(btnNavSales);
            pnlSidebar.Controls.Add(btnNavSuppliers);
            pnlSidebar.Controls.Add(btnNavInventory);
            pnlSidebar.Controls.Add(btnNavDashboard);
            pnlSidebar.Controls.Add(lblWelcomeUser);
            pnlSidebar.Controls.Add(lblAdminTitle);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(240, 907);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 57, 43);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(23, 820);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(194, 53);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnNavSettings
            // 
            btnNavSettings.FlatAppearance.BorderSize = 0;
            btnNavSettings.FlatStyle = FlatStyle.Flat;
            btnNavSettings.Font = new Font("Segoe UI", 10.5F);
            btnNavSettings.ForeColor = Color.White;
            btnNavSettings.Location = new Point(0, 453);
            btnNavSettings.Margin = new Padding(3, 4, 3, 4);
            btnNavSettings.Name = "btnNavSettings";
            btnNavSettings.Padding = new Padding(29, 0, 0, 0);
            btnNavSettings.Size = new Size(240, 60);
            btnNavSettings.TabIndex = 6;
            btnNavSettings.Text = "Settings";
            btnNavSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSettings.UseVisualStyleBackColor = true;
            // 
            // btnNavSales
            // 
            btnNavSales.FlatAppearance.BorderSize = 0;
            btnNavSales.FlatStyle = FlatStyle.Flat;
            btnNavSales.Font = new Font("Segoe UI", 10.5F);
            btnNavSales.ForeColor = Color.White;
            btnNavSales.Location = new Point(0, 387);
            btnNavSales.Margin = new Padding(3, 4, 3, 4);
            btnNavSales.Name = "btnNavSales";
            btnNavSales.Padding = new Padding(29, 0, 0, 0);
            btnNavSales.Size = new Size(240, 60);
            btnNavSales.TabIndex = 5;
            btnNavSales.Text = "Sales";
            btnNavSales.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSales.UseVisualStyleBackColor = true;
            // 
            // btnNavSuppliers
            // 
            btnNavSuppliers.FlatAppearance.BorderSize = 0;
            btnNavSuppliers.FlatStyle = FlatStyle.Flat;
            btnNavSuppliers.Font = new Font("Segoe UI", 10.5F);
            btnNavSuppliers.ForeColor = Color.White;
            btnNavSuppliers.Location = new Point(0, 320);
            btnNavSuppliers.Margin = new Padding(3, 4, 3, 4);
            btnNavSuppliers.Name = "btnNavSuppliers";
            btnNavSuppliers.Padding = new Padding(29, 0, 0, 0);
            btnNavSuppliers.Size = new Size(240, 60);
            btnNavSuppliers.TabIndex = 4;
            btnNavSuppliers.Text = "Suppliers";
            btnNavSuppliers.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnNavInventory
            // 
            btnNavInventory.BackColor = Color.FromArgb(46, 125, 82);
            btnNavInventory.FlatAppearance.BorderSize = 0;
            btnNavInventory.FlatStyle = FlatStyle.Flat;
            btnNavInventory.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnNavInventory.ForeColor = Color.White;
            btnNavInventory.Location = new Point(0, 253);
            btnNavInventory.Margin = new Padding(3, 4, 3, 4);
            btnNavInventory.Name = "btnNavInventory";
            btnNavInventory.Padding = new Padding(29, 0, 0, 0);
            btnNavInventory.Size = new Size(240, 60);
            btnNavInventory.TabIndex = 3;
            btnNavInventory.Text = "Inventory";
            btnNavInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnNavInventory.UseVisualStyleBackColor = false;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.FlatAppearance.BorderSize = 0;
            btnNavDashboard.FlatStyle = FlatStyle.Flat;
            btnNavDashboard.Font = new Font("Segoe UI", 10.5F);
            btnNavDashboard.ForeColor = Color.White;
            btnNavDashboard.Location = new Point(0, 187);
            btnNavDashboard.Margin = new Padding(3, 4, 3, 4);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Padding = new Padding(29, 0, 0, 0);
            btnNavDashboard.Size = new Size(240, 60);
            btnNavDashboard.TabIndex = 2;
            btnNavDashboard.Text = "Dashboard";
            btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnNavDashboard.UseVisualStyleBackColor = true;
            // 
            // lblWelcomeUser
            // 
            lblWelcomeUser.Font = new Font("Segoe UI", 9.5F);
            lblWelcomeUser.ForeColor = Color.FromArgb(210, 240, 220);
            lblWelcomeUser.Location = new Point(14, 96);
            lblWelcomeUser.Name = "lblWelcomeUser";
            lblWelcomeUser.Size = new Size(213, 33);
            lblWelcomeUser.TabIndex = 1;
            lblWelcomeUser.Text = "Welcome, Admin";
            lblWelcomeUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAdminTitle
            // 
            lblAdminTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAdminTitle.ForeColor = Color.White;
            lblAdminTitle.Location = new Point(14, 43);
            lblAdminTitle.Name = "lblAdminTitle";
            lblAdminTitle.Size = new Size(213, 47);
            lblAdminTitle.TabIndex = 0;
            lblAdminTitle.Text = "ADMIN PANEL";
            lblAdminTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(25, 70, 45);
            lblHeaderTitle.Location = new Point(263, 24);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(311, 41);
            lblHeaderTitle.TabIndex = 1;
            lblHeaderTitle.Text = "TORRES INVENTORY";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(749, 29);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(279, 30);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(34, 96, 62);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1040, 27);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(97, 39);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(52, 73, 94);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1149, 27);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(103, 39);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pnlTotalItems
            // 
            pnlTotalItems.BackColor = Color.FromArgb(187, 214, 238);
            pnlTotalItems.Controls.Add(lblTotalItems);
            pnlTotalItems.Controls.Add(lblTotalItemsTitle);
            pnlTotalItems.Location = new Point(263, 87);
            pnlTotalItems.Margin = new Padding(3, 4, 3, 4);
            pnlTotalItems.Name = "pnlTotalItems";
            pnlTotalItems.Size = new Size(314, 107);
            pnlTotalItems.TabIndex = 5;
            // 
            // lblTotalItems
            // 
            lblTotalItems.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalItems.Location = new Point(11, 47);
            lblTotalItems.Name = "lblTotalItems";
            lblTotalItems.Size = new Size(291, 51);
            lblTotalItems.TabIndex = 1;
            lblTotalItems.Text = "0";
            lblTotalItems.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalItemsTitle
            // 
            lblTotalItemsTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTotalItemsTitle.Location = new Point(11, 11);
            lblTotalItemsTitle.Name = "lblTotalItemsTitle";
            lblTotalItemsTitle.Size = new Size(291, 32);
            lblTotalItemsTitle.TabIndex = 0;
            lblTotalItemsTitle.Text = "Total Items";
            lblTotalItemsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLowStock
            // 
            pnlLowStock.BackColor = Color.FromArgb(255, 213, 158);
            pnlLowStock.Controls.Add(lblLowStock);
            pnlLowStock.Controls.Add(lblLowStockTitle);
            pnlLowStock.Location = new Point(600, 87);
            pnlLowStock.Margin = new Padding(3, 4, 3, 4);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(314, 107);
            pnlLowStock.TabIndex = 6;
            // 
            // lblLowStock
            // 
            lblLowStock.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblLowStock.Location = new Point(11, 47);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(291, 51);
            lblLowStock.TabIndex = 1;
            lblLowStock.Text = "0";
            lblLowStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblLowStockTitle.Location = new Point(11, 11);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(291, 32);
            lblLowStockTitle.TabIndex = 0;
            lblLowStockTitle.Text = "Low Stock";
            lblLowStockTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlOutOfStock
            // 
            pnlOutOfStock.BackColor = Color.FromArgb(255, 173, 173);
            pnlOutOfStock.Controls.Add(lblOutOfStock);
            pnlOutOfStock.Controls.Add(lblOutOfStockTitle);
            pnlOutOfStock.Location = new Point(937, 87);
            pnlOutOfStock.Margin = new Padding(3, 4, 3, 4);
            pnlOutOfStock.Name = "pnlOutOfStock";
            pnlOutOfStock.Size = new Size(314, 107);
            pnlOutOfStock.TabIndex = 7;
            // 
            // lblOutOfStock
            // 
            lblOutOfStock.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblOutOfStock.Location = new Point(11, 47);
            lblOutOfStock.Name = "lblOutOfStock";
            lblOutOfStock.Size = new Size(291, 51);
            lblOutOfStock.TabIndex = 1;
            lblOutOfStock.Text = "0";
            lblOutOfStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOutOfStockTitle
            // 
            lblOutOfStockTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblOutOfStockTitle.Location = new Point(11, 11);
            lblOutOfStockTitle.Name = "lblOutOfStockTitle";
            lblOutOfStockTitle.Size = new Size(291, 32);
            lblOutOfStockTitle.TabIndex = 0;
            lblOutOfStockTitle.Text = "Out of Stock";
            lblOutOfStockTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInputs
            // 
            pnlInputs.BackColor = Color.White;
            pnlInputs.BorderStyle = BorderStyle.FixedSingle;
            pnlInputs.Controls.Add(lblSelectedId);
            pnlInputs.Controls.Add(btnClear);
            pnlInputs.Controls.Add(btnDelete);
            pnlInputs.Controls.Add(btnUpdate);
            pnlInputs.Controls.Add(btnAdd);
            pnlInputs.Controls.Add(txtReorderLevel);
            pnlInputs.Controls.Add(lblReorderLevel);
            pnlInputs.Controls.Add(txtUnitPrice);
            pnlInputs.Controls.Add(lblUnitPrice);
            pnlInputs.Controls.Add(txtQuantity);
            pnlInputs.Controls.Add(lblQuantity);
            pnlInputs.Controls.Add(cmbCategory);
            pnlInputs.Controls.Add(lblCategory);
            pnlInputs.Controls.Add(txtProductName);
            pnlInputs.Controls.Add(lblProductName);
            pnlInputs.Location = new Point(263, 213);
            pnlInputs.Margin = new Padding(3, 4, 3, 4);
            pnlInputs.Name = "pnlInputs";
            pnlInputs.Size = new Size(988, 186);
            pnlInputs.TabIndex = 8;
            // 
            // lblSelectedId
            // 
            lblSelectedId.AutoSize = true;
            lblSelectedId.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            lblSelectedId.ForeColor = Color.DimGray;
            lblSelectedId.Location = new Point(709, 127);
            lblSelectedId.Name = "lblSelectedId";
            lblSelectedId.Size = new Size(131, 21);
            lblSelectedId.TabIndex = 14;
            lblSelectedId.Text = "Selected ID: None";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(108, 117, 125);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(543, 113);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(137, 48);
            btnClear.TabIndex = 13;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(377, 113);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 48);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 123, 255);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(194, 113);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(166, 48);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "EDIT / UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(40, 167, 69);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(17, 113);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 48);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "+ ADD NEW";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.Font = new Font("Segoe UI", 10F);
            txtReorderLevel.Location = new Point(840, 51);
            txtReorderLevel.Margin = new Padding(3, 4, 3, 4);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(125, 30);
            txtReorderLevel.TabIndex = 9;
            // 
            // lblReorderLevel
            // 
            lblReorderLevel.AutoSize = true;
            lblReorderLevel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblReorderLevel.Location = new Point(840, 21);
            lblReorderLevel.Name = "lblReorderLevel";
            lblReorderLevel.Size = new Size(114, 21);
            lblReorderLevel.TabIndex = 8;
            lblReorderLevel.Text = "Reorder Level";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Segoe UI", 10F);
            txtUnitPrice.Location = new Point(691, 51);
            txtUnitPrice.Margin = new Padding(3, 4, 3, 4);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(131, 30);
            txtUnitPrice.TabIndex = 7;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUnitPrice.Location = new Point(691, 21);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(85, 21);
            lblUnitPrice.TabIndex = 6;
            lblUnitPrice.Text = "Unit Price";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 10F);
            txtQuantity.Location = new Point(543, 51);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(131, 30);
            txtQuantity.TabIndex = 5;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblQuantity.Location = new Point(543, 21);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(77, 21);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Food", "Beverages", "Grocery", "Computer Hardware", "Phone Accessories", "Others" });
            cmbCategory.Location = new Point(303, 51);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(222, 31);
            cmbCategory.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCategory.Location = new Point(303, 21);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(80, 21);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 10F);
            txtProductName.Location = new Point(17, 51);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(268, 30);
            txtProductName.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblProductName.Location = new Point(17, 21);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(120, 21);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(263, 420);
            dgvProducts.Margin = new Padding(3, 4, 3, 4);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 45;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(989, 460);
            dgvProducts.TabIndex = 9;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 248, 243);
            ClientSize = new Size(1280, 907);
            Controls.Add(dgvProducts);
            Controls.Add(pnlInputs);
            Controls.Add(pnlOutOfStock);
            Controls.Add(pnlLowStock);
            Controls.Add(pnlTotalItems);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblHeaderTitle);
            Controls.Add(pnlSidebar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Torres Inventory System - Admin Panel";
            pnlSidebar.ResumeLayout(false);
            pnlTotalItems.ResumeLayout(false);
            pnlLowStock.ResumeLayout(false);
            pnlOutOfStock.ResumeLayout(false);
            pnlInputs.ResumeLayout(false);
            pnlInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblAdminTitle;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavInventory;
        private System.Windows.Forms.Button btnNavSuppliers;
        private System.Windows.Forms.Button btnNavSales;
        private System.Windows.Forms.Button btnNavSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlTotalItems;
        private System.Windows.Forms.Label lblTotalItemsTitle;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Label lblLowStockTitle;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Panel pnlOutOfStock;
        private System.Windows.Forms.Label lblOutOfStockTitle;
        private System.Windows.Forms.Label lblOutOfStock;
        private System.Windows.Forms.Panel pnlInputs;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSelectedId;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}