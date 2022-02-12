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
    public partial class Technician_MainUI : Form
    {
        private static string username;
        public Technician_MainUI()
        {
            

            InitializeComponent();

            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(960, 600);
            picLogo.Image = Properties.Resources.TechieMen___transparent_crop;

        }

        public Technician_MainUI(string u)
        {
            InitializeComponent();
            picLogo.Image = Properties.Resources.TechieMen___transparent_crop;

            username = u;
        }

        private void btnViewServ_Click(object sender, EventArgs e)
        {
            ViewService view = new ViewService();
            view.ShowDialog();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            Inbox inbox = new Inbox();
            inbox.ShowDialog();
        }

        private void btnPersInfo_Click(object sender, EventArgs e)
        {
            User u = new User(username);
            string[] personal_details = u.view_profile_details();

            // preparing the personal details before loading the profile form
            Technician_Personal_Profile profile = new Technician_Personal_Profile(personal_details);
            profile.ShowDialog();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            // getting the choice of the user
            DialogResult result = MessageBox.Show("Confirm Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No) {}
        }

        private void Technician_MainUI_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Welcome back, " + username + "!";
        }
    }
}