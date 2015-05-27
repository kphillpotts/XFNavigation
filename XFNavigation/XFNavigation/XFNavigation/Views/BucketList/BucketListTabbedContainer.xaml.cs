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


            Children.Add( new NavigationPage(new BucketListPage(BucketCategory.ThingsToDo))
                {
                    Title = "To Do", 
                    Icon="ToDo.png"
                });

            Children.Add(new NavigationPage(new BucketListPage(BucketCategory.PlacesToVisit))
            {
                Title = "To Visit",
                Icon = "ToGo.png"
            });

            Children.Add(new NavigationPage(new BucketListPage(BucketCategory.BooksToRead))
            {
                Title = "To Read",
                Icon = "ToRead.png"
            });

            Children.Add(new NavigationPage(new BucketListPage(BucketCategory.MoviesToSee))
            {
                Title = "To See",
                Icon = "ToWatch.png"
            });
        }
    }
}