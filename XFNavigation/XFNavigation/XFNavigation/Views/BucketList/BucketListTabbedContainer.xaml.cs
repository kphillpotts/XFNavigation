using Xamarin.Forms;
using XFNavigation.Data;

namespace XFNavigation.Views.BucketList
{
    public partial class BucketListTabbedContainer : TabbedPage
    {
        public BucketListTabbedContainer()
        {
            InitializeComponent();
            Title = "Bucket List";

            Children.Add(new NavigationPage(new BucketListPage(BucketCategory.ThingsToDo))
            {
                Title = "To Do",
                Icon = "ThingsToDo.png"
            });

            Children.Add(new NavigationPage(new BucketListPage(BucketCategory.PlacesToGo))
            {
                Title = "To Go",
                Icon = "PlacesToGo.png"
            });

            Children.Add(new NavigationPage(new BucketListPage(BucketCategory.BooksToRead))
            {
                Title = "To Read",
                Icon = "BooksToRead.png"
            });

            Children.Add(new NavigationPage(new BucketListPage(BucketCategory.MoviesToWatch))
            {
                Title = "To See",
                Icon = "MoviesToWatch.png"
            });
        }
    }
}