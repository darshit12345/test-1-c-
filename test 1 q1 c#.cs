// this is darshit's code .......

class Program
    {
        static void Main(string[] args)
        {
            List<Movie> oscarsList = new List<Movie>();
            oscarsList.Add(new Movie("Parasite", "Bong Joon Ho", 2019, 1243333, "Thriller"));
            oscarsList.Add(new Movie("Irish Man", "Martin Scorsesse", 2020, 32231145, "Drama"));
            oscarsList.Add(new Movie("Pulp Fiction", "Quentin Tarantino", 1994, 8000000, "Action"));
            oscarsList.Add(new Movie("The Social Network", "David Fincher", 2010, 40000000, "Drama"));
            oscarsList.Add(new Movie("The Godfather", "Francis Ford Coppola", 1972, 7200000, "Drama"));
            oscarsList.Add(new Movie("Inception", "Christopher Nolan", 2010, 160000000, "Thriller"));
            oscarsList.Add(new Movie("Schindler's List", "Steven Spielberg", 2019, 22000000, "War"));
            oscarsList.Add(new Movie("Good Fellas", "Martin Scorsesse", 1990, 25000000, "Action"));
            oscarsList.Add(new Movie("12 Angry Men", "Sidney Lumet", 1957, 337000, "Drama"));
            oscarsList.Add(new Movie("The Dark Knight", "Christopher Nolan", 2008, 185000000, "Action"));
            oscarsList.Add(new Movie("Good Will Hunting", "Gus Van Sant", 1997, 10000000, "Drama"));
            oscarsList.Add(new Movie("Citizen Kane", "Orson Welles", 1941, 839727, "Mystery"));
            oscarsList.Add(new Movie("Apocalypse Now", "Francis Ford Coppola", 1979, 3100000, "War"));
        }
    }

    class Movie
    {
        public string name { get; set; }
        public string director { get; set; }
        public int yearOfRelease { get; set; }
        public long budget { get; set; }
        public string genre { get; set; }

        public Movie(string name, string director, int yearOfRelease, long budget, string genre)
        {
            this.name = name;
            this.director = director;
            this.yearOfRelease = yearOfRelease;
            this.budget = budget;
            this.genre = genre;
        }
    }

    // b. Display genres................


var genreQuery = (from o in oscarsList
select o,genre) Distinct();
foreach (var genre in genreQuery) {
Console WriteLine(oscarsList)
Console.WriteLine("");

// c. Display the highest budget..........

var movieQuery = (from o in oscarsList
select o budget) sum();
Console.WriteLine(movieQuery);
Console.WriteLine(*highest budget*);

// d. Display the min , average budget.

IEnumerable<short> budgetQuery = 
from o in oscarsList 
select o.budget;


Console. WriteLine (budgetQuery.Min());
Console. WriteLine (budgetQuery. Max());

List<Float> budgetSum = new List<float>();
foreach (short e in budgetquery) (
budgetSum.Add(e);
}
Console.WriteLine(budgetSum.Average());

// e. Group the genre and show the result 


var groupedmovies = from movie in oscarsList
group movie by movie.genre;

foreach (var group in groupedmovies) {
Console. WriteLine(group.Key + " : " + group.Count0());


foreach (var movie in group) {
Console.WriteLine(" the movie names : " + movie.Name +
", this is genre: " + movie.genre);
}
}


//f. Display movies that were released after 2000 with budgets less than 20 million.
var abudget = "20million"
var varName = oscarsList.Select(s => new { yearOfRelease > 2000 = s.yearOfRelease  });

var movieQuery = (from v in varName
select v budget) sum<abudget();
Console.WriteLine(movieQuery);
Console.WriteLine(*after 2000 year of relese movies budget less then 20million*);

//g.  Perform exception handling so that your application terminates gracefully in case of any unexpected events.
protected void Application_AuthorizeRequest(object sender, EventArgs e)
{
    // Event handler code
}

// end of the code