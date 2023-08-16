namespace MultiArrays
{
  class Program
  {
    static void Main(string[] args)
    {
      //declare 2d array
      string[,] matrix;

      // 3D array
      int[,,] threeD;


      //two dimensional array
      int[,] array2D = new int[,]
      {
        {1, 2, 3 }, //row 0
        {4, 5, 6 }, //row 1
        {7, 8, 9 }  //row 2 
      };
      Console.WriteLine("Central value is: {0}", array2D[1, 1]);

      int dimensions = array2D.Rank;

      Exit();
    }
    public static void Exit()
    {
      Console.WriteLine("Program will exit in 4 seconds...");
      System.Threading.Thread.Sleep(4000);
    }
  }
}