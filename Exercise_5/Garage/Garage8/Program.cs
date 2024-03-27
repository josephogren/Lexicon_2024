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


        static void Main(string[] args)
        {
            Initialize();

            IUI prompt = new Prompt();

            ////run

            prompt.PrintText(title);
            prompt.PrintText(menu);
            var user_input = prompt.getReply();
            int ui = (int)user_input;

            switch(ui)
            {

                case 1:
                    prompt.ShowMessage("CREATING A NEW GARAGE");
                    prompt.Prompt("Capacity: ");
                    var cap = prompt.getReply();
                    GarageHandler gh = new GarageHandler();
                    gh.Build(cap);
                    break;
                case 2:
                    prompt.ShowMessage("ADD OR REMOVE VEHICLES IN GARAGE");
                    prompt.Prompt("1 - Add, 2 - Remove");
                    var ans = prompt.getReply();    
                    if(ans == 1)
                    {
                        ourGarage.AddVehicle(new Models.Vehicle());
                    }
                    if(ans == 2)
                    {
                        prompt.Prompt("Enter Vehicle to remove: ");
                        var n  = (int)prompt.getReply();
                        foreach (Vehicle v in ourGarage)
                        {
                            if (v.VIN == n)
                            {
                                ourGarage.RemoveVehicle(v);
                            }
                        }
                        
                    }
                    break;
                case 3:
                    prompt.ShowMessage("SHOWING ALL VEHICLES IN GARAGE");
                    break;
                case 4:
                    prompt.ShowMessage("SEARCH FOR VEHICLE IN GARAGE");
                    break;
                case 5:
                    prompt.ShowMessage("ARE YOU SURE YOU WANT TO QUIT? (y/n)"); 
                    if (prompt.getReply() == 'y')
                    {
                        quit = true;
                    }
                    break;
                    default:
                    break;                        

            }   
            



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


    }







}
