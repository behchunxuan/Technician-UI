namespace Technician_UI
{
    partial class CustomerServiceDetails
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
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.grpCustomerID = new System.Windows.Forms.GroupBox();
            this.grpService = new System.Windows.Forms.GroupBox();
            this.txtServ = new System.Windows.Forms.TextBox();
            this.grpPriority = new System.Windows.Forms.GroupBox();
            this.txtPrior = new System.Windows.Forms.TextBox();
            this.grpCollectDate = new System.Windows.Forms.GroupBox();
            this.txtCollectDate = new System.Windows.Forms.TextBox();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.radCpl = new System.Windows.Forms.RadioButton();
            this.radMtn = new System.Windows.Forms.RadioButton();
            this.radPnd = new System.Windows.Forms.RadioButton();
            this.grpName = new System.Windows.Forms.GroupBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblTitleDesc = new System.Windows.Forms.Label();
            this.btnUpt = new Technician_UI.AdvancedButton();
            this.btnBack = new Technician_UI.AdvancedButton();
            this.rtxDesc = new System.Windows.Forms.RichTextBox();
            this.txtAppDate = new System.Windows.Forms.TextBox();
            this.grpAppDate = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpCustomerID.SuspendLayout();
            this.grpService.SuspendLayout();
            this.grpPriority.SuspendLayout();
            this.grpCollectDate.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.grpName.SuspendLayout();
            this.grpAppDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(464, 42);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Customer Service Details";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Technician_UI.Properties.Resources.TechieMen___transparent_crop;
            this.picLogo.Location = new System.Drawing.Point(650, 12);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(276, 110);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-11, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(957, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "_________________________________________________________________________________" +
    "______________________________________________________";
            // 
            // txtOrder
            // 
            this.txtOrder.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrder.Cursor = System.Windows.Forms.Cursors.No;
            this.txtOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrder.Location = new System.Drawing.Point(42, 20);
            this.txtOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(351, 32);
            this.txtOrder.TabIndex = 6;
            // 
            // grpCustomerID
            // 
            this.grpCustomerID.Controls.Add(this.txtOrder);
            this.grpCustomerID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpCustomerID.Location = new System.Drawing.Point(35, 136);
            this.grpCustomerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCustomerID.Name = "grpCustomerID";
            this.grpCustomerID.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCustomerID.Size = new System.Drawing.Size(431, 58);
            this.grpCustomerID.TabIndex = 7;
            this.grpCustomerID.TabStop = false;
            this.grpCustomerID.Text = "Order ID";
            // 
            // grpService
            // 
            this.grpService.Controls.Add(this.txtServ);
            this.grpService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpService.Location = new System.Drawing.Point(35, 210);
            this.grpService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpService.Name = "grpService";
            this.grpService.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpService.Size = new System.Drawing.Size(431, 65);
            this.grpService.TabIndex = 8;
            this.grpService.TabStop = false;
            this.grpService.Text = "Service Type";
            // 
            // txtServ
            // 
            this.txtServ.BackColor = System.Drawing.SystemColors.Window;
            this.txtServ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServ.Cursor = System.Windows.Forms.Cursors.No;
            this.txtServ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtServ.ForeColor = System.Drawing.Color.Black;
            this.txtServ.Location = new System.Drawing.Point(42, 26);
            this.txtServ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServ.Name = "txtServ";
            this.txtServ.ReadOnly = true;
            this.txtServ.Size = new System.Drawing.Size(351, 32);
            this.txtServ.TabIndex = 6;
            // 
            // grpPriority
            // 
            this.grpPriority.Controls.Add(this.txtPrior);
            this.grpPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPriority.Location = new System.Drawing.Point(495, 212);
            this.grpPriority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPriority.Name = "grpPriority";
            this.grpPriority.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPriority.Size = new System.Drawing.Size(431, 63);
            this.grpPriority.TabIndex = 9;
            this.grpPriority.TabStop = false;
            this.grpPriority.Text = "Priority";
            // 
            // txtPrior
            // 
            this.txtPrior.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrior.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPrior.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrior.Location = new System.Drawing.Point(42, 25);
            this.txtPrior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrior.Name = "txtPrior";
            this.txtPrior.ReadOnly = true;
            this.txtPrior.Size = new System.Drawing.Size(351, 32);
            this.txtPrior.TabIndex = 6;
            // 
            // grpCollectDate
            // 
            this.grpCollectDate.Controls.Add(this.txtCollectDate);
            this.grpCollectDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpCollectDate.Location = new System.Drawing.Point(35, 380);
            this.grpCollectDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCollectDate.Name = "grpCollectDate";
            this.grpCollectDate.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCollectDate.Size = new System.Drawing.Size(431, 66);
            this.grpCollectDate.TabIndex = 8;
            this.grpCollectDate.TabStop = false;
            this.grpCollectDate.Text = "Collection Date";
            // 
            // txtCollectDate
            // 
            this.txtCollectDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCollectDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCollectDate.ForeColor = System.Drawing.Color.Silver;
            this.txtCollectDate.Location = new System.Drawing.Point(42, 26);
            this.txtCollectDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCollectDate.Name = "txtCollectDate";
            this.txtCollectDate.Size = new System.Drawing.Size(351, 32);
            this.txtCollectDate.TabIndex = 6;
            this.txtCollectDate.Text = "Enter Collection Date";
            this.txtCollectDate.TextChanged += new System.EventHandler(this.txtCollectDate_TextChanged);
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.radCpl);
            this.grpStatus.Controls.Add(this.radMtn);
            this.grpStatus.Controls.Add(this.radPnd);
            this.grpStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpStatus.Location = new System.Drawing.Point(35, 454);
            this.grpStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpStatus.Size = new System.Drawing.Size(496, 79);
            this.grpStatus.TabIndex = 9;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // radCpl
            // 
            this.radCpl.AutoSize = true;
            this.radCpl.Location = new System.Drawing.Point(364, 30);
            this.radCpl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radCpl.Name = "radCpl";
            this.radCpl.Size = new System.Drawing.Size(125, 29);
            this.radCpl.TabIndex = 12;
            this.radCpl.TabStop = true;
            this.radCpl.Text = "Completed";
            this.radCpl.UseVisualStyleBackColor = true;
            // 
            // radMtn
            // 
            this.radMtn.AutoSize = true;
            this.radMtn.Location = new System.Drawing.Point(151, 31);
            this.radMtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radMtn.Name = "radMtn";
            this.radMtn.Size = new System.Drawing.Size(190, 29);
            this.radMtn.TabIndex = 11;
            this.radMtn.TabStop = true;
            this.radMtn.Text = "Under Maintenance";
            this.radMtn.UseVisualStyleBackColor = true;
            // 
            // radPnd
            // 
            this.radPnd.AutoSize = true;
            this.radPnd.Location = new System.Drawing.Point(27, 30);
            this.radPnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radPnd.Name = "radPnd";
            this.radPnd.Size = new System.Drawing.Size(101, 29);
            this.radPnd.TabIndex = 10;
            this.radPnd.TabStop = true;
            this.radPnd.Text = "Pending";
            this.radPnd.UseVisualStyleBackColor = true;
            // 
            // grpName
            // 
            this.grpName.Controls.Add(this.txtCustomer);
            this.grpName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpName.Location = new System.Drawing.Point(495, 136);
            this.grpName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpName.Name = "grpName";
            this.grpName.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpName.Size = new System.Drawing.Size(431, 58);
            this.grpName.TabIndex = 8;
            this.grpName.TabStop = false;
            this.grpName.Text = "Customer ID";
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomer.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomer.Location = new System.Drawing.Point(42, 20);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(351, 32);
            this.txtCustomer.TabIndex = 6;
            // 
            // lblTitleDesc
            // 
            this.lblTitleDesc.AutoSize = true;
            this.lblTitleDesc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleDesc.Location = new System.Drawing.Point(495, 299);
            this.lblTitleDesc.Name = "lblTitleDesc";
            this.lblTitleDesc.Size = new System.Drawing.Size(215, 26);
            this.lblTitleDesc.TabIndex = 13;
            this.lblTitleDesc.Text = "Title of Description";
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
            this.btnUpt.Location = new System.Drawing.Point(798, 489);
            this.btnUpt.Name = "btnUpt";
            this.btnUpt.Size = new System.Drawing.Size(128, 44);
            this.btnUpt.TabIndex = 14;
            this.btnUpt.Text = "Update";
            this.btnUpt.TextColor = System.Drawing.Color.White;
            this.btnUpt.UseVisualStyleBackColor = false;
            this.btnUpt.Click += new System.EventHandler(this.btnUpt_Click);
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
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rtxDesc
            // 
            this.rtxDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxDesc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxDesc.ForeColor = System.Drawing.Color.Silver;
            this.rtxDesc.Location = new System.Drawing.Point(495, 328);
            this.rtxDesc.Name = "rtxDesc";
            this.rtxDesc.Size = new System.Drawing.Size(431, 119);
            this.rtxDesc.TabIndex = 7;
            this.rtxDesc.Text = "  Enter Service Desciption................";
            this.rtxDesc.TextChanged += new System.EventHandler(this.rtxDesc_TextChanged_1);
            // 
            // txtAppDate
            // 
            this.txtAppDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtAppDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAppDate.Cursor = System.Windows.Forms.Cursors.No;
            this.txtAppDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAppDate.ForeColor = System.Drawing.Color.Black;
            this.txtAppDate.Location = new System.Drawing.Point(42, 26);
            this.txtAppDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAppDate.Name = "txtAppDate";
            this.txtAppDate.ReadOnly = true;
            this.txtAppDate.Size = new System.Drawing.Size(351, 32);
            this.txtAppDate.TabIndex = 7;
            // 
            // grpAppDate
            // 
            this.grpAppDate.Controls.Add(this.txtAppDate);
            this.grpAppDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpAppDate.Location = new System.Drawing.Point(35, 299);
            this.grpAppDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAppDate.Name = "grpAppDate";
            this.grpAppDate.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAppDate.Size = new System.Drawing.Size(431, 65);
            this.grpAppDate.TabIndex = 10;
            this.grpAppDate.TabStop = false;
            this.grpAppDate.Text = "Application Date";
            // 
            // CustomerServiceDetails
            // 
            this.AcceptButton = this.btnUpt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(938, 544);
            this.Controls.Add(this.rtxDesc);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpt);
            this.Controls.Add(this.lblTitleDesc);
            this.Controls.Add(this.grpAppDate);
            this.Controls.Add(this.grpName);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.grpCollectDate);
            this.Controls.Add(this.grpPriority);
            this.Controls.Add(this.grpService);
            this.Controls.Add(this.grpCustomerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerServiceDetails";
            this.Text = "CustomerServiceDetails";
            this.Load += new System.EventHandler(this.CustomerServiceDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpCustomerID.ResumeLayout(false);
            this.grpCustomerID.PerformLayout();
            this.grpService.ResumeLayout(false);
            this.grpService.PerformLayout();
            this.grpPriority.ResumeLayout(false);
            this.grpPriority.PerformLayout();
            this.grpCollectDate.ResumeLayout(false);
            this.grpCollectDate.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.grpName.ResumeLayout(false);
            this.grpName.PerformLayout();
            this.grpAppDate.ResumeLayout(false);
            this.grpAppDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitle;
        private PictureBox picLogo;
        private Label label2;
        private TextBox txtOrder;
        private GroupBox grpCustomerID;
        private GroupBox grpService;
        private TextBox txtServ;
        private GroupBox grpPriority;
        private TextBox txtPrior;
        private GroupBox grpCollectDate;
        private TextBox txtCollectDate;
        private GroupBox grpStatus;
        private RadioButton radCpl;
        private RadioButton radMtn;
        private RadioButton radPnd;
        private GroupBox grpName;
        private TextBox txtCustomer;
        private Label lblTitleDesc;
        private AdvancedButton btnUpt;
        private AdvancedButton btnBack;
        private RichTextBox rtxDesc;
        private TextBox txtAppDate;
        private GroupBox grpAppDate;
    }
}