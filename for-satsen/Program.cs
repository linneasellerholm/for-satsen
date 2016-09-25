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
        {/*
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
            

            //Övning 1
            Console.Write("Mata in start:");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Mata in stop:");
            int stopp = int.Parse(Console.ReadLine());
            Console.Write("Mata in steg:");
            int steg = int.Parse(Console.ReadLine());

            var x = start;
            var y = stopp;
            var z = steg;

            for (start=x; x < y; x = x + z) 
            {
                Console.WriteLine(x); 

            //Övning 3
            Console.Write("Mata in ett heltal:");
            int tal = int.Parse(Console.ReadLine());

            var summa = 0;

            for (int x = 0; x <= tal; x++)
            {
                summa = summa + x;
                if (x==tal)
                {
                    Console.WriteLine(summa);
                }
                
            }
            //Övning 4
            Console.Write("Mata in ett heltal:");
            int tal = int.Parse(Console.ReadLine());

            var x = 1;

            if (tal < 21)
                Console.WriteLine("Hittade inga tal");

            else
            {
                for (int y = tal; x <= tal; x++)
                {
                    if (x % 7 == 0 && x % 3 == 0)
                    {
                        Console.WriteLine("Talet " + x + " är delbart med både 3 och 7");
                    }
                }
          
            }
            
            //Övning 5
            Console.Write("Mata in hur många tal i Fibonaccis talföljd du vill se: ");
            int antal = int.Parse(Console.ReadLine());

            var a = 0;
            var b = 1;
            if (antal == 0)
                Console.WriteLine("?");
            else
            {
                Console.WriteLine("1");
                for (int x = 0; x < antal - 1; x++)
                {
                    var c = a + b;
                    Console.WriteLine(c);
                    a = b;
                    b = c;

                }
            }
            Console.ReadKey();
            
            //Övning 6

            Console.Write("Mata in ett tal: ");
            int tal = int.Parse(Console.ReadLine());
            for (double x = 0; x < tal; x = x+0.1)
            {
                if (x * x * x >= tal) //GER KUBIKROT AV 125 = 5.1 (???)
                {
                    Console.WriteLine(x);
                    break;
                }
            }
            Console.ReadKey();
            */
            //Övning 7

            Console.Write("Ange ett tal som ska undersökas: ");
            int tal = int.Parse(Console.ReadLine());
            for (int i = 2; i < tal; i++)
            {
                if (tal % i == 0)
                {
                    Console.WriteLine("Inte ett primtal");
                    break;
                }
            } //FIXA SÅ ATT SKRIVER UT NÄR PRIMTAL
            
        
    }
    }
}
