using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = MyLinq.Random().Where(n => n > 0.5).Take(10);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            var movies = new List<Movie>
            {
                new Movie {Title = "The Dark Knight", Rating = 8.9f, Year = 2008 },
                new Movie {Title = "The King's Speech", Rating = 8.0f, Year = 2010 },
                new Movie {Title = "Casablanca", Rating = 8.5f, Year = 1942 },
                new Movie {Title = "Star Wars V", Rating = 8.7f, Year = 1980 },
            };

            // var query = Enumerable.Empty<Movie>();
            /*            try // count, tolist de preferat in try

                        {
                            query = movies.Filter(m => m.Year > 2000);//.ToList();
                        }
                        catch (Exception ex)
                        {
                            //query = query.Take(1); // TAKE IS also select 

                            Console.WriteLine(ex.Message);
                        }*/
            // query = movies.Filter(m => m.Year > 2000)//.ToList();
            //  .OrderByDescending(m => m.Rating);
            // Console.WriteLine(query.Count());

            var query = from movie in movies
                        where movie.Year > 2000
                        orderby movie.Rating descending
                        select movie;

            var enumerator = query.GetEnumerator ();
            while(enumerator.MoveNext ())
            {
                Console.WriteLine (enumerator.Current.Title); 
            }

            //var query = movies.Filter(m => m.Year > 2000); 
/*
            foreach (var movie in query)
            {
                Console.WriteLine(movie.Title);
            }*/
        }
    }
}
