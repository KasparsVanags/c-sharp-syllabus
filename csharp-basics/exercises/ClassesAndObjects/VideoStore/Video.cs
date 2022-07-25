using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        public Video(string title)
        {
            
        }

        public void BeingCheckedOut()
        {
            
        }

        public void BeingReturned()
        {
            
        }

        public void ReceivingRating(double rating)
        {
            
        }

        public double AverageRating()
        {
            return 0;
        }

        public bool Available()
        {
            return true;
        }

        public string Title => "";

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
