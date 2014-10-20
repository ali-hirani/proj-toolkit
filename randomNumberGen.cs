using System;
using System.Diagnostics;

class RandomNumberGen
{
    public int rn = 0;
    public void Rando(int Rmin, int Rmax)
    {
       Random rn = new Random();
       Console.WriteLine("Your Randomly Generated Number Within the Bounds is: " + rn.Next(Rmin, Rmax + 1)); 
       //Rmax + 1 makes it inclusive of the user's inputs
       //Therefore Rmin = 5, Rmax = 6 can yield 5 or 6
    }
}