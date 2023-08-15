namespace Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			basicForLoop();
			doWhileLoop();
			calcStringLength();




			Console.WriteLine("Program will exit in 5 seconds ...");
			System.Threading.Thread.Sleep(5000);
		}

		public static void basicForLoop()
		{

			Console.WriteLine("Basic For Loop");
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
			}
		}

		public static void doWhileLoop()
		{
			Console.WriteLine("Do While Loop");
			int counter = 0;
			do
			{
				// This will run once at least 
				Console.WriteLine(counter);
				counter++;

				//make sure these loops do END at some point.
			} while (counter < 10);
		}

		public static void calcStringLength()
		{
			int lengthOfString = 0;
			string wholeText = "";

			do
			{
				Console.WriteLine("Write the name of a friend:");
				string name = Console.ReadLine();
				int currentLength = name.Length;
				lengthOfString += currentLength;
				wholeText += name;
			} while (lengthOfString < 20);

		}

	}
}