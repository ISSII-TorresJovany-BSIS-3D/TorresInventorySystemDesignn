namespace TorresInventorySystemDesign
{
    partial class SignInForm
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
            pnlCard = new Panel();
            pnlForm = new Panel();
            linkRegister = new LinkLabel();
            btnSignIn = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblSubtext = new Label();
            lblWelcome = new Label();
            pnlBrand = new Panel();
            lblBrandFooter = new Label();
            lblBrandSub = new Label();
            pnlDivider = new Panel();
            lblBrandTitle = new Label();
            pnlCard.SuspendLayout();
            pnlForm.SuspendLayout();
            pnlBrand.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(pnlForm);
            pnlCard.Controls.Add(pnlBrand);
            pnlCard.Location = new Point(69, 73);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(868, 573);
            pnlCard.TabIndex = 0;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(linkRegister);
            pnlForm.Controls.Add(btnSignIn);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(lblPassword);
            pnlForm.Controls.Add(txtUsername);
            pnlForm.Controls.Add(lblUsername);
            pnlForm.Controls.Add(lblSubtext);
            pnlForm.Controls.Add(lblWelcome);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(354, 0);
            pnlForm.Margin = new Padding(3, 4, 3, 4);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(512, 571);
            pnlForm.TabIndex = 1;
            // 
            // linkRegister
            // 
            linkRegister.ActiveLinkColor = Color.FromArgb(46, 125, 82);
            linkRegister.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            linkRegister.LinkBehavior = LinkBehavior.HoverUnderline;
            linkRegister.LinkColor = Color.FromArgb(34, 96, 62);
            linkRegister.Location = new Point(57, 453);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(400, 33);
            linkRegister.TabIndex = 7;
            linkRegister.TabStop = true;
            linkRegister.Text = "Don't have an account? Register here.";
            linkRegister.TextAlign = ContentAlignment.MiddleCenter;
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(34, 96, 62);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 125, 82);
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(57, 368);
            btnSignIn.Margin = new Padding(3, 4, 3, 4);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(400, 59);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "SIGN IN";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(245, 250, 247);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11.5F);
            txtPassword.Location = new Point(57, 293);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(400, 33);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(45, 65, 55);
            lblPassword.Location = new Point(57, 263);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 21);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(245, 250, 247);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11.5F);
            txtUsername.Location = new Point(57, 200);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 33);
            txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(45, 65, 55);
            lblUsername.Location = new Point(57, 169);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 21);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblSubtext
            // 
            lblSubtext.AutoSize = true;
            lblSubtext.Font = new Font("Segoe UI", 9.5F);
            lblSubtext.ForeColor = Color.FromArgb(110, 125, 118);
            lblSubtext.Location = new Point(58, 109);
            lblSubtext.Name = "lblSubtext";
            lblSubtext.Size = new Size(252, 21);
            lblSubtext.TabIndex = 1;
            lblSubtext.Text = "Sign in to your account to continue";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(25, 70, 45);
            lblWelcome.Location = new Point(54, 56);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(262, 46);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Back!";
            // 
            // pnlBrand
            // 
            pnlBrand.BackColor = Color.FromArgb(34, 96, 62);
            pnlBrand.Controls.Add(lblBrandFooter);
            pnlBrand.Controls.Add(lblBrandSub);
            pnlBrand.Controls.Add(pnlDivider);
            pnlBrand.Controls.Add(lblBrandTitle);
            pnlBrand.Dock = DockStyle.Left;
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Margin = new Padding(3, 4, 3, 4);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(354, 571);
            pnlBrand.TabIndex = 0;
            // 
            // lblBrandFooter
            // 
            lblBrandFooter.Font = new Font("Segoe UI", 8.5F);
            lblBrandFooter.ForeColor = Color.FromArgb(180, 220, 195);
            lblBrandFooter.Location = new Point(37, 509);
            lblBrandFooter.Name = "lblBrandFooter";
            lblBrandFooter.Size = new Size(280, 29);
            lblBrandFooter.TabIndex = 3;
            lblBrandFooter.Text = "Admin & Inventory Control Portal";
            // 
            // lblBrandSub
            // 
            lblBrandSub.Font = new Font("Segoe UI", 10F);
            lblBrandSub.ForeColor = Color.FromArgb(215, 242, 225);
            lblBrandSub.Location = new Point(37, 309);
            lblBrandSub.Name = "lblBrandSub";
            lblBrandSub.Size = new Size(280, 87);
            lblBrandSub.TabIndex = 2;
            lblBrandSub.Text = "Manage products, monitor stock levels, and track inventory in real time.";
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(130, 224, 170);
            pnlDivider.Location = new Point(39, 283);
            pnlDivider.Margin = new Padding(3, 4, 3, 4);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(63, 5);
            pnlDivider.TabIndex = 1;
            // 
            // lblBrandTitle
            // 
            lblBrandTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblBrandTitle.ForeColor = Color.White;
            lblBrandTitle.Location = new Point(34, 109);
            lblBrandTitle.Name = "lblBrandTitle";
            lblBrandTitle.Size = new Size(286, 160);
            lblBrandTitle.TabIndex = 0;
            lblBrandTitle.Text = "TORRES\r\nINVENTORY\r\nSYSTEM";
            // 
            // SignInForm
            // 
            AcceptButton = btnSignIn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 248, 243);
            ClientSize = new Size(1098, 768);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Torres Inventory System - Sign In";
            pnlCard.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlBrand.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblBrandSub;
        private System.Windows.Forms.Label lblBrandFooter;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtext;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.LinkLabel linkRegister;
    }
}