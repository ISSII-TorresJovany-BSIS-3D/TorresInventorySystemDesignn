namespace TorresInventorySystemDesign
{
    partial class RegisterForm
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
            panel1 = new Panel();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            btnRegister = new Button();
            label5 = new Label();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblFullName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(lblConfirmPassword);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblFullName);
            panel1.Location = new Point(215, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 725);
            panel1.TabIndex = 10;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(124, 504);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(506, 27);
            txtConfirmPassword.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(124, 422);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(506, 27);
            txtPassword.TabIndex = 11;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(124, 476);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(162, 25);
            lblConfirmPassword.TabIndex = 10;
            lblConfirmPassword.Text = "Re-enter Password:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(124, 394);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Vineta BT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(124, 66);
            label3.Name = "label3";
            label3.Size = new Size(531, 41);
            label3.TabIndex = 5;
            label3.Text = "TORRES INVENTORY";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(209, 642);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(257, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don't have an account? Register here.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Vineta BT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(259, 124);
            label4.Name = "label4";
            label4.Size = new Size(207, 38);
            label4.TabIndex = 6;
            label4.Text = "SYSTEM";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.MidnightBlue;
            btnRegister.ForeColor = SystemColors.ControlLightLight;
            btnRegister.Location = new Point(279, 569);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(142, 40);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(279, 178);
            label5.Name = "label5";
            label5.Size = new Size(167, 22);
            label5.TabIndex = 7;
            label5.Text = "Create your Account";
            label5.UseWaitCursor = true;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(124, 277);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(506, 27);
            txtFullName.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(124, 347);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(506, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(124, 319);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(95, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(124, 249);
            lblFullName.Margin = new Padding(4, 0, 4, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(95, 25);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1193, 808);
            Controls.Add(panel1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label4;
        private Button btnRegister;
        private Label label5;
        private TextBox txtUsername;
        private TextBox txtFullName;
        private Label lblFullName;
        private Label lblUsername;
        private Label lblConfirmPassword;
        private Label lblPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
    }
}