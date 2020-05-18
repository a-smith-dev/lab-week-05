using System;
using System.Collections.Generic;

namespace Lab_Week_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lab 11.
            var appName = "Movie List Application";
            var movieList = new List<Movie>
                {
                    new Movie("The Emperor's New Groove", $"{Category.animated}"),
                    new Movie("Joker", $"{Category.drama}"),
                    new Movie("See No Evil", $"{Category.horror}"),
                    new Movie("District 9", $"{Category.scifi}"),
                    new Movie("Batman: Mask of the Phantasm", $"{Category.animated}"),
                    new Movie("The Social Network", $"{Category.drama}"),
                    new Movie("Saw", $"{Category.horror}"),
                    new Movie("Chappie", $"{Category.scifi}"),
                    new Movie("Hercules", $"{Category.animated}"),
                    new Movie("The Matrix Reloaded", $"{Category.scifi}")
                };
            Console.WriteLine($"Welcome to the {appName}!\n\n" +
                $"There are {movieList.Count} movies in the list.");
            do
            {
                Console.Write($"\nWhat category are you interested in? Choose from " +
                    $"{Category.animated}, {Category.drama}, {Category.horror}, and {Category.scifi}: ");
                var choice = Validate.CategoryCheck(Console.ReadLine());
                Console.WriteLine($"\nHere are the {choice} movies we have:");
                foreach (var movie in movieList)
                {
                    if (movie.GetCategory() == $"{choice}")
                        Console.WriteLine(movie.GetTitle());
                }
                Console.Write("\nContinue? (y/n): ");
            } while (Validate.YesNo(Console.ReadLine()) == "y");
            Console.WriteLine($"Thank you for using the {appName}!");
        }
    }
}
