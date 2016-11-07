using static System.Console;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = LogicS.BinarySearch.find(new []{1,2,3,4}, 5);
 
            WriteLine(x);
            ReadKey();
        }
    }
  
}


