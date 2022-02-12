namespace Technician_UI
{
    partial class Forgot_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot_Password));
            this.grpEmail = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpMobile = new System.Windows.Forms.GroupBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.grpUsername = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new Technician_UI.AdvancedButton();
            this.btnConfirm = new Technician_UI.AdvancedButton();
            this.grpFirstName = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.grpLastName = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpEmail.SuspendLayout();
            this.grpMobile.SuspendLayout();
            this.grpUsername.SuspendLayout();
            this.grpFirstName.SuspendLayout();
            this.grpLastName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEmail
            // 
            this.grpEmail.Controls.Add(this.txtEmail);
            this.grpEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpEmail.Location = new System.Drawing.Point(14, 322);
            this.grpEmail.Name = "grpEmail";
            this.grpEmail.Size = new System.Drawing.Size(913, 70);
            this.grpEmail.TabIndex = 11;
            this.grpEmail.TabStop = false;
            this.grpEmail.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(18, 30);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 32);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "Enter Email Address";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged_1);
            // 
            // grpMobile
            // 
            this.grpMobile.Controls.Add(this.txtMobile);
            this.grpMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMobile.Location = new System.Drawing.Point(12, 408);
            this.grpMobile.Name = "grpMobile";
            this.grpMobile.Size = new System.Drawing.Size(1054, 66);
            this.grpMobile.TabIndex = 12;
            this.grpMobile.TabStop = false;
            this.grpMobile.Text = "Mobile No.";
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.SystemColors.Window;
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMobile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMobile.ForeColor = System.Drawing.Color.Silver;
            this.txtMobile.Location = new System.Drawing.Point(20, 28);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(301, 32);
            this.txtMobile.TabIndex = 5;
            this.txtMobile.Text = "Enter Mobile No.";
            this.txtMobile.TextChanged += new System.EventHandler(this.txtMobile_TextChanged_1);
            // 
            // grpUsername
            // 
            this.grpUsername.Controls.Add(this.txtUsername);
            this.grpUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpUsername.Location = new System.Drawing.Point(14, 171);
            this.grpUsername.Name = "grpUsername";
            this.grpUsername.Size = new System.Drawing.Size(912, 65);
            this.grpUsername.TabIndex = 12;
            this.grpUsername.TabStop = false;
            this.grpUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtUsername.Location = new System.Drawing.Point(18, 27);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(802, 32);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Enter Username";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(13, 73);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 42);
            this.lblTitle.TabIndex = 44;
            this.lblTitle.Text = "Forgot Password";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.BackColor = System.Drawing.Color.White;
            this.lblDes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDes.Location = new System.Drawing.Point(1, 140);
            this.lblDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(714, 28);
            this.lblDes.TabIndex = 47;
            this.lblDes.Text = "Fill in the correct details to verify your information before reset password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-26, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1475, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = resources.GetString("label2.Text");
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
            this.btnBack.Location = new System.Drawing.Point(14, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 47);
            this.btnBack.TabIndex = 55;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConfirm.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnConfirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirm.BorderRadius = 20;
            this.btnConfirm.BorderSize = 0;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(397, 490);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(142, 42);
            this.btnConfirm.TabIndex = 58;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // grpFirstName
            // 
            this.grpFirstName.Controls.Add(this.txtFirstName);
            this.grpFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpFirstName.Location = new System.Drawing.Point(14, 244);
            this.grpFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFirstName.Name = "grpFirstName";
            this.grpFirstName.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFirstName.Size = new System.Drawing.Size(428, 61);
            this.grpFirstName.TabIndex = 59;
            this.grpFirstName.TabStop = false;
            this.grpFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.ForeColor = System.Drawing.Color.Silver;
            this.txtFirstName.Location = new System.Drawing.Point(18, 21);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(301, 32);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.Text = "Enter First Name";
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged_1);
            // 
            // grpLastName
            // 
            this.grpLastName.Controls.Add(this.txtLastName);
            this.grpLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpLastName.Location = new System.Drawing.Point(503, 244);
            this.grpLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLastName.Name = "grpLastName";
            this.grpLastName.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLastName.Size = new System.Drawing.Size(423, 61);
            this.grpLastName.TabIndex = 60;
            this.grpLastName.TabStop = false;
            this.grpLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.ForeColor = System.Drawing.Color.Silver;
            this.txtLastName.Location = new System.Drawing.Point(18, 21);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(301, 32);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Text = "Enter Last Name";
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged_1);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(691, 14);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(236, 103);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 61;
            this.picLogo.TabStop = false;
            // 
            // Forgot_Password
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(938, 544);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grpLastName);
            this.Controls.Add(this.grpFirstName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpUsername);
            this.Controls.Add(this.grpMobile);
            this.Controls.Add(this.grpEmail);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Forgot_Password";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.Forgot_Password_Load);
            this.grpEmail.ResumeLayout(false);
            this.grpEmail.PerformLayout();
            this.grpMobile.ResumeLayout(false);
            this.grpMobile.PerformLayout();
            this.grpUsername.ResumeLayout(false);
            this.grpUsername.PerformLayout();
            this.grpFirstName.ResumeLayout(false);
            this.grpFirstName.PerformLayout();
            this.grpLastName.ResumeLayout(false);
            this.grpLastName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox grpEmail;
        private GroupBox grpMobile;
        private GroupBox grpUsername;
        private Label lblTitle;
        private Label lblDes;
        private Label label2;
        private Technician_UI.AdvancedButton btnBack;
        private Technician_UI.AdvancedButton btnConfirm;
        private GroupBox grpFirstName;
        private GroupBox grpLastName;
        private PictureBox picLogo;
        private TextBox txtEmail;
        private TextBox txtMobile;
        private TextBox txtUsername;
        private TextBox txtFirstName;
        private TextBox txtLastName;
    }
}