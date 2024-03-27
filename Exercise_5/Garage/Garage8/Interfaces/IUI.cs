using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage8.Interfaces
{
    public interface IUI
    {

        string Prompt(string prompt);               
        string PromptInput();
        void ShowMessage(string msg);
        void PrintText(string text);
        int getUserInput();
        char getReply(); 

    }


    internal class Prompt : IUI 
    {

        string Prompt(string prompt)
        {
            Console.WriteLine(prompt);
        }

        void Alert(string alert) { Console.WriteLine(alert); }

        string PromptInput()
        {
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) && string.IsNullOrWhiteSpace(input))
            {
                throw new FormatException("Syntax Error");
            }

            return input;

        }

        void ShowMessage(string msg) { Console.Write(msg); }
        void PrintText(string text) { Console.WriteLine(text); }

        int getUserInput() { return Console.Read(); }
        char getReply()
        {
            var input = Console.ReadKey();
            return input.KeyChar;
        }

    }
}
