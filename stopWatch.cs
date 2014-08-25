using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
	ConsoleKeyInfo watchKey;
	Stopwatch stopwatch = new Stopwatch();
	// Create new stopwatch

	stopwatch.Start();
	// Begin timing

	// Do something
	do
	{
	    Console.Write("\r{0}", stopwatch.Elapsed);
	    //This \r makes it write each timestamp on the beginning of the line
	    //It appears as if its a dynamic clock but its just printing
	    //a new time on the same line each time it loops
	    Thread.Sleep(1);
	    Console.ReadKey();
	}
	while(watchKey.KeyChar != 's');

	// Stop timing
	stopwatch.Stop();

	// Write result
	Console.WriteLine("Time elapsed: {0}",
	    stopwatch.Elapsed);
	Console.ReadLine();
    }
}