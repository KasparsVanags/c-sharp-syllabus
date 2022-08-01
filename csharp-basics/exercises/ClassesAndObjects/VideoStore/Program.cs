using System;

namespace VideoStore
{
    class VideoStoreTest
    {
        private const int CountOfMovies = 3;
        private static VideoStore _videoStore = new VideoStore();
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to rate video (as user)");
                Console.WriteLine("Choose 5 to list inventory");

                int n = Convert.ToByte(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        RateVideo();
                        break;
                    case 5:
                        ListInventory();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void ListInventory()
        {
            foreach (var video in _videoStore.ListInventory())
            {
                Console.WriteLine(video);
            }
        }

        private static void FillVideoStore()
        {
            for (var i = 0; i < CountOfMovies; i++)
            {
                Console.WriteLine("Enter movie name:");
                string movieName = Console.ReadLine();

                Console.WriteLine("Enter rating 1-10:");
                int rating = Convert.ToInt16(Console.ReadLine());

                _videoStore.AddVideo(movieName);
                _videoStore.TakeUsersRating(rating, movieName);
            }
        }

        private static void RentVideo()
        {
            string movieName = GetName();
            _videoStore.Checkout(movieName);
        }

        private static void ReturnVideo()
        {
            string movieName = GetName();
            _videoStore.ReturnVideo(movieName);
        }

        private static void RateVideo()
        {
            string movieName = GetName();
            Console.WriteLine("Enter your rating 1 - 10");
            double rating = double.Parse(Console.ReadLine());
            _videoStore.TakeUsersRating(rating, movieName);
        }

        static string GetName()
        {
            Console.WriteLine("Enter movie name:");
            return Console.ReadLine();
        }
    }
}
