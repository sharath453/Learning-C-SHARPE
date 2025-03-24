using System;

namespace ComputerApp
{
    public interface IBag : IVendor
    {
        string Name { get; }
        int Compartments { get; }
        string Color { get; }
        string Material { get; }
    }
}
