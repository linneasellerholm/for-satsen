using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_satsen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            for (int x = 0; x < 101; x++)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();

            //Övning 2
            for (int x = 20; x > 0; x--)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
            //Övning 3
            for (int i = 0; i < 50; i=i+2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
