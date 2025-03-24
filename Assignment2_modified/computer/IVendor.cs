
namespace ComputerProject
{
    public interface IVendor
    {
        string VendorName { get; }
        double SalePrice { get; }
        double DiscountPercentage { get; }
    }
}
