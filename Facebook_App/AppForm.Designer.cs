namespace Facebook_App
{
    partial class AppForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label nameLabel2;
            System.Windows.Forms.Label religionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.groupBoxFriends = new System.Windows.Forms.GroupBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.comboBoxFriends = new System.Windows.Forms.ComboBox();
            this.buttonGetFriends = new System.Windows.Forms.Button();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.listBoxFetch = new System.Windows.Forms.ListBox();
            this.comboBoxFetch = new System.Windows.Forms.ComboBox();
            this.labelFetch = new System.Windows.Forms.Label();
            this.buttonFetch = new System.Windows.Forms.Button();
            this.groupBoxAlbumsAndFichers = new System.Windows.Forms.GroupBox();
            this.buttonShowMostLikedPhoto = new System.Windows.Forms.Button();
            this.buttonAlbumList = new System.Windows.Forms.Button();
            this.buttonDownloadAlbum = new System.Windows.Forms.Button();
            this.pictureBoxMostLikes = new System.Windows.Forms.PictureBox();
            this.labelMostLiked = new System.Windows.Forms.Label();
            this.listBoxAlbumList = new System.Windows.Forms.ListBox();
            this.labelAlbumList = new System.Windows.Forms.Label();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.religionLabel1 = new System.Windows.Forms.Label();
            this.CityLabel1 = new System.Windows.Forms.Label();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.buttonDisconect = new System.Windows.Forms.Button();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            religionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.groupBoxFriends.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
            this.groupBoxAlbumsAndFichers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikes)).BeginInit();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(222, 16);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 93;
            nameLabel.Text = "Name:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(222, 39);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 94;
            birthdayLabel.Text = "Birthday:";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Location = new System.Drawing.Point(222, 60);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new System.Drawing.Size(27, 13);
            nameLabel2.TabIndex = 95;
            nameLabel2.Text = "City:";
            // 
            // religionLabel
            // 
            religionLabel.AutoSize = true;
            religionLabel.Location = new System.Drawing.Point(222, 79);
            religionLabel.Name = "religionLabel";
            religionLabel.Size = new System.Drawing.Size(48, 13);
            religionLabel.TabIndex = 96;
            religionLabel.Text = "Religion:";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(898, 556);
            // 
            // groupBoxFriends
            // 
            this.groupBoxFriends.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxFriends.Controls.Add(this.listBoxFriends);
            this.groupBoxFriends.Controls.Add(this.comboBoxFriends);
            this.groupBoxFriends.Controls.Add(this.buttonGetFriends);
            this.groupBoxFriends.Location = new System.Drawing.Point(395, 9);
            this.groupBoxFriends.Name = "groupBoxFriends";
            this.groupBoxFriends.Size = new System.Drawing.Size(259, 127);
            this.groupBoxFriends.TabIndex = 90;
            this.groupBoxFriends.TabStop = false;
            this.groupBoxFriends.Text = "Friends";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(116, 17);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(132, 82);
            this.listBoxFriends.TabIndex = 7;
            // 
            // comboBoxFriends
            // 
            this.comboBoxFriends.FormattingEnabled = true;
            this.comboBoxFriends.Items.AddRange(new object[] {
            "All Friends",
            "Female",
            "Male"});
            this.comboBoxFriends.Location = new System.Drawing.Point(11, 29);
            this.comboBoxFriends.Name = "comboBoxFriends";
            this.comboBoxFriends.Size = new System.Drawing.Size(97, 21);
            this.comboBoxFriends.TabIndex = 50;
            this.comboBoxFriends.Text = "All Friends";
            // 
            // buttonGetFriends
            // 
            this.buttonGetFriends.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonGetFriends.Location = new System.Drawing.Point(11, 60);
            this.buttonGetFriends.Name = "buttonGetFriends";
            this.buttonGetFriends.Size = new System.Drawing.Size(75, 23);
            this.buttonGetFriends.TabIndex = 6;
            this.buttonGetFriends.Text = "GetFriends";
            this.buttonGetFriends.UseVisualStyleBackColor = false;
            this.buttonGetFriends.Click += new System.EventHandler(this.buttonGetFriends_Click);
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxGeneral.Controls.Add(this.labelPostStatus);
            this.groupBoxGeneral.Controls.Add(this.textBoxStatus);
            this.groupBoxGeneral.Controls.Add(this.buttonSetStatus);
            this.groupBoxGeneral.Controls.Add(this.listBoxFetch);
            this.groupBoxGeneral.Controls.Add(this.comboBoxFetch);
            this.groupBoxGeneral.Controls.Add(this.labelFetch);
            this.groupBoxGeneral.Controls.Add(this.buttonFetch);
            this.groupBoxGeneral.Location = new System.Drawing.Point(242, 146);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(412, 401);
            this.groupBoxGeneral.TabIndex = 89;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "General";
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Location = new System.Drawing.Point(19, 31);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(64, 13);
            this.labelPostStatus.TabIndex = 0;
            this.labelPostStatus.Text = "Post Status:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Location = new System.Drawing.Point(88, 31);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(226, 20);
            this.textBoxStatus.TabIndex = 48;
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetStatus.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonSetStatus.Location = new System.Drawing.Point(320, 29);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonSetStatus.TabIndex = 49;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = false;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // listBoxFetch
            // 
            this.listBoxFetch.FormattingEnabled = true;
            this.listBoxFetch.Location = new System.Drawing.Point(24, 104);
            this.listBoxFetch.Name = "listBoxFetch";
            this.listBoxFetch.Size = new System.Drawing.Size(371, 277);
            this.listBoxFetch.TabIndex = 51;
            // 
            // comboBoxFetch
            // 
            this.comboBoxFetch.FormattingEnabled = true;
            this.comboBoxFetch.Items.AddRange(new object[] {
            "Posts",
            "Checkins",
            "Events",
            "Liked Pages"});
            this.comboBoxFetch.Location = new System.Drawing.Point(88, 70);
            this.comboBoxFetch.Name = "comboBoxFetch";
            this.comboBoxFetch.Size = new System.Drawing.Size(126, 21);
            this.comboBoxFetch.TabIndex = 52;
            this.comboBoxFetch.Text = "Your Choice";
            this.comboBoxFetch.SelectedValueChanged += new System.EventHandler(this.comboBoxFetch_SelectedValueChanged);
            // 
            // labelFetch
            // 
            this.labelFetch.AutoSize = true;
            this.labelFetch.Location = new System.Drawing.Point(21, 73);
            this.labelFetch.Name = "labelFetch";
            this.labelFetch.Size = new System.Drawing.Size(37, 13);
            this.labelFetch.TabIndex = 0;
            this.labelFetch.Text = "Fetch:";
            // 
            // buttonFetch
            // 
            this.buttonFetch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonFetch.Location = new System.Drawing.Point(241, 69);
            this.buttonFetch.Name = "buttonFetch";
            this.buttonFetch.Size = new System.Drawing.Size(154, 23);
            this.buttonFetch.TabIndex = 54;
            this.buttonFetch.Text = "Fetch";
            this.buttonFetch.UseVisualStyleBackColor = false;
            this.buttonFetch.Click += new System.EventHandler(this.buttonFetch_Click);
            // 
            // groupBoxAlbumsAndFichers
            // 
            this.groupBoxAlbumsAndFichers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxAlbumsAndFichers.Controls.Add(this.buttonShowMostLikedPhoto);
            this.groupBoxAlbumsAndFichers.Controls.Add(this.buttonAlbumList);
            this.groupBoxAlbumsAndFichers.Controls.Add(this.buttonDownloadAlbum);
            this.groupBoxAlbumsAndFichers.Controls.Add(this.pictureBoxMostLikes);
            this.groupBoxAlbumsAndFichers.Controls.Add(this.labelMostLiked);
            this.groupBoxAlbumsAndFichers.Controls.Add(this.listBoxAlbumList);
            this.groupBoxAlbumsAndFichers.Controls.Add(this.labelAlbumList);
            this.groupBoxAlbumsAndFichers.Location = new System.Drawing.Point(8, 146);
            this.groupBoxAlbumsAndFichers.Name = "groupBoxAlbumsAndFichers";
            this.groupBoxAlbumsAndFichers.Size = new System.Drawing.Size(221, 401);
            this.groupBoxAlbumsAndFichers.TabIndex = 91;
            this.groupBoxAlbumsAndFichers.TabStop = false;
            this.groupBoxAlbumsAndFichers.Text = "Albums And Fichers";
            // 
            // buttonShowMostLikedPhoto
            // 
            this.buttonShowMostLikedPhoto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonShowMostLikedPhoto.Location = new System.Drawing.Point(8, 172);
            this.buttonShowMostLikedPhoto.Name = "buttonShowMostLikedPhoto";
            this.buttonShowMostLikedPhoto.Size = new System.Drawing.Size(135, 23);
            this.buttonShowMostLikedPhoto.TabIndex = 73;
            this.buttonShowMostLikedPhoto.Text = "Show Most Liked Photo";
            this.buttonShowMostLikedPhoto.UseVisualStyleBackColor = false;
            this.buttonShowMostLikedPhoto.Click += new System.EventHandler(this.buttonShowMostLikedPhoto_Click);
            // 
            // buttonAlbumList
            // 
            this.buttonAlbumList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonAlbumList.Location = new System.Drawing.Point(70, 19);
            this.buttonAlbumList.Name = "buttonAlbumList";
            this.buttonAlbumList.Size = new System.Drawing.Size(85, 23);
            this.buttonAlbumList.TabIndex = 55;
            this.buttonAlbumList.Text = "Album List";
            this.buttonAlbumList.UseVisualStyleBackColor = false;
            this.buttonAlbumList.Click += new System.EventHandler(this.buttonAlbumList_Click);
            // 
            // buttonDownloadAlbum
            // 
            this.buttonDownloadAlbum.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDownloadAlbum.Location = new System.Drawing.Point(8, 201);
            this.buttonDownloadAlbum.Name = "buttonDownloadAlbum";
            this.buttonDownloadAlbum.Size = new System.Drawing.Size(135, 23);
            this.buttonDownloadAlbum.TabIndex = 68;
            this.buttonDownloadAlbum.Text = "Download Album";
            this.buttonDownloadAlbum.UseVisualStyleBackColor = false;
            this.buttonDownloadAlbum.Click += new System.EventHandler(this.buttonDownloadAlbum_Click);
            // 
            // pictureBoxMostLikes
            // 
            this.pictureBoxMostLikes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMostLikes.Location = new System.Drawing.Point(8, 266);
            this.pictureBoxMostLikes.Name = "pictureBoxMostLikes";
            this.pictureBoxMostLikes.Size = new System.Drawing.Size(189, 127);
            this.pictureBoxMostLikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostLikes.TabIndex = 56;
            this.pictureBoxMostLikes.TabStop = false;
            // 
            // labelMostLiked
            // 
            this.labelMostLiked.AutoSize = true;
            this.labelMostLiked.Location = new System.Drawing.Point(6, 229);
            this.labelMostLiked.Name = "labelMostLiked";
            this.labelMostLiked.Size = new System.Drawing.Size(35, 13);
            this.labelMostLiked.TabIndex = 0;
            this.labelMostLiked.Text = "label1";
            this.labelMostLiked.Visible = false;
            // 
            // listBoxAlbumList
            // 
            this.listBoxAlbumList.FormattingEnabled = true;
            this.listBoxAlbumList.Location = new System.Drawing.Point(9, 42);
            this.listBoxAlbumList.Name = "listBoxAlbumList";
            this.listBoxAlbumList.Size = new System.Drawing.Size(188, 121);
            this.listBoxAlbumList.TabIndex = 57;
            this.listBoxAlbumList.SelectedValueChanged += new System.EventHandler(this.listBoxAlbumList_SelectedValueChanged);
            // 
            // labelAlbumList
            // 
            this.labelAlbumList.AutoSize = true;
            this.labelAlbumList.Location = new System.Drawing.Point(6, 23);
            this.labelAlbumList.Name = "labelAlbumList";
            this.labelAlbumList.Size = new System.Drawing.Size(58, 13);
            this.labelAlbumList.TabIndex = 0;
            this.labelAlbumList.Text = "Album List:";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxDetails.Controls.Add(religionLabel);
            this.groupBoxDetails.Controls.Add(this.religionLabel1);
            this.groupBoxDetails.Controls.Add(nameLabel2);
            this.groupBoxDetails.Controls.Add(this.CityLabel1);
            this.groupBoxDetails.Controls.Add(birthdayLabel);
            this.groupBoxDetails.Controls.Add(this.birthdayLabel1);
            this.groupBoxDetails.Controls.Add(nameLabel);
            this.groupBoxDetails.Controls.Add(this.nameLabel1);
            this.groupBoxDetails.Controls.Add(this.buttonLogIn);
            this.groupBoxDetails.Controls.Add(this.buttonDisconect);
            this.groupBoxDetails.Controls.Add(this.imageNormalPictureBox);
            this.groupBoxDetails.Location = new System.Drawing.Point(8, 9);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(381, 127);
            this.groupBoxDetails.TabIndex = 92;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // religionLabel1
            // 
            this.religionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Religion", true));
            this.religionLabel1.Location = new System.Drawing.Point(276, 79);
            this.religionLabel1.Name = "religionLabel1";
            this.religionLabel1.Size = new System.Drawing.Size(100, 23);
            this.religionLabel1.TabIndex = 97;
            this.religionLabel1.Text = "label1";
            this.religionLabel1.Visible = false;
            // 
            // CityLabel1
            // 
            this.CityLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Location.Name", true));
            this.CityLabel1.Location = new System.Drawing.Point(266, 60);
            this.CityLabel1.Name = "CityLabel1";
            this.CityLabel1.Size = new System.Drawing.Size(100, 23);
            this.CityLabel1.TabIndex = 96;
            this.CityLabel1.Text = "label1";
            this.CityLabel1.Visible = false;
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(276, 39);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(100, 23);
            this.birthdayLabel1.TabIndex = 95;
            this.birthdayLabel1.Text = "label1";
            this.birthdayLabel1.Visible = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(266, 16);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 94;
            this.nameLabel1.Text = "label1";
            this.nameLabel1.Visible = false;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonLogIn.Location = new System.Drawing.Point(9, 19);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(63, 23);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonDisconect
            // 
            this.buttonDisconect.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDisconect.Enabled = false;
            this.buttonDisconect.Location = new System.Drawing.Point(9, 60);
            this.buttonDisconect.Name = "buttonDisconect";
            this.buttonDisconect.Size = new System.Drawing.Size(63, 23);
            this.buttonDisconect.TabIndex = 5;
            this.buttonDisconect.Text = "Disconect";
            this.buttonDisconect.UseVisualStyleBackColor = false;
            this.buttonDisconect.Click += new System.EventHandler(this.buttonDisconect_Click);
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(82, 16);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(124, 79);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 80;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.userBindingSource;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(661, 556);
            this.Controls.Add(this.groupBoxFriends);
            this.Controls.Add(this.groupBoxGeneral);
            this.Controls.Add(this.groupBoxAlbumsAndFichers);
            this.Controls.Add(this.groupBoxDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AppForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status: Disconected";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.groupBoxFriends.ResumeLayout(false);
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.groupBoxAlbumsAndFichers.ResumeLayout(false);
            this.groupBoxAlbumsAndFichers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikes)).EndInit();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.GroupBox groupBoxFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ComboBox comboBoxFriends;
        private System.Windows.Forms.Button buttonGetFriends;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.ListBox listBoxFetch;
        private System.Windows.Forms.ComboBox comboBoxFetch;
        private System.Windows.Forms.Label labelFetch;
        private System.Windows.Forms.Button buttonFetch;
        private System.Windows.Forms.GroupBox groupBoxAlbumsAndFichers;
        private System.Windows.Forms.Button buttonShowMostLikedPhoto;
        private System.Windows.Forms.Button buttonAlbumList;
        private System.Windows.Forms.Button buttonDownloadAlbum;
        private System.Windows.Forms.PictureBox pictureBoxMostLikes;
        private System.Windows.Forms.Label labelMostLiked;
        private System.Windows.Forms.ListBox listBoxAlbumList;
        private System.Windows.Forms.Label labelAlbumList;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Button buttonDisconect;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private System.Windows.Forms.Label religionLabel1;
        private System.Windows.Forms.Label CityLabel1;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label nameLabel1;
    }
}