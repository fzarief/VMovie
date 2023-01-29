using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMovie
{
    public class MovieList
    {
        private List<Movie> movies = new List<Movie>();

        public int Count { get { return movies.Count; } }

        public void AddMovie()
        {
            while (true)
            {
                Console.Write("Masukan Id Movie: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Masukan Judul Movie: ");
                string title = Console.ReadLine();
                Console.Write("Masukan movie rating: ");
                decimal rating = decimal.Parse(Console.ReadLine());
                Movie movie = new Movie(id, title, rating);
                movies.Add(movie);
                Console.Write("Mau input movie lagi? (Y/N) ");
                string choice = Console.ReadLine();
                if (choice.ToUpper() == "N")
                {
                    break;
                }
            }
            while (true)
            {
                Console.Write("Mau memvote movie (Y/N) ");
                string choice = Console.ReadLine();
                if (choice.ToUpper() == "N")
                {
                    break;
                }
                Console.WriteLine("Pilih Id movie yang mau di vote: ");
                int id = int.Parse(Console.ReadLine());
                Movie movie = movies.Find(m => m.Id == id);
                if (movie == null)
                {
                    Console.WriteLine("Id Invalid masukan id yang benar");
                    continue;
                }
                movie.Rating += 0.1m;
            }
        }

        public void ListMovies()
        {
            foreach (Movie movie in movies)
            {
                Console.WriteLine("Id: {0}, Title: {1}, Rating: {2}", movie.Id, movie.Title, movie.Rating);
            }
        }
    }
}
