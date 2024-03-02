using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

class Program
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            {"яблуко", "фрукт"},
            {"морква", "овоч"},
            {"банан", "фрукт"}
        };

        // Сортуємо словник за значеннями, а потім за ключами, щоб зберегти стабільність сортування
        var sortedDictionary = dictionary
            .OrderBy(pair => pair.Value)
            .ThenBy(pair => pair.Key)
            .ToDictionary(pair => pair.Key, pair => pair.Value);

        // Серіалізуємо відсортований словник у JSON
        string json = JsonSerializer.Serialize(sortedDictionary, new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine(json);

        Console.WriteLine("Натиснiть будь-яку клавiшу для виходу...");
        Console.ReadLine();
    }
}