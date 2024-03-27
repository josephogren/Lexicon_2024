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
        string PromptInput();
        void Alert(string alert);
        void ShowMessage(string msg);
        void PrintText(string text);
        int getUserInput();
        char getReply(); 

    }


    internal class Prompt : IUI
    {

        void IUI.Prompt(string prompt)
        {
            Console.WriteLine(prompt);
        }

        void IUI.Alert(string alert) { Console.WriteLine(alert); }

        string IUI.PromptInput()
        {
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) && string.IsNullOrWhiteSpace(input))
            {
                throw new FormatException("Syntax Error");
            }

            return input;

        }

        void IUI.ShowMessage(string msg) { Console.Write(msg); }
        void IUI.PrintText(string text) { Console.WriteLine(text); }

        int IUI.getUserInput() { return Console.Read(); }
        char IUI.getReply()
        {
            var input = Console.ReadKey();
            return input.KeyChar;
        }

    }
}
