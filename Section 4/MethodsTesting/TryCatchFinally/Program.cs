using System.Linq.Expressions;

namespace TryCatchFinally
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please Enter a number");
      string userInput = Console.ReadLine();


      try
      {
        //some methods will tell you the possible exceptions when you hover over them.
        int userInputAsInt = int.Parse(userInput);
      }
      catch (FormatException)
      {

        Console.WriteLine("Format Exception, Please enter a number next time");
      }
      catch (OverflowException)
      {
        Console.WriteLine("OverFlow Exception: Number to was too small or too large for an INT 32");
      }
      catch (ArgumentNullException)
      {
        Console.WriteLine("ArgumentNulllException: Value was Null/Empty");
      }
      finally
      {
        Console.WriteLine("This is called anyways...");
      };


      divideByZero();
      Console.ReadKey();
    }

    public static void divideByZero()
    {
      Console.WriteLine("Please Choose A Number for division:");
      string input1 = Console.ReadLine();
      Console.WriteLine("Please Choose another number for division:");
      string input2 = Console.ReadLine();

      int div1 = int.Parse(input1);
      int div2 = int.Parse(input2);

      int division = div1 / div2;

      Console.WriteLine(division);

    }

  }
}