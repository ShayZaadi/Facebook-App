namespace Facebook_App
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using FacebookWrapper.ObjectModel;
    using FacebookWrapper;

    //Singelton class that stores user information
    public class FetchItems
    {
        private static FetchItems s_Instance = null;
        private static object s_LockObj = new object();
        public AppLogic m_Logic { get; set; }
        public List<string> m_Events = new List<string>();
        public List<string> m_Checkin = new List<string>();
        public List<string> m_Page = new List<string>();
        public List<string> m_Post = new List<string>();        

        private FetchItems()
        {
            m_Logic = AppLogic.GetInstance;
            fetchInformation();
        }

        public static FetchItems Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new FetchItems();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public void fetchInformation()
        {
            fetchCheckins();
            fetchPages();
            fetchEvents();
            fetchPosts();
        }

        private void fetchCheckins()
        {
            foreach (Checkin checkin in m_Logic.m_UserLogIn.Checkins)
            {
                m_Checkin.Add(checkin.Place.Name);
            }
        }

        private void fetchPages()
        {
            foreach (Page page in m_Logic.m_UserLogIn.LikedPages)
            {
                m_Page.Add(page.Name);
            }
        }

        private void fetchEvents()
        {
            foreach (Event fbEvent in m_Logic.m_UserLogIn.Events)
            {
                m_Events.Add(fbEvent.Name);
            }
        }

        private void fetchPosts()
        {
            foreach (Post post in m_Logic.m_UserLogIn.Posts)
            {
                if (post.Message != null)
                {
                    m_Post.Add(post.Message);
                }                
            }
        }
    }    
}