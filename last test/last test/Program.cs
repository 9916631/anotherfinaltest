using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace last_test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("guess bird, duck chick or sparrow");

            string input = Console.ReadLine();
            switch (input)
            {
                case "duck":
                case "chick":
                    Console.WriteLine("Wrong");
                    break;
                default:
                case "sparrow":
                    Console.WriteLine("You got it right");
                    break;
                  
            }
            Console.ReadLine();

        }
    }
}
