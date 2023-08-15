using ClassesAndObjects;


namespace ClassesAndObjects
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Car audi = new Car();
      Car bmw = new Car();
      audi.Drive();



      Console.WriteLine("Press 1 to stop car.");
      string userInput = Console.ReadLine();
      if (userInput == "1")
      {
        audi.Stop();
      }
      else
      {
        Console.WriteLine("Car wrecks!");
      }



      Exit();

    }

    public static void Exit()
    {
      Console.WriteLine("Program will exit in 5 seconds...");
      System.Threading.Thread.Sleep(5000);
    }
  }
}