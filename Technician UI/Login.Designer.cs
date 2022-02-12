namespace Technician_UI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpUsername = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lklblForgotPw = new System.Windows.Forms.LinkLabel();
            this.chkPassword = new System.Windows.Forms.CheckBox();
            this.btnLogin = new Technician_UI.AdvancedButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.llbForgotPassword = new System.Windows.Forms.LinkLabel();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.grpUsername.SuspendLayout();
            this.grpPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(372, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 42);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Login Menu";
            // 
            // grpUsername
            // 
            this.grpUsername.Controls.Add(this.txtUsername);
            this.grpUsername.Location = new System.Drawing.Point(314, 214);
            this.grpUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpUsername.Name = "grpUsername";
            this.grpUsername.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpUsername.Size = new System.Drawing.Size(329, 70);
            this.grpUsername.TabIndex = 22;
            this.grpUsername.TabStop = false;
            this.grpUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtUsername.Location = new System.Drawing.Point(20, 30);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(301, 32);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Enter Username";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // grpPassword
            // 
            this.grpPassword.Controls.Add(this.txtPassword);
            this.grpPassword.Location = new System.Drawing.Point(314, 290);
            this.grpPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpPassword.Size = new System.Drawing.Size(329, 69);
            this.grpPassword.TabIndex = 24;
            this.grpPassword.TabStop = false;
            this.grpPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(20, 30);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(301, 32);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Enter Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lklblForgotPw
            // 
            this.lklblForgotPw.AutoSize = true;
            this.lklblForgotPw.Location = new System.Drawing.Point(1189, 883);
            this.lklblForgotPw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklblForgotPw.Name = "lklblForgotPw";
            this.lklblForgotPw.Size = new System.Drawing.Size(154, 25);
            this.lklblForgotPw.TabIndex = 25;
            this.lklblForgotPw.TabStop = true;
            this.lklblForgotPw.Text = "Forgot Password?";
            // 
            // chkPassword
            // 
            this.chkPassword.AutoSize = true;
            this.chkPassword.Location = new System.Drawing.Point(314, 365);
            this.chkPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.Size = new System.Drawing.Size(162, 29);
            this.chkPassword.TabIndex = 26;
            this.chkPassword.Text = "Show Password";
            this.chkPassword.UseVisualStyleBackColor = true;
            this.chkPassword.CheckedChanged += new System.EventHandler(this.chkPassword_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(419, 460);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 46);
            this.btnLogin.TabIndex = 28;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(353, 85);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(251, 105);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 62;
            this.picLogo.TabStop = false;
            // 
            // llbForgotPassword
            // 
            this.llbForgotPassword.ActiveLinkColor = System.Drawing.Color.Black;
            this.llbForgotPassword.AutoSize = true;
            this.llbForgotPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llbForgotPassword.LinkColor = System.Drawing.Color.DimGray;
            this.llbForgotPassword.Location = new System.Drawing.Point(12, 514);
            this.llbForgotPassword.Name = "llbForgotPassword";
            this.llbForgotPassword.Size = new System.Drawing.Size(171, 21);
            this.llbForgotPassword.TabIndex = 63;
            this.llbForgotPassword.TabStop = true;
            this.llbForgotPassword.Text = "Forgot Password?";
            this.llbForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbForgotPassword_LinkClicked);
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCountdown.Location = new System.Drawing.Point(419, 412);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(0, 21);
            this.lblCountdown.TabIndex = 64;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(938, 544);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.llbForgotPassword);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkPassword);
            this.Controls.Add(this.lklblForgotPw);
            this.Controls.Add(this.grpPassword);
            this.Controls.Add(this.grpUsername);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.grpUsername.ResumeLayout(false);
            this.grpUsername.PerformLayout();
            this.grpPassword.ResumeLayout(false);
            this.grpPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitle;
        private GroupBox grpUsername;
        private TextBox txtUsername;
        private GroupBox grpPassword;
        private TextBox txtPassword;
        private LinkLabel lklblForgotPw;
        private CheckBox chkPassword;
        private Technician_UI.AdvancedButton btnLogin;
        private PictureBox picLogo;
        private LinkLabel llbForgotPassword;
        private Label lblCountdown;
    }
}