namespace ComputerProject
{
    public enum ComputerTier { LowEnd, MidEnd, HighEnd }

    public class Computer : IComputer
    {
        public string ModelName { get; }
        public double ScreenDimension { get; }
        public double Weight { get; }
        public string KeyboardType { get; }
        public string OperatingSystem { get; }
        public string FormFactor { get; }
        public double AspectRatio { get; }
        public int RAMSizeGB { get; } 
        public IVendor Vendor { get; } 


        public Computer(string modelName, double screenDimension, double weight, string keyboardType, string operatingSystem, string formFactor, double aspectRatio, int ramSizeGB, IVendor vendor)
        {
            ModelName = modelName;
            ScreenDimension = screenDimension;
            Weight = weight;
            KeyboardType = keyboardType;
            OperatingSystem = operatingSystem;
            FormFactor = formFactor;
            AspectRatio = aspectRatio;
            RAMSizeGB = ramSizeGB;
            Vendor = vendor;
        }

        public override string ToString()
        {
            return $"Model: {ModelName}, FormFactor: {FormFactor}, OS: {OperatingSystem}, Screen: {ScreenDimension}\", Weight: {Weight}kg, Keyboard: {KeyboardType}, RAM: {RAMSizeGB}GB, Aspect Ratio: {AspectRatio}, Vendor: {Vendor}";
        }

        public ComputerTier GetComputerTier()
        {
            if (RAMSizeGB <= 4)
            {
                return ComputerTier.LowEnd;
            }
            else if (RAMSizeGB >= 8)
            {
                return ComputerTier.HighEnd;
            }
            else
            {
                return ComputerTier.MidEnd;
            }
        }
    }
}