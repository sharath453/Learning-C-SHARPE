
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IComputer> computers = PopulateComputers();

            Console.WriteLine("----------------------------------");
            Console.WriteLine("All Computers:");
            Console.WriteLine("----------------------------------");
            foreach (var computer in computers)
            {
                Console.WriteLine(computer);
            }

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("Laptops with Mechanical Keyboard:");
            Console.WriteLine("----------------------------------");
            PrintLaptopsWithMechanicalKeyboard(computers);

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("Desktops running Windows OS:");
            Console.WriteLine("----------------------------------");
            PrintDesktopsRunningWindows(computers);

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("macOS Computers with Aspect Ratio 1.6 and above:");
            Console.WriteLine("----------------------------------");
            PrintMacOSComputersWithAspectRatioAbove1_6(computers);

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("Computer Tiers:");
            Console.WriteLine("----------------------------------");
            PrintComputerTiers(computers);

            List<IBag> bags = PopulateBags();

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("All Bags:");
            Console.WriteLine("----------------------------------");
            foreach (var bag in bags)
            {
                Console.WriteLine(bag);
            }

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("Total Compartments of Fabric Bags:");
            Console.WriteLine("----------------------------------");
            PrintFabricBagCompartmentCount(bags);

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("Products by Vendor 'v1':");
            Console.WriteLine("----------------------------------");
            PrintProductsByVendor(computers, "v1");
        }

        static List<IComputer> PopulateComputers()
        {
            return new List<IComputer>
            {
                new Computer("MacBook Pro 16", 16.2, 1.6, "Magic Keyboard", "macOS", "Laptop", 1.6, 16, new Vendor("v1", 2400, 10)),
                new Computer("Dell XPS 13", 13.4, 1.2, "Chiclet", "Windows", "Laptop", 1.4, 8, new Vendor("v2", 1200, 5)),
                new Computer("HP Spectre x360", 14, 1.3, "Chiclet", "Windows", "Laptop", 1.5, 12, new Vendor("v1", 1800, 8)),
                new Computer("iMac 27", 27, 8.9, "Magic Keyboard", "macOS", "Desktop", 1.78, 32, new Vendor("v3", 2000, 12)),
                new Computer("Mac Mini", 0, 1.2, "None", "macOS", "Desktop", 1.78, 8, new Vendor("v1", 800, 0)), 
                new Computer("Lenovo ThinkCentre", 0, 5.5, "Mechanical", "Windows", "Desktop", 1.78, 4, new Vendor("v2", 600, 3)),
                new Computer("Alienware m15", 15.6, 2.5, "Mechanical", "Windows", "Laptop", 1.78, 16, new Vendor("v1", 2800, 15)),
                new Computer("Surface Laptop 4", 13.5, 1.2, "Alcantara", "Windows", "Laptop", 1.5, 8, new Vendor("v2", 1300, 7)),
                new Computer("MacBook Air M2", 13.6, 1.24, "Magic Keyboard", "macOS", "Laptop", 1.6, 8, new Vendor("v3", 1500, 10)),
                new Computer("Lenovo Legion Tower", 0, 14, "Mechanical", "Windows", "Desktop", 1.78, 32, new Vendor("v1", 2200, 5))
            };
        }

        static void PrintLaptopsWithMechanicalKeyboard(List<IComputer> computers)
        {
            foreach (var computer in computers)
            {
                if (computer.FormFactor == "Laptop" && computer.KeyboardType == "Mechanical")
                {
                    Console.WriteLine(computer);
                }
            }
        }

        static void PrintDesktopsRunningWindows(List<IComputer> computers)
        {
            foreach (var computer in computers)
            {
                if (computer.FormFactor == "Desktop" && computer.OperatingSystem == "Windows")
                {
                    Console.WriteLine(computer);
                }
            }
        }

        static void PrintMacOSComputersWithAspectRatioAbove1_6(List<IComputer> computers)
        {
            foreach (var computer in computers)
            {
                if (computer.OperatingSystem == "macOS" && computer.AspectRatio >= 1.6)
                {
                    Console.WriteLine(computer);
                }
            }
        }

        static void PrintComputerTiers(List<IComputer> computers)
        {
            foreach (var computer in computers)
            {
                ComputerTier tier = (computer as Computer)?.GetComputerTier() ?? ComputerTier.MidEnd;
                Console.WriteLine($"{computer.ModelName} is {tier}");
            }
        }


        static List<IBag> PopulateBags()
        {
            return new List<IBag>
            {
                new Bag("Backpack 1", 3, "Blue", "Fabric"),
                new Bag("Laptop Bag", 2, "Gray", "Polyester"),
                new Bag("Tote Bag", 1, "Beige", "Canvas"),
                new Bag("Messenger Bag", 4, "Black", "Fabric"),
                new Bag("Duffel Bag", 2, "Red", "Nylon")
            };
        }

        static void PrintFabricBagCompartmentCount(List<IBag> bags)
        {
            int totalCompartments = 0;
            foreach (var bag in bags)
            {
                if (bag.Material == "Fabric")
                {
                    totalCompartments += bag.NumberOfCompartments;
                }
            }
            Console.WriteLine($"Total compartments in fabric bags: {totalCompartments}");
        }

        static void PrintProductsByVendor(List<IComputer> computers, string vendorName)
        {
            Console.WriteLine($"Products sold by vendor '{vendorName}':");
            foreach (var computer in computers)
            {
                if (computer is Computer concreteComputer && concreteComputer.Vendor?.VendorName == vendorName)
                {
                    Console.WriteLine($"- {computer.ModelName}");
                }
            }
        }
    }
}