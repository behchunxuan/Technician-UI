using System;
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
    public partial class VerifyYourself : Form
    {
        private string stat;
        public string Stat { get => stat; set => stat = value; }

        string default_usertxt = "Enter Username";
        string default_passtxt = "Enter Password";

        public VerifyYourself()
        {
            InitializeComponent();

            txtUsername.GotFocus += new EventHandler(txtUsername_GotFocus);
            txtUsername.LostFocus += new EventHandler(txtUsername_LostFocus);

            txtPassword.GotFocus += new EventHandler(txtPassword_GotFocus);
            txtPassword.LostFocus += new EventHandler(txtPassword_LostFocus);
        }

        private void txtUsername_GotFocus(object sender, EventArgs e)
        {
            if (txtUsername.Text == default_usertxt)
                txtUsername.Text = string.Empty;
        }

        private void txtUsername_LostFocus(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty)
            {
                txtUsername.Text = default_usertxt;
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_GotFocus(object sender, EventArgs e)
        {
            if (txtPassword.Text == default_passtxt)
                txtPassword.Text = string.Empty;
        }

        private void txtPassword_LostFocus(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = default_passtxt;
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {
            if (txtUsername.Text != default_usertxt)
                txtUsername.ForeColor = Color.Black;
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPassword.Text != default_passtxt)
                txtPassword.ForeColor = Color.Black;
        }

        private void chkPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkPassword.Checked == true)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
                    throw new CustomException("All fields must be filled in for verify your identity");

                string username = txtUsername.Text;
                string password = txtPassword.Text;

                User u = new User(username, password);
                stat = u.login(); // verify the identity of the current user

                if (stat == null)
                    MessageBox.Show("Failed to verify", "Verify Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Verify Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                this.Close();
            }         
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // getting the choices of the user
            DialogResult result = MessageBox.Show("Want to go back?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No) { }
        }

        private void VerifyYourself_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsername;
        }
    }
}
