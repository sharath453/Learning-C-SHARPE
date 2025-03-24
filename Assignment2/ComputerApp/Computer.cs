using System;

namespace ComputerApp
{
    public class Computer : IComputer
    {
        public string ModelName { get; private set; }
        public double ScreenWidth { get; private set; }
        public double ScreenHeight { get; private set; }
        public double AspectRatio => ScreenWidth / ScreenHeight;
        public double Weight { get; private set; }
        public int RAM { get; private set; } // RAM property
        public KeyboardType Keyboard { get; private set; }
        public ComputerType Type { get; private set; }
        public string OS { get; private set; }
        public string VendorName { get; private set; }
        public double SalePrice { get; private set; }
        public double Discount { get; private set; }

        public string PerformanceCategory => RAM <= 4 ? "LowEnd" : (RAM >= 8 ? "HighEnd" : "MidEnd");

        public Computer(string modelName, double screenWidth, double screenHeight, double weight, int ram,
                        KeyboardType keyboard, ComputerType type, string os, string vendorName, double salePrice, double discount)
        {
            ModelName = modelName;
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;
            Weight = weight;
            RAM = ram;
            Keyboard = keyboard;
            Type = type;
            OS = os;
            VendorName = vendorName;
            SalePrice = salePrice;
            Discount = discount;
        }

        public override string ToString()
        {
            return $"{ModelName} | {Type} | {OS} | {Keyboard} | RAM: {RAM}GB | {PerformanceCategory} | Aspect Ratio: {AspectRatio:F2}";
        }
    }
}
