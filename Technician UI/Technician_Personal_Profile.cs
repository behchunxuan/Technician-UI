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
using System.Text.RegularExpressions;

namespace Technician_UI
{
    public partial class Technician_Personal_Profile : Form
    {
        string[] personal_details = new string[7];

        string default_firstnametxt = "Enter First Name";
        string default_lastnametxt = "Enter Last Name";
        string default_emailtxt = "Enter Email Address";
        string default_mobiletxt = "Enter Mobile Number";
        string default_passtxt = "Enter Password";

        public Technician_Personal_Profile()
        {
            InitializeComponent();
        }

        public Technician_Personal_Profile(string[] pd)
        {
            InitializeComponent();

            this.ActiveControl = txtFirstName;

            txtFirstName.GotFocus += new EventHandler(txtFirstName_GotFocus);
            txtFirstName.LostFocus += new EventHandler(txtFirstName_LostFocus);

            txtLastName.GotFocus += new EventHandler(txtLastName_GotFocus);
            txtLastName.LostFocus += new EventHandler(txtLastName_LostFocus);

            txtEmail.GotFocus += new EventHandler(txtEmail_GotFocus);
            txtEmail.LostFocus += new EventHandler(txtEmail_LostFocus);

            txtMobile.GotFocus += new EventHandler(txtMobile_GotFocus);
            txtMobile.LostFocus += new EventHandler(txtMobile_LostFocus);

            txtPassword.GotFocus += new EventHandler(txtPassword_GotFocus);
            txtPassword.LostFocus += new EventHandler(txtPassword_LostFocus);

            personal_details = pd;
        }
        
        private void txtFirstName_GotFocus(object sender, EventArgs e)
        {
            if (txtFirstName.Text == default_firstnametxt)
            {
                txtFirstName.Text = string.Empty;
            }
        }
        
        private void txtFirstName_LostFocus(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty)
            {
                txtFirstName.Text = default_firstnametxt;
                txtFirstName.ForeColor = Color.Silver;
            }
        }

        private void txtLastName_GotFocus(object sender, EventArgs e)
        {
            if (txtLastName.Text == default_lastnametxt)
            {
                txtLastName.Text = string.Empty;
            }
        }

        private void txtLastName_LostFocus(object sender, EventArgs e)
        {
            if (txtLastName.Text == string.Empty)
            {
                txtLastName.Text = default_lastnametxt;
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
                txtLastName.ForeColor= Color.Silver;
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
                txtMobile.ForeColor= Color.Silver;
            }
        }

        private void txtPassword_GotFocus(object sender, EventArgs e)
        {
            if (txtPassword.Text == default_passtxt)
            {
                txtPassword.Text = string.Empty;
            }
        }

        private void txtPassword_LostFocus(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = default_passtxt;
                txtPassword.ForeColor= Color.Silver;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text != default_firstnametxt)
            {
                txtFirstName.ForeColor = Color.Black;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text != default_lastnametxt)
            {
                txtLastName.ForeColor = Color.Black;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text != default_emailtxt)
            {
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            if (txtMobile.Text != default_mobiletxt)
            {
                txtMobile.ForeColor = Color.Black;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != default_passtxt)
            {
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void Technician_Personal_Profile_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtFirstName;

            // setting a custom format
            dpkBirth.CustomFormat = "MM/dd/yyyy";
            dpkBirth.Format = DateTimePickerFormat.Custom;

            string password = personal_details[0];
            string first_name = personal_details[1];
            string last_name = personal_details[2];
            string phone_number = personal_details[3];
            DateTime dob = Convert.ToDateTime(personal_details[4]);
            string email = personal_details[5];

            // putting the details onto the corresponding textbox
            txtPassword.Text = password;
            txtFirstName.Text = first_name;
            txtLastName.Text = last_name;
            txtMobile.Text = phone_number;
            dpkBirth.Value = dob;
            txtEmail.Text = email;    
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // getting the result from the user either Yes or No
            DialogResult result = MessageBox.Show("Want to go back?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // If yes, close the topmost form
            }
            else if (result == DialogResult.No) { } // If no, remains focus to the form
        }

        private void btnUpt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty || txtEmail.Text == string.Empty || txtMobile.Text == string.Empty || txtPassword.Text == String.Empty || dpkBirth.Text == string.Empty)
                    throw new CustomException("All fields must be filled in to update your profile");

                // validate an email address
                Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                RegexOptions.CultureInvariant | RegexOptions.Singleline);

                bool isValidEmail = regex.IsMatch(txtEmail.Text);
                if (!isValidEmail)
                    throw new CustomException("The email is invalid");

                // validate mobile number
                if (txtMobile.Text.Length < 7 || txtMobile.Text.Length > 12)
                    throw new CustomException("Invalid mobile number, must be in between 7 - 12 numbers");


                string[] new_personal_details = new string[7];

                new_personal_details[0] = txtPassword.Text;
                new_personal_details[1] = txtFirstName.Text;
                new_personal_details[2] = txtLastName.Text;
                new_personal_details[3] = txtMobile.Text;
                new_personal_details[4] = dpkBirth.Text;
                new_personal_details[5] = txtEmail.Text;
                new_personal_details[6] = personal_details[6];

                using (VerifyYourself verifyYourself = new VerifyYourself())
                {
                    verifyYourself.ShowDialog();

                    // User is verified successful
                    if(verifyYourself.Stat != null)
                    {
                        User u = new User(personal_details[6]);
                        string update_stat = u.update_personal_profile(new_personal_details);

                        // show the update status to the user
                        if (update_stat != null)
                            MessageBox.Show(update_stat, "Update Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }            
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Update Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
