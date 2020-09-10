
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Schema;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {

            ////opdracht A
            //string name = "Tom";
            //Console.WriteLine(name);

            ////opdracht B:
            //Console.ReadKey();
            //string variable1 = "c ";
            //int nummer1 = 123;
            //double nummer2 = 1.5;
            //bool status = false;
            //double rest = nummer1 % nummer2;
            //string spatie = " ";

            //Console.WriteLine("Hello " + name);
            //Console.WriteLine(variable1 + nummer1);
            //Console.WriteLine(nummer2 + spatie + status);
            //Console.WriteLine(rest);
            //Console.ReadLine();

            //Voorbeeld Mark opdracht B:
            //string naam;
            //char variable1;
            //int nummer1;
            //double nummer2, rest;
            //bool status;

            //naam = Console.ReadLine();
            //variable1 = 'c';
            //nummer1 = 123;
            //nummer2 = 1.5;
            //status = false;
            //rest = nummer1 % nummer2;

            //Console.WriteLine($"Hello {naam}.\n" +
            //    $"{variabele1} {nummer1}\n" +
            //    $"{nummer2} {status}\n" +
            //    $"Rest = {rest}");

            ////opdracht C
            //Console.ReadKey();
            //Console.Clear();
            //Console.WriteLine("Geef een temperatuur in Celsius");
            //int temperature = Convert.ToInt32(Console.ReadLine());
            //string fah = " Fahrenheit";
            //Console.WriteLine(temperature * 1.8 + 32 + fah);

            //voorbeeld mark opdracht C
            //int temperatuurcelsius;
            //double temperatuurfahrenheit;

            //Console.Write("Geef een temperatuur in Celsius");

            //temperatuurcelsius = Convert.ToInt16(Console.ReadLine());
            //temperatuurfahrenheit = (temperatuurcelsius * 1.8) + 32;

            //Console.WriteLine($"Dit is {temperatuurfahrenheit} graden Fahrentheit");

            //Console.ReadKey();

            //Euro omrekenen in USD:

            //Console.ReadKey();
            //Console.Clear();
            //Console.WriteLine("Voer in hoeveel euro je wilt omrekenen");
            //string eu = " Euro is ";
            //string us = " USD";
            //decimal usdollar = 1.16M;
            //int euro = Convert.ToInt32(Console.ReadLine());
            //decimal usd = euro * usdollar;
            //Console.WriteLine(euro + eu + usd + us);
            //Console.ReadKey();

            //opdracht D
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Bent u een man of vrouw?");
            string persoon = Console.ReadLine();
            if (persoon == "man")
            {
                Console.WriteLine("Wat is uw lenge in cm?");
                int lengteman = Convert.ToInt32(Console.ReadLine());
                double ideaalgewichtman = (lengteman - 100) * 0.9;
                Console.WriteLine("Je ideale gewicht is: " + ideaalgewichtman + " kg");
            }
            if (persoon == "vrouw")
            {
                Console.WriteLine("Wat is uw lengte in cm?");
                int lengtevrouw = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wat is uw polsomtrek?");
                int polsomtrekvrouw = Convert.ToInt32(Console.ReadLine());
                int ideaalgewichtvrouw = (lengtevrouw + 4 * polsomtrekvrouw - 100) / 2;
                Console.WriteLine("Je ideale gewicht is: " + ideaalgewichtvrouw + " kg");

            }
            else
            {
                Console.WriteLine("Je hebt een verkeerd antwoord ingevoerd!");
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("What language do you speak?: nl, en, fr, de, sp");
            string taal = Console.ReadLine();
            if (taal == "nl")
            {
                Console.WriteLine("Tot ziens");
            }
            if (taal == "en")
            {
                Console.WriteLine("Goodbye");
            }
            if (taal == "de")
            {
                Console.WriteLine("Auf wiedersehen");
            }
            if (taal == "fr")
            {
                Console.WriteLine("Aurevoir");
            }
            if (taal == "sp")
            {
                Console.WriteLine("Adios");
            }
            Console.ReadKey();
        }
    }
}