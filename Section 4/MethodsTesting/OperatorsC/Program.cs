namespace OperatorsC
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1 = 5;
			int num2 = 10;
			int num3;
			bool isSunny = false;
			int num = 0;

			//unary operators
			num3 = -num1;
			Console.WriteLine("num3 is {0}", num3);
            Console.WriteLine("is it sunny? {0}", isSunny);

			//increment operators

			num++;
			Console.WriteLine("num is now {0}", num);
			//Pre-increment
			Console.WriteLine("num is now {0}", ++num);
			//post increment
			Console.WriteLine("num is still {0}", num++);
			Console.WriteLine("but now num is {0}", num);

			//pre and post increment works with -- as well


			Console.Read();

		}
	}
}