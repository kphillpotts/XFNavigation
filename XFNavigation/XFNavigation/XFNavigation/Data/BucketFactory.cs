using System.Collections.ObjectModel;

namespace XFNavigation.Data
{
    public static class BucketFactory
    {
        static BucketFactory()
        {
            BucketList = new ObservableCollection<BucketItem>
            {
                new BucketItem
                {
                    Name = "Dinner with David Attenborough",
                    BucketImageUrl = "David.png",
                    Description = "Because he is awesome",
                    Category = BucketCategory.ThingsToDo,
                    Done = false
                },
                new BucketItem
                {
                    Name = "Go Bungy Jumping",
                    BucketImageUrl = "BungyJumping.png",
                    Description = "Because gravity sucks!",
                    Category = BucketCategory.ThingsToDo,
                    Done = false
                },
                new BucketItem
                {
                    Name = "Visit Japan",
                    BucketImageUrl = "Japan.png",
                    Description = "If it's good enough for Godzilla",
                    Category = BucketCategory.PlacesToGo,
                    Done = false
                },
                new BucketItem
                {
                    Name = "Visit the Moon",
                    BucketImageUrl = "moon.png",
                    Description = "I'm a rocket man",
                    Category = BucketCategory.PlacesToGo,
                    Done = false
                }          ,
                new BucketItem
                {
                    Name = "Code Complete",
                    BucketImageUrl = "CodeComplete.png",
                    Description = "Everyone needs to read this",
                    Category = BucketCategory.BooksToRead,
                    Done = false
                },
  
                new BucketItem
                {
                    Name = "Feelings and how to destroy them",
                    BucketImageUrl = "Feelings.png",
                    Description = "Why not",
                    Category = BucketCategory.BooksToRead,
                    Done = false
                },
                new BucketItem
                {
                    Name = "Finding Emo",
                    BucketImageUrl = "FindingEmo.png",
                    Description = "A modern tale",
                    Category = BucketCategory.MoviesToWatch,
                    Done = false
                },
                new BucketItem
                {
                    Name = "Great Wall of China",
                    BucketImageUrl = "GreatWallOfChina.png",
                    Description = "Because you can see it from the moon",
                    Category = BucketCategory.PlacesToGo,
                    Done = false
                },
                new BucketItem
                {
                    Name = "Jet Boarding",
                    BucketImageUrl = "JetBoarding.png",
                    Description = "The right amount of crazy",
                    Category = BucketCategory.ThingsToDo,
                    Done = false
                },
                new BucketItem
                {
                    Name = "Mad Max Road Warrior",
                    BucketImageUrl = "MadMax.png",
                    Description = "What a trip!",
                    Category = BucketCategory.MoviesToWatch,
                    Done = true
                },
                new BucketItem
                {
                    Name = "My First Cavity Search",
                    BucketImageUrl = "MyFirstCavitySearch.png",
                    Description = "Welcome to the new world",
                    Category = BucketCategory.BooksToRead,
                    Done = true
                },
               new BucketItem
                {
                    Name = "Creating Mobile Apps with Xamarin.Forms",
                    BucketImageUrl = "Petzold.png",
                    Description = "Petzold is a legend.",
                    Category = BucketCategory.BooksToRead,
                    Done = true
                },
   
                             new BucketItem
                {
                    Name = "Star Wars - the new one",
                    BucketImageUrl = "StarWars.png",
                    Description = "Plesae be good.",
                    Category = BucketCategory.MoviesToWatch,
                    Done = true
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

        public static ObservableCollection<BucketItem> BucketList { get; private set; }
    }
}