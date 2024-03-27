namespace GarageApp
{



    internal class Program
    {



        // ## DEFINES AND CONSTS ##
        const int exercise = 5; // the current exercise
        string input = null;
        bool quit = false;
        int result = 0;
        static string title = $"Lexicon 2024 .Net - Övning{exercise} (Garage)";


        // ENVIRONMENT AND DIRECTORY INFO
        static string CurrentWorkingDirectory = Environment.CurrentDirectory;
        static string SolutionFolder = Directory.GetParent(CurrentWorkingDirectory).Parent.Parent.Parent.FullName;
        static string MainProjectFolder = Directory.GetParent(CurrentWorkingDirectory).Parent.Parent.FullName;

        string[] directories = Directory.GetDirectories(SolutionFolder);
        static FileInfo[] fileList = Directory.GetParent(MainProjectFolder).GetFiles();
        string[] projectFiles = Directory.EnumerateFiles(MainProjectFolder).ToArray();


        static void Initialize()
        {
            ////initialize
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetWindowSize(800, 600);
            Console.Title = title;
        }


        static void Main(string[] args)
        {





           


            ////run



            foreach (FileInfo file in fileList) { Console.WriteLine(file); }


            //do
            //{
            //    /* start-loop */
            //    Console.WriteLine("** EXERCISE 5 - GARAGE **");
            //    Console.WriteLine("Enter Choice (0 to quit): ");

            //    input = Console.ReadLine();
            //    /* pause-loop */

            //    int.TryParse(input, out result);
            //    //result == 0 ? quit = true : quit = false;
            //    if (result == 0) { quit = true; }

            //    /* continue-loop */

            //    switch (result)
            //    {
            //        case 1:
            //            Console.WriteLine("Car Paint WHITE selected");
            //            Models.Vehicle v1 = new Car { vColor = Models.vColor.White };
            //            v1.Print();
            //            break;
            //        case 2:
            //            Console.WriteLine("Car Paint RED selected");
            //            Models.Vehicle v2 = new Car { vColor = Models.vColor.Red };
            //            v2.Print();
            //            break;
            //        case 3:
            //            Console.WriteLine("Car Paint BLUE selected");
            //            Models.Vehicle v3 = new Car { vColor = Models.vColor.Blue };
            //            v3.Print();
            //            break;
            //        case 4:
            //            Console.WriteLine("Car Paint GREEN selected");
            //            Models.Vehicle v4 = new Car { vColor = Models.vColor.Green };
            //            v4.Print();
            //            break;
            //        case 99:
            //            Console.WriteLine("99");
            //            break;
            //        default:

            //            Console.WriteLine("DEFAULT Car Paint BLACK selected");
            //            Models.Vehicle v = new Car { vColor = Models.vColor.Black };
            //            v.Print();
            //            break;

            //    }




            //    /* end-loop */
            //} while (!quit);



            ////close
            Console.In.Close();
            Console.In.Dispose();
            Console.Beep();
        }





    }







}
