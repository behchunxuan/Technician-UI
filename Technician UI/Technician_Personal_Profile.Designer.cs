namespace Technician_UI
{
    partial class Technician_Personal_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Technician_Personal_Profile));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblCustomerProfile = new System.Windows.Forms.Label();
            this.grpFirstName = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.grpLastName = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.grpEmail = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpMobileNum = new System.Windows.Forms.GroupBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnBack = new Technician_UI.AdvancedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpt = new Technician_UI.AdvancedButton();
            this.grpDOB = new System.Windows.Forms.GroupBox();
            this.dpkBirth = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpFirstName.SuspendLayout();
            this.grpLastName.SuspendLayout();
            this.grpEmail.SuspendLayout();
            this.grpMobileNum.SuspendLayout();
            this.grpPassword.SuspendLayout();
            this.grpDOB.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(689, 12);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(236, 103);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // lblCustomerProfile
            // 
            this.lblCustomerProfile.AutoSize = true;
            this.lblCustomerProfile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerProfile.Location = new System.Drawing.Point(12, 59);
            this.lblCustomerProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerProfile.Name = "lblCustomerProfile";
            this.lblCustomerProfile.Size = new System.Drawing.Size(335, 42);
            this.lblCustomerProfile.TabIndex = 11;
            this.lblCustomerProfile.Text = "Technician Profile";
            // 
            // grpFirstName
            // 
            this.grpFirstName.Controls.Add(this.txtFirstName);
            this.grpFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpFirstName.Location = new System.Drawing.Point(29, 152);
            this.grpFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFirstName.Name = "grpFirstName";
            this.grpFirstName.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFirstName.Size = new System.Drawing.Size(397, 71);
            this.grpFirstName.TabIndex = 14;
            this.grpFirstName.TabStop = false;
            this.grpFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.ForeColor = System.Drawing.Color.Silver;
            this.txtFirstName.Location = new System.Drawing.Point(22, 29);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(367, 32);
            this.txtFirstName.TabIndex = 15;
            this.txtFirstName.Text = "Enter First Name";
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // grpLastName
            // 
            this.grpLastName.Controls.Add(this.txtLastName);
            this.grpLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpLastName.Location = new System.Drawing.Point(510, 152);
            this.grpLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLastName.Name = "grpLastName";
            this.grpLastName.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLastName.Size = new System.Drawing.Size(395, 71);
            this.grpLastName.TabIndex = 14;
            this.grpLastName.TabStop = false;
            this.grpLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.ForeColor = System.Drawing.Color.Silver;
            this.txtLastName.Location = new System.Drawing.Point(21, 29);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(366, 32);
            this.txtLastName.TabIndex = 14;
            this.txtLastName.Text = "Enter Last Name";
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // grpEmail
            // 
            this.grpEmail.Controls.Add(this.txtEmail);
            this.grpEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpEmail.Location = new System.Drawing.Point(29, 254);
            this.grpEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEmail.Name = "grpEmail";
            this.grpEmail.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEmail.Size = new System.Drawing.Size(876, 66);
            this.grpEmail.TabIndex = 14;
            this.grpEmail.TabStop = false;
            this.grpEmail.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(22, 26);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(844, 32);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "Enter Email Address";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // grpMobileNum
            // 
            this.grpMobileNum.Controls.Add(this.txtMobile);
            this.grpMobileNum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpMobileNum.Location = new System.Drawing.Point(29, 349);
            this.grpMobileNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMobileNum.Name = "grpMobileNum";
            this.grpMobileNum.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMobileNum.Size = new System.Drawing.Size(414, 60);
            this.grpMobileNum.TabIndex = 14;
            this.grpMobileNum.TabStop = false;
            this.grpMobileNum.Text = "Mobile Number";
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.SystemColors.Window;
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMobile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMobile.ForeColor = System.Drawing.Color.Silver;
            this.txtMobile.Location = new System.Drawing.Point(32, 23);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(365, 32);
            this.txtMobile.TabIndex = 13;
            this.txtMobile.Text = "Enter Mobile Number";
            this.txtMobile.TextChanged += new System.EventHandler(this.txtMobile_TextChanged);
            // 
            // grpPassword
            // 
            this.grpPassword.Controls.Add(this.txtPassword);
            this.grpPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpPassword.Location = new System.Drawing.Point(510, 349);
            this.grpPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPassword.Size = new System.Drawing.Size(395, 60);
            this.grpPassword.TabIndex = 14;
            this.grpPassword.TabStop = false;
            this.grpPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(22, 23);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(365, 32);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Text = "Enter Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
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
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 34);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(957, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "_________________________________________________________________________________" +
    "______________________________________________________";
            // 
            // btnUpt
            // 
            this.btnUpt.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpt.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnUpt.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpt.BorderRadius = 20;
            this.btnUpt.BorderSize = 0;
            this.btnUpt.FlatAppearance.BorderSize = 0;
            this.btnUpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpt.ForeColor = System.Drawing.Color.White;
            this.btnUpt.Location = new System.Drawing.Point(798, 488);
            this.btnUpt.Name = "btnUpt";
            this.btnUpt.Size = new System.Drawing.Size(128, 44);
            this.btnUpt.TabIndex = 27;
            this.btnUpt.Text = "Update";
            this.btnUpt.TextColor = System.Drawing.Color.White;
            this.btnUpt.UseVisualStyleBackColor = false;
            this.btnUpt.Click += new System.EventHandler(this.btnUpt_Click);
            // 
            // grpDOB
            // 
            this.grpDOB.Controls.Add(this.dpkBirth);
            this.grpDOB.Location = new System.Drawing.Point(29, 436);
            this.grpDOB.Name = "grpDOB";
            this.grpDOB.Size = new System.Drawing.Size(414, 96);
            this.grpDOB.TabIndex = 28;
            this.grpDOB.TabStop = false;
            this.grpDOB.Text = "Date of Birth";
            // 
            // dpkBirth
            // 
            this.dpkBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkBirth.Location = new System.Drawing.Point(46, 41);
            this.dpkBirth.Name = "dpkBirth";
            this.dpkBirth.Size = new System.Drawing.Size(300, 31);
            this.dpkBirth.TabIndex = 0;
            // 
            // Technician_Personal_Profile
            // 
            this.AcceptButton = this.btnUpt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(938, 544);
            this.Controls.Add(this.btnUpt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpLastName);
            this.Controls.Add(this.grpPassword);
            this.Controls.Add(this.grpMobileNum);
            this.Controls.Add(this.grpEmail);
            this.Controls.Add(this.grpFirstName);
            this.Controls.Add(this.lblCustomerProfile);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grpDOB);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Technician_Personal_Profile";
            this.Text = "Technician_Personal_Profile";
            this.Load += new System.EventHandler(this.Technician_Personal_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpFirstName.ResumeLayout(false);
            this.grpFirstName.PerformLayout();
            this.grpLastName.ResumeLayout(false);
            this.grpLastName.PerformLayout();
            this.grpEmail.ResumeLayout(false);
            this.grpEmail.PerformLayout();
            this.grpMobileNum.ResumeLayout(false);
            this.grpMobileNum.PerformLayout();
            this.grpPassword.ResumeLayout(false);
            this.grpPassword.PerformLayout();
            this.grpDOB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblCustomerProfile;
        private System.Windows.Forms.GroupBox grpFirstName;
        private System.Windows.Forms.GroupBox grpLastName;
        private System.Windows.Forms.GroupBox grpEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grpMobileNum;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.GroupBox grpPassword;
        private Technician_UI.AdvancedButton btnBack;
        private Label label2;
        private Technician_UI.AdvancedButton btnUpt;
        private GroupBox grpDOB;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPassword;
        private DateTimePicker dpkBirth;
    }
}