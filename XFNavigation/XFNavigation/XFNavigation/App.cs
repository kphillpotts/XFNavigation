﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XFNavigation.Data;
using XFNavigation.Views.PushPop;

namespace XFNavigation
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new MyPage(1));

            // The root page of your application
          //  MainPage = new Views.BucketItemDetail(BucketFactory.BucketList.First());

            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new Label {
            //                XAlign = TextAlignment.Center,
            //                Text = "Welcome to Forms!"
            //            }
            //        }
            //    }
            //};
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
