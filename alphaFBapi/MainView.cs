using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using System.Net;
using System.IO;

namespace EncryptedFacebook
{
    public partial class MainView : Form
    {
        private Dictionary<string, string> myFriendsData;
        private Dictionary<string, string> myFriendsDataReverse; 
       
        FacebookAPI apiService;

        public MainView()
        {
            InitializeComponent();
            myFriendsData = new Dictionary<string, string>();
            myFriendsDataReverse = new Dictionary<string, string>();
            apiService = new FacebookAPI();

        }


        private void MainView_Load(object sender, EventArgs e)
        {
          
          
        }


        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInForm lif = new LogInForm();
            lif.Show();

        }


        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogOutForm lof = new LogOutForm();
            lof.Show();
        }


        private void addFrndBtn_Click(object sender, EventArgs e)
        {

            string name = String.Empty;
            name = frndIDBoxAdd.Text;

            AddFriendForm aff = new AddFriendForm(name);
            aff.Show();
            
        }


        private void GetFriendsbtn_Click(object sender, EventArgs e)
        {

            FacebookAPI api = new Facebook.FacebookAPI(myToken.Default.token);

            JSONObject me = api.Get("/me");
            var yo = me.Dictionary["id"].String; //gets your user id
            myToken.Default.userId = yo.ToString();//save your id

            JSONObject friendsData = api.Get("/me/friends");//pulls all your friends 
            

            //pulls your profile image
            pictureMyImage.Image = getUrlImage("https://graph.facebook.com/" + myToken.Default.userId + "/picture");


            var data = friendsData.Dictionary["data"];

            List<JSONObject> listofFriends = data.Array.ToList<JSONObject>();

            //loop to grab any fields like friends ID, Name.......
            foreach (var friend in listofFriends)
            {
                myFriendsData.Add(friend.Dictionary["id"].String, friend.Dictionary["name"].String);
                myFriendsDataReverse.Add(friend.Dictionary["name"].String, friend.Dictionary["id"].String);
                friendsName.Items.Add(friend.Dictionary["name"].String);//adding each friends name to a listBox
            }

            //last get all my wall data
            myWall.Items.Clear();
            getMyWallData();

            

        }

       
        


        private void getMyWallData()
        {

            apiService.AccessToken = myToken.Default.token;

            JSONObject myWallFeed = apiService.Get("/me/feed");
            var wallData = myWallFeed.Dictionary["data"];

            List<JSONObject> myFeeds = wallData.Array.ToList<JSONObject>();

            foreach (var p in myFeeds)
            {
                JSONObject messageFrom = p.Dictionary["from"];
                
                try
                {
                    if (p.Dictionary.ContainsKey("message"))
                    {
                       // Console.WriteLine(messageFrom.Dictionary["name"].String + ": " + p.Dictionary["message"].String + " " + p.Dictionary["created_time"].String);
                        myWall.Items.Add(messageFrom.Dictionary["name"].String + ": " + p.Dictionary["message"].String);
                        myWall.Items.Add("");
                    }

                    if (p.Dictionary.ContainsKey("comments"))
                    {
                        myWall.Items.Add("   " + p.Dictionary["comments"].Dictionary["data"].Array[0].Dictionary["from"].Dictionary["name"].String + " " + p.Dictionary["comments"].Dictionary["data"].Array[0].Dictionary["message"].String);
                        myWall.Items.Add("");
                    }


                }
                catch (KeyNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);

                }
                
            }


        }

        private void getSentMessage()
        {
            try
            {
               
                sentMessage.Items.Add("To: " + myFriendsData[frndIDBoxMsg.Text]);
                sentMessage.Items.Add(txtFrndPost.Text);
            }
            catch (KeyNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("Need to get friend data first!");
            }   

        }



        public static Image getUrlImage(string psUrl)
        {
            WebResponse result = null;
            Image rImage = null;

            try
            {
                WebRequest request = WebRequest.Create(psUrl);
                byte[] rBytes;

                // Get the content
                result = request.GetResponse();
                System.IO.Stream rStream = result.GetResponseStream();

                // Bytes from address
                using (BinaryReader br = new BinaryReader(rStream))
                {
                    // Ask for bytes bigger than the actual stream
                    rBytes = br.ReadBytes(1000000);
                    br.Close();
                }
                // close down the web response object
                result.Close();

                // Bytes into image
                using (MemoryStream imageStream = new MemoryStream(rBytes, 0, rBytes.Length))
                {
                    imageStream.Write(rBytes, 0, rBytes.Length);
                    rImage = Image.FromStream(imageStream, true);
                    imageStream.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("error= " + ex);
            }
            finally
            {
                if (result != null) result.Close();
            }

            return rImage;
        }


        private void StatusUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                //same thing pass your app token
                FacebookAPI api = new FacebookAPI(myToken.Default.token);
                //build a dictionary
            
                Dictionary<string, string> postArgs = new Dictionary<string, string>();
                postArgs["message"] = txtPost.Text;//key message, value text
                //postArgs["picture"] = "http://test.com/folder/test-image.jpg";//pass a image url
                
                

                //send to fb
                JSONObject post = api.Post("/ " + myToken.Default.userId + "/feed", postArgs);

               


                //clear wall 
                myWall.Items.Clear();
                //refresh data
                getMyWallData();
                //clear text box
                txtPost.Text = "";
            }
            catch (FacebookAPIException exr)
            {

                Console.WriteLine(exr.Message);
            }
           
        }


        private void RefreshBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                myWall.Items.Clear();
                getMyWallData();
                getSentMessage();
            }
            catch (FacebookAPIException exr)
            {

                Console.WriteLine(exr.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lbFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("You've selected " + friendsName.SelectedItem.ToString());
            frndDetailBox.Items.Clear();
            frndDetailBox.Items.Add("User Name: " + friendsName.SelectedItem.ToString());
            frndDetailBox.Items.Add("User ID: : " + myFriendsDataReverse[friendsName.SelectedItem.ToString()]);
            frndDetailBox.Items.Add("Encryption Key: ");
            frndDetailBox.Items.Add("Belongs to :");
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Encrypt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frndPostBtn_Click(object sender, EventArgs e)
        {
            try
            {



                //same thing pass your app token
                FacebookAPI api = new FacebookAPI(myToken.Default.token);
                //build a dictionary

                Dictionary<string, string> postArgs = new Dictionary<string, string>();
                postArgs["message"] = txtFrndPost.Text;//key message, value text
                

                //send to fb
                JSONObject post = api.Post("/ " + frndIDBoxMsg.Text + "/feed", postArgs);


                //clear friend wall 
                //refresh data
                getSentMessage();
                //clear text box
                txtFrndPost.Text = "";
            }
            catch (FacebookAPIException exr)
            {

                Console.WriteLine(exr.Message);
            }

        }

        private void createFrndList_Click(object sender, EventArgs e) 
        {
            try
            {
                
            }
            catch (FacebookAPIException exr)
            {
                Console.WriteLine(exr.Message);
            }

        }


    }
}
