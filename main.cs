using System;

class TipCalculator
{
    public double billTotal;
    //billValue
    public double billNum;
    //pre-tax bill value
    public string billParse;
    public double tipRate = -1;
    public double tipValue = 0;
    ConsoleKeyInfo serviceKey;
    public void TipCalc()
    {
        Console.WriteLine("This tool calculates the Tip based on quality of service.");
        Console.WriteLine("How was the service today?");
        Console.WriteLine("1. Excellent!");
        //20% tip
        Console.WriteLine("2. Good");
        //15% tip
        Console.WriteLine("3. Okay");
        //10% tip
        Console.WriteLine("4. Poor");
        //0% tip
        Console.WriteLine("");
        do
        {
            serviceKey = Console.ReadKey();
            if(serviceKey.KeyChar == '1')
            {
                tipRate = 0.2;
            }
            else if(serviceKey.KeyChar == '2')
            {
                tipRate = 0.15;
            }
            else if(serviceKey.KeyChar == '3')
            {
                tipRate = 0.1;
            }
            else if(serviceKey.KeyChar == '4')
            {
                tipRate = 0;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("---Not Accepted");
                Console.WriteLine();
                Console.WriteLine("Choose from options 1 to 4.");
                Console.ReadKey();
            }
        }
        while(tipRate < 0);
        //if its set to any of the 4 rates it will exit the loop
        Console.WriteLine("---Accepted");
        Console.WriteLine("");
        Console.WriteLine("Enter Pre-tax Bill Value.");
        do
        {
            Console.WriteLine("");
            billParse = Console.ReadLine();
            if(double.TryParse(billParse, out billNum))
            {
                tipValue = billNum * tipRate;
                //tip is evaluated on pretax value
                billTotal = (tipValue + billNum * 1.13);
                //total = tip + bill pretax + tax
                Console.WriteLine("");
                Console.WriteLine("You should tip: ${0:f2}", tipValue);
                Console.WriteLine("Your total comes to: ${0:f2}", billTotal);
            }
            else
            {
                Console.WriteLine("Please input valid number.");
                //if it does not parse as a dobule, request valid input
            }
        }
        while(tipValue == 0);
        //exits loop if the the entered value is a numerical value
    }
}
class Statistic
{
    public double sum;
    //holds total sum of numerical values inputted
    public double sumNum;
    //contains the value read in
    public string sumParse;
    //string for ReadLine() for TryParse
    public void Sum()
    //yields the sum of a set of user inputted number
    {
        Console.WriteLine("This tool calculates the sum of numbers inputted. Enter each value individually and type end to terminate input.");
        do
        {
            sumParse = Console.ReadLine();
            if(double.TryParse(sumParse, out sumNum))
            //checks if the string sumParse parses as a double
            {

                sum += sumNum;
                //if it does parse as double, output to sumNum which is then added to sum
            }
            else if(sumParse == "end")
            {
                Console.WriteLine("");
                Console.Write("The Sum of the Inputted Values is: ");
            }
            else
            {
                Console.WriteLine("Please input valid number.");
                //if it does not parse as a dobule, request valid input
            }
        }
        while(sumParse != "end");
        //user must type end to terminate the program
        Console.Write(sum);
        sum = 0;
        //resets value so that if the sum function is used again in the same function it wont be additive
    }
}
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

class Program
{
    static void Main()
    {
        UserInterface ui = new UserInterface();
        TipCalculator tc = new TipCalculator();
        Statistic stat = new Statistic();

        DateTime now = DateTime.Now;

        ConsoleKeyInfo uiKey;
        bool keyCheck = false;
        bool terminate = false;
        string tool1 = "Tip Calculator";
        string tool2 = "Quadratic Formula";
        string tool3 = "Mean/Mode/Median Tool";
        string tool4 = "Sum Tool";
        
        while(terminate == false)
        //terminate's value only changes in the else if condition where 't' is pressed
        {
            do
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Choose the tool you want to use!");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. {0}", tool1);
                Console.WriteLine("2. {0}", tool2);
                Console.WriteLine("3. {0}", tool3);
                Console.WriteLine("4. {0}", tool4);
                Console.WriteLine("--------------------------------");
                //Console.WriteLine("");
                Console.WriteLine("Press t to Terminate Program");
                //Console.WriteLine("");
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
                    ui.EmptyMethod(tool2);
                    keyCheck = true;
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
    }
}