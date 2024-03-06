// Lexicon .Net 2024 - Exercise 2 (FLOW CONTROL)
// Author: Joseph Ogren   Date: 2024-05-06
////////////////////////////////////////////


namespace FlowControl;

enum MenuOption
{
    Exit,
    BuyTickets,
    Group,
    Repeat10Times,
    ThirdWord
}

internal class Program
{
    const int JUNIOR_PRICE = 80;
    const int STANDARD_PRICE = 120;
    const int SENIOR_PRICE = 90;

    const string menu = "0 - Exit, 1 - BILJETTER, 2 - Grupp, 3 - X10 GGR, 4 - DET TREDJE ORDET";


    static void Main(string[] args)
    {

        // Global Variable
        uint gTotalprice = 0;


        bool flag = true;

        while (flag)
        {
            Printer.PrintMenu(menu);

            // Check if the user input corresponds to any of the Menu enumerables
            if (!Enum.TryParse<MenuOption>(Console.ReadLine(), out var menuOption))
            {
                Printer.PrintMessage("Invalid input. Please enter a number corresponding to a menu option.");
                continue;
            }

            // SWITCH on the chosen enumerable menu items
            switch (menuOption)
            {
                case MenuOption.Exit:
                    flag = false;
                    break;


                case MenuOption.BuyTickets:
                    Printer.PrintMessage("** BUY YOUR TICKETS! **");
                    ShowTicketPrices();
                    break;


                case MenuOption.Group:
                    Printer.PrintMessage("Paketpris");
                    BuyGroupTickets();
                    break;


                case MenuOption.Repeat10Times:
                    Printer.PrintMessage("Upprepa 10 ggr");
                    Repeat10Times();
                    break;


                case MenuOption.ThirdWord:
                    Printer.PrintMessage("Menyval 3: Det tredje ordet");
                    The3rdWord();
                    break;


                default:
                    Printer.PrintMessage("Felaktig inmatning!");
                    break;
            }


            // Functionality that get called from the Menu Switch

            // MENYVAL 1 UNGDOM ELLER PENSIONÄR
            void ShowTicketPrices()
            {
                int age;
                do
                {
                    Printer.PrintMessage("Age: ");
                    age = Printer.PromptNumber();

                } while (age <= 0);

                // Check if person is an Adult
                if (age >= 20)
                {  // Make sure person is not a Senior
                    if (age < 65)
                    {
                        Printer.PrintMessage("Standardpris 120kr");
                        gTotalprice += STANDARD_PRICE;
                    }
                    else
                    {
                        Printer.PrintMessage("Pensionärspris 90kr");
                        gTotalprice += SENIOR_PRICE;
                    }
                }
                // Must be a young person
                else
                {
                    Printer.PrintMessage("Ungdomspris: 80kr");
                    gTotalprice += JUNIOR_PRICE;
                }
            }

            void BuyGroupTickets()
            {
                gTotalprice = 0;

                Printer.PrintMessage("Antal i sällskapet: ");

                var input_str = Printer.PromptText();
                var nPeople = int.TryParse(input_str, out var result) ? result : 0;

                // Show (Ticket Purchase) for each person
                for (int p = 1; p <= nPeople; p++)
                {
                    ShowTicketPrices();
                }

                Printer.PrintMessage($"Antal personer: {nPeople}  TOTALPRIS: {gTotalprice}");

            }

            // MENYVAL 2 UPREPA TIO GÅNGER
            void Repeat10Times()
            {
                Printer.Clear();
                Printer.PrintMessage("Enter Random Text> ");
                var input_str = Printer.PromptText();
                Printer.Print10(input_str); // Prints same text 10 times
            }

            // MENYVAL 3 DET TREDJE ORDET
            void The3rdWord()
            {
                Printer.Clear();
                Printer.PrintMessage("Skriv Dina Ord.....");
                string input_str = Printer.PromptText();
                string[] inputStrArr = input_str.Split(" ");
                Printer.PrintMessage(input_str);

                // Check thtat our input string is not null or empty as well as has 3 or more words
                if (!string.IsNullOrEmpty(input_str) && inputStrArr.Length >= 3)
                {
                    Printer.PrintMessage($"Det 3e Ordet: {inputStrArr[2]}");
                }

            }
        }


        Printer.PrintMessage("Programmet avslutas..");
        Printer.Alert();
    }

}


internal class Printer
{
    internal static void Clear() { Console.Clear(); }

    internal static void PrintMessage(string message) { Console.WriteLine(message); }

    internal static void PrintMenu(string menu) { PrintMessage(menu); }

    internal static int PromptNumber()
    {
        var input_str = string.Empty;
        input_str = Console.ReadLine();
        return int.TryParse(input_str, out var result) ? result : 0;
    }

    internal static string PromptText()
    {
        string? input_str = Console.ReadLine();
        return input_str;
    }

    internal static void Print10(string message)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Write(message);
        }
        Console.WriteLine(" ");
    }

    internal static void Alert() { Console.Beep(); }
}