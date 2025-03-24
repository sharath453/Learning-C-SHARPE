
namespace ComputerProject
{
    public class Vendor : IVendor
    {
        public string VendorName { get; } 
        public double SalePrice { get; }
        public double DiscountPercentage { get; }

        public Vendor(string vendorName, double salePrice, double discountPercentage)
        {
            VendorName = vendorName;
            SalePrice = salePrice;
            DiscountPercentage = discountPercentage;
        }

        public override string ToString()
        {
            return $"Vendor: {VendorName}, Price: ${SalePrice}, Discount: {DiscountPercentage}%";
        }
    }
}
