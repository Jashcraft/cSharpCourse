using System;
namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Add());
      Console.Read();

    }





    public static void AskName()
    {
      string name = "";
      Console.WriteLine("What is your name?");
      name = Console.ReadLine();
      Console.WriteLine("is your name " + name + "?");
      Console.WriteLine("Press Enter to Exit!");
      Console.Read();
    }



    public static int Add()
    {
      Console.WriteLine("Please select a number");
      string num1input = Console.ReadLine();
      Console.WriteLine("Please select another number");
      string num2input = Console.ReadLine();

      int num1 = int.Parse(num1input);
      int num2 = int.Parse(num2input);

      int result = num1 + num2;
      return result;
    }

  }
}