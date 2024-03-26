using Garage.Models;
using System;

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
            Console.Title = title;


            ////run

            do
            {
                /* start-loop */
                Console.WriteLine("** EXERCISE 5 - GARAGE **");
                Console.WriteLine("Enter Choice (0 to quit): ");

                input = Console.ReadLine();
                /* pause-loop */

                int.TryParse(input, out result);
                //result == 0 ? quit = true : quit = false;
                if (result == 0) { quit = true; }

                /* continue-loop */

                switch (result)
                {
                    case 1:
                        Console.WriteLine("Car Paint WHITE selected");
                        Vehicle v1 = new Car { color = carPaint.White };
                        v1.Print();
                        break;
                    case 2:
                        Console.WriteLine("Car Paint RED selected");
                        Vehicle v2 = new Car { color = carPaint.Red };
                        v2.Print();
                        break;
                    case 3:
                        Console.WriteLine("Car Paint BLUE selected");
                        Vehicle v3 = new Car { color = carPaint.Blue };
                        v3.Print();
                        break;
                    case 4:
                        Console.WriteLine("Car Paint GREEN selected");
                        Vehicle v4 = new Car { color = carPaint.Green };
                        v4.Print();
                        break;
                    case 99:
                        Console.WriteLine("99");
                        break;
                    default:
                    
                        Console.WriteLine("DEFAULT Car Paint BLACK selected");
                        Vehicle v = new Car { color = carPaint.Black };
                        v.Print();
                        break;
                        
                }




                /* end-loop */
            } while (!quit);



            ////close
            Console.In.Close();
            Console.In.Dispose();
            Console.Beep();
        }
    }
}
