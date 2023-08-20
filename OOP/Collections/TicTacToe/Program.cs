class Program
{

  static char[,] fieldData =
  {
      {'1', '2', '3' },
      {'4', '5', '6' },
      {'7', '8', '9' }
  };

  static void Main()
  {


    DrawField();
    Exit();
  }

/// <summary>
/// Field Drawing Section
/// </summary>
  public static void DrawField()
  {
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |  {2}  ", fieldData[0,0], fieldData[0,1], fieldData[0,2]);
    Console.WriteLine("_____|_____|_____");
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |  {2}  ", fieldData[1, 0], fieldData[1, 1], fieldData[1, 2]);
    Console.WriteLine("_____|_____|_____");
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |  {2}  ", fieldData[2, 0], fieldData[2, 1], fieldData[2, 2]);
    Console.WriteLine("     |     |     ");

  }
  public static void Exit()
  {
    Console.WriteLine("\nProgram will exit in 4 seconds...");
    System.Threading.Thread.Sleep(4000);
  }

}