namespace Arrays
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = new int[10];
      for (int i = 0; i < nums.Length; i++)
      {
        nums[i] = i;

      }

      for (int j = 0; j < nums.Length; j++)
      {
        Console.WriteLine("Element{0} = {1}", j, nums[j]);
      }

      int counter = 0;
      foreach (int item in nums)
      {
        Console.WriteLine("Element{0} = {1}", counter, item); counter++;
      }

      Exit();
    }
    public static void Exit()
    {
      Console.WriteLine("Program will exit in 4 seconds...");
      System.Threading.Thread.Sleep(4000);
    }


  }
}