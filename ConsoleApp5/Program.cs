using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Масив чисел
        int[] numbers = { 32, 22, 55, 48, 26, 54, 98 };

        // Вибір 4 чисел, починаючи з третього
        var selectedNumbers = numbers.Skip(2).Take(4);

        // Виведення результату
        foreach (var num in selectedNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
