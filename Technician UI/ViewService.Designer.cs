namespace Technician_UI
{
    partial class ViewService
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.txtOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new Technician_UI.AdvancedButton();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(386, 42);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Waiting for Servicing";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Technician_UI.Properties.Resources.TechieMen___transparent_crop;
            this.picLogo.Location = new System.Drawing.Point(650, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(276, 110);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(957, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "_________________________________________________________________________________" +
    "______________________________________________________";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(26, 148);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(180, 23);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Service Category";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPriority.Location = new System.Drawing.Point(650, 148);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(81, 23);
            this.lblPriority.TabIndex = 6;
            this.lblPriority.Text = "Priority";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Remove virus, malware or spyware",
            "Troubleshot and fix computer running slow",
            "Laptop screen replacement",
            "Laptop keyboard replacement",
            "Laptop battery replacement",
            "Operating System Format and Installation",
            "Data backup and recovery",
            "Internet connectivity issues",
            "All"});
            this.cmbCategory.Location = new System.Drawing.Point(26, 189);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(434, 33);
            this.cmbCategory.TabIndex = 7;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "Normal",
            "Urgent",
            "All"});
            this.cmbPriority.Location = new System.Drawing.Point(650, 189);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(244, 33);
            this.cmbPriority.TabIndex = 8;
            this.cmbPriority.SelectedIndexChanged += new System.EventHandler(this.cmbPriority_SelectedIndexChanged);
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtOrder,
            this.txtService,
            this.txtStatus,
            this.txtPriority});
            this.dgvServices.Location = new System.Drawing.Point(26, 265);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersWidth = 62;
            this.dgvServices.RowTemplate.Height = 33;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(868, 256);
            this.dgvServices.TabIndex = 12;
            this.dgvServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellContentClick);
            // 
            // txtOrder
            // 
            this.txtOrder.HeaderText = "OrderID";
            this.txtOrder.MinimumWidth = 8;
            this.txtOrder.Name = "txtOrder";
            // 
            // txtService
            // 
            this.txtService.HeaderText = "ServiceID";
            this.txtService.MinimumWidth = 8;
            this.txtService.Name = "txtService";
            // 
            // txtStatus
            // 
            this.txtStatus.HeaderText = "Status";
            this.txtStatus.MinimumWidth = 8;
            this.txtStatus.Name = "txtStatus";
            // 
            // txtPriority
            // 
            this.txtPriority.HeaderText = "Priority";
            this.txtPriority.MinimumWidth = 8;
            this.txtPriority.Name = "txtPriority";
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
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // ViewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(938, 544);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblTitle);
            this.Name = "ViewService";
            this.Text = "ViewService";
            this.Load += new System.EventHandler(this.ViewService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitle;
        private PictureBox picLogo;
        private Label label2;
        private Label lblCategory;
        private Label lblPriority;
        private ComboBox cmbCategory;
        private ComboBox cmbPriority;
        private DataGridView dgvServices;
        private DataGridViewTextBoxColumn txtOrder;
        private DataGridViewTextBoxColumn txtService;
        private DataGridViewTextBoxColumn txtStatus;
        private DataGridViewTextBoxColumn txtPriority;
        private AdvancedButton btnBack;
    }
}