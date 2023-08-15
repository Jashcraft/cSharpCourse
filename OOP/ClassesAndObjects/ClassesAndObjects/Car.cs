using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
  internal class Car
  {
    //*************************************************************//
    #region Private Member Variables

    private string _name;
    private int _hp;
    private string _status;
    private string _color;
    private int _year;
    private int _TopSpeed;
    #endregion
    //*************************************************************//
    #region Constructors
    //Default Constructor
    public Car()
    {
      _name = "Car";
      _hp = 125;
      _year = 1999;
      _color = "Black";
      _status = "stopped";
      _TopSpeed = 30;
    }

    //Partial Specific Constructor
    public Car(string name, int hp)

    {
      Console.WriteLine(name + " was created with " + hp + " horsepower!");
      _name = name;
      _hp = hp;
      _status = "Stopped";
      _color = "Black";
      _year = 1999;
    }

    // Specific Constructor

    public Car(string name, string color, int hp, int year)
    {
      _name = name;
      _color = color;
      _hp = hp;
      _year = year;
      _status = "stopped";
    }
    #endregion
    //*************************************************************//
    #region Public Member Methods
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
    #endregion
    //*************************************************************//
    #region Public Properties

    public string Name
    {
      get { return _name; } //get accessor
      set
      {
        if (value == "")
        {
          _name = "DEFAULTCARNAME";
        }
        else
        {
          _name = value;
        }
      } //set accessor
    }

    public int TopSpeed
    {
      set
      {
        _TopSpeed = value;
      }
    }


    #endregion
    //*************************************************************//

  }
}
