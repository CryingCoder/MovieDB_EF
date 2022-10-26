using System;
using System.Collections.Generic;

namespace MovieDB_EF.Model
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public double? Runtime { get; set; }
        public MovieDBContext db { get; set; } = new MovieDBContext();


        public static void SearchByGenre(List<Movie> genre)
        {
            MovieDBContext db = new MovieDBContext();
            foreach (Movie movie in genre)
            {
                Console.WriteLine($"{movie.Genre} : {movie.Title}");
            }
        }

        public static void SearchByTitle(List<Movie> title)
        {
            MovieDBContext db = new MovieDBContext();
            foreach (Movie movie in title)
            {
                Console.WriteLine($"{movie.Title} : {movie.Genre}");
            }
        }


        //I wrote this after writing the original in the Movie class because I thought this may make calling it from Program easier, but it didn't.
        /*public List<Movie> SearchByGenre(List<Movie> genre)
        {
            var gtl = db.Movies.Select(g => g.Genre).ToList();
            Console.WriteLine(gtl);

            return genre;
        }

        public List<Movie> SearchByTitle(List<Movie> title)
        {
            var ttl = db.Movies.Select(t => t.Title).ToList();
            Console.WriteLine(ttl);

            return title;
        }*/
    }
}
