using System.Collections.Generic;
using System.Collections.ObjectModel;
using XFNavigation.Views.BucketList;
using XFNavigation.Views.MasterDetail;

namespace XFNavigation.Data
{
    public static class MenuListData
    {
        public static ObservableCollection<MenuItem> MenuListItems { get; private set; }

        static MenuListData ()
        {
            MenuListItems = new ObservableCollection<MenuItem>();

            MenuListItems.Add (new MenuItem () { 
                Title = "Things", 
                IconSource = "Lead.png", 
                TargetType = typeof(BucketListPage),
                Category = BucketCategory.ThingsToDo
            });

            MenuListItems.Add (new MenuItem () { 
                Title = "Places", 
                IconSource = "Accounts.png", 
                TargetType = typeof(BucketListPage),
                Category = BucketCategory.PlacesToVisit
            });

            MenuListItems.Add (new MenuItem () { 
                Title = "Books", 
                IconSource = "Accounts.png", 
                TargetType = typeof(BucketListPage),
                Category = BucketCategory.BooksToRead
            });

            MenuListItems.Add (new MenuItem () {
                Title = "Movies",
                IconSource = "Opportunity.png",
                TargetType = typeof(BucketListPage),
                Category = BucketCategory.MoviesToSee
            });
        }
    }
}

