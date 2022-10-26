using MovieDB_EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB_EF
{
    public class Display
    {
        public MovieDBContext mdbc { get; set; } = new MovieDBContext();



        public void Menu()
        {
            Console.WriteLine("Moviefone Whodis?");
            Console.WriteLine("Search by \"Genre\" or \"Title\":");
            string input = Console.ReadLine();


        }

    }
}
