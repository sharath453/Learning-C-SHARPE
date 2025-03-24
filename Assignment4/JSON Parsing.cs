using System;
using System.IO;
using Newtonsoft.Json.Linq;

class JSONParsingExample
{
    static void Main()
    {
        string filePath = @"C:\Users\Sharath A L\Downloads\data.json";

        if (File.Exists(filePath))
        {
            string jsonContent = File.ReadAllText(filePath);
            JObject jsonData = JObject.Parse(jsonContent);

            string? name = jsonData["name"]?.ToString();
            int? age = jsonData["age"]?.Value<int>();
            string? city = jsonData["address"]?["city"]?.ToString();

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"City: {city}");

            Console.WriteLine("Skills:");
            foreach (var skill in jsonData["skills"] ?? new JArray())
            {
                Console.WriteLine("- " + skill);
            }
        }
        else
        {
            Console.WriteLine("Error: JSON file not found!");
        }
    }
}
