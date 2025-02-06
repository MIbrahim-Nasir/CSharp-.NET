using System.Linq;

namespace Milestone_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine(@"Welcome to IMDB
1. List Movies
2. Add Movies
3. Exit

Enter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        var moviesList = MovieRepository.GetMovies();
                        Console.WriteLine("\nList of Movies");

                        if (moviesList.Count == 0)
                        {
                            Console.WriteLine("List is empty\n");
                        }
                        else
                        {
                            foreach (var x in moviesList)
                            {
                                Console.Write("\nName: " + x.Name);
                                Console.Write("\tYear Of Release: " + x.YearOfRelease);
                                Console.Write("\tPlot: " + x.Plot);

                                Console.Write("\tActors: ");
                                foreach (var actor in x.Actors)
                                {
                                    Console.Write(actor + " ");
                                }

                                Console.Write("\tProducer: " + x.Producer);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 2:
                        string name;
                        int year;
                        string plot;
                        try
                        {
                            Console.WriteLine("Enter the Name of Movie: ");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter Year of release: ");
                            year = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Plot: ");
                            plot = Console.ReadLine();

                            List<string> actors = new();
                            while (true)
                            {
                                Actors actorsList = new Actors();
                                actorsList.GetActors();
                                Console.WriteLine("Enter actor number to select or type 'exit' to exit from actor selection");
                                string entry = Console.ReadLine();
                                if (string.IsNullOrEmpty(entry))
                                {
                                    Console.WriteLine("Invalid input");
                                }
                                else if (entry.Equals("exit"))
                                {
                                    break;
                                }
                                else
                                {
                                    if (!int.TryParse(entry, out int result) || result > actorsList.GetActorsCount() || result < 1)
                                    {
                                        Console.WriteLine("Please enter a valid number");

                                    }
                                    else
                                    {
                                        actors.Add(actorsList[result].ToString());

                                    }
                                }


                            }

                            string producer;

                            Console.WriteLine("Select Producer");
                            Producers producerList = new Producers();
                            producerList.GetProducers();
                            string producerChoice = Console.ReadLine();
                            Console.WriteLine("producer choice is: "+ producerChoice);
                            if (string.IsNullOrEmpty(producerChoice) || !int.TryParse(producerChoice, out int n) || n > producerList.GetProducerCount())
                            {
                                Console.WriteLine("Invalid selection");
                                break;
                            }
                            else
                            {
                                producer = producerList[n].ToString();
                                Console.WriteLine(name);
                                Console.WriteLine(year);
                                Console.WriteLine(plot);
                                foreach(string x in actors)
                                {
                                    Console.WriteLine(x);
                                }
                                Console.WriteLine(producer);
                                MovieRepository.AddMovie(new Movie() { Name = name, YearOfRelease = year, Plot = plot, Actors = actors, Producer = producer });
                            }
                           

                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Wrong Format Entered");
                        }
                        catch (MovieEntryException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        break;
                    
                    case 3:
                        exit = true;
                        Console.WriteLine("\nGoodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a number between 1 and 6, or enter 0 to exit.\n");
                        break;
                }
            }

            //Adding Sample Data
            MovieRepository.AddMovie(new Movie() { Name = "Inception", YearOfRelease = 2010, Plot = "A thief who steals corporate secrets through the use of dream-sharing technology.", Actors = new List<string> { "Leonardo DiCaprio", "Joseph Gordon-Levitt" }, Producer = "Christopher Nolan" });
            MovieRepository.AddMovie(new Movie() { Name = "Avatar", YearOfRelease = 2009, Plot = "A paraplegic Marine is dispatched to the moon Pandora on a unique mission.", Actors = new List<string> { "Sam Worthington", "Zoe Saldana" }, Producer = "James Cameron" });
            MovieRepository.AddMovie(new Movie() { Name = "The Avengers", YearOfRelease = 2012, Plot = "Earth's mightiest heroes must come together and learn to fight as a team.", Actors = new List<string> { "Robert Downey Jr", "Chris Evans", "Mark Ruffalo", "Scarlett Johansson" }, Producer = "Kevin Feige" });
            MovieRepository.AddMovie(new Movie() { Name = "Titanic", YearOfRelease = 1997, Plot = "A young couple's tragic love story unfolds during the sinking of the Titanic.", Actors = new List<string> { "Leonardo DiCaprio", "Kate Winslet" }, Producer = "James Cameron" });
            MovieRepository.AddMovie(new Movie() { Name = "I Am Legend", YearOfRelease = 2007, Plot = "A post-apocalyptic survivor in New York City seeks a cure for a virus.", Actors = new List<string> { "Will Smith" }, Producer = "Akiva Goldsman" });
            MovieRepository.AddMovie(new Movie() { Name = "The Pursuit of Happyness", YearOfRelease = 2006, Plot = "A struggling salesman takes custody of his son as he's poised to begin a life-changing professional endeavor.", Actors = new List<string> { "Will Smith", "Jaden Smith" }, Producer = "Steve Tisch" });


            //LINQ Queries
            Console.WriteLine(" list of all movies released after year 2010");
            var moviesAfter2010 = MovieRepository.GetMovies().Where(x => x.YearOfRelease > 2010);
            foreach (var movie in moviesAfter2010)
            {
                Console.WriteLine(movie.Name);
            }

            Console.WriteLine();

            Console.WriteLine("name of all movies whose producer name is ‘James Cameron’");
            var jamesCameronMovies = MovieRepository.GetMovies().Where(x => x.Producer == "James Cameron");
            foreach (var movie in jamesCameronMovies)
            {
                Console.WriteLine(movie.Name);
            }

            Console.WriteLine();

            Console.WriteLine("name and year of release of all movies");
            var movieNamesAndYears = MovieRepository.GetMovies().Select(x => new {x.Name, x.YearOfRelease});
            foreach (var movie in movieNamesAndYears)
            {
                Console.WriteLine($"Name: {movie.Name}, Year of Release: {movie.YearOfRelease}");
            }

            Console.WriteLine();

            Console.WriteLine(" first movie whose name contains ‘Avatar’");
            var avatarMovie = MovieRepository.GetMovies().FirstOrDefault(x => x.Name.Contains("Avatar"));
            if (avatarMovie != null)
            {
                Console.WriteLine($"First movie whose name contains 'Avatar': {avatarMovie.Name}, Year of Release: {avatarMovie.YearOfRelease}");
            }
            else
            {
                Console.WriteLine("No movie found with 'Avatar' in its name.");
            }

            Console.WriteLine();

            Console.WriteLine("list of all those movies in which the actor ’Will Smith’ has acted\r\n");
            var willSmithMovies = MovieRepository.GetMovies().Where(x => x.Actors.Contains("Will Smith"));
            foreach (var movie in willSmithMovies)
            {
                Console.WriteLine(movie.Name);
            }
        }
    }
}
