using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Technician_UI
{
    public partial class Forgot_Password : Form
    {
        string default_usertxt = "Enter Username";
        string default_firstNametxt = "Enter First Name";
        string default_lastNametxt = "Enter Last Name";
        string default_emailtxt = "Enter Email Address";
        string default_mobiletxt = "Enter Mobile No.";

        public Forgot_Password()
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(960, 600);

            InitializeComponent();



            txtUsername.GotFocus += new EventHandler(txtUsername_GotFocus);
            txtUsername.LostFocus += new EventHandler(txtUsername_LostFocus);

            txtFirstName.GotFocus += new EventHandler(txtFirstName_GotFocus);
            txtFirstName.LostFocus += new EventHandler(txtFirstName_LostFocus);

            txtLastName.GotFocus += new EventHandler(txtLastName_GotFocus);
            txtLastName.LostFocus += new EventHandler(txtLastName_LostFocus);

            txtEmail.GotFocus += new EventHandler(txtEmail_GotFocus);
            txtEmail.LostFocus += new EventHandler(txtEmail_LostFocus);

            txtMobile.GotFocus += new EventHandler(txtMobile_GotFocus);
            txtMobile.LostFocus += new EventHandler(txtMobile_LostFocus);
        }

        private void txtUsername_GotFocus(object sender, EventArgs e)
        {
            if (txtUsername.Text == default_usertxt)
            {
                txtUsername.Text = string.Empty;
            }
        }

        private void txtUsername_LostFocus(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty)
            {
                txtUsername.Text = default_usertxt;
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtFirstName_GotFocus(object sender, EventArgs e)
        {
            if (txtFirstName.Text == default_firstNametxt)
            {
                txtFirstName.Text = string.Empty;
            }
        }

        private void txtFirstName_LostFocus(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty)
            {
                txtFirstName.Text = default_firstNametxt;
                txtFirstName.ForeColor = Color.Silver;
            }
        }

        private void txtLastName_GotFocus(object sender, EventArgs e)
        {
            if (txtLastName.Text == default_lastNametxt)
            {
                txtLastName.Text = string.Empty;
            }
        }

        private void txtLastName_LostFocus(object sender, EventArgs e)
        {
            if (txtLastName.Text == string.Empty)
            {
                txtLastName.Text = default_lastNametxt;
                txtLastName.ForeColor = Color.Silver;   
            }
        }

        private void txtEmail_GotFocus(object sender, EventArgs e)
        {
            if (txtEmail.Text == default_emailtxt)
            {
                txtEmail.Text = string.Empty;
            }
        }

        private void txtEmail_LostFocus(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty)
            {
                txtEmail.Text = default_emailtxt;
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtMobile_GotFocus(object sender, EventArgs e)
        {
            if (txtMobile.Text == default_mobiletxt)
            {
                txtMobile.Text = string.Empty;
            }
        }

        private void txtMobile_LostFocus(object sender, EventArgs e)
        {
            if (txtMobile.Text == string.Empty)
            {
                txtMobile.Text = default_mobiletxt;
                txtMobile.ForeColor = Color.Silver;
            }
        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty)
                txtUsername.ForeColor = Color.Black;
        }

        private void txtFirstName_TextChanged_1(object sender, EventArgs e)
        {
            if (txtFirstName.Text != default_firstNametxt)
                txtFirstName.ForeColor = Color.Black;
        }

        private void txtLastName_TextChanged_1(object sender, EventArgs e)
        {
            if (txtLastName.Text != default_lastNametxt)
                txtLastName.ForeColor = Color.Black;
        }

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {
            if (txtEmail.Text != default_emailtxt)
                txtEmail.ForeColor = Color.Black;
        }

        private void txtMobile_TextChanged_1(object sender, EventArgs e)
        {
            if (txtMobile.Text != default_mobiletxt)
                txtMobile.ForeColor = Color.Black;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Want to go back?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            { 
                this.Close();
            }
            else if (result == DialogResult.No) {}
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == default_usertxt || txtFirstName.Text == default_firstNametxt || txtLastName.Text == default_lastNametxt || txtEmail.Text == default_emailtxt || txtMobile.Text == default_mobiletxt)
                    throw new CustomException("All fields must be filled in to verify your identity");

                string status;

                string username;
                string firstName;
                string lastName;
                string email;
                string mobile;

                int verify_mobile;

                username = txtUsername.Text;
                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;
                email = txtEmail.Text;
                mobile = txtMobile.Text;

                // validate an email address
                Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                RegexOptions.CultureInvariant | RegexOptions.Singleline);

                bool isValidEmail = regex.IsMatch(email);
                if (!isValidEmail)
                    throw new CustomException("The email is invalid");

                // validate mobile number
                if (int.TryParse(txtMobile.Text, out verify_mobile))
                {
                    if (txtMobile.Text.Length < 7 || txtMobile.Text.Length > 12)
                    {
                        throw new CustomException("Invalid mobile number, must be in between 7 - 12 numbers");
                    }
                }
                else
                    throw new CustomException("Mobile number must be in integer");

                User u = new User(username, firstName, lastName, email, mobile);
                status = u.forgot_password();

                if (status != null)
                    MessageBox.Show(status, "Forgot Password Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Forgot Password Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Forgot_Password_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsername;

        }
    }
}
