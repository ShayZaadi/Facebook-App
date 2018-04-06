using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Facebook_App
{
    public partial class AppForm : Form
    {
        public AppLogic m_Logic { get; set; }
        public List<string> m_Friends { get; set; }
        public FetchItems m_Fetches { get; set; }
        public List<string> m_FetchThis = new List<string>();

        public AppForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
            m_Logic = AppLogic.GetInstance;
        }       

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_Logic.m_AccessToken == null)
                {
                    m_Logic.LogInAndInitialize();
                }

                userBindingSource.DataSource = m_Logic.m_UserLogIn;
                UpdateDataAfterLogin();
                this.Text = "Status: Connected";
            }
            catch (Exception)
            {
                MessageBox.Show(m_Logic.m_LoginResult.ErrorMessage);
            }
        }

        private void UpdateDataAfterLogin()
        {
            nameLabel1.Visible = true;
            birthdayLabel1.Visible = true;
            CityLabel1.Visible = true;
            religionLabel1.Visible = true;
            imageNormalPictureBox.Visible = true;
            buttonDisconect.Enabled = true;
        }

        private void buttonDisconect_Click(object sender, EventArgs e)
        {
            try
            {
                disconnect();
            }
            catch (Exception)
            {
                MessageBox.Show("First You need to log in");
            }
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            try
            {
                string messageStatusPostedOrNot = postStatus(textBoxStatus.Text);
                MessageBox.Show(messageStatusPostedOrNot);
            }
            catch (Exception)
            {
                MessageBox.Show("First You need to log in");
            }
        }

        private void buttonGetFriends_Click(object sender, EventArgs e)
        {
            listBoxFriends.Items.Clear();
            new Thread(fetchFriends).Start();           
        }

        private void buttonFetch_Click(object sender, EventArgs e)
        {
            new Thread(fetchMyChoice).Start();            
        }

        private void buttonAlbumList_Click(object sender, EventArgs e)
        {
            new Thread(fetchListAlbums).Start();
        }

        private void buttonShowMostLikedPhoto_Click(object sender, EventArgs e)
        {
            new Thread(showMostLikedPhoto).Start();            
        }

        private void buttonDownloadAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                int counter = 0;
                object selectedItem = null;
                string selectedAlbum = null;
                listBoxAlbumList.Invoke(new MethodInvoker(delegate() { counter = listBoxAlbumList.Items.Count; }));
                if (counter != 0 && selectedItem != string.Empty)
                {
                    listBoxAlbumList.Invoke(new MethodInvoker(delegate() { selectedAlbum = listBoxAlbumList.SelectedItem.ToString(); }));
                    m_Logic.SaveAlbumPictures(selectedAlbum);
                }
                else
                {
                    MessageBox.Show("You need to choose an album first");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("First You need to log in");
            }
        }

        private void comboBoxFetch_SelectedValueChanged(object sender, EventArgs e)
        {
            buttonFetch.Text = "Fetch " + comboBoxFetch.Text.ToString();
        }

        private void listBoxAlbumList_SelectedValueChanged(object sender, EventArgs e)
        {
            pictureBoxMostLikes.Image = null;
            labelMostLiked.Visible = true;
            labelMostLiked.Text = string.Empty;
        }

        private void AppForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (m_Logic.m_AccessToken != null)
            {
                disconnect();
            }
        }
        
        private void noValueMessage()
        {
            MessageBox.Show("No value to retrieve :(");
        }

        private void disconnect()
        {
            pictureBoxMostLikes.Image = null;
            comboBoxFriends.Text = "All Friends";
            comboBoxFetch.Text = "Your Choice";
            listBoxFriends.Items.Clear();
            listBoxAlbumList.Items.Clear();
            listBoxFetch.Items.Clear();
            textBoxStatus.Clear();
            nameLabel1.Visible = false;
            birthdayLabel1.Visible = false;
            CityLabel1.Visible = false;
            religionLabel1.Visible = false;
            buttonDisconect.Enabled = false;
            imageNormalPictureBox.Visible = false;
            this.Text = "Status: Disconnected";
            buttonDisconect.Enabled = false;
            FacebookService.Logout(null);
            m_Logic.m_AccessToken = null;
            m_Logic.m_LoginResult = null;
            m_Logic.m_UserLogIn = null;
        }

        private void fetchFriends()
        {
            try
            {
                string myChoice = null;
                comboBoxFriends.Invoke(new MethodInvoker(delegate() { myChoice = comboBoxFriends.Text; }));
                myChoice = m_Logic.ChooseGender(myChoice);
                foreach (User friend in m_Logic.m_UserLogIn.Friends)
                {
                    if (friend.Gender.Value.ToString() == myChoice || myChoice == "All Friends")
                    {
                        listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend.Name)));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("First You need to log in");
            }
        }

        private void fetchListAlbums()
        {
            try
            {
                if (listBoxAlbumList.Items.Count == 0)
                {
                    foreach (Album album in m_Logic.m_UserLogIn.Albums)
                    {
                        listBoxAlbumList.Invoke(new Action(() => listBoxAlbumList.Items.Add(album.Name)));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("First You need to log in");
            }
        }

        private void showMostLikedPhoto()
        {
            try
            {
                int counter = 0;
                object selectedItem = null;
                string selectedItemOnlistBoxAlbumList = null;
                listBoxAlbumList.Invoke(new MethodInvoker(delegate() { counter = listBoxAlbumList.Items.Count; }));
                listBoxAlbumList.Invoke(new MethodInvoker(delegate() { selectedItem = listBoxAlbumList.SelectedItem; }));
                if (counter != 0 && selectedItem != null)
                {
                    Photo mostLikedPhoto = new Photo();
                    listBoxAlbumList.Invoke(new MethodInvoker(delegate() { selectedItemOnlistBoxAlbumList = listBoxAlbumList.SelectedItem.ToString(); }));

                    pictureBoxMostLikes.Image = null;
                    labelMostLiked.Invoke(new MethodInvoker(delegate() { labelMostLiked.Visible = false; }));
                    labelMostLiked.Text = string.Empty;

                    mostLikedPhoto = m_Logic.fetchTheMostLikedPhoto(selectedItemOnlistBoxAlbumList);
                    if (mostLikedPhoto != null)
                    {
                        if (mostLikedPhoto.LikedBy.Count() != 0)
                        {
                            pictureBoxMostLikes.LoadAsync(mostLikedPhoto.PictureNormalURL);
                            labelMostLiked.Invoke(new MethodInvoker(delegate() { labelMostLiked.Visible = true; }));
                            labelMostLiked.Invoke(new MethodInvoker(delegate()
                            {
                                labelMostLiked.Text = string.Format(@"This is the most liked picture 
in {0} album", mostLikedPhoto.Album.Name.ToString());
                            }));
                        }
                        else
                        {
                            MessageBox.Show("There is'nt a most liked photo in this album");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No photos in this album");
                    }
                }
                else
                {
                    MessageBox.Show("You need to choose an album first");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("First You need to log in");
            }
        }

        private void fetchMyChoice()
        {
            try
            {
                string txtComboFetch = null;
                string txtButtonFetch = null;
                listBoxFetch.Invoke(new Action(() => listBoxFetch.Items.Clear()));
                comboBoxFetch.Invoke(new MethodInvoker(delegate() { txtComboFetch = comboBoxFetch.Text; }));
                if (txtComboFetch == "Your Choice" && m_Logic.m_AccessToken != null)
                {
                    MessageBox.Show("You didn't choose anyting to fetch");
                }
                else
                {
                    buttonFetch.Invoke(new MethodInvoker(delegate() { txtButtonFetch = buttonFetch.Text; }));
                    fetchYourChoice(txtComboFetch, txtButtonFetch);

                    foreach (string item in m_FetchThis)
                    {
                        listBoxFetch.Invoke(new Action(() => listBoxFetch.Items.Add(item)));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("First You need to log in");
            }
        }

        public string postStatus(string i_postThisStatus)
        {
            string ThisMassage;
            if (m_Logic.m_UserLogIn == null)
            {
                ThisMassage = "First You need to log in";
            }
            else if (i_postThisStatus == string.Empty)
            {
                ThisMassage = "The post is empty";
            }
            else
            {
                Status postedStatus = m_Logic.m_UserLogIn.PostStatus(i_postThisStatus);
                ThisMassage = "Status Posted! ID: " + postedStatus.Id;
            }

            return ThisMassage;
        }

        public void fetchYourChoice(string i_comboBoxFetch, string i_buttonFetch)
        {
            m_Fetches = FetchItems.Instance;

            if (m_Logic.FetchTheChosenFromList(i_buttonFetch))
            {
                if (i_comboBoxFetch == "Posts")
                {
                    m_FetchThis = m_Fetches.m_Post;
                }
                else if (i_comboBoxFetch == "Liked Pages")
                {
                    m_FetchThis = m_Fetches.m_Page;
                }
                else if (i_comboBoxFetch == "Events")
                {
                    m_FetchThis = m_Fetches.m_Events;
                }
                else
                {
                    m_FetchThis = m_Fetches.m_Checkin;
                }
            }
        }
    }
}
