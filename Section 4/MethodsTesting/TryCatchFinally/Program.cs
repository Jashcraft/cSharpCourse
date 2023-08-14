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
      catch(ArgumentNullException) 
      {
        Console.WriteLine("ArgumentNulllException: Value was Null/Empty");
      }finally 
      {
        Console.WriteLine("This is called anyways...");
      };



      Console.ReadKey();
    }
  }
}