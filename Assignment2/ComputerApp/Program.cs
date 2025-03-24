using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerApp
{
    class Program
    {
        static void Main()
        {
            List<IComputer> computers = new List<IComputer>
            {
                new Computer("Dell XPS 15", 15.6, 9.8, 2.0, 16, KeyboardType.Mechanical, ComputerType.Laptop, "Windows", "v1", 1200, 10),
                new Computer("MacBook Pro", 13.3, 8.3, 1.4, 8, KeyboardType.Normal, ComputerType.Laptop, "macOS", "v2", 1500, 5),
                new Computer("HP Pavilion", 21.5, 12.5, 5.5, 4, KeyboardType.Normal, ComputerType.Desktop, "Windows", "v3", 800, 15)
            };

            List<IBag> bags = new List<IBag>
            {
                new Bag("Backpack", 3, "Black", "Fabric", "v1", 50, 10),
                new Bag("Laptop Bag", 2, "Blue", "Leather", "v2", 70, 5)
            };

            Console.WriteLine("\nComputers and their Performance Categories:");
            foreach (var comp in computers) Console.WriteLine(comp);

            Console.WriteLine("\nNumber of compartments in fabric bags:");
            var fabricBags = bags.Where(b => b.Material == "Fabric");
            foreach (var bag in fabricBags) Console.WriteLine($"{bag.Name} has {bag.Compartments} compartments.");

            Console.WriteLine("\nAll products sold by vendor 'v1':");
            var productsByV1 = computers.Cast<IVendor>().Concat(bags.Cast<IVendor>()).Where(p => p.VendorName == "v1");
            foreach (var product in productsByV1) Console.WriteLine(product.GetType().Name + " - " + ((product as IComputer)?.ModelName ?? (product as IBag)?.Name));
        }
    }
}
