namespace BreakAndContinue
{
	class Program
	{
		static void Main(string[] args)
    {
      Console.WriteLine("For Loop with Break: ");
      breakLoop();

      Console.WriteLine("For Loop With Continue");
      continueLoop();


      Console.WriteLine("Program will exit in 5 seconds ...");
      System.Threading.Thread.Sleep(5000);
    } 

		public static void breakLoop ()
		{
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine(i);
        if (i == 3)
        {
          Console.WriteLine("We stop at 3");
          break;
        }
      }
    }

		public static void continueLoop () {
      for (int i = 0; i < 10; i++)
      {

        if (i % 2 == 0)
        {
          Console.WriteLine("This number is even.");
          continue;
        }
        Console.WriteLine(i);
      }
    }
	}
}