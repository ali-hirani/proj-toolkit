using System;
using System.Diagnostics;

class RockPaperScissors
{
    public string rpsRan; 
    public int rpsRando; 
    public string rpsUser; 

    public void RPS()
    {
        Random rpsvariable = new Random(); 
        rpsRando = rpsvariable.Next(100);

        ConsoleKeyInfo rpsKey;

        if(rpsRando <= 33)
        {
            rpsRan = "rock"; 
        }
        else if(rpsRando <= 67)
        {
            rpsRan = "paper"; 
        }
        else
        {
            rpsRan = "scissors"; 
        }

        Console.WriteLine("Do you choose rock, paper or scissors?");
        Console.WriteLine("");
        Console.WriteLine("1. Rock");
        Console.WriteLine("2. Paper");
        Console.WriteLine("3. Scissors");
        Console.WriteLine("");
        
        do
        {
            rpsKey = Console.ReadKey();
            if(rpsKey.KeyChar == '1')
            {
                rpsUser = "rock";
                Console.WriteLine("---Accepted");
            }
            else if(rpsKey.KeyChar == '2')
            {
                rpsUser = "paper"; 
                Console.WriteLine("---Accepted");
            }
            else if(rpsKey.KeyChar == '3')
            {
                rpsUser = "scissors";
                Console.WriteLine("---Accepted");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        while(rpsKey.KeyChar != '1' && rpsKey.KeyChar != '2' && rpsKey.KeyChar != '3');

        Console.WriteLine("");

        if(rpsUser == "rock" && rpsRan == "scissors" )
        {
            Console.WriteLine("User: Rock vs. Bot: Scissors");
            Console.WriteLine("Winner!");
        }
        else if(rpsUser == "scissors" && rpsRan == "rock")
        {
            Console.WriteLine("User: Scissors vs. Bot: Rock"); 
            Console.WriteLine("Defeat!");
        }
        else if(rpsUser == "paper" && rpsRan == "scissors")
        {
            Console.WriteLine("User: Paper vs. Bot: Scissors");
            Console.WriteLine("Defeat!");
        }
        else if(rpsUser == "scissors" && rpsRan == "paper")
        {
            Console.WriteLine("User: Scissors vs. Bot: Paper"); 
            Console.WriteLine("Winner!"); 
        }
        else if(rpsUser == rpsRan)
        //draw case
        {
            Console.WriteLine("It's a Draw!"); 
            if(rpsUser == "scissors")
            {   
                Console.WriteLine("User: Scissors vs. Bot: Scissors "); 
            }
            else if(rpsUser == "paper")
            {
                Console.WriteLine("User: Paper vs. Bot: Paper "); 
            }
            else 
            {
                Console.WriteLine("User: Rock vs. Bot: Rock "); 
            }
            
        }
        else if(rpsUser == "rock" && rpsRan == "paper")
        {
            Console.WriteLine("User: Rock vs. Bot: Paper "); 
            Console.WriteLine("Defeat!"); 
        }
        else if(rpsUser == "paper" && rpsRan == "rock")
        {
            Console.WriteLine("User: Paper vs. Bot: Rock"); 
            Console.WriteLine("Winner!"); 
        }
    }
}