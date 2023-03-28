using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Create a list of video game names...
            Order the list of games by length of the game name.
            Use the lambda expression in this exercise as well.
            use Method Syntax for this exercise*/

            var movieList = new List<string>
            { "First Wives Club",
                "Birdcage",
                "Mrs.Doubtfire",
                "My Cousin Vinny"
            };

            var sortedMovies = movieList.OrderBy(movie => movie.Length);

            foreach (var movie in sortedMovies)
            {
                Console.WriteLine(movie);
            }

        }
    }
}
