using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XFNavigation.Data;
using XFNavigation.Views.BucketList;
using XFNavigation.Views.MasterDetail;
using XFNavigation.Views.PushPop;

namespace XFNavigation
{
    public class App : Application
    {
        public App()
        {
            #region Simple Page Navigation Sample
            //MainPage = new NavigationPage(new PushPage(1));
            #endregion

            #region ListViews with Navigation
            //MainPage = new NavigationPage(new BucketListPage());
            #endregion

            #region Tabbed Pages (with navigation)
            //MainPage = new BucketListTabbedContainer();
            #endregion

            #region Carousel Page
            //MainPage = new BucketCarouselContainer();
            #endregion

            #region Master Detail Page
            MainPage = new MasterDetailRoot();
            #endregion;
        }

        void Current_ModalPopping(object sender, ModalPoppingEventArgs e)
        {
            Debug.WriteLine("Page popped {0}", e.Modal.Title);
            //throw new NotImplementedException();
        }

        void navPage_Popped(object sender, NavigationEventArgs e)
        {
            Debug.WriteLine("Page popped {0}", e.Page.Title);
        }

        void navPage_Pushed(object sender, NavigationEventArgs e)
        {
            Debug.WriteLine("Page popped {0}", e.Page.Title);
        }

        void App_ModalPopping(object sender, ModalPoppingEventArgs e)
        {
            
            //throw new NotImplementedException();
        }

        void App_ModalPushing(object sender, ModalPushingEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void App_ModalPushed(object sender, ModalPushedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void App_ModalPopped(object sender, ModalPoppedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
