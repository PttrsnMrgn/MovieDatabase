using MovieDatabase;

Movie movie1 = new Movie("TOP GUN", "ACTION");
Movie movie2 = new Movie("ROCKY", "ACTION");
Movie movie3 = new Movie("TERMINATOR", "ACTION");
Movie movie4 = new Movie("JOHN WICK", "ACTION");
Movie movie5 = new Movie("THE GODFATHER", "DRAMA");
Movie movie6 = new Movie("GOOD WILL HUNTING", "DRAMA");
Movie movie7 = new Movie("SEVEN POUNDS", "DRAMA");
Movie movie8 = new Movie("CASABLANCA", "ROMANCE");
Movie movie9 = new Movie("TITANIC", "ROMANCE");
Movie movie10 = new Movie("DIRTY DANCING", "ROMANCE");

List<Movie> movieList = new List<Movie>();

movieList.Add(movie1);
movieList.Add(movie2);
movieList.Add(movie3);
movieList.Add(movie4);
movieList.Add(movie5);
movieList.Add(movie6);
movieList.Add(movie7);
movieList.Add(movie8);
movieList.Add(movie9);
movieList.Add(movie10);

string restart;
do
{
    List<Movie> actionMovies = new List<Movie>();
    List<Movie> dramaMovies = new List<Movie>();
    List<Movie> romanceMovies = new List<Movie>();

    Console.Clear();
    Console.WriteLine("PLEASE SELECT A CATEGORY OF MOVIE YOU'D LIKE TO WATCH:" +
                      "\nACTION - DRAMA - ROMANCE?");
    string input = Console.ReadLine().ToUpper();

    if (input == "ACTION" || input == "DRAMA" || input == "ROMANCE")
    {
        if (input == "ACTION")
        {
            Console.WriteLine("\nSOME MOVIES YOU'D LIKE:");

            foreach (Movie m in movieList)
            {
                if (m.Category.Contains("ACTION"))
                {
                    actionMovies.Add(m);
                }
            }
            foreach (Movie m in actionMovies)
            {
                Console.WriteLine(m.Title);
            }

        }
        if (input == "DRAMA")
        {
            Console.WriteLine("\nSOME MOVIES YOU'D LIKE:");

            foreach (Movie m in movieList)
            {
                if (m.Category.Contains("DRAMA"))
                {
                    dramaMovies.Add(m);
                }
            }
            foreach (Movie m in dramaMovies)
            {
                Console.WriteLine(m.Title);
            }

        }
        if (input == "ROMANCE")
        {
            Console.WriteLine("\nSOME MOVIES YOU'D LIKE:");

            foreach (Movie m in movieList)
            {
                if (m.Category.Contains("ROMANCE"))
                {
                    romanceMovies.Add(m);
                }
            }
            foreach (Movie m in romanceMovies)
            {
                Console.WriteLine(m.Title);
            }

        }
        Console.WriteLine("\nWOULD YOU LIKE TO TRY AGAIN? Y/N");
        restart = Console.ReadLine().ToUpper();
    }
    else
    {
        Console.WriteLine("\nINVALID INPUT! \nWOULD YOU LIKE TO TRY AGAIN? Y/N");
        restart = Console.ReadLine().ToUpper();
    }
}
while (restart == "Y");

Console.Clear();
Console.WriteLine("GOODBYE!!!");
Thread.Sleep(3000);






