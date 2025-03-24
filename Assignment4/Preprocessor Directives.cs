#define DEBUG
#define TEST

using System;

class PreprocessorExample
{
    static void Main()
    {
#if DEBUG
        Console.WriteLine("Debug mode is enabled");
#endif

#if TEST
        Console.WriteLine("Test mode is active");
#endif

#if RELEASE
        Console.WriteLine("Release mode is active");
#endif

#if DEBUG && TEST
        Console.WriteLine("Both Debug and Test modes are enabled");
#endif

#if !DEBUG
        Console.WriteLine("Debug mode is disabled");
#endif
    }
}
