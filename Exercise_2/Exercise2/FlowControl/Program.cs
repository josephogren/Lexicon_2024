namespace FlowControl;

internal class Program
{

    const int JUNIOR_PRICE = 80;
    const int STANDARD_PRICE = 120;
    const int SENIOR_PRICE = 90;


    static void Main(string[] args)
    {       
        
        Printer.PrintMessage("0 - Exit, 1 - BILJETTER, 2 - Grupp, 3 - X10 GGR, 4 - DET TREDJE ORDET");

        // Global Variables
        uint gTotalprice = 0;


        // CASES FOR THE SWITCH         

        // MENYVAL 1 UNGDOM ELLER PENSIONÄR
        void menyVal1()
        {            
            Printer.PrintMessage("Enter age: ");

            var input_str = Console.ReadLine();
            var age = int.TryParse(input_str, out var result) ? result : 0;     

            if (age >= 20)
            { if (age < 65) { Console.WriteLine("Standardpris 120kr"); }
                else { Printer.PrintMessage("Pensionärspris 90kr"); }
            }
            else { Printer.PrintMessage("Ungdomspris: 80kr"); }
        }

        void subMenu() 
        {
            int count = 0;
            Printer.PrintMessage("Antal i sällskapet: ");

            var input_str = Console.ReadLine();
            var nPurchasedTickets = int.TryParse(input_str, out var result) ? result : 0;

            gTotalprice += STANDARD_PRICE;
            Console.WriteLine($"TICKETS: {nPurchasedTickets}, TOTAL PRICE: {gTotalprice}");
        }

        // MENYVAL 2 UPREPA TIO GÅNGER
        void menyVal2()
        {
            Console.Clear();
            Printer.PrintMessage("RandomText> ");
            var input_str = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(input_str);
            }
        }

        // MENYVAL 3 DET TREDJE ORDET
        void menyVal3()
        {
            Console.Clear();
            Console.Write("Skriv Dina Ord.....");
            var input_str = Console.ReadLine();
            Console.WriteLine(input_str);

            // Check thtat our input string is not null or empty as well as has 3 or more words
            if (!string.IsNullOrEmpty(input_str) && input_str.Length >= 3)
            {
                string[] splitInput = input_str.Split(" ");
                Console.WriteLine($"Det 3e Ordet: {splitInput[2]}");
            }

        }

        bool flag = true;

        while (flag)
        {
            Console.Clear();
            Printer.PrintMessage("** HUVUDMENU **");
            var input_str = Console.ReadLine();
            Printer.PrintMessage(input_str);

            var parsedInputString = int.TryParse(input_str, out var result) ? result : 0;

            switch (parsedInputString)
            {
                case 0:
                    flag = false;
                    break;


                case 1:
                    Printer.PrintMessage("** BUY YOUR TICKETS! **");
                    menyVal1();
                    break;


                case 2:
                    Printer.PrintMessage("Paketpris");
                    subMenu();
                    break;


                case 3:
                    Printer.PrintMessage("Upprepa 10 ggr");
                    menyVal2();
                    break;


                case 4:
                    Printer.PrintMessage("Menyval 3: Det tredje ordet");
                    menyVal3();
                    break;


                default:
                    Printer.PrintMessage("Felaktig inmatning!");
                    break;
            }
        }

        System.Console.WriteLine("Programmet avslutas..");
        Console.Beep();
    }

}


internal class Printer 
{   
    internal static void PrintMessage(string message) {
        Console.Clear(); Console.WriteLine(message); 
    }
}