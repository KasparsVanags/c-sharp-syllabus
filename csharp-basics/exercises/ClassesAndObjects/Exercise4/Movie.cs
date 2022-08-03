using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    public class Movie
    {
        private readonly string _title;
        private readonly string _studio;
        private readonly string _rating;
        
        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        public static Movie[] GetPG(Movie[] inputArr)
        {
            return inputArr.Where(x => x._rating == "PG").ToArray();
        }
        
        public void PrintInfo()
        {
            Console.WriteLine($"Title: {_title}, studio: {_studio}, rating: {_rating}");
        }
    }
}