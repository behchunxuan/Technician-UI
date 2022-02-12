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
    public partial class Reset_Password : Form
    {
        string default_newtxt = "Enter New Password";
        string default_confirmtxt = "Confirm Password";
        public Reset_Password()
        {
            InitializeComponent();

            txtNew.GotFocus += new EventHandler(txtNew_GotFocus);
            txtConfirm.LostFocus += new EventHandler(txtConfirm_LostFocus);

            txtConfirm.GotFocus += new EventHandler(txtConfirm_GotFocus);
            txtConfirm.LostFocus += new EventHandler(txtConfirm_LostFocus);
        }

        public void txtNew_GotFocus(object sender, EventArgs e)
        {
            if (txtNew.Text == default_newtxt)
                txtNew.Text = string.Empty;
        }

        public void txtNew_LostFocus(object sender, EventArgs e)
        {
            if (txtNew.Text == string.Empty)
            {
                txtNew.Text = default_newtxt;
                txtNew.ForeColor = Color.Silver;
            }
        }

        public void txtConfirm_GotFocus(object sender, EventArgs e)
        {
            if (txtConfirm.Text == default_confirmtxt)
                txtConfirm.Text = string.Empty;
        }

        public void txtConfirm_LostFocus(object sender, EventArgs e)
        {
            if (txtConfirm.Text == string.Empty)
            {
                txtConfirm.Text = default_confirmtxt;
                txtConfirm.ForeColor = Color.Silver;
            }
        }


        private void txtNew_TextChanged(object sender, EventArgs e)
        {
            if (txtNew.Text != string.Empty)
                txtNew.ForeColor = Color.Black;
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirm.Text != string.Empty)
                txtConfirm.ForeColor = Color.Black;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList num_of_char = new ArrayList();

                string new_pass = txtNew.Text;
                string confirm_pass = txtConfirm.Text;

                // if length of the new password less than 8, throw an exception
                if (new_pass.Length < 8)
                {
                    throw new CustomException("Password length must be at least 8 characters");
                }
                else
                {
                    // check the equality of the two passwords
                    if (new_pass == confirm_pass)
                    {
                        User u = new User();
                        string status = u.reset_password(confirm_pass);
                        MessageBox.Show(status, "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        throw new CustomException("Unmatched Password, Please Confirm Again"); // throw an exception if the equality of the two passwords is not same
                    }
                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Reset Password" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Reset_Password_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtNew;
        }
    }
}
