using System;

class Statistic
{
    public double sum;
    public double num;
    public string temp;
    public void Sum()
    //yields the sum of a set of user inputted number
    {
        do
        {
            temp = Console.ReadLine();
            if(double.TryParse(temp, out num))
            //checks if the string 'temp' parses as a double
            {
                sum += num;
                //if it does add it to sum
            }
            else if(temp == "end")
            {
                Console.WriteLine("");
                Console.Write("The Sum of the Inputted Values is: ");
            }
            else
            {
                Console.WriteLine("Please input valid number.");
                //if it does not request valid input
            }
        }
        while(temp != "end");
        //user must type end to terminate the program
        Console.Write(sum);
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
        Statistic stat = new Statistic();

        ConsoleKeyInfo info;
        bool keyCheck = false;
        bool terminate = false;
        string tool1 = "Tip Calculator";
        string tool2 = "Quadratic Formula";
        string tool3 = "Mean/Mode/Median Tool";
        string tool4 = "Sum";
        while(terminate == false)
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
                Console.WriteLine("Press t to Terminate Program");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("");
                info = Console.ReadKey();
                if(info.KeyChar == '1')
                {
                    ui.EmptyMethod(tool1);
                    keyCheck = true;
                }
                else if(info.KeyChar == '2')
                {
                    ui.EmptyMethod(tool2);
                    keyCheck = true;
                }
                else if(info.KeyChar == '3')
                {
                    ui.EmptyMethod(tool3);
                    keyCheck = true;
                }
                else if(info.KeyChar == '4')
                {
                    ui.ToolStart(tool4);
                    stat.Sum();
                    ui.ToolEnd();
                }
                else if(info.KeyChar == 't')
                {
                    Console.WriteLine("---Accepted");
                    Console.WriteLine("");
                    Console.WriteLine("You chose to exit");
                    keyCheck = true;
                    terminate = true;
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