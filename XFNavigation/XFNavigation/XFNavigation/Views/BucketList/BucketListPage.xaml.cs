using System;
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
            //items = BucketFactory.BucketList;
            BindingContext = BucketFactory.BucketList;
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();


        }

        public BucketListPage(BucketCategory category)
        {
            InitializeComponent();

            this.Title = "By Category";
            //items = BucketFactory.BucketList.Where(c => c.Category == category);

            BindingContext = BucketFactory.BucketList.Where(c => c.Category == category);
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

