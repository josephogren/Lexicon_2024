namespace FlowControl;

internal class Program
{

    const int JUNIOR_PRICE = 80;
    const int STANDARD_PRICE = 120;
    const int SENIOR_PRICE = 90;


    static void Main(string[] args)
    {
        System.Console.WriteLine("Välkommen till mitt program!");

        // Global Variables
        uint gTotalprice = 0;


        // CASES FOR THE SWITCH         

        // MENYVAL 1 UNGDOM ELLER PENSIONÄR
        void menyVal1()
        {
            Console.Clear();
            Console.WriteLine("Enter age: ");

            var input_str = Console.ReadLine();

            var age = int.TryParse(input_str, out var result) ? result : 0;        



            if (age >= 20)
            {
                if (age < 65) { Console.WriteLine("Standardpris 120kr"); }

                else { Console.WriteLine("Pensionärspris 90kr"); }
            }
            else { Console.WriteLine("Ungdomspris: 80kr"); }

        }

        void subMenu() 
        {
            int count = 167;
            Console.WriteLine("Antal i sällskapet: ");
            gTotalprice += STANDARD_PRICE;
            Console.WriteLine($"TICKETS: {count}, TOTAL PRICE: {gTotalprice}");
        }

        // MENYVAL 2 UPREPA TIO GÅNGER
        void menyVal2()
        {
            Console.Clear();
            Console.WriteLine("RandomText> ");
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
            Console.WriteLine("** HUVUDMENU **");
            Console.WriteLine("Skriv in siffror..");
            var input_str = Console.ReadLine();
            Console.WriteLine(input_str);

            var parsedInputString = int.TryParse(input_str, out var result) ? result : 0;

            switch (parsedInputString)
            {
                case 0:
                    flag = false;
                    break;


                case 1:
                    Console.WriteLine("** BUY YOUR TICKETS! **");
                    menyVal1();
                    break;


                case 2:
                    Console.WriteLine("Paketpris");
                    subMenu();
                    break;


                case 3:
                    Console.WriteLine("Upprepa 10 ggr");
                    menyVal2();
                    break;


                case 4:
                    Console.WriteLine("Menyval 3: Det tredje ordet");
                    menyVal3();
                    break;


                default:
                    Console.WriteLine("Felaktig inmatning!");
                    break;
            }
        }

        System.Console.WriteLine("Programmet avslutas..");
        Console.Beep();
    }

}


internal class Printer
{

}