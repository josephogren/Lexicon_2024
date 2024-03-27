namespace Garage8.Interfaces
{
    public interface IUI
    {
        public ConsoleKey GetKeyInput();
        public int GetNumberFromUser();
        public bool GetReply();
        public string GetUserInput();

        public void Alert(string alert);
        public void ShowMessage(string msg);
        public void PrintText(string text);

        public string ValidateStringInput(string string_input);
    }


    public class Prompt : IUI
    {
        
        // IN
        public ConsoleKey GetKeyInput() { return Console.ReadKey().Key; }


        public bool GetReply()
        {
            ConsoleKey key_input = GetKeyInput();

            switch (key_input)
            {
                case ConsoleKey.Enter: return true;
                case ConsoleKey.Y: return true;
                case ConsoleKey.N: return false;
                default: return false;
            }
        }

        public string GetUserInput()
        {
            var string_input = Console.ReadLine();
            return ValidateStringInput(string_input.ToString());
        }

        // OUT
        public void Alert(string alert) { Console.WriteLine(alert); }
        public void ShowMessage(string msg) { Console.Write(msg); }
        public void PrintText(string text) { Console.WriteLine(text); }


        /* Validation Code */
        public string ValidateStringInput(string user_input)
        {

            if (string.IsNullOrEmpty(user_input) && string.IsNullOrWhiteSpace(user_input))
            {
                throw new FormatException("Syntax Error");
            }

            return user_input;

        }
          

        public int GetNumberFromUser()
        {
            int result = 0;
            int.TryParse(GetUserInput(), out result);
            return result;
        }
    }
}
