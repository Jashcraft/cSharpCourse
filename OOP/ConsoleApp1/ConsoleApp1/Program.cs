using ClassesAndObjects;


namespace ClassesAndObjects
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Car audi = new Car("Audi",75);
      Car bmw = new Car("BMW", 350);
      audi.PrintStats();
      bmw.PrintStats();
      audi.Drive();
      bmw.Drive();



      Console.WriteLine("Press 1 to stop audi.");
      Console.WriteLine("Press 2 to stop bmw.");
      string userInput = Console.ReadLine();

      switch (userInput)
      {
        case "1":
          audi.Stop(); break;
        case "2":
          bmw.Stop(); break;
        default:
          audi.Wreck();
          bmw.Wreck();
          break;
      }
      audi.PrintStats();
      bmw.PrintStats();




      Exit();

    }

    public static void Exit()
    {
      Console.WriteLine("Program will exit in 5 seconds...");
      System.Threading.Thread.Sleep(5000);
    }
  }
}