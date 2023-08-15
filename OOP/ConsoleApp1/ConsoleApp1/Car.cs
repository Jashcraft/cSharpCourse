using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
  internal class Car
  {
    //Member variables
    private string _name; //private field typically used for storing data. 
    private int _hp;
    private string _status;
    private string _color;
    private int _year;
    //Constructor
    public Car(
      string name,
      int hp = 0,
      string status = "stopped",
      string color = "Black",
      int year = 1999
      )

    {
      Console.WriteLine(name + " was created!");
      _name = name;
      _hp = hp;
      _status = status;
      _color = color;
    }
    //Member Methods
    public void Drive()
    {
      Console.WriteLine(_name + " is driving!");
      _status = "driving";
    }
    public void Stop()
    {
      Console.WriteLine(_name + " has stopped!");
      _status = "stopped";
    }

    public void PrintStats()
    {
      Console.WriteLine("\n***Vehicle Stats***\n");
      Console.WriteLine("   Vehicle Name: " + _name);
      Console.WriteLine("   Vehicle Color: " + _color);
      Console.WriteLine("   Vehicle Year: " + _year);
      Console.WriteLine("   Vehicle Horsepower: " + _hp);
      Console.WriteLine("   Vehicle Status: " + _status);
    }

    public void Wreck()
    {
      Console.WriteLine(_name + " Wrecks!");
      _status = "wrecked";
    }

  }
}
