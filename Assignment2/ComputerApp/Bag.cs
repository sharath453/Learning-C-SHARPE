using System;

namespace ComputerApp
{
    public class Bag : IBag
    {
        public string Name { get; private set; }
        public int Compartments { get; private set; }
        public string Color { get; private set; }
        public string Material { get; private set; }
        public string VendorName { get; private set; }
        public double SalePrice { get; private set; }
        public double Discount { get; private set; }

        public Bag(string name, int compartments, string color, string material, string vendorName, double salePrice, double discount)
        {
            Name = name;
            Compartments = compartments;
            Color = color;
            Material = material;
            VendorName = vendorName;
            SalePrice = salePrice;
            Discount = discount;
        }

        public override string ToString()
        {
            return $"{Name} | Compartments: {Compartments} | Color: {Color} | Material: {Material} | Vendor: {VendorName}";
        }
    }
}
