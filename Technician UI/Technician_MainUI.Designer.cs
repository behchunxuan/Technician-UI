namespace Technician_UI
{
    partial class Technician_MainUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new Technician_UI.AdvancedButton();
            this.btnViewServ = new Technician_UI.AdvancedButton();
            this.btnInbox = new Technician_UI.AdvancedButton();
            this.btnPersInfo = new Technician_UI.AdvancedButton();
            this.txtUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(292, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(376, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Main UI (Technician)";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Technician_UI.Properties.Resources.TechieMen___transparent_crop;
            this.picLogo.Location = new System.Drawing.Point(337, 93);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(276, 110);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogout.BorderRadius = 20;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 34);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnViewServ
            // 
            this.btnViewServ.BackColor = System.Drawing.Color.SteelBlue;
            this.btnViewServ.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnViewServ.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnViewServ.BorderRadius = 20;
            this.btnViewServ.BorderSize = 0;
            this.btnViewServ.FlatAppearance.BorderSize = 0;
            this.btnViewServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewServ.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewServ.ForeColor = System.Drawing.Color.White;
            this.btnViewServ.Location = new System.Drawing.Point(326, 282);
            this.btnViewServ.Name = "btnViewServ";
            this.btnViewServ.Size = new System.Drawing.Size(296, 65);
            this.btnViewServ.TabIndex = 17;
            this.btnViewServ.Text = "View Service Requested";
            this.btnViewServ.TextColor = System.Drawing.Color.White;
            this.btnViewServ.UseVisualStyleBackColor = false;
            this.btnViewServ.Click += new System.EventHandler(this.btnViewServ_Click);
            // 
            // btnInbox
            // 
            this.btnInbox.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInbox.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnInbox.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInbox.BorderRadius = 20;
            this.btnInbox.BorderSize = 0;
            this.btnInbox.FlatAppearance.BorderSize = 0;
            this.btnInbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInbox.ForeColor = System.Drawing.Color.White;
            this.btnInbox.Location = new System.Drawing.Point(326, 366);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(296, 65);
            this.btnInbox.TabIndex = 18;
            this.btnInbox.Text = "Inbox";
            this.btnInbox.TextColor = System.Drawing.Color.White;
            this.btnInbox.UseVisualStyleBackColor = false;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // btnPersInfo
            // 
            this.btnPersInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPersInfo.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnPersInfo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPersInfo.BorderRadius = 20;
            this.btnPersInfo.BorderSize = 0;
            this.btnPersInfo.FlatAppearance.BorderSize = 0;
            this.btnPersInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPersInfo.ForeColor = System.Drawing.Color.White;
            this.btnPersInfo.Location = new System.Drawing.Point(326, 448);
            this.btnPersInfo.Name = "btnPersInfo";
            this.btnPersInfo.Size = new System.Drawing.Size(296, 65);
            this.btnPersInfo.TabIndex = 19;
            this.btnPersInfo.Text = "Personal Info";
            this.btnPersInfo.TextColor = System.Drawing.Color.White;
            this.btnPersInfo.UseVisualStyleBackColor = false;
            this.btnPersInfo.Click += new System.EventHandler(this.btnPersInfo_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(326, 227);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(0, 28);
            this.txtUsername.TabIndex = 20;
            // 
            // Technician_MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(938, 544);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnPersInfo);
            this.Controls.Add(this.btnInbox);
            this.Controls.Add(this.btnViewServ);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblTitle);
            this.Name = "Technician_MainUI";
            this.Text = "Technician Main UI";
            this.Load += new System.EventHandler(this.Technician_MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitle;
        private PictureBox picLogo;
        private AdvancedButton btnLogout;
        private AdvancedButton btnViewServ;
        private AdvancedButton btnInbox;
        private AdvancedButton btnPersInfo;
        private Label txtUsername;
    }
}