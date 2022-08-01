using System;

namespace Exercise4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var casinoRoyale = new Movie("Casino Royale", "Eon Productions", "PG13");
            var glass = new Movie("Glass", "Buena Vista International", "PG13");
            var spiderMan = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures");
            var movies = new Movie[] { casinoRoyale, glass, spiderMan };
            Console.WriteLine("All movies:");
            foreach (var movie in movies)
            {
                movie.PrintInfo();
            }
            Console.WriteLine("PG movies:");
            foreach (var movie in Movie.GetPG(movies))
            {
                movie.PrintInfo();
            }

            Console.ReadKey();
        }
    }
}