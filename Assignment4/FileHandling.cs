using System;
using System.IO; 

class FileReadExample
{
    static void Main()
    {
        string filePath = @"C:\Users\Sharath A L\Downloads\file.txt";

        if (File.Exists(filePath))
        {
            
            string readContent = File.ReadAllText(filePath);
            Console.WriteLine("File Content: \n" + readContent);
            Console.WriteLine("process is completed!");
        }
        else
        {
            Console.WriteLine("Error: File not found!");
        }
    }
}
