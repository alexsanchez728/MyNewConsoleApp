using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime is the type of the purchaseData variable.
            DateTime purchaseDate = DateTime.Now;

            /*
                string is the type of the lastName variable. It
                tells the compiler that the lastName variable can
                ONLY hold a string value.
            */
            string lastName = "Smith";

            /*
                C# now supports implicitly typing of a variable. The
                type of the variable will be determined, by the
                compiler, at compile time.
            */
            var firstName = "Bill";

            /*
              The String.Format() function syntax allows you to
              build the final string, with placeholders, and
              then provide comma-delimited list of variables to
              use in the placeholders.
            */
            Console.WriteLine($"{firstName} {lastName} purchased on {purchaseDate}");
            Console.ReadLine();
        }
    }
}
