using System;
namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
      AskName();

    }





    public static void AskName()
    {

      Console.WriteLine("What is your name?");
      string name = Console.ReadLine();
      Console.WriteLine("is your name " + name + "?");
      Console.WriteLine("Press Enter to Exit!");
      Console.Read();
    }



    public static int Minus(int num1, int num2)
    {
      int value = num1 - num2;
      return value;
    }

  }
}