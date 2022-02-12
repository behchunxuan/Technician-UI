using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Technician_UI
{
    public partial class CustomerServiceDetails : Form
    {
        string default_collectdatetxt = "Enter Collection Date";
        string default_desctxt = "  Enter Service Desciption................";

        [DllImport("user32")]
        private static extern bool HideCaret(IntPtr hWnd);

        public static string[] details;
        public CustomerServiceDetails()
        {
            InitializeComponent();
        }

        public CustomerServiceDetails(string[] d)
        {
            InitializeComponent();

            txtOrder.GotFocus += txtboxes_GotFocus;
            txtServ.GotFocus += txtboxes_GotFocus;
            txtPrior.GotFocus += txtboxes_GotFocus;
            txtCustomer.GotFocus += txtboxes_GotFocus;
            txtAppDate.GotFocus += txtboxes_GotFocus;

            txtCollectDate.GotFocus += new EventHandler(txtCollectDate_GotFocus);
            txtCollectDate.LostFocus += new EventHandler(txtCollectDate_LostFocus);
            rtxDesc.GotFocus += new EventHandler(rtxDesc_GotFocus);
            rtxDesc.LostFocus += new EventHandler(rtxDesc_LostFocus);

            details = d;
        }
        private void txtboxes_GotFocus(object sender, EventArgs e)
        {
            HideCaret(txtOrder.Handle);
            HideCaret(txtServ.Handle);
            HideCaret(txtPrior.Handle);
            HideCaret(txtCustomer.Handle);
            HideCaret(txtAppDate.Handle);
        }

        private void txtCollectDate_GotFocus(object sender, EventArgs e)
        {
            if (txtCollectDate.Text == default_collectdatetxt)
            {
                txtCollectDate.Text = string.Empty;
            }
        }

        private void txtCollectDate_LostFocus(object sender, EventArgs e)
        {
            if (txtCollectDate.Text == string.Empty)
            {
                txtCollectDate.Text = default_collectdatetxt;
                txtCollectDate.ForeColor = Color.Silver;
            }
        }

        private void rtxDesc_GotFocus(object sender, EventArgs e)
        {
            if (rtxDesc.Text == default_desctxt)
            {
                rtxDesc.Text = string.Empty;
            }
        }

        private void rtxDesc_LostFocus(object sender, EventArgs e)
        {
            if (rtxDesc.Text == string.Empty)
            {
                rtxDesc.Text = default_desctxt;
                rtxDesc.ForeColor = Color.Silver;
            }
        }

        private void CustomerServiceDetails_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCollectDate;

            string orderID;
            string customerID;
            string serviceID;
            string statusID;
            string priorityID;
            string applicationDate;

            customerID = details[0];
            orderID = details[1];
            serviceID = details[2];
            statusID = details[3];
            priorityID = details[4];
            applicationDate = details[5];

            // create a Customer object c with six attributes
            Customer c = new Customer(customerID, orderID, serviceID, statusID, priorityID, applicationDate);

            txtOrder.Text = c.OrderID;
            txtCustomer.Text = c.CustomerID;
            txtServ.Text = c.ServiceID;
            txtPrior.Text = c.PriorityID;
            txtAppDate.Text = c.ApplicationDate;

            if (c.StatusID == "701")
                radPnd.Checked = true;
            else if (c.StatusID == "702")
                radMtn.Checked = true;
            else if (c.StatusID == "703")
                radCpl.Checked = true;
        }

        private void rtxDesc_TextChanged_1(object sender, EventArgs e)
        {
            if (rtxDesc.Text != default_desctxt)
                rtxDesc.ForeColor = Color.Black;
        }
        private void txtCollectDate_TextChanged(object sender, EventArgs e)
        {
            if (txtCollectDate.Text != default_collectdatetxt)
                txtCollectDate.ForeColor = Color.Black;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Want to go back?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No) { }
        }


        private void btnUpt_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime collectDate;
                if (DateTime.TryParse(txtCollectDate.Text, out collectDate)) { }
                else
                    throw new CustomException("Please enter a valid date"); // if failed to convert datetime from string, throw exception

                string orderID = txtOrder.Text;
                string servDesc = rtxDesc.Text;
                string status = null;

                if (radPnd.Checked)
                    status = "701";   
                else if (radMtn.Checked)
                    status = "702";
                else if (radCpl.Checked)
                    status = "703";
                
                Technician t = new Technician(); // create a Technician object t
                string update_stat = t.update_order_details(orderID, collectDate, servDesc, status);

                if (update_stat != null)
                    MessageBox.Show(update_stat, "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Update Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
