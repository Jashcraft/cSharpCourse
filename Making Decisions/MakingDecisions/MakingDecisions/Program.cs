using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
      //judgeTemperature();
      judgeTempRefactor();


      Console.WriteLine("Please press ENTER to exit:");
			Console.Read();
    }

    public static void judgeTemperature()
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
    }
    public static void judgeTempRefactor()
    {
      int temp = 0;

      Console.WriteLine("What is the temperature outside ?: ");
      string userInput = Console.ReadLine();
      temp = int.Parse(userInput);

      if (temp < 30)
      {
        Console.WriteLine("It's Freezing! Go play outside!");

      } else if (temp < 60)
      {
        Console.WriteLine("It's Chilly Outside!");
      } else if (temp < 80)
      {
        Console.WriteLine("It's perfect outside! Take the day off work!");
      } else if (temp < 90)
      {
        Console.WriteLine("It's warm outside be carfeul!");
      } else
      {
        Console.WriteLine("It's too hot outside");
      }

    }
  }
}