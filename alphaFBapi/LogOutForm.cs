using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncryptedFacebook
{
    public partial class LogOutForm : Form
    {
        public LogOutForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            webBrowser1.Navigate("www.facebook.com/logout.php");

        }

    }
}
