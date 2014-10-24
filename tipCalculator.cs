using System;
using System.Diagnostics;

class TipCalculator
{
    //billValue
    public double billTotal;

    //pre-tax bill value
    public double billNum;
    public string billParse;
    public double tipRate = -1;
    public double tipValue = 0;
    public double custTipRate = -1;
    ConsoleKeyInfo serviceKey;
    public void TipCalc()
    {
        Console.WriteLine("This tool calculates the Tip based on quality of service.");
        Console.WriteLine("How was the service today?");
        Console.WriteLine("");
        Console.WriteLine("1. Excellent!");     //20% tip
        Console.WriteLine("2. Good");           //15% tip
        Console.WriteLine("3. Okay");           //10% tip
        Console.WriteLine("4. Poor");           //0% tip
        Console.WriteLine("5. Custom");         //Custom tip amount
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
            else if(serviceKey.KeyChar == '5')
            {   
                  Console.WriteLine("---Accepted");
                  Console.Write("Please enter a custom tip amount in percent: ");
                  custTipRate = (Double.Parse(Console.ReadLine()))/100;  
                while(custTipRate < 0)
                {
                    Console.WriteLine("Please try again");
                    custTipRate = (Double.Parse(Console.ReadLine()))/100; 

                }     
            }
            else
            {
                Console.WriteLine("---Not Accepted");
                Console.WriteLine();
                Console.WriteLine("Choose from options 1 to 5.");
                Console.WriteLine();
            }
        }
        while(tipRate < 0 && custTipRate < 0);
        //if its set to any of the 4 rates, or the custRate, it will exit the loop
        
        if(tipRate >= 0)
        //for formatting purposes
        {
            Console.WriteLine("---Accepted");
            Console.WriteLine("");
        }
        else if(custTipRate > 0)
        //for formatting purposes
        {
            Console.WriteLine("");
        }
        
        Console.Write("Enter Pre-tax Bill Value: ");    
        do
        {
            Console.WriteLine("");
            billParse = Console.ReadLine();
            if(double.TryParse(billParse, out billNum))
            {
                if(tipRate >= 0)
                {
                    tipValue = billNum * tipRate;
                    //tip is evaluated on pretax value
                    billTotal = (tipValue + billNum * 1.13);
                    //total = tip + bill pretax + tax
                    Console.WriteLine("");
                    Console.WriteLine("You should tip: ${0:f2}", tipValue);
                    Console.WriteLine("Your total comes to: ${0:f2} including tax.", billTotal);
                }
                if(custTipRate > 0)
                {
                    tipValue = billNum * custTipRate;
                    //tip is evaluated on pretax value
                    billTotal = (tipValue + billNum * 1.13);
                    //total = tip + bill pretax + tax
                    Console.WriteLine("");
                    Console.WriteLine("You should tip: ${0:f2}", tipValue);
                    Console.WriteLine("Your total comes to: ${0:f2} including tax. ", billTotal);
                }
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