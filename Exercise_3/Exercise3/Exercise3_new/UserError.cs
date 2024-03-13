using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_new
{
   
    // Step 1 & 2: Create the abstract class UserError with abstract method UEMessage()
    public abstract class UserError
    {
        public abstract string UEMessage();
    }

    // Step 3 & 4: Create NumericInputError class that inherits from UserError and override UEMessage()
    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    // Step 5 & 6: Create TextInputError class that inherits from UserError and override UEMessage()
    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    // Step 9: Create three custom classes with custom definitions of UEMessage()
    public class CustomError1 : UserError
    {
        public override string UEMessage()
        {
            return "This is a custom error message 1.";
        }
    }

    public class CustomError2 : UserError
    {
        public override string UEMessage()
        {
            return "This is a custom error message 2.";
        }
    }

    public class CustomError3 : UserError
    {
        public override string UEMessage()
        {
            return "This is a custom error message 3.";
        }
    }

    // Step 7 & 8: In Program.cs's Main method: Create a list of UserErrors and populate it with instances of NumericInputError and TextInputError. Print all UserErrors UEMessage() through a foreach loop.
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<UserError> errors = new List<UserError>
    //    {
    //        new NumericInputError(),
    //        new TextInputError(),
    //        new CustomError1(),
    //        new CustomError2(),
    //        new CustomError3()
    //    };

    //        foreach (var error in errors)
    //        {
    //            Console.WriteLine(error.UEMessage());
    //        }
    //    }
    //}





}
