using System;
using System.Diagnostics;

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