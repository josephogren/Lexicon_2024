using Garage8.Interfaces;
using GarageApp.Handlers;
using GarageApp.Models;
using System.Net.Quic;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;

namespace GarageApp
{
    //// ENVIRONMENT AND DIRECTORY INFO
    //static string CurrentWorkingDirectory = Environment.CurrentDirectory;
    //static string SolutionFolder = Directory.GetParent(CurrentWorkingDirectory).Parent.Parent.Parent.FullName;
    //static string MainProjectFolder = Directory.GetParent(CurrentWorkingDirectory).Parent.Parent.FullName;

    //string[] directories = Directory.GetDirectories(SolutionFolder);
    //static FileInfo[] fileList = Directory.GetParent(MainProjectFolder).GetFiles();
    //string[] projectFiles = Directory.EnumerateFiles(MainProjectFolder).ToArray();


    internal class Program
    {

        // ## DEFINES AND CONSTS ##
        const int exercise = 5; // the current exercise
        static string input = null;
        static bool quit = false;
        static int result = 0;
        static string title = $"Lexicon 2024 .Net - Övning{exercise} (Garage)";

        static string menu = $"1 - New Garage, 2 - Add/Remove, 3 - List All, 4 - Search, 5 - Quit";

        static Garage ourGarage;
        static IUI prompt = new Prompt();


        static void Main(string[] args)
        {
            Initialize();
            
            prompt.PrintText(title);

            ////run
            do
            {                
              Run();
            } while (!quit);
           

            ////close
            Console.In.Close();
            Console.In.Dispose();
            Console.Beep();
        }


        static void Initialize()
        {
            ////initialize
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetWindowSize(800, 600);
            Console.Title = title;
        }

        static void Run()
        {

            prompt.PrintText(menu);
            var user_input = prompt.GetUserInput();
            int ui = 0;
            int.TryParse(user_input, out ui);

            switch (ui)
            {

                case 1:
                    prompt.PrintText("CREATING A NEW GARAGE");
                    prompt.ShowMessage("Capacity: ");
                    int cap = prompt.GetNumberFromUser();
                    GarageHandler gh = new GarageHandler();
                    gh.Build(cap);
                    break;
                case 2:
                    prompt.PrintText("ADD OR REMOVE VEHICLES IN GARAGE");
                    prompt.ShowMessage("1 - Add, 2 - Remove");
                    var ans = prompt.GetNumberFromUser();
                    if (ans.Equals(1))
                    {

                        prompt.Alert("This will create a new vehicle!");
                        prompt.PrintText($"1 - Car, 2 - Motorcycle, 3 - Bus, 4 - Boat, 5 - Airplane");
                        int ans= prompt.GetNumberFromUser();

                        switch (ans)
                        {
                            case 1: ourGarage.AddVehicle(new Car()); break;
                            case 2: ourGarage.AddVehicle(new Motorcycle()); break;
                            case 3: ourGarage.AddVehicle(new Bus()); break;
                            case 4: ourGarage.AddVehicle(new Boat()); break;
                            case 5: ourGarage.AddVehicle(new Airplane()); break;
                            defalut: prompt.Alert("Please enter a number between 1 and 5"); break;
                        }
                        
                    }
                    if (ans.Equals(2))
                    {
                        prompt.ShowMessage("Enter Vehicle to remove: ");
                        int number = prompt.GetNumberFromUser();
                        foreach (Vehicle v in ourGarage)
                        {
                            if (v.VIN == number)
                            {
                                ourGarage.RemoveVehicle(v);
                            }
                        }

                    }
                    break;
                case 3:
                    prompt.PrintText("SHOWING ALL VEHICLES IN GARAGE");
                    foreach (Vehicle v in ourGarage)
                    {
                        v.PrintVehicle();
                    }
                    break;
                case 4:
                    prompt.PrintText("SEARCH FOR VEHICLE IN GARAGE");
                    break;
                case 5:
                    prompt.PrintText("ARE YOU SURE YOU WANT TO QUIT? (y/n)");
                    quit = prompt.GetReply();
                    
                    break;
                default:
                    break;

            }
        }


    }







}
