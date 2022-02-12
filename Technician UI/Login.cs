using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Technician_UI
{
    public partial class Login : Form
    {
        public static int login_count = 0;
        string default_usertxt = "Enter Username";
        string default_passtxt = "Enter Password";
        
        public Login()
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != default_usertxt)
                txtUsername.ForeColor = Color.Black; 
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != default_passtxt)
                txtPassword.ForeColor = Color.Black;     
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked == true)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
                    throw new CustomException("All fields must be filled in for login");

                string stat = null;
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                User u = new User(username, password);
                stat = u.login();

                // to identify the user role when login to the main UI
                switch(stat)
                {
                    case "1":
                        Technician_MainUI tech = new Technician_MainUI(username);
                        tech.ShowDialog();
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    default:
                        MessageBox.Show("Login Unsuccessful, Please Try Again", "Login Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);        
                        // login count increment when failed to login
                        login_count++;
                        if (login_count <= 3)
                            stat = u.login();
                        // invalidate the login input when exceeding login count
                        else
                        {
                            txtUsername.ReadOnly = true;
                            txtPassword.ReadOnly = true;
                            txtUsername.Cursor = Cursors.No;
                            txtPassword.Cursor = Cursors.No;

                            tmrCountDown = new System.Windows.Forms.Timer();
                            tmrCountDown.Interval = 1000; // 1 secs
                            tmrCountDown.Tick += new EventHandler(tmrCountDown_Tick);
                            tmrCountDown.Start();

                            throw new CustomException("Try to login again in 10 seconds");
                        }
                        break;               
                }

            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Login Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                txtUsername.Text = String.Empty;
                txtPassword.Text = String.Empty;
            }
        }

        private void llbForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password forgot_pass = new Forgot_Password();
            forgot_pass.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // always take focus on txtUsername when the form loads
            this.ActiveControl = txtUsername;                
        }

        private System.Windows.Forms.Timer tmrCountDown;
        private int countdown = 11;
        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            countdown--;
            lblCountdown.Text = countdown.ToString() + " seconds left";

            if (countdown == 0)
            {
                tmrCountDown.Stop(); // stop the countdown clock after the time over

                // recover back the functionality of the controls
                txtUsername.ReadOnly = false;
                txtPassword.ReadOnly = false;
                txtUsername.Cursor = Cursors.IBeam;
                txtPassword.Cursor = Cursors.IBeam;
                lblCountdown.Text = string.Empty;

                // reset the failed login count to zero
                login_count = 0;
            }          
        }
    }
}
