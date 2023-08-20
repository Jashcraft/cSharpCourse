

class Program
{
  static int[,] matrix =
{
  {1,2,3 },
  {4,5,6},
  {7,8,9 }
};

  static void Main()
  {
    foreach (var item in matrix)
    {
      Console.Write(item + " ");
    }


    Console.WriteLine("This is our 2D array printed using a nested for loop");
    //outer for loop
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      //inner for loop
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        int value = matrix[i, j];
        if (value % 2 == 0)
        {
          Console.WriteLine(matrix[i, j] + " ");
        }

      }
    }

    Exit();
  }
  public static void Exit()
  {
    Console.WriteLine("\nProgram will exit in 4 seconds...");
    System.Threading.Thread.Sleep(4000);
  }

}
