using System;
using System.Collections.Generic;

class Program
{
    static readonly Dictionary<char, string> KeypadMapping = new()
    {
        {'a', "2"}, {'b', "22"}, {'c', "222"},
        {'d', "3"}, {'e', "33"}, {'f', "333"},
        {'g', "4"}, {'h', "44"}, {'i', "444"},
        {'j', "5"}, {'k', "55"}, {'l', "555"},
        {'m', "6"}, {'n', "66"}, {'o', "666"},
        {'p', "7"}, {'q', "77"}, {'r', "777"}, {'s', "7777"},
        {'t', "8"}, {'u', "88"}, {'v', "888"},
        {'w', "9"}, {'x', "99"}, {'y', "999"}, {'z', "9999"},
        {' ', "0"}
    };

    static string ConvertToKeypress(string message)
    {
        string result = "";
        char lastChar = '\0';
        
        foreach (char c in message)
        {
            if (lastChar != '\0' && KeypadMapping[lastChar][0] == KeypadMapping[c][0])
                result += " ";
            
            result += KeypadMapping[c];
            lastChar = c;
        }
        
        return result;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            string message = Console.ReadLine();
            Console.WriteLine($"Case #{i}: {ConvertToKeypress(message)}");
        }
    }
}
