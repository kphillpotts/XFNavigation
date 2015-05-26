using System.Collections.ObjectModel;

namespace XFNavigation.Data
{
    public static class BucketFactory
    {
        
        public static ObservableCollection<BucketItem> BucketList { get; private set; }

        static BucketFactory()
        {
            BucketList = new ObservableCollection<BucketItem>
            {
                new BucketItem
                {
                    Name = "Dinner with David Attenborough",
                    BucketImageUrl = "David.png",
                    Description = "Dinner with David Attenborough",
                    Category = BucketCategory.ThingsToDo,
                    Done = false
                },
                new BucketItem
                {
                    Name = "Visit the Moon",
                    BucketImageUrl = "moon.png",
                    Description = "Just like Tin-Tin did",
                    Category = BucketCategory.PlacesToVisit,
                    Done = false
                }
            };

//            BucketList = new ObservableCollection<BucketItem> {
//                new BucketItem {
//                    
//                    Name = "Homer Simpson", 
//                    HeadshotUrl = "Homer.gif", 
//                    Email = "donutlover@aol.com", 
//                    Dob = new DateTime(1965, 1, 24),
//                    Gender = Gender.Male,
//                    IsFavorite = false,
//                },
//            }
        }
    }
}

