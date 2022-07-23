using MovieDatabase;

Movie movie1 = new Movie("Top Gun", "Action");
Movie movie2 = new Movie("Rocky", "Action");
Movie movie3 = new Movie("Terminator", "Action");
Movie movie4 = new Movie("John Wick", "Action");
Movie movie5 = new Movie("Fight Club", "Drama");
Movie movie6 = new Movie("Good Will Hunting", "Drama");
Movie movie7 = new Movie("Seven Pounds", "Drama");
Movie movie8 = new Movie("Casablanca", "Romance");
Movie movie9 = new Movie("Titanic", "Romance");
Movie movie10 = new Movie("Dirty Dancing", "Romance");

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

foreach (Movie m in movieList)
{
    Console.WriteLine(m);
}
