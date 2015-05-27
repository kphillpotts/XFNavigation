using Xamarin.Forms;
using XFNavigation.Data;

namespace XFNavigation.Views.BucketList
{
    public class BucketCarouselContainer : CarouselPage 
    {
        public BucketCarouselContainer()
        {
            foreach (var buckteItem in BucketFactory.BucketList)
            {
                Children.Add(new BucketItemDetail(buckteItem));    
            }
        }
    }
}


