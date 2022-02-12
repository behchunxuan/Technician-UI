namespace Technician_UI
{
    partial class VerifyYourself
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyYourself));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpUsername = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkPassword = new System.Windows.Forms.CheckBox();
            this.btnVerify = new Technician_UI.AdvancedButton();
            this.btnBack = new Technician_UI.AdvancedButton();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpUsername.SuspendLayout();
            this.grpPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(141, 30);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(236, 103);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 11;
            this.picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(121, 159);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 42);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Verify Yourself";
            // 
            // grpUsername
            // 
            this.grpUsername.Controls.Add(this.txtUsername);
            this.grpUsername.Location = new System.Drawing.Point(86, 248);
            this.grpUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpUsername.Name = "grpUsername";
            this.grpUsername.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpUsername.Size = new System.Drawing.Size(329, 70);
            this.grpUsername.TabIndex = 23;
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
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Enter Username";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged_1);
            // 
            // grpPassword
            // 
            this.grpPassword.Controls.Add(this.txtPassword);
            this.grpPassword.Location = new System.Drawing.Point(86, 343);
            this.grpPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpPassword.Size = new System.Drawing.Size(329, 69);
            this.grpPassword.TabIndex = 25;
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
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Enter Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged_1);
            // 
            // chkPassword
            // 
            this.chkPassword.AutoSize = true;
            this.chkPassword.Location = new System.Drawing.Point(86, 418);
            this.chkPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.Size = new System.Drawing.Size(162, 29);
            this.chkPassword.TabIndex = 27;
            this.chkPassword.Text = "Show Password";
            this.chkPassword.UseVisualStyleBackColor = true;
            this.chkPassword.CheckedChanged += new System.EventHandler(this.chkPassword_CheckedChanged_1);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVerify.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnVerify.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVerify.BorderRadius = 20;
            this.btnVerify.BorderSize = 0;
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(188, 496);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(134, 46);
            this.btnVerify.TabIndex = 29;
            this.btnVerify.Text = "Verify";
            this.btnVerify.TextColor = System.Drawing.Color.White;
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBack.BorderRadius = 20;
            this.btnBack.BorderSize = 0;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 30);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // VerifyYourself
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(528, 624);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.chkPassword);
            this.Controls.Add(this.grpPassword);
            this.Controls.Add(this.grpUsername);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picLogo);
            this.Name = "VerifyYourself";
            this.Text = "VerifyYourself";
            this.Load += new System.EventHandler(this.VerifyYourself_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpUsername.ResumeLayout(false);
            this.grpUsername.PerformLayout();
            this.grpPassword.ResumeLayout(false);
            this.grpPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picLogo;
        private Label lblTitle;
        private GroupBox grpUsername;
        private GroupBox grpPassword;
        private CheckBox chkPassword;
        private AdvancedButton btnVerify;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private AdvancedButton btnBack;
    }
}