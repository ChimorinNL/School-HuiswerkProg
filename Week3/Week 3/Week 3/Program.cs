using System;

namespace Week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] myFamily = new string[5];
            //myFamily[0] = "Jerry";
            //myFamily[1] = "Beth";
            //myFamily[2] = "Summer";
            //myFamily[3] = "Morty";
            //myFamily[4] = "Rick";

            //string[] Family = new string[5]( "Jerry", "Beth", "Summer", "Morty", "Rick" );

            Console.ReadKey();

            string[] family = new string[5];
            Console.WriteLine("Writeline in loop");
            for (int i = 0; i < family.Length; i++) ;
            {
                Console.WriteLine(family[i]);
            }

            //ARRAYS 3
            int[] getallen = new int[10];
            getallen[0] = 42;
            getallen[4] = 41;

            for (int i = 0; i < getallen.Length; i++) ;
            {
                Console.WriteLine(getallen[i]);
            }
            Console.ReadKey();
        }
    }
}
