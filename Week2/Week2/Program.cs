using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 ==0)
                    Console.WriteLine("Hello World!");
            }
            Console.ReadKey();

            int teller = 0;
            while (teller < 10)
            {
                Console.WriteLine("Dobby" + teller);
                teller++;

            }
            Console.ReadKey();

            bool asleep = true;
            while (asleep)
            {
                Console.WriteLine("Ben je al wakker?");
                asleep = Console.ReadLine() != "ja";
            }
            Console.WriteLine("Mooi dat je wakker bent!");
            Console.ReadKey();
        }
    }
}
