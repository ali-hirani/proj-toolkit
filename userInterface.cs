using System;
using System.Diagnostics;

class UserInterface
{

    public void EmptyMethod(string toolName)
    {
        Console.WriteLine("---Accepted");
        Console.WriteLine("");
        Console.WriteLine("You chose {0}", toolName);
        Console.WriteLine("");
        Console.WriteLine("{0} not implemented", toolName);
        Console.WriteLine("");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Press any key to return to main menu");
        Console.ReadKey();
    }
    public void ToolStart(string toolName)
    {
        Console.WriteLine("---Accepted");
        Console.WriteLine("");
        Console.WriteLine("You chose {0}", toolName);
        Console.WriteLine("");
    }
    public void ToolEnd()
    {
        Console.WriteLine("");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Press any key to return to main menu");
        Console.ReadKey();
    }
}