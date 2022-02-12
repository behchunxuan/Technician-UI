using System;
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
    public partial class Email_Reading : Form
    {
        [DllImport("user32")]
        private static extern bool HideCaret(IntPtr hWnd);
        public Email_Reading()
        {
            InitializeComponent();
            txtCategory.GotFocus += txtboxes_GotFocus;
            txtEmail.GotFocus += txtboxes_GotFocus;
            txtSubject.GotFocus += txtboxes_GotFocus;
        }

        private void txtboxes_GotFocus(object sender, EventArgs e)
        {
            HideCaret(txtCategory.Handle);
            HideCaret(txtEmail.Handle);
            HideCaret(txtSubject.Handle);
        }


        private void Email_Reading_Load(object sender, EventArgs e)
        {

        }
    }
}
