using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Колекція доменних імен
        List<string> domains = new List<string>
        {
            "google.com", "yahoo.com", "vk.com", "facebook.com", "twitter.com",
            "linkedin.com", "instagram.com", "wikipedia.org", "reddit.com", "youtube.com"
        };

        // Запит LINQ для пошуку сайту "vk.com"
        var vkSite = domains.FirstOrDefault(domain => domain == "vk.com");

        if (vkSite != null)
            Console.WriteLine($"Сайт знайдений: {vkSite}");
        else
            Console.WriteLine("Сайт не знайдений.");
    }
}
