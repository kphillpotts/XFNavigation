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
                Title = "Things To Do", 
                IconSource = "ThingsToDo.png", 
                TargetType = typeof(BucketListPage),
                Category = BucketCategory.ThingsToDo
            });

            MenuListItems.Add (new MenuItem () { 
                Title = "Places To Go", 
                IconSource = "PlacesToGo.png", 
                TargetType = typeof(BucketListPage),
                Category = BucketCategory.PlacesToGo
            });

            MenuListItems.Add (new MenuItem () { 
                Title = "Books To Read", 
                IconSource = "BooksToRead.png", 
                TargetType = typeof(BucketListPage),
                Category = BucketCategory.BooksToRead
            });

            MenuListItems.Add (new MenuItem () {
                Title = "Movies To Watch",
                IconSource = "MoviesToWatch.png",
                TargetType = typeof(BucketListPage),
                Category = BucketCategory.MoviesToWatch
            });
        }
    }
}

