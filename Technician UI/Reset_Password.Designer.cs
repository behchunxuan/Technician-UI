namespace Technician_UI
{
    partial class Reset_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reset_Password));
            this.grpNew = new System.Windows.Forms.GroupBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpConfrim = new System.Windows.Forms.GroupBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.btnReset = new Technician_UI.AdvancedButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpNew.SuspendLayout();
            this.grpConfrim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNew
            // 
            this.grpNew.Controls.Add(this.txtNew);
            this.grpNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpNew.Location = new System.Drawing.Point(13, 179);
            this.grpNew.Margin = new System.Windows.Forms.Padding(2);
            this.grpNew.Name = "grpNew";
            this.grpNew.Padding = new System.Windows.Forms.Padding(2);
            this.grpNew.Size = new System.Drawing.Size(912, 66);
            this.grpNew.TabIndex = 82;
            this.grpNew.TabStop = false;
            this.grpNew.Text = "New Password";
            // 
            // txtNew
            // 
            this.txtNew.BackColor = System.Drawing.SystemColors.Window;
            this.txtNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNew.ForeColor = System.Drawing.Color.Silver;
            this.txtNew.Location = new System.Drawing.Point(35, 29);
            this.txtNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(828, 32);
            this.txtNew.TabIndex = 2;
            this.txtNew.Text = "Enter New Password";
            this.txtNew.TextChanged += new System.EventHandler(this.txtNew_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(14, 45);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 42);
            this.lblTitle.TabIndex = 79;
            this.lblTitle.Text = "Reset Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(-12, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1195, 25);
            this.label2.TabIndex = 80;
            this.label2.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "________\r\n";
            // 
            // grpConfrim
            // 
            this.grpConfrim.Controls.Add(this.txtConfirm);
            this.grpConfrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpConfrim.Location = new System.Drawing.Point(13, 266);
            this.grpConfrim.Margin = new System.Windows.Forms.Padding(2);
            this.grpConfrim.Name = "grpConfrim";
            this.grpConfrim.Padding = new System.Windows.Forms.Padding(2);
            this.grpConfrim.Size = new System.Drawing.Size(912, 66);
            this.grpConfrim.TabIndex = 85;
            this.grpConfrim.TabStop = false;
            this.grpConfrim.Text = "Confirm Password";
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirm.ForeColor = System.Drawing.Color.Silver;
            this.txtConfirm.Location = new System.Drawing.Point(35, 29);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(828, 32);
            this.txtConfirm.TabIndex = 3;
            this.txtConfirm.Text = "Confirm Password";
            this.txtConfirm.TextChanged += new System.EventHandler(this.txtConfirm_TextChanged);
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDes.Location = new System.Drawing.Point(13, 124);
            this.lblDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(460, 28);
            this.lblDes.TabIndex = 90;
            this.lblDes.Text = "The password should have at least 8 characters";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReset.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReset.BorderRadius = 20;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReset.Location = new System.Drawing.Point(380, 383);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(178, 54);
            this.btnReset.TabIndex = 91;
            this.btnReset.Text = "Reset";
            this.btnReset.TextColor = System.Drawing.SystemColors.HighlightText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(689, 14);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(236, 103);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 92;
            this.picLogo.TabStop = false;
            // 
            // Reset_Password
            // 
            this.AcceptButton = this.btnReset;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(938, 544);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.grpConfrim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpNew);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reset_Password";
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.Reset_Password_Load);
            this.grpNew.ResumeLayout(false);
            this.grpNew.PerformLayout();
            this.grpConfrim.ResumeLayout(false);
            this.grpConfrim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox grpNew;
        private Label lblTitle;
        private Label label2;
        private GroupBox grpConfrim;
        private Label lblDes;
        private Technician_UI.AdvancedButton btnReset;
        private PictureBox picLogo;
        private TextBox txtNew;
        private TextBox txtConfirm;
    }
}