using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using XFNavigation.Data;
using MenuItem = XFNavigation.Data.MenuItem;

namespace XFNavigation.Views.MasterDetail.FunctionalMasterDetail
{
    public class MenuListView : ListView
    {
        public MenuListView ()
        {
            List<MenuItem> data = MenuListData.MenuListItems.ToList();

            ItemsSource = data;
            VerticalOptions = LayoutOptions.FillAndExpand;
            BackgroundColor = Color.Transparent;

            var cell = new DataTemplate (typeof(ImageCell));
            cell.SetBinding (TextCell.TextProperty, "Title");
            cell.SetBinding (ImageCell.ImageSourceProperty, "IconSource");

            ItemTemplate = cell;
        }
    }
}

