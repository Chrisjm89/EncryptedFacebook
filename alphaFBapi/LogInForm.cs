using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;

namespace EncryptedFacebook
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("https://graph.facebook.com/oauth/authorize" +
        "?client_id=" + myToken.Default.appId +
        "&redirect_uri=http://www.facebook.com/connect/login_success.html" +
        "&display=popup&type=user_agent&scope=user_status,user_photos,email,user_birthday,user_online_presence,publish_stream,read_stream,read_friendlists,manage_friendlists");

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.Document.Url.ToString().Contains("access_token"))
            {
                string token = String.Empty;
                string URL = webBrowser1.Document.Url.ToString();

                token = URL.Substring(URL.IndexOf("access_token") + 13);
                token = token.Substring(0, token.IndexOf("&"));

                // Received access token and save it
                myToken.Default.token = token;

                Console.WriteLine(URL);
            }


            
        }
    }
}
