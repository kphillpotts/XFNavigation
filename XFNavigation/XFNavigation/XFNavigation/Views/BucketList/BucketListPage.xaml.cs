﻿using System;
using System.Linq;
using Xamarin.Forms;
using XFNavigation.Data;

namespace XFNavigation.Views.BucketList
{
    public partial class BucketListPage : ContentPage
    {
        

        public BucketListPage()
        {
            InitializeComponent();

            this.Title = "All";
            BindingContext = BucketFactory.BucketList;
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();


        }

        public BucketListPage(BucketCategory category)
        {
            InitializeComponent();

            this.Title = GetCategoryTitle(category);

            BindingContext = BucketFactory.BucketList.Where(c => c.Category == category);
        }

        private string GetCategoryTitle(BucketCategory category)
        {
            switch (category)
            {
                case BucketCategory.ThingsToDo:
                    return "Things To Do";
                case BucketCategory.PlacesToGo:
                    return "Places To Go";
                case BucketCategory.BooksToRead:
                    return "Books To Read";
                case BucketCategory.MoviesToWatch:
                    return "Movies To See";
                default:
                    return "By Category";
            }
        }


        async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            BucketItem tappedPerson = (BucketItem)e.Item;
            await this.Navigation.PushAsync(new BucketItemDetail(tappedPerson));
            BucketListView.SelectedItem = null;
        }

        public void OnMore (object sender, EventArgs e) {
            var mi = ((Xamarin.Forms.MenuItem)sender);
            var t = mi.CommandParameter;
            var bucketItem = t as BucketItem;
            BucketFactory.BucketList.Remove(bucketItem);


            //DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }
            
        public void OnDelete (object sender, EventArgs e) {
            var mi = ((Xamarin.Forms.MenuItem)sender);
            var t = mi.CommandParameter;
                //var mi = ((MenuItem)sender);
            //DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");

//            Debug.WriteLine ("delete " + mi.CommandParameter.ToString ());
//            items.Remove (mi.CommandParameter.ToString());
        }

    }
}

