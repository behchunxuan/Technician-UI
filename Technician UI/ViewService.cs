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

namespace Technician_UI
{
    public partial class ViewService : Form
    {
        DataTable table;
        public string fil_servID;
        public string fil_priorID; 
        public ViewService()
        {
            InitializeComponent();
        }

        private void ViewService_Load(object sender, EventArgs e)
        {
            ArrayList rows = Technician.viewService();

            table = new DataTable();
            table.Columns.Add("OrderID", typeof(string));
            table.Columns.Add("ServiceID", typeof(string));
            table.Columns.Add("Status", typeof(string));
            table.Columns.Add("Priority", typeof(string));

            int cnt = 0;
            for (int i = 0; i < rows.Count / 4; i++) // rows.Count / 4 means the total number of service records
            {
                string[] row = new string[4]; // a service record
                for (int j = 0; j < row.Length; j++)
                {
                    row[j] = rows[cnt++].ToString(); // put 4 service details into row (one service record) from rows every times
                }
                dgvServices.Rows.Add(row);
                table.Rows.Add(row);
            }

            cmbCategory.Text = "All";
            cmbPriority.Text = "All";
        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string current_order_id = dgvServices.CurrentRow.Cells[0].Value.ToString();
            string current_service = dgvServices.CurrentRow.Cells[1].Value.ToString();
            string current_status = dgvServices.CurrentRow.Cells[2].Value.ToString();
            string current_priority = dgvServices.CurrentRow.Cells[3].Value.ToString();

            Technician t = new Technician();
            string[] details = t.view_order_details(current_order_id, current_service, current_status, current_priority);         
       

            CustomerServiceDetails customerServiceDetails = new CustomerServiceDetails(details);
            customerServiceDetails.ShowDialog();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clear the columns of the previous table
            dgvServices.Columns.Clear();
            //insert a new table into dgvServices
            dgvServices.DataSource = table;

            if (cmbCategory.SelectedIndex == 0)
                fil_servID = "S001";
            else if (cmbCategory.SelectedIndex == 1)
                fil_servID = "S002";
            else if (cmbCategory.SelectedIndex == 2)
                fil_servID = "S003";
            else if (cmbCategory.SelectedIndex == 3)
                fil_servID = "S004";
            else if (cmbCategory.SelectedIndex == 4)
                fil_servID = "S005";
            else if (cmbCategory.SelectedIndex == 5)
                fil_servID = "S006";
            else if (cmbCategory.SelectedIndex == 6)
                fil_servID = "S007";
            else if (cmbCategory.SelectedIndex == 7)
                fil_servID = "S008";
            else if (cmbCategory.SelectedIndex == 8)
                fil_servID = null;

            DataView dv1 = table.DefaultView;

            dv1.RowFilter = "ServiceID LIKE '" + fil_servID + "%' "; // filter the records by service category
            dgvServices.DataSource = dv1;
        }  

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clear the columns of the previous table
            dgvServices.Columns.Clear();
            //insert a new table into dgvServices
            dgvServices.DataSource = table;

            if (cmbPriority.SelectedIndex == 0)
                fil_priorID = "N";
            else if (cmbPriority.SelectedIndex == 1)
                fil_priorID = "U";
            else if (cmbPriority.SelectedIndex == 2)
                fil_priorID = null;


            DataView dv2 = table.DefaultView;

            dv2.RowFilter = "Priority LIKE '" + fil_priorID + "%' "; // filter the records by priority
            dgvServices.DataSource = dv2;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Want to go back?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No) { }
        }
    }
}
