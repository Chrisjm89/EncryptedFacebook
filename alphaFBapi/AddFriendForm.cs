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
    public partial class AddFriendForm : Form
    {
        public AddFriendForm(string userID)
        {
            InitializeComponent();
            
            name = userID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            webBrowser1.Navigate("http://www.facebook.com/addfriend.php?id=" + this.name );

        }

    }
}
