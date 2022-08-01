using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private readonly string _title;
        private bool _checkedOut;
        private readonly List<double> _ratingList = new List<double>();
        public Video(string title)
        {
            _title = title;
        }

        public void BeingCheckedOut()
        {
            _checkedOut = true;
        }

        public void BeingReturned()
        {
            _checkedOut = false;
        }

        public void ReceivingRating(double rating)
        {
            _ratingList.Add(rating);
        }

        private double AverageRating()
        {
            return Math.Round(_ratingList.Average(), 2);
        }

        private string Available()
        {
            if (_checkedOut)
            {
                return "unavailable";
            }

            return "available";
        }

        public override string ToString()
        {
            return $"Title: {_title}, average rating: {AverageRating()}, status: {Available()}";
        }
    }
}
