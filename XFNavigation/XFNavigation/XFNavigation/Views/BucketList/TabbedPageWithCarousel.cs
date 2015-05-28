using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFNavigation.Data;

namespace XFNavigation.Views.BucketList
{


    public class TabbedPageWithCarousel   : TabbedPage
    {
        public TabbedPageWithCarousel()
        {


            foreach (var menuListItem in MenuListData.MenuListItems)
            {
                // construct carousel page for each item in group
                var carousel = new CarouselPage();
                carousel.Title = menuListItem.Category.ToString();
                carousel.Icon = menuListItem.IconSource;

                // get the pages for the category
                var item = menuListItem;
                var items = BucketFactory.BucketList.Where(c => c.Category == item.Category);

                foreach (var bucketItem in items)
                {
                    carousel.Children.Add(new BucketItemDetail(bucketItem));
                }

                // create a tab and add the carousel
                Children.Add(carousel);
            }

        }

    }
}
