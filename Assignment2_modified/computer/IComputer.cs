namespace ComputerProject
{
    public interface IComputer
    {
        string ModelName { get; }
        double ScreenDimension { get; }
        double Weight { get; }
        string KeyboardType { get; }
        string OperatingSystem { get; }
        string FormFactor { get; }
        double AspectRatio { get; }
        int RAMSizeGB { get; }
        IVendor Vendor { get; }
    }
}