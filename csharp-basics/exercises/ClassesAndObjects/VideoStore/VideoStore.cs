using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class VideoStore
    {
        private readonly Dictionary<string, Video> _inventory = new Dictionary<string, Video>();

        public void AddVideo(string title)
        {
            _inventory.Add(title, new Video(title));
        }
        
        public void Checkout(string title)
        {
            _inventory[title].BeingCheckedOut();
        }

        public void ReturnVideo(string title)
        {
            _inventory[title].BeingReturned();
        }

        public void TakeUsersRating(double rating, string title)
        {
            _inventory[title].ReceivingRating(rating);
        }

        public List<Video> ListInventory()
        {
            return _inventory.Values.ToList();
        }
    }
}
