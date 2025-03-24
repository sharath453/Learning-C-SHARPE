using System;
using System.Collections.Generic;

class SubjectAlreadyExistsException : Exception
{
    public SubjectAlreadyExistsException(string message) : base(message) { }
}

class SubjectNotFoundException : Exception
{
    public SubjectNotFoundException(string message) : base(message) { }
}

class Timetable
{
    private Dictionary<string, List<string>> schedule;

    public Timetable()
    {
        schedule = new Dictionary<string, List<string>>();
    }

    // Add a subject for a given day
    public void AddSubject(string day, string subject)
    {
        if (!schedule.ContainsKey(day))
        {
            schedule[day] = new List<string>();
        }

        if (schedule[day].Contains(subject))
        {
            throw new SubjectAlreadyExistsException($"Error: {subject} is already scheduled on {day}.");
        }

        schedule[day].Add(subject);
        Console.WriteLine($"Added {subject} to {day}.");
    }

    // Remove a subject for a given day
    public void RemoveSubject(string day, string subject)
    {
        if (!schedule.ContainsKey(day) || !schedule[day].Contains(subject))
        {
            throw new SubjectNotFoundException($"Error: {subject} is not scheduled on {day}.");
        }

        schedule[day].Remove(subject);
        Console.WriteLine($"Removed {subject} from {day}.");
    }

    // Check if a subject is scheduled for a given day
    public bool IsSubjectScheduled(string day, string subject)
    {
        return schedule.ContainsKey(day) && schedule[day].Contains(subject);
    }

    // Display the full timetable
    public void DisplayTimetable()
    {
        Console.WriteLine("\nWeekly Timetable:");
        foreach (var entry in schedule)
        {
            Console.WriteLine($"{entry.Key}: {string.Join(", ", entry.Value)}");
        }
    }
}

class Program
{
    static void Main()
    {
        Timetable timetable = new Timetable();

        while (true)
        {
            Console.WriteLine("\nSelect an action:");
            Console.WriteLine("1. Add Subject");
            Console.WriteLine("2. Remove Subject");
            Console.WriteLine("3. Check Subject");
            Console.WriteLine("4. Display Timetable");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the day: ");
                        string addDay = Console.ReadLine();
                        Console.Write("Enter the subject: ");
                        string addSubject = Console.ReadLine();
                        timetable.AddSubject(addDay, addSubject);
                        break;

                    case "2":
                        Console.Write("Enter the day: ");
                        string removeDay = Console.ReadLine();
                        Console.Write("Enter the subject: ");
                        string removeSubject = Console.ReadLine();
                        timetable.RemoveSubject(removeDay, removeSubject);
                        break;

                    case "3":
                        Console.Write("Enter the day: ");
                        string checkDay = Console.ReadLine();
                        Console.Write("Enter the subject: ");
                        string checkSubject = Console.ReadLine();
                        bool exists = timetable.IsSubjectScheduled(checkDay, checkSubject);
                        Console.WriteLine(exists ? $"{checkSubject} is scheduled on {checkDay}." : $"{checkSubject} is NOT scheduled on {checkDay}.");
                        break;

                    case "4":
                        timetable.DisplayTimetable();
                        break;

                    case "5":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
