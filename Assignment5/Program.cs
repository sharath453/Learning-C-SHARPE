using System;
using System.Collections.Generic;

// Single Responsibility Principle (SRP)
class ReportGenerator
{
    public string GenerateReport(string data) => $"Report: {data}";
}

class ReportPrinter
{
    public void Print(string report) => Console.WriteLine(report);
}

// Open-Closed Principle (OCP)
interface IDiscount
{
    double ApplyDiscount(double amount);
}

class RegularDiscount : IDiscount
{
    public double ApplyDiscount(double amount) => amount * 0.1;
}

class PremiumDiscount : IDiscount
{
    public double ApplyDiscount(double amount) => amount * 0.2;
}

class DiscountCalculator
{
    public double CalculateDiscount(IDiscount discount, double amount) => discount.ApplyDiscount(amount);
}

// Liskov Substitution Principle (LSP)
abstract class Bird
{
    public abstract void Fly();
}

class Sparrow : Bird
{
    public override void Fly() => Console.WriteLine("Sparrow is flying");
}

class Penguin : Bird
{
    public override void Fly() => throw new NotImplementedException("Penguins can't fly");
}

// Interface Segregation Principle (ISP)
interface IPrint
{
    void Print();
}

interface IScan
{
    void Scan();
}

class Printer : IPrint
{
    public void Print() => Console.WriteLine("Printing document");
}

class MultiFunctionPrinter : IPrint, IScan
{
    public void Print() => Console.WriteLine("Printing document");
    public void Scan() => Console.WriteLine("Scanning document");
}

// Dependency Inversion Principle (DIP)
interface ILogger
{
    void Log(string message);
}

class ConsoleLogger : ILogger
{
    public void Log(string message) => Console.WriteLine($"Log: {message}");
}

class Application
{
    private readonly ILogger _logger;
    
    public Application(ILogger logger)
    {
        _logger = logger;
    }
    
    public void Run() => _logger.Log("Application is running");
}

// Main Program
class Program
{
    static void Main()
    {
        var reportGenerator = new ReportGenerator();
        var reportPrinter = new ReportPrinter();
        string report = reportGenerator.GenerateReport("Sales Data");
        reportPrinter.Print(report);
        
        var discountCalculator = new DiscountCalculator();
        Console.WriteLine(discountCalculator.CalculateDiscount(new RegularDiscount(), 100));
        Console.WriteLine(discountCalculator.CalculateDiscount(new PremiumDiscount(), 100));
        
        Bird sparrow = new Sparrow();
        sparrow.Fly();
        
        IPrint printer = new Printer();
        printer.Print();
        
        IPrint multiPrinter = new MultiFunctionPrinter();
        multiPrinter.Print();
        
        ILogger logger = new ConsoleLogger();
        Application app = new Application(logger);
        app.Run();
    }
}
