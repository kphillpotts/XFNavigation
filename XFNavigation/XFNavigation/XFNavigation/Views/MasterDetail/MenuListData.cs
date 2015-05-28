using System;
using System.Collections.Generic;
using XFNavigation.Data;
using XFNavigation.Views.BucketList;
using XFNavigation.Views.MasterDetail;

namespace NavigationPatterns
{
    public class MenuListData : List<MenuItem>
    {
        public MenuListData ()
        {
            this.Add (new MenuItem () { 
                Title = "All", 
                IconSource = "contracts.png", 
                TargetType = typeof(BucketListPage)
            });

            this.Add (new MenuItem () { 
                Title = "Things", 
                IconSource = "Lead.png", 
                TargetType = typeof(BucketListPage),
                Category = BucketCategory.ThingsToDo
            });

            this.Add (new MenuItem () { 
                Title = "Places", 
                IconSource = "Accounts.png", 
                TargetType = typeof(BucketListPage),
                Category = BucketCategory.PlacesToVisit
            });

            this.Add (new MenuItem () { 
                Title = "Books", 
                IconSource = "Accounts.png", 
                TargetType = typeof(BucketListPage),
                Category = BucketCategory.BooksToRead
            });

            this.Add (new MenuItem () {
                Title = "Movies",
                IconSource = "Opportunity.png",
                TargetType = typeof(BucketListPage),
                Category = BucketCategory.MoviesToSee
            });
        }
    }
}

