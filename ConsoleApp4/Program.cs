using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Масив чисел
        int[] numbers = { 32, 22, 55, 48, 26, 54, 98 };

        // Сума чисел
        int sum = numbers.Sum();
        Console.WriteLine($"Сума чисел: {sum}");

        // Різниця чисел (сума всіх чисел - мінімальне число)
        int difference = sum - numbers.Min();
        Console.WriteLine($"Різниця чисел: {difference}");
    }
}
