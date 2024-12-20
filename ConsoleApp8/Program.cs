using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Масив рейтингів студентів
        int[] ratings = { 55, 82, 45, 91, 77, 60, 48, 92, 63, 59 };

        // Запит LINQ для студентів з рейтингом < 60
        var lowRatingsCount = ratings.Count(r => r < 60);
        Console.WriteLine($"Кількість студентів з рейтингом < 60: {lowRatingsCount}");

        // Запит LINQ для студентів з рейтингом > 90
        var highRatingsCount = ratings.Count(r => r > 90);
        Console.WriteLine($"Кількість студентів з рейтингом > 90: {highRatingsCount}");
    }
}
