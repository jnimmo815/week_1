using sc = System.Console;

namespace Revature.Week1.HelloWord  //  namespace scope
{
  // class, struct, interface, enum only scopes available to the namespace

  class Program //  class scope
  {
    private static void Main()  //method scope
    {
      //  stdin to get your name
      sc.WriteLine("Enter your name:");
      // string in;
      var input = sc.ReadLine(); //  datatype inference 
      //  stdout to print your name
      sc.WriteLine($"Hello {input}"); //  string interpolation, template string
    }
    private void UiPath()
    {
      {   //  block scope            
      }

      {   //  block scope            
      }
    }
  }
}
