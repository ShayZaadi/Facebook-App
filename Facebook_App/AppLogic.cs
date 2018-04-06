namespace Facebook_App
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Threading;
    using System.IO;
    using System.Net;
    using FacebookWrapper.ObjectModel;
    using FacebookWrapper;

    public sealed class AppLogic
    {
        public User m_UserLogIn { get; set; }
        public string m_AccessToken { get; set; }
        public LoginResult m_LoginResult { get; set; }
        private static AppLogic s_Instance = null;
        private static object s_LockObj = new object();

        public static AppLogic GetInstance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new AppLogic();
                        }
                    }
                }

                return s_Instance;
            }
        }

        private AppLogic()
        {
        }

        public void LogInAndInitialize()
        {
            m_LoginResult = FacebookService.Login("1736866409657315",
                "public_profile", "public_profile", "user_education_history",
                "user_birthday", "user_actions.video", "user_actions.news",
                "user_actions.music", "user_actions.fitness", "user_actions.books",
                "user_about_me", "user_friends", "publish_actions", "user_events", "user_games_activity",
                "user_hometown", "user_likes", "user_location", "user_managed_groups", "user_photos",
                "user_posts", "user_relationships", "user_relationship_details", "user_religion_politics",
                "user_tagged_places", "user_videos", "user_website", "user_work_history",
                "read_custom_friendlists",
                "read_page_mailboxes",
                "manage_pages", "publish_pages", "publish_actions", "rsvp_event");
            m_AccessToken = m_LoginResult.AccessToken;
            m_UserLogIn = m_LoginResult.LoggedInUser;
        }

        public string ChooseGender(string i_Text)
        {
            if (i_Text == "Female")
            {
                i_Text = "female";
            }
            else if (i_Text == "Male")
            {
                i_Text = "male";
            }

            return i_Text;
        }

        public bool FetchTheChosenFromList(string io_Text)
        {
            bool isHaveValueOrNot = true;
            if (io_Text == "Posts" && m_UserLogIn.Posts.Count() == 0)
            {
                isHaveValueOrNot = false;
            }
            else if (io_Text == "Events" && m_UserLogIn.Events.Count() == 0)
            {
                isHaveValueOrNot = false;
            }
            else if (io_Text == "Liked Pages" && m_UserLogIn.LikedPages.Count() == 0)
            {
                isHaveValueOrNot = false;
            }
            else if (io_Text == "Checkins" && m_UserLogIn.Checkins.Count() == 0)
            {
                isHaveValueOrNot = false;
            }

            return isHaveValueOrNot;
        }

        public void SaveAlbumPictures(string i_Text)
        {
            string msg = null;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            WebClient webClient = new WebClient();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            Album albumToSave = new Album();
            foreach (Album album in m_UserLogIn.Albums)
            {
                if (album.Name == i_Text)
                {
                    albumToSave = album;
                }
            }

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                        foreach (Photo photo in albumToSave.Photos)
                        {
                            msg = string.Format("{0}\\{1}.jpg", folderBrowserDialog.SelectedPath, photo.Id);
                            saveFileDialog.FileName = msg;
                            webClient.DownloadFile(photo.PictureNormalURL, saveFileDialog.FileName);                           
                }
            }
        }
        
        public string NotUpdatedField()
        {
            return "Not Updated Filed";
        }

        public string ComboBoxFriendChoice(string i_comboBoxFriends)
        {
            if (i_comboBoxFriends == "All Friends")
            {
                i_comboBoxFriends = "Friends";
            }

            return i_comboBoxFriends;
        }

        public Album UserAlbumChoosen(string i_AlbumName)
        {
            Album tempAlbumValue = new Album();
            foreach (Album album in m_UserLogIn.Albums)
            {
                if (i_AlbumName == album.Name)
                {
                    tempAlbumValue = album;
                }
            }

            return tempAlbumValue;
        }

        public Photo fetchTheMostLikedPhoto(string i_AlbumName)
        {
            Album tempAlbumValue = new Album();
            Photo mostLikedPhoto = new Photo();
            int maxLikes = 0;
            mostLikedPhoto = null;

            tempAlbumValue = UserAlbumChoosen(i_AlbumName);
            if (tempAlbumValue.Photos.Count != 0)
            {
                foreach (Photo photo in tempAlbumValue.Photos)
                {
                    if (photo.LikedBy.Count() > maxLikes)
                    {
                        maxLikes = photo.LikedBy.Count();
                        mostLikedPhoto = photo;
                    }
                }
            }

            return mostLikedPhoto;
        }
    }
}
