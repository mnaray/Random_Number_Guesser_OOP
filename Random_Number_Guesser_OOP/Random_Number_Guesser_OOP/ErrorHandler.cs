using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Guesser_OOP
{
    internal class ErrorHandler
    {
        public void Error(int errorcode)
        {
            switch (errorcode)
            {
                case 0:
                    Console.WriteLine("We don't recognize the input. Try something else.");
                    break;
                case 1:
                    Console.WriteLine("Please try guessing in the possible range of 1-100.");
                    break;
                default:
                    Console.WriteLine("We don't know what happened.\n" +
                        "You might want to restart the application...");
                    break;
            }
        }
    }
}
