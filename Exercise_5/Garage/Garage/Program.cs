using System;
using System.ComponentModel;
using System.Net.Security;

namespace Garage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int exercise = 5; // the current exercise
            string input = null;
            bool quit = false;
            int result = 0;
            string title = $"Lexicon 2024 .Net - Övning{exercise} (Garage)";

            ////initialize
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetWindowSize(800, 600);
            //Console.Title = title;


            ////run

            do
            {
            Console.WriteLine("** EXERCISE 5 - GARAGE **");
            Console.WriteLine("Enter Choice (0 to quit): ");

            input = Console.ReadLine();
            //pause
            //    .
            //    .
            //    .
            //continue
            int.TryParse(input, out result);
            //    //result == 0 ? quit = true : quit = false;
            if (result == 0) { quit = true; }           

            } while (!quit);

                                  

            ////close
            Console.In.Close();
            Console.In.Dispose();
            Console.Beep();
        }
    }
}
