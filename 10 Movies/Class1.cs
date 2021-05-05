using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Movies
{
    class Class1
    {
        static void Main(string[] args)
        {

            List<Movie> movies = new List<Movie>
            {
                new Movie("Death Bed: The Bed That Eats", "Horror"),
                new Movie("Bloodthirst Butchers", "Horror"),
                new Movie("A Troll in Central Park", "Animated"),
                new Movie("The Emoji Movie", "Animated"),
                new Movie("The Nut Job", "Animated"),
                new Movie("Tarzan the Ape Man", "Drama"),
                new Movie("Cats", "Drama"),
                new Movie("Santa Claus Conquers the Martians", "SciFi"),
                new Movie("Maximum Overdrive", "SciFi"),
                new Movie("Piranha Part Two: The Spawning", "SciFi"),
            };
            Console.WriteLine("Welcome to the Movie List");

            bool runProgram = true;
            while (runProgram)
            {
                string input = "";
                Console.WriteLine("Please enter a movie category: Horror, Animated, Drama or SciFi");

                while (true)
                {
                    input = Console.ReadLine().Trim().ToLower();
                    if (input == "")
                    {
                        Console.WriteLine("Please enter a category: Horror, Animated, Drama or SciFi");
                    }

                    else
                    {
                        break;
                    }

                }

                foreach (Movie movie in movies)
                {
                    if (movie.Category.Trim().ToLower() == input)
                    {
                        Console.WriteLine(movie.MovieTitle);
                    }
                }

                Console.WriteLine("Do you want to continue? y/n");

                while (true)
                {
                    string choice = Console.ReadLine().Trim().ToLower();
                    if (choice == "y")
                    {
                        break;  
                    }
                    else if (choice == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid input");
                    }
                }
            }

        }
    }
}
