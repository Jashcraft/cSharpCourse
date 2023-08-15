using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
  internal class Car
  {
    //Constructor
    public Car()
    {
      Console.WriteLine("Car was created!");
    }
    //Methods on class.
    public void Drive()
    {
      Console.WriteLine("Car is driving!");
    }
    public void Stop()
    {
      Console.WriteLine("Car has stopped!");
    }
  }
}
