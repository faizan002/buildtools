using System;

class HelloWorld
{
    static void Main()
    {
        #if DebugConfig
        Console.WriteLine("We are in the DEBUG config");
        #endif
        Console.WriteLine("Hello, world!");
    }
}