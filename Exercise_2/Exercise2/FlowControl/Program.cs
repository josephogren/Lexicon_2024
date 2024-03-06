namespace FlowControl;

internal class Program
{

    const int JUNIOR_PRICE = 80;
    const int STANDARD_PRICE = 120;
    const int SENIOR_PRICE = 90;


    static void Main(string[] args)
    {


        // Global Variable
        uint gTotalprice = 0;


        // CASES FOR THE SWITCH         

        // MENYVAL 1 UNGDOM ELLER PENSIONÄR
        void menyVal1()
        {
            var age = 0;

            Printer.PrintMessage("Age: ");
                        
            while(Printer.PromptNumber() <= 0);

            // Check if person is an Adult
            if (age >= 20)
            {
                // Make sure person is not a Senior
                if (age < 65) { Printer.PrintMessage("Standardpris 120kr"); }
                else { Printer.PrintMessage("Pensionärspris 90kr"); }
            }
            else { Printer.PrintMessage("Ungdomspris: 80kr"); }


        }

        void subMenu()
        {
            gTotalprice = 0;

            Printer.PrintMessage("Antal i sällskapet: ");

            var input_str = Printer.PromptText();
            var nPeople = int.TryParse(input_str, out var result) ? result : 0;

            // Run Menu option 1 (Ticket Purchase) for each person
            for (int p = 1; p <= nPeople; p++)
            {
                menyVal1();
            }

            Printer.PrintMessage($"Antal personer: {nPeople}  TOTALPRIS: {gTotalprice}");

        }

        // MENYVAL 2 UPREPA TIO GÅNGER
        void menyVal2()
        {
            Printer.Clear();
            Printer.PrintMessage("Enter Random Text> ");
            var input_str = Printer.PromptText();
            Printer.Print10(input_str);
        }

        // MENYVAL 3 DET TREDJE ORDET
        void menyVal3()
        {
            Printer.Clear();
            Printer.PrintMessage("Skriv Dina Ord.....");
            string input_str = Printer.PromptText();
            string[] inputStrArr = input_str.Split(" ");
            Printer.PrintMessage(input_str);

            // Check thtat our input string is not null or empty as well as has 3 or more words
            if (!string.IsNullOrEmpty(input_str) && inputStrArr.Length >= 3)
            {
                string[] splitInput = input_str.Split(" ");
                Printer.PrintMessage($"Det 3e Ordet: {splitInput[2]}");
            }

        }

        bool flag = true;

        while (flag)
        {
            Printer.PrintMessage("0 - Exit, 1 - BILJETTER, 2 - Grupp, 3 - X10 GGR, 4 - DET TREDJE ORDET");

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


        Printer.PrintMessage("Programmet avslutas..");
        Printer.Alert();
    }

}


internal class Printer
{
    internal static void Clear() { Console.Clear(); }

    internal static void PrintMessage(string message) { Console.Write(message); }

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