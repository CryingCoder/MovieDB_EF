using MovieDB_EF.Model;

namespace MovieDB_EF
{
    public class Program
    {

        

        static void Main(string[] args)
        {
            MovieDBContext db = new MovieDBContext();

            List<Movie> mv = db.Movies.ToList();
            //using Movie.SearchByGenre();//Not sure how to use this syntax here. 
            SearchByMethods.SearchByGenre(mv).ToList();
            SearchByMethods.SearchByTitle(mv).ToList();


            /*using (var context = new MovieDBContext())
            {
                
                Movie mv = new Movie()
                {
                    Title = "Bill & Ted's Excellent Adventure",
                    Genre = "Comedy",
                    Runtime = 90
                };
                Movie mv2 = new Movie()
                {
                    Title = "Die Hard",
                    Genre = "Holiday",
                    Runtime = 132
                };
                Movie mv3 = new Movie()
                {
                    Title = "Coming to America",
                    Genre = "Comedy",
                    Runtime = 117
                };
                Movie mv4 = new Movie()
                {
                    Title = "Robocop",
                    Genre = "Action",
                    Runtime = 102
                };
                Movie mv5 = new Movie()
                {
                    Title = "The Golden Child",
                    Genre = "Action",
                    Runtime = 94
                };
                Movie mv6 = new Movie()
                {
                    Title = "The Last Emperor",
                    Genre = "Biography",
                    Runtime = 163
                };
                Movie mv7 = new Movie()
                {
                    Title = "The Goonies",
                    Genre = "Adventure",
                    Runtime = 114
                };
                Movie mv8 = new Movie()
                {
                    Title = "Moonstruck",
                    Genre = "Romance",
                    Runtime = 102
                };
                Movie mv9 = new Movie()
                {
                    Title = "The Road Warrior",
                    Genre = "Action",
                    Runtime = 96
                };
                context.Movies.Add(mv);
                context.Movies.Add(mv2);
                context.Movies.Add(mv3);
                context.Movies.Add(mv4);
                context.Movies.Add(mv5);
                context.Movies.Add(mv6);
                context.Movies.Add(mv7);
                context.Movies.Add(mv8);
                context.Movies.Add(mv9);
                context.SaveChanges();
                //var stmv = context.Movies.Where(m => m.Title == "Bill & Ted's Excellent Adventure").ToList();
                //Console.WriteLine(stmv.Count);
            }*/
        }
    }
}