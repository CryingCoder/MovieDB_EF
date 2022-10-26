using MovieDB_EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB_EF
{
    
    public class SearchByMethods
    {
        
        /*//Made this class to see if I could call from Main.
        public static void SearchByGenre(List<Movie> genre)
        {
            foreach (Movie movie in genre)
            {
                Console.WriteLine($"{movie.Genre} : {movie.Title}");
            }
        }

        public static void SearchByTitle(List<Movie> title)
        {
            foreach (Movie movie in title)
            {
                Console.WriteLine($"{movie.Title} : {movie.Genre}");
            }
        }*/
        public static List<Movie> SearchByGenre(List<Movie> genre)
        {
            MovieDBContext db = new MovieDBContext();
            var gtl = db.Movies.Select(g => g.Genre).ToList();
            Console.WriteLine(gtl);

            return genre;
        }

        public static List<Movie> SearchByTitle(List<Movie> title)
        {
            MovieDBContext db = new MovieDBContext();
            var ttl = db.Movies.Select(t => t.Title).ToList();
            Console.WriteLine(ttl);

            return title;
        }
    }
}
