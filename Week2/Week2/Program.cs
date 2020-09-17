using System;
using System.Threading;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            int getal;

            for (int i = 0; i < 10; i++) {
                result = 1;
                getal = i;
            
                Console.WriteLine("2 tot de macht " + i + " is " + result);
            }
            Console.ReadKey();

            int wgetal = 2;
            int tgetal = 0;
            while (tgetal < 10) ;
            {
                Console.WriteLine("2 tot de macht " + tgetal + " is " + wgetal);
            }
        }
    }
}
