using System.Security.Cryptography.X509Certificates;

namespace EnhancedIf
{
	class Program
	{
		static void Main(string[] args)
		{
			int temperature = -5;
			string stateOfMatter;

			if (temperature < 32)
			{
				stateOfMatter = "Solid";
			}
			else
			{
				stateOfMatter = "Liquid";
			}

			Console.WriteLine("State of matter is {0}", stateOfMatter);
			Console.Read();



		}

    public static void enhancedIf()
    {
			string stateOfWater;
			int temp = 12;
			stateOfWater = temp < 32 ? "Solid" : "Liquid";
    }
  }
}