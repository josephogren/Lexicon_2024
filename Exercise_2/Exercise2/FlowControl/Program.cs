namespace FlowControl;

internal class Program
{

    const int JUNIOR_PRICE = 5;
    const int ADULT_PRICE = 20;
    const int SENIOR_PRICE = 11;


    public static void Main(string[] args)
    {
        System.Console.WriteLine("Välkommen till mitt program!");

        // Global Variable
        uint gTotalprice = 0;

        // CASES FOR THE SWITCH 

        void runOption1()
        {
            Console.WriteLine("Enter age: ");

            var input_str = Console.ReadLine();

            var age = int.TryParse(input_str, out var result) ? result : 0;

            if (age < 20)
            {
                //Console.WriteLine("Age < 20");
                gTotalprice += JUNIOR_PRICE;
                Console.WriteLine($"TOTAL PRICE: {gTotalprice}");
            }

            else if (age < 65)
            {
                //Console.WriteLine("Age is between 20 and 64");
                Console.WriteLine($"TOTAL PRICE: {gTotalprice}");
                gTotalprice += ADULT_PRICE;
                Console.WriteLine($"TOTAL PRICE: {gTotalprice}");
            }

            else
            {
                gTotalprice += SENIOR_PRICE;
                Console.WriteLine($"TOTAL PRICE: {gTotalprice}");
            }

        }

        void runOption3() { Console.WriteLine("OPTION 3"); }

        void runOption4()
        {
            Console.Write("Skriv Dina Ord.....");
            var input_str = Console.ReadLine();
            Console.WriteLine(input_str);
            
            if(!string.IsNullOrEmpty(input_str))
            {
                string[] splitInput = input_str.Split(" ");
                Console.WriteLine($"Det 3e Ordet: {splitInput[2]}");
            }                    

        }

        bool flag = true;

        while (flag)
        {
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
                    runOption1();
                    break;
                case 2:
                    Console.WriteLine("Räkna ut Totalpris");
                    break;
                case 3:
                    Console.WriteLine("Du valde fel alternativ 3");
                    runOption3();
                    break;
                case 4:
                    Console.WriteLine("Menyval 3: Det tredje ordet");
                    runOption4();
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