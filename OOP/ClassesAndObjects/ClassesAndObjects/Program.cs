using ClassesAndObjects;


namespace ClassesAndObjects
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Car myCar = new Car();
      myCar.Name = "My Volvo";

      Console.WriteLine("Name: " + myCar.Name + "\nTopSpeed: " + myCar.TopSpeed);


      Exit();

    }

    public static void Exit()
    {
      Console.WriteLine("Program will exit in 5 seconds...");
      System.Threading.Thread.Sleep(5000);
    }
  }
}