namespace EncryptedFacebook
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lnkLogin = new System.Windows.Forms.LinkLabel();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.pictureMyImage = new System.Windows.Forms.PictureBox();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.myWallTab = new System.Windows.Forms.TabPage();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.statusUpdateBtn = new System.Windows.Forms.Button();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.myWall = new System.Windows.Forms.ListBox();
            this.friendsTab = new System.Windows.Forms.TabPage();
            this.frndDetailBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frndIDBoxAdd = new System.Windows.Forms.TextBox();
            this.addFrndBtn = new System.Windows.Forms.Button();
            this.friendsName = new System.Windows.Forms.ListBox();
            this.getFriendsbtn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.messageTab = new System.Windows.Forms.TabPage();
            this.sentMessage = new System.Windows.Forms.ListBox();
            this.frndPostBtn = new System.Windows.Forms.Button();
            this.frndIDBoxMsg = new System.Windows.Forms.TextBox();
            this.friendID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFrndPost = new System.Windows.Forms.TextBox();
            this.friendListTab = new System.Windows.Forms.TabPage();
            this.deleteFrndfrmFrndList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addFrndtoFrndList = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.friendListBox = new System.Windows.Forms.ListBox();
            this.friendListName = new System.Windows.Forms.Label();
            this.createFrndList = new System.Windows.Forms.Button();
            this.frndListName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMyImage)).BeginInit();
            this.myWallTab.SuspendLayout();
            this.friendsTab.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.messageTab.SuspendLayout();
            this.friendListTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkLogin
            // 
            this.lnkLogin.AutoSize = true;
            this.lnkLogin.Location = new System.Drawing.Point(13, 13);
            this.lnkLogin.Name = "lnkLogin";
            this.lnkLogin.Size = new System.Drawing.Size(33, 13);
            this.lnkLogin.TabIndex = 0;
            this.lnkLogin.TabStop = true;
            this.lnkLogin.Text = "Login";
            this.lnkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogin_LinkClicked);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(437, 34);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click_1);
            // 
            // pictureMyImage
            // 
            this.pictureMyImage.Location = new System.Drawing.Point(347, 13);
            this.pictureMyImage.Name = "pictureMyImage";
            this.pictureMyImage.Size = new System.Drawing.Size(66, 44);
            this.pictureMyImage.TabIndex = 3;
            this.pictureMyImage.TabStop = false;
            // 
            // lnkLogout
            // 
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.Location = new System.Drawing.Point(571, 13);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(40, 13);
            this.lnkLogout.TabIndex = 4;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);
            // 
            // myWallTab
            // 
            this.myWallTab.Controls.Add(this.decryptBtn);
            this.myWallTab.Controls.Add(this.encryptBtn);
            this.myWallTab.Controls.Add(this.statusUpdateBtn);
            this.myWallTab.Controls.Add(this.txtPost);
            this.myWallTab.Controls.Add(this.myWall);
            this.myWallTab.Location = new System.Drawing.Point(4, 22);
            this.myWallTab.Name = "myWallTab";
            this.myWallTab.Padding = new System.Windows.Forms.Padding(3);
            this.myWallTab.Size = new System.Drawing.Size(610, 252);
            this.myWallTab.TabIndex = 1;
            this.myWallTab.Text = "Wall";
            this.myWallTab.UseVisualStyleBackColor = true;
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(507, 212);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(93, 24);
            this.decryptBtn.TabIndex = 9;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(408, 211);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(93, 25);
            this.encryptBtn.TabIndex = 8;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // statusUpdateBtn
            // 
            this.statusUpdateBtn.Location = new System.Drawing.Point(327, 211);
            this.statusUpdateBtn.Name = "statusUpdateBtn";
            this.statusUpdateBtn.Size = new System.Drawing.Size(75, 25);
            this.statusUpdateBtn.TabIndex = 6;
            this.statusUpdateBtn.Text = "Post";
            this.statusUpdateBtn.UseVisualStyleBackColor = true;
            this.statusUpdateBtn.Click += new System.EventHandler(this.StatusUpdate_Click);
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(6, 211);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(315, 20);
            this.txtPost.TabIndex = 5;
            // 
            // myWall
            // 
            this.myWall.FormattingEnabled = true;
            this.myWall.HorizontalScrollbar = true;
            this.myWall.Location = new System.Drawing.Point(6, 6);
            this.myWall.MaximumSize = new System.Drawing.Size(800, 800);
            this.myWall.Name = "myWall";
            this.myWall.Size = new System.Drawing.Size(594, 199);
            this.myWall.TabIndex = 0;
            // 
            // friendsTab
            // 
            this.friendsTab.Controls.Add(this.frndDetailBox);
            this.friendsTab.Controls.Add(this.label1);
            this.friendsTab.Controls.Add(this.frndIDBoxAdd);
            this.friendsTab.Controls.Add(this.addFrndBtn);
            this.friendsTab.Controls.Add(this.friendsName);
            this.friendsTab.Controls.Add(this.getFriendsbtn);
            this.friendsTab.Location = new System.Drawing.Point(4, 22);
            this.friendsTab.Name = "friendsTab";
            this.friendsTab.Padding = new System.Windows.Forms.Padding(3);
            this.friendsTab.Size = new System.Drawing.Size(610, 252);
            this.friendsTab.TabIndex = 0;
            this.friendsTab.Text = "Friends";
            this.friendsTab.UseVisualStyleBackColor = true;
            this.friendsTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // frndDetailBox
            // 
            this.frndDetailBox.FormattingEnabled = true;
            this.frndDetailBox.Location = new System.Drawing.Point(294, 6);
            this.frndDetailBox.Name = "frndDetailBox";
            this.frndDetailBox.Size = new System.Drawing.Size(310, 212);
            this.frndDetailBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "USER_ID";
            // 
            // frndIDBoxAdd
            // 
            this.frndIDBoxAdd.Location = new System.Drawing.Point(268, 226);
            this.frndIDBoxAdd.Name = "frndIDBoxAdd";
            this.frndIDBoxAdd.Size = new System.Drawing.Size(149, 20);
            this.frndIDBoxAdd.TabIndex = 5;
            this.frndIDBoxAdd.Text = "Friend\'s UserID";
            // 
            // addFrndBtn
            // 
            this.addFrndBtn.Location = new System.Drawing.Point(426, 223);
            this.addFrndBtn.Name = "addFrndBtn";
            this.addFrndBtn.Size = new System.Drawing.Size(75, 23);
            this.addFrndBtn.TabIndex = 3;
            this.addFrndBtn.Text = "Add Friend";
            this.addFrndBtn.UseVisualStyleBackColor = true;
            this.addFrndBtn.Click += new System.EventHandler(this.addFrndBtn_Click);
            // 
            // friendsName
            // 
            this.friendsName.FormattingEnabled = true;
            this.friendsName.HorizontalScrollbar = true;
            this.friendsName.Location = new System.Drawing.Point(6, 6);
            this.friendsName.Name = "friendsName";
            this.friendsName.Size = new System.Drawing.Size(249, 212);
            this.friendsName.TabIndex = 2;
            this.friendsName.SelectedIndexChanged += new System.EventHandler(this.lbFriends_SelectedIndexChanged);
            // 
            // getFriendsbtn
            // 
            this.getFriendsbtn.Location = new System.Drawing.Point(6, 223);
            this.getFriendsbtn.Name = "getFriendsbtn";
            this.getFriendsbtn.Size = new System.Drawing.Size(75, 23);
            this.getFriendsbtn.TabIndex = 1;
            this.getFriendsbtn.Text = "Get Friends";
            this.getFriendsbtn.UseVisualStyleBackColor = true;
            this.getFriendsbtn.Click += new System.EventHandler(this.GetFriendsbtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.friendsTab);
            this.tabControl.Controls.Add(this.myWallTab);
            this.tabControl.Controls.Add(this.messageTab);
            this.tabControl.Controls.Add(this.friendListTab);
            this.tabControl.Location = new System.Drawing.Point(16, 41);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(618, 278);
            this.tabControl.TabIndex = 2;
            // 
            // messageTab
            // 
            this.messageTab.Controls.Add(this.sentMessage);
            this.messageTab.Controls.Add(this.frndPostBtn);
            this.messageTab.Controls.Add(this.frndIDBoxMsg);
            this.messageTab.Controls.Add(this.friendID);
            this.messageTab.Controls.Add(this.button2);
            this.messageTab.Controls.Add(this.button1);
            this.messageTab.Controls.Add(this.txtFrndPost);
            this.messageTab.Location = new System.Drawing.Point(4, 22);
            this.messageTab.Name = "messageTab";
            this.messageTab.Padding = new System.Windows.Forms.Padding(3);
            this.messageTab.Size = new System.Drawing.Size(610, 252);
            this.messageTab.TabIndex = 2;
            this.messageTab.Text = "Message";
            this.messageTab.UseVisualStyleBackColor = true;
            // 
            // sentMessage
            // 
            this.sentMessage.FormattingEnabled = true;
            this.sentMessage.Location = new System.Drawing.Point(6, 35);
            this.sentMessage.Name = "sentMessage";
            this.sentMessage.Size = new System.Drawing.Size(598, 160);
            this.sentMessage.TabIndex = 14;
            // 
            // frndPostBtn
            // 
            this.frndPostBtn.Location = new System.Drawing.Point(327, 211);
            this.frndPostBtn.Name = "frndPostBtn";
            this.frndPostBtn.Size = new System.Drawing.Size(79, 24);
            this.frndPostBtn.TabIndex = 13;
            this.frndPostBtn.Text = "Post";
            this.frndPostBtn.UseVisualStyleBackColor = true;
            this.frndPostBtn.Click += new System.EventHandler(this.frndPostBtn_Click);
            // 
            // frndIDBoxMsg
            // 
            this.frndIDBoxMsg.Location = new System.Drawing.Point(94, 9);
            this.frndIDBoxMsg.Name = "frndIDBoxMsg";
            this.frndIDBoxMsg.Size = new System.Drawing.Size(100, 20);
            this.frndIDBoxMsg.TabIndex = 12;
            // 
            // friendID
            // 
            this.friendID.AutoSize = true;
            this.friendID.Location = new System.Drawing.Point(6, 12);
            this.friendID.Name = "friendID";
            this.friendID.Size = new System.Drawing.Size(82, 13);
            this.friendID.TabIndex = 11;
            this.friendID.Text = "Friend\'s User ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 24);
            this.button2.TabIndex = 10;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtFrndPost
            // 
            this.txtFrndPost.Location = new System.Drawing.Point(16, 213);
            this.txtFrndPost.Name = "txtFrndPost";
            this.txtFrndPost.Size = new System.Drawing.Size(297, 20);
            this.txtFrndPost.TabIndex = 6;
            // 
            // friendListTab
            // 
            this.friendListTab.Controls.Add(this.deleteFrndfrmFrndList);
            this.friendListTab.Controls.Add(this.listBox1);
            this.friendListTab.Controls.Add(this.addFrndtoFrndList);
            this.friendListTab.Controls.Add(this.button4);
            this.friendListTab.Controls.Add(this.button3);
            this.friendListTab.Controls.Add(this.friendListBox);
            this.friendListTab.Controls.Add(this.friendListName);
            this.friendListTab.Controls.Add(this.createFrndList);
            this.friendListTab.Controls.Add(this.frndListName);
            this.friendListTab.Location = new System.Drawing.Point(4, 22);
            this.friendListTab.Name = "friendListTab";
            this.friendListTab.Padding = new System.Windows.Forms.Padding(3);
            this.friendListTab.Size = new System.Drawing.Size(610, 252);
            this.friendListTab.TabIndex = 3;
            this.friendListTab.Text = "Friend Lists";
            this.friendListTab.UseVisualStyleBackColor = true;
            // 
            // deleteFrndfrmFrndList
            // 
            this.deleteFrndfrmFrndList.Location = new System.Drawing.Point(261, 33);
            this.deleteFrndfrmFrndList.Name = "deleteFrndfrmFrndList";
            this.deleteFrndfrmFrndList.Size = new System.Drawing.Size(73, 21);
            this.deleteFrndfrmFrndList.TabIndex = 8;
            this.deleteFrndfrmFrndList.Text = "Delete";
            this.deleteFrndfrmFrndList.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(340, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 186);
            this.listBox1.TabIndex = 7;
            // 
            // addFrndtoFrndList
            // 
            this.addFrndtoFrndList.Location = new System.Drawing.Point(261, 6);
            this.addFrndtoFrndList.Name = "addFrndtoFrndList";
            this.addFrndtoFrndList.Size = new System.Drawing.Size(73, 21);
            this.addFrndtoFrndList.TabIndex = 6;
            this.addFrndtoFrndList.Text = "Add";
            this.addFrndtoFrndList.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 21);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 21);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // friendListBox
            // 
            this.friendListBox.FormattingEnabled = true;
            this.friendListBox.Location = new System.Drawing.Point(85, 6);
            this.friendListBox.Name = "friendListBox";
            this.friendListBox.Size = new System.Drawing.Size(170, 186);
            this.friendListBox.TabIndex = 3;
            // 
            // friendListName
            // 
            this.friendListName.AutoSize = true;
            this.friendListName.Location = new System.Drawing.Point(13, 222);
            this.friendListName.Name = "friendListName";
            this.friendListName.Size = new System.Drawing.Size(86, 13);
            this.friendListName.TabIndex = 2;
            this.friendListName.Text = "Friend List Name";
            // 
            // createFrndList
            // 
            this.createFrndList.Location = new System.Drawing.Point(274, 218);
            this.createFrndList.Name = "createFrndList";
            this.createFrndList.Size = new System.Drawing.Size(119, 21);
            this.createFrndList.TabIndex = 1;
            this.createFrndList.Text = "Create a Friend List";
            this.createFrndList.UseVisualStyleBackColor = true;
            this.createFrndList.Click += new System.EventHandler(this.createFrndList_Click);
            // 
            // frndListName
            // 
            this.frndListName.Location = new System.Drawing.Point(105, 219);
            this.frndListName.Name = "frndListName";
            this.frndListName.Size = new System.Drawing.Size(163, 20);
            this.frndListName.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 331);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.pictureMyImage);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lnkLogin);
            this.Name = "MainView";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMyImage)).EndInit();
            this.myWallTab.ResumeLayout(false);
            this.myWallTab.PerformLayout();
            this.friendsTab.ResumeLayout(false);
            this.friendsTab.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.messageTab.ResumeLayout(false);
            this.messageTab.PerformLayout();
            this.friendListTab.ResumeLayout(false);
            this.friendListTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkLogin;
        private System.Windows.Forms.PictureBox pictureMyImage;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.TabPage myWallTab;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button statusUpdateBtn;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.ListBox myWall;
        private System.Windows.Forms.TabPage friendsTab;
        private System.Windows.Forms.ListBox friendsName;
        private System.Windows.Forms.Button getFriendsbtn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage messageTab;
        private System.Windows.Forms.TextBox txtFrndPost;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addFrndBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox frndIDBoxAdd;
        private System.Windows.Forms.TabPage friendListTab;
        private System.Windows.Forms.Button createFrndList;
        private System.Windows.Forms.TextBox frndListName;
        private System.Windows.Forms.Label friendListName;
        private System.Windows.Forms.ListBox friendListBox;
        private System.Windows.Forms.Label friendID;
        private System.Windows.Forms.TextBox frndIDBoxMsg;
        private System.Windows.Forms.Button frndPostBtn;
        private System.Windows.Forms.ListBox sentMessage;
        private System.Windows.Forms.ListBox frndDetailBox;
        private System.Windows.Forms.Button addFrndtoFrndList;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button deleteFrndfrmFrndList;
    }
}