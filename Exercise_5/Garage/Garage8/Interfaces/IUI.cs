using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage8.Interfaces
{
    internal interface IUI
    {


        string Prompt();
        string PromptInput();
        void ShowText(string text);
        void PrintMessage(string message);

        string getUserInput();
        string getReply();

    }
}
