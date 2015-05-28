using System.Collections.Generic;
using NavigationPatterns;
using Xamarin.Forms;

namespace XFNavigation.Views.MasterDetail
{
    public class MenuListView : ListView
    {
        public MenuListView ()
        {
            List<MenuItem> data = new MenuListData ();

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

