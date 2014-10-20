using System;
using System.Diagnostics;

class Qformula
{
//(b^2) - 4ac < 0 then it can't do anythin
    public double a;
    public double b;
    public double c;
    public string aParse;
    public string bParse;
    public string cParse;
    public double aNum = 0;
    public double bNum = 0;
    public double cNum = 0;
    public double test= 0;
    public double result1= 0; 
    public double result2= 0;
    
    public void Quadformula()
    {
        Console.WriteLine("Welcome to the Quadractic Root Solver.");
        Console.WriteLine("");
        Console.WriteLine("Please enter the A value.");
        do
        {
            aParse = Console.ReadLine();
            if(double.TryParse(aParse, out aNum))
            {
                a = aNum;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter valid number.");
                Console.WriteLine("");
            }
        }
        while(aNum == 0);
        Console.WriteLine("Please enter the B value.");
        do
        {
            bParse = Console.ReadLine();
            if(double.TryParse(bParse, out bNum))
            {
                b = bNum;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter valid number.");
                Console.WriteLine("");
            }
        }
        while(bNum == 0);   
        Console.WriteLine("Please enter the C value.");
        do
        {
            cParse = Console.ReadLine();
            if(double.TryParse(cParse, out cNum))
            {
                c = cNum;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter valid number.");
                Console.WriteLine("");
            }
        }
        while(cNum == 0);    
        test = (b * b) - (4*(a * c));
        if(test < 0)
        {
            Console.WriteLine("");
            Console.WriteLine("Value is not real.");
        }   
        else
        {
            result1 = (-b + Math.Sqrt((b * b) - (4 * (a * c)))) / (2 * (a));
            result2 =(-b - Math.Sqrt((b * b) - (4 * (a * c)))) / (2 * (a));
            Console.WriteLine("");
            Console.WriteLine("x1 = " + Math.Round(result1, 3));
            Console.WriteLine("x2 = " + Math.Round(result2, 3));    
        }
    }       
}