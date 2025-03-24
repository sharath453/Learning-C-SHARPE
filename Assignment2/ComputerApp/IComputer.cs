using System;

namespace ComputerApp
{
    public enum KeyboardType { Mechanical, Normal }
    public enum ComputerType { Desktop, Laptop }
    
    public interface IComputer : IVendor  // Now implements IVendor
    {
        string ModelName { get; }
        double ScreenWidth { get; }
        double ScreenHeight { get; }
        double AspectRatio { get; }
        double Weight { get; }
        int RAM { get; } // Added RAM Property
        KeyboardType Keyboard { get; }
        ComputerType Type { get; }
        string OS { get; }
        string PerformanceCategory { get; } // LowEnd, MidEnd, HighEnd
    }
}
