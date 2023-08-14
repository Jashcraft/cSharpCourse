using System;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			int temperature = 60;


			Console.WriteLine("What is the temperature outside ?:");

			string userInput = Console.ReadLine();

			temperature = int.Parse(userInput);
			if (temperature < 50)
			{
				Console.WriteLine("It is chilly outside");
			}
			if (temperature < 80 && temperature > 60)
			{
				Console.WriteLine("It's perfect outside!");
			}
			if (temperature < 90 && temperature > 80)
			{
				Console.WriteLine("It's warm outside");
			}
			if (temperature > 90)
			{
				Console.WriteLine("It is too hot outside");
			}



			Console.Read();
		}
	}
}