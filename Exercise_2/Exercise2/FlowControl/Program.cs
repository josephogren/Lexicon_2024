namespace FlowControl;

internal class Program
{

    public static void Main(string[] args)
    {
        System.Console.WriteLine(   "Välkommen till mitt program!");
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
                Console.WriteLine("Du valde alternativ 1");
                break;
            case 2:
                Console.WriteLine("Räkna ut Totalpris");
                break;
            case 3:
                Console.WriteLine("Du valde alternativ 3");
                break;
            default:
                Console.WriteLine("Felaktig inmatning!");
                break;
        }}
    
        System.Console.WriteLine("Programmet avslutas..");
    }}