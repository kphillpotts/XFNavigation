using System;
using Xamarin.Forms;
using XFNavigation.Views.BucketList;
using MenuItem = XFNavigation.Data.MenuItem;

namespace XFNavigation.Views.MasterDetail.FunctionalMasterDetail
{
    public class MasterDetailRoot : MasterDetailPage
    {
        public MasterDetailRoot()
        {
            var menuPage = new MenuPage ();

            menuPage.Menu.ItemSelected += (sender, e) => NavigateTo (e.SelectedItem as MenuItem);

            Master = menuPage;
            Detail = new NavigationPage (new BucketListPage ());
        }

        void NavigateTo (MenuItem menu)
        {
            Page displayPage;
            var t = typeof(BucketListPage);
            if (menu.TargetType == t)
            {
                var category = menu.Category;
                if (category == null)
                {
                    displayPage = new BucketListPage();
                }
                else
                    displayPage = new BucketListPage(category);
            }
            else
            {
                displayPage = (Page)Activator.CreateInstance(menu.TargetType);
            }



//            if (menu.TargetType is typeof(BucketListPage))
//            {
//                var category = menu.Category;
//                Page = new BucketListPage
//            };
//            Page displayPage = (Page)Activator.CreateInstance (menu.TargetType);

            Detail = new NavigationPage (displayPage);

            IsPresented = false;
        }
    }
}


