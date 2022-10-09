using MovieOefening.Classes;

var movies = new List<Movie>();

movies.Add(new Movie() { Name = "Jurasic Park", Director = "Steven Spielberg", Producer = "Danny", Rating = 9, ReleaseDate = new DateTime(1998, 10, 12) });
movies.Add(new Movie() { Name = "Jurasic Park 2", Director = "Steven Spielberg", Producer = "Johny", Rating = 8, ReleaseDate = new DateTime(1999, 11, 12) });
movies.Add(new Movie() { Name = "Jurasic Park 3", Director = "Steven Spielberg", Producer = "Danny", Rating = 6, ReleaseDate = new DateTime(2000, 10, 12) });
movies.Add(new Movie() { Name = "Titanic", Director = "James Cameron", Producer = "Wim", Rating = 7, ReleaseDate = new DateTime(1999, 5, 4) });
movies.Add(new Movie() { Name = "My movie", Director = "Arne", Producer = "Arne", Rating = 5, ReleaseDate = new DateTime(2010, 7, 1) });

//Toon alle films uit 2010
var result1 = movies.Where(e => e.ReleaseDate.Year == 2010).Select(e => $"{e.Name}");

//ShowResult(result1);

//Toon alle films met een rating tussen 4 en 6
var result2 = movies.Where(e => e.Rating >= 4 && e.Rating <= 6).Select(e => $"{e.Name}");

//ShowResult(result2);

//Toon alle films van de regiseur "Steven Spielberg"
var result3 = movies.Where(e => e.Director == "Steven Spielberg").Select(e => $"{e.Name}");

//ShowResult(result3);

//Toon het aantal films per regiseur
var result4 = movies.GroupBy(e => e.Director).Select(e => $"{e.Key} : {e.Count()}");

//ShowResult(result4);

//Toon het aantal films per producer


//Toon de gemiddelde rating van een film voor elk jaar
var result5 = movies.GroupBy(e => e.ReleaseDate.Year).Select(e => $"{e.Key} : {e.Average(movie => movie.Rating)}");

ShowResult(result5);


void ShowResult(IEnumerable<string> result)
{
    foreach (var item in result)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("");
}