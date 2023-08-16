using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersC
{
  internal class Members
  {
    //member private field
    private string _memberName;
    private string _jobTitle;
    private int _salary = 20000;

    //member public field
    public int age;

    //member properties - Start with Capital letter
    public string JobTitle
    {
      get
      {
        return jobTitle;
      }
      set
      {
        jobTitle = value;
      }
    }

    // public member method - can be called from other classes
    public void Introducing(bool isFriend)
    {
      if (isFriend)
      {
        SharingPrivateInfo();
      }
      else
      {
        Console.WriteLine("hi, my name is {0}, and my job is {1}. I'm {2} years old", _memberName, _jobTitle, age);
      }
    }

    // private member method
    private void SharingPrivateInfo()
    {
      Console.WriteLine("Hi my salary is " + _salary);
    }

    //members constructor
    public Members()
    {
      age = 30;
      _memberName = "steve";
      _jobTitle = "dev";
      _salary = 70000;
      Console.WriteLine("Member Created");
    }

    // member finalizer - deconstructor
    ~Members()
    {
      //clean up statements
      Console.WriteLine("deconstruction of members object");
    }

  }
}
