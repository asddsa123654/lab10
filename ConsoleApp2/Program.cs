using System;
using System.Collections.Generic;
using System.Linq;

class Movie
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public string Category { get; set; }

    public Movie(string name, string author, int year, string category)
    {
        Name = name;
        Author = author;
        Year = year;
        Category = category;
    }
}

class Program
{
    static void Main()
    {
        // Колекція фільмів
        List<Movie> movies = new List<Movie>
        {
            new Movie("Фільм 1", "Автор 1", 1999, "Фентезі"),
            new Movie("Фільм 2", "Автор 2", 2005, "Фентезі"),
            new Movie("Фільм 3", "Автор 3", 2010, "Фентезі"),
            new Movie("Фільм 4", "Автор 4", 2011, "Фентезі"),
            new Movie("Фільм 5", "Автор 5", 2003, "Драма"),
            new Movie("Фільм 6", "Автор 6", 2008, "Фентезі"),
            new Movie("Фільм 7", "Автор 7", 2015, "Комедія"),
            new Movie("Фільм 8", "Автор 8", 2000, "Фентезі"),
            new Movie("Фільм 9", "Автор 9", 2007, "Фентезі"),
            new Movie("Фільм 10", "Автор 10", 2014, "Фентезі")
        };

        // Запит LINQ для фільмів категорії "Фентезі" з роками між 2000 та 2012
        var selectedMovies = from movie in movies
                             where movie.Category == "Фентезі" && movie.Year > 2000 && movie.Year < 2012
                             select movie;

        // Виведення результату
        foreach (var movie in selectedMovies)
        {
            Console.WriteLine($"Назва: {movie.Name}, Автор: {movie.Author}, Рік: {movie.Year}");
        }

        // Знаходимо фільм з найменшим роком
        var movieWithMinYear = selectedMovies.OrderBy(m => m.Year).First();
        Console.WriteLine($"Фільм з найменшим роком: {movieWithMinYear.Name} ({movieWithMinYear.Year})");
    }
}
