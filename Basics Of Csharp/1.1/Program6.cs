using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    internal class Program6
    {
        public static void RunProgram()
        {
            Console.WriteLine("Enter your favorite movies, one per line. Type 'done' to finish:");
            var movies = new List<string>();
            string movie;
            while ((movie = Console.ReadLine()) != "done")
            {
                movies.Add(movie);
            }

            string filePath = "FavoriteMovies.txt";
            File.WriteAllLines(filePath, movies);
            Console.WriteLine($"Saved to {filePath}.");

            string[] savedMovies = File.ReadAllLines(filePath);
            Console.WriteLine("Your Favourite movies are");
            foreach (string savedMovie in savedMovies)
            {
                Console.WriteLine(savedMovie.ToUpper());
            }
        }
    }
}
