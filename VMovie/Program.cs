namespace VMovie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieList movieList = new MovieList();
            while (true)
            {
                Console.WriteLine("1. Daftar-daftar Movie ");
                Console.WriteLine("2. Tambahkan Movie ");
                Console.WriteLine("3. Exit");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    if (movieList.Count == 0)
                    {
                        Console.WriteLine("Tidak ditemukan movie, mohon daftarkan dahulu");
                    }
                    else
                    {
                        movieList.ListMovies();
                    }
                }
                else if (choice == 2)
                {
                    movieList.AddMovie();
                }
                else if (choice == 3)
                {
                    break;
                }
            }

        }
    }
}