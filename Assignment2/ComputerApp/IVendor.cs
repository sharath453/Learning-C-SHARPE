using System;

namespace ComputerApp
{
    public interface IVendor
    {
        string VendorName { get; }
        double SalePrice { get; }
        double Discount { get; }
    }
}
