using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage8.Interfaces
{
    public interface IUI
    {

        void Prompt(string prompt);               
        string ValidateUserInput(string input);
        void Alert(string alert);
        void ShowMessage(string msg);
        void PrintText(string text);
        string getUserInput();
        char getReply(); 

    }


    public class Prompt : IUI
    {

        string ValidateUserInput(string user_input)
        {
            
            if (string.IsNullOrEmpty(user_input) && string.IsNullOrWhiteSpace(user_input))
            {
                throw new FormatException("Syntax Error");
            }

            return user_input;

        }

        string getUserInput() 
        {
            var string_input = Console.ReadLine();
            return ValidateUserInput(string_input);            
        }
        char getReply()
        {
            var key_input = Console.ReadKey();
            return IUI.ValidateUserInput(key_input);
            
        }


        void Prompt(string prompt)
        {
            Console.WriteLine(prompt);
        }

        void Alert(string alert) { Console.WriteLine(alert); }


        void ShowMessage(string msg) { Console.Write(msg); }
        void PrintText(string text) { Console.WriteLine(text); }


    }
}
