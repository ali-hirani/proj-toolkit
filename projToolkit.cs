using System;
using System.Diagnostics;

class ProjToolkit
{
    static void Main()
    {
        UserInterface ui = new UserInterface();
        TipCalculator tc = new TipCalculator();
        Statistic stat = new Statistic();
        Qformula qf = new Qformula();
        RandomNumberGen rng = new RandomNumberGen();
        RockPaperScissors rps = new RockPaperScissors();
        KanyeQuoteGen kanye = new KanyeQuoteGen();

        DateTime now = DateTime.Now;
        //Stopwatch stopwatch = new Stopwatch();

        ConsoleKeyInfo uiKey;
        bool keyCheck = false;
        bool terminate = false;
        string tool1 = "Tip Calculator".PadRight(29);
        string tool2 = "Quadratic Formula".PadRight(29);
        string tool3 = "Mean/Mode/Median Tool".PadRight(29);
        string tool4 = "Sum Tool".PadRight(29);
        string tool5 = "Molar Mass Calculator".PadRight(29);
        string tool6 = "Element Name Tool".PadRight(29);
        string tool7 = "Random Number Generator".PadRight(29);
        string tool8 = "Rock Paper Scissors Game".PadRight(29);
        string tool9 = "Kanye West Quote Generator".PadRight(29);
        
        while(terminate == false)
        //terminate's value only changes in the else if condition where 't' is pressed
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Choose the tool you want to use!");
                Console.WriteLine("--------------------------------");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. {0}", tool1);
                Console.WriteLine("2. {0}", tool2);
                Console.WriteLine("3. {0}", tool3);
                Console.WriteLine("4. {0}", tool4);
                Console.WriteLine("5. {0}", tool5);
                Console.WriteLine("6. {0}", tool6);
                Console.WriteLine("7. {0}", tool7);
                Console.WriteLine("8. {0}", tool8);
                Console.WriteLine("9. {0}", tool9);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Press t to Terminate Program    ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Session Start Date/Time: " + now);
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("");
                uiKey = Console.ReadKey();
                if(uiKey.KeyChar == '1')
                {
                    ui.ToolStart(tool1);
                    tc.TipCalc();
                    ui.ToolEnd();
                }
                else if(uiKey.KeyChar == '2')
                {
                    ui.ToolStart(tool2);
                    qf.Quadformula();
                    ui.ToolEnd();
                }
                else if(uiKey.KeyChar == '3')
                {
                    ui.EmptyMethod(tool3);
                    keyCheck = true;
                }
                else if(uiKey.KeyChar == '4')
                {
                    ui.ToolStart(tool4);
                    stat.Sum();
                    ui.ToolEnd();
                }
                else if(uiKey.KeyChar == '5')
                {
                    ui.ToolStart(tool5);
                    double molarMassSum = 0;
                    keyCheck = true;
                    Console.WriteLine("");
                    Console.Write("Number of elements present in the molecule: ");
                    int elNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    for(int i = 1; i <= elNum; i++)
                    {
                        Console.Write("Input chemical formula for element #{0} in molecule: ",i);
                        Element userElement = new Element(Console.ReadLine());
                        Console.WriteLine("");
                        Console.Write("Input number of atoms of element #{0} in molecule: ",i);
                        userElement.Atoms = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        molarMassSum += userElement.MolarMass();
                    }
                    Console.WriteLine("Molar Mass = {0}", molarMassSum);
                    ui.ToolEnd();
                }
                else if(uiKey.KeyChar == '6')
                {
                    ui.ToolStart(tool6);
                    keyCheck = true;
                    Console.Write("Type in Chemical Formula: ");
                    Element userElement= new Element(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("Chemical Name: ");
                    userElement.ChemName();
                    ui.ToolEnd();
                }
                else if(uiKey.KeyChar == '7')
                {
                    ui.ToolStart(tool7);
                    Console.Write("Enter Lower Bound: ");
                    int RminMain = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("Enter Upper Bound: ");
                    int RmaxMain = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    rng.Rando(RminMain, RmaxMain);
                    ui.ToolEnd();
                }
                else if(uiKey.KeyChar == '8')
                {
                    ui.ToolStart(tool8); 
                    rps.RPS(); 
                    ui.ToolEnd(); 
                }
                else if(uiKey.KeyChar == '9')
                {
                    ui.ToolStart(tool9);
                    kanye.QuoteGenerate();
                    ui.ToolEnd();
                }
                else if(uiKey.KeyChar == 't')
                {
                    Console.WriteLine("---Accepted");
                    Console.WriteLine("");
                    Console.WriteLine("You chose to exit");
                    keyCheck = true;
                    terminate = true;
                    //terminate is only true if t is pressed, the while loop is exited
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("---Not Accepted");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return to main menu");
                    Console.ReadKey();
                }
            }
            while(keyCheck == false);
        }
        Console.WriteLine("---------------------");
        Console.WriteLine("Press Any Key to Exit");
        Console.ReadKey();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Session End Date/Time: " + DateTime.Now);
        Console.WriteLine("------------------------------------------------");
    }
}