using System;

namespace TryParse
{
  class Program
  {
    static void Main(string[] args)
    {

      init();

      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("\nProgram Complete! Closing automatically in 5 seconds...");
      System.Threading.Thread.Sleep(5000);
    }

    public static void parseExample()
    {
      Console.WriteLine("Choose a number to parse:");
      string numberAsString = Console.ReadLine();


      int parsedValue;
      bool success = int.TryParse(numberAsString, out parsedValue);
      if (success)
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nParsing Successful! Number saved is: {0}", parsedValue);
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Parsing FAILED: Check input data below:\n");
        Console.WriteLine("'" + numberAsString + "'");
      }

    }

    public static void init()
    {
      Console.WriteLine("Enable floating point (decimals) (y/n)?");
      string userInput = Console.ReadLine();
      bool floatingEnabled = false;

      if (userInput == "y")
      {
        floatingEnabled = true;
        Console.WriteLine("\nFloating Enabled!");
      }
      else if (userInput == "n")
      {
        Console.WriteLine("\nFloating Disabled!");
        floatingEnabled = false;
      }
      else
      {
        Console.WriteLine("\nOption not understood, Floating Disabled.");
        floatingEnabled = false;
      }

      if (floatingEnabled)
      {
        parseFloatingEnabled();
      }
      else
      {
        parseExample();
      }
      
    }

    public static void parseFloatingEnabled()
    {
      Console.WriteLine("Choose a number to parse (decimals allowed):");
      string numberAsString = Console.ReadLine();


      float parsedValue;
      bool success = float.TryParse(numberAsString, out parsedValue);
      if (success)
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nParsing Successful! Number saved is: {0}", parsedValue);
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Parsing FAILED: Check input data below:\n");
        Console.WriteLine("'" + numberAsString + "'");
      }
    }

  }
}