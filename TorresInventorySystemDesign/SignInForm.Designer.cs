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
            panel1 = new Panel();
            txtPassword = new TextBox();
            lblPassword = new Label();
            label3 = new Label();
            linkRegister = new LinkLabel();
            label4 = new Label();
            btnSignIn = new Button();
            label5 = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(linkRegister);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblUsername);
            panel1.Location = new Point(215, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 725);
            panel1.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(124, 422);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(506, 27);
            txtPassword.TabIndex = 11;
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
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Location = new Point(209, 642);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(257, 20);
            linkRegister.TabIndex = 8;
            linkRegister.TabStop = true;
            linkRegister.Text = "Don't have an account? Register here.";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
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
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.MidnightBlue;
            btnSignIn.ForeColor = SystemColors.ControlLightLight;
            btnSignIn.Location = new Point(279, 569);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(142, 40);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(279, 178);
            label5.Name = "label5";
            label5.Size = new Size(191, 22);
            label5.TabIndex = 7;
            label5.Text = "Sign In to your Account";
            label5.UseWaitCursor = true;
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
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1193, 808);
            Controls.Add(panel1);
            Name = "SignInForm";
            Text = "SignInForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private LinkLabel linkRegister;
        private Label label4;
        private Button btnSignIn;
        private Label label5;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtPassword;
    }
}