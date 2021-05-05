using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Movies
{
    class Movie
    {
        private string movieTitle;
        private string category;

        public string MovieTitle
        {
            get
            {
                return movieTitle;
            }
            set
            {
                movieTitle = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public Movie()
        {

        }

        public Movie(string _movieTitle, string _category)
        {
            movieTitle = _movieTitle;
            category = _category;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"The {category} movies are: {movieTitle} \n {movieTitle} \n {movieTitle}");
        }
    }
}
   