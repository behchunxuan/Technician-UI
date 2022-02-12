namespace Technician_UI
{
    partial class Inbox
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dgvEmail = new System.Windows.Forms.DataGridView();
            this.vscEmail = new System.Windows.Forms.VScrollBar();
            this.advancedButton1 = new Technician_UI.AdvancedButton();
            this.btnCompose = new Technician_UI.AdvancedButton();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 68);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 42);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Inbox";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Technician_UI.Properties.Resources.TechieMen___transparent_crop;
            this.picLogo.Location = new System.Drawing.Point(338, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(276, 110);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(957, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "_________________________________________________________________________________" +
    "______________________________________________________";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilter.Location = new System.Drawing.Point(650, 150);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(90, 23);
            this.lblFilter.TabIndex = 8;
            this.lblFilter.Text = "Filter By";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Seen",
            "Delivered"});
            this.cmbStatus.Location = new System.Drawing.Point(650, 186);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(244, 33);
            this.cmbStatus.TabIndex = 9;
            // 
            // dgvEmail
            // 
            this.dgvEmail.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmail.Location = new System.Drawing.Point(26, 266);
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.RowHeadersWidth = 62;
            this.dgvEmail.RowTemplate.Height = 33;
            this.dgvEmail.Size = new System.Drawing.Size(868, 256);
            this.dgvEmail.TabIndex = 14;
            // 
            // vscEmail
            // 
            this.vscEmail.Location = new System.Drawing.Point(894, 266);
            this.vscEmail.Name = "vscEmail";
            this.vscEmail.Size = new System.Drawing.Size(24, 256);
            this.vscEmail.TabIndex = 13;
            // 
            // advancedButton1
            // 
            this.advancedButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.advancedButton1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.advancedButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.advancedButton1.BorderRadius = 20;
            this.advancedButton1.BorderSize = 0;
            this.advancedButton1.FlatAppearance.BorderSize = 0;
            this.advancedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advancedButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.advancedButton1.ForeColor = System.Drawing.Color.White;
            this.advancedButton1.Location = new System.Drawing.Point(12, 12);
            this.advancedButton1.Name = "advancedButton1";
            this.advancedButton1.Size = new System.Drawing.Size(112, 34);
            this.advancedButton1.TabIndex = 16;
            this.advancedButton1.Text = "Back";
            this.advancedButton1.TextColor = System.Drawing.Color.White;
            this.advancedButton1.UseVisualStyleBackColor = false;
            // 
            // btnCompose
            // 
            this.btnCompose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCompose.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnCompose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCompose.BorderRadius = 20;
            this.btnCompose.BorderSize = 0;
            this.btnCompose.FlatAppearance.BorderSize = 0;
            this.btnCompose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompose.ForeColor = System.Drawing.Color.White;
            this.btnCompose.Location = new System.Drawing.Point(26, 173);
            this.btnCompose.Name = "btnCompose";
            this.btnCompose.Size = new System.Drawing.Size(153, 46);
            this.btnCompose.TabIndex = 17;
            this.btnCompose.Text = "Compose";
            this.btnCompose.TextColor = System.Drawing.Color.White;
            this.btnCompose.UseVisualStyleBackColor = false;
            // 
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(938, 544);
            this.Controls.Add(this.btnCompose);
            this.Controls.Add(this.advancedButton1);
            this.Controls.Add(this.dgvEmail);
            this.Controls.Add(this.vscEmail);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblTitle);
            this.Name = "Inbox";
            this.Text = "Inbox";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitle;
        private PictureBox picLogo;
        private Label label2;
        private Label lblFilter;
        private ComboBox cmbStatus;
        private DataGridView dgvEmail;
        private VScrollBar vscEmail;
        private AdvancedButton advancedButton1;
        private AdvancedButton btnCompose;
    }
}