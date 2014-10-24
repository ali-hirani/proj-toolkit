using System;
using System.Diagnostics;

class Qformula
{
    public string testParse;
    public double aNum = 0;
    public double bNum = 0;
    public double cNum = 0;
    public double num = 0;
    public double test = 0;
    public double result1= 0; 
    public double result2= 0;
    
    public double GetValue(string valueName)
    {
        Console.Write("Please enter the {0} value: ", valueName);
        do
        {
            testParse = Console.ReadLine();
            if(!double.TryParse(testParse, out num))
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter valid number.");
                Console.WriteLine("");
            }
        }
        while(num == 0);
        return num;
    }
    public void Quadformula()
    {
        Console.WriteLine("Welcome to the Quadractic Root Solver.");
        Console.WriteLine("");
        
        //take in values
        aNum = GetValue("A");
        bNum = GetValue("B");
        cNum = GetValue("C");
        
        while(cNum == 0);    
        test = (bNum * bNum) - (4 * (aNum * cNum));
        
        //(b^2) - 4ac < 0 then it can't do anything
        if(test < 0)
        {
            Console.WriteLine("");
            Console.WriteLine("Value is not real.");
        }

        //evaluate if input is acceptable
        else
        {
            result1 = (-bNum + Math.Sqrt((bNum * bNum) - (4 * (aNum * cNum)))) / (2 * (aNum));
            result2 =(-bNum - Math.Sqrt((bNum * bNum) - (4 * (aNum * cNum)))) / (2 * (aNum));
            Console.WriteLine("");
            Console.WriteLine("x1 = " + Math.Round(result1, 3));
            Console.WriteLine("x2 = " + Math.Round(result2, 3));    
        }
    }       
}