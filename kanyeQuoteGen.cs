using System;
using System.IO;

class KanyeQuoteGen
{
	public int lineNum = 0;
	public string[] quotes = new string[99];
	public int kanye = 0;
	StreamReader reader;
	bool ran = false;

	public void QuoteGenerate()
	{
		Random ranKanye = new Random();
		kanye = ranKanye.Next(0, 100);

		if(ran == false)
		{
			using (reader = new StreamReader("kanye.txt"))
			{
				while(!reader.EndOfStream)
				{
					quotes [lineNum] = reader.ReadLine();
					lineNum ++;
				}
			}
			reader.Dispose();
		}
		Console.WriteLine(quotes[kanye]);
		ran = true;
	}
}