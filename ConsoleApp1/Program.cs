using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Масив слів
        string[] words = { "математика", "фізика", "хімія", "інформатика", "біологія" };

        // Запит LINQ для пошуку слова "інформатика"
        var word = words.FirstOrDefault(w => w.Equals("інформатика", StringComparison.OrdinalIgnoreCase));

        if (word != null)
            Console.WriteLine($"Слово знайдено: {word}");
        else
            Console.WriteLine("Слово не знайдено.");
    }
}
