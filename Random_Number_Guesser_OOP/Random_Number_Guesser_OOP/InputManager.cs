using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Guesser_OOP
{
    internal class InputManager
    {
        NumberGenerator numberGenerator = new NumberGenerator();
        HintManager hintManager = new HintManager();
        ErrorHandler errorHandler = new ErrorHandler();

        bool isRunning = true;
        string input = "";
        int number;


        public void Listen()
        {
            while (isRunning)
            {
                input = Console.ReadLine();

                if (int.TryParse(input, out int _))
                {
                    // if input is a number, it gets converted
                    number = Convert.ToInt32(input);
                }
                else if (input == "exit")
                {
                    // loop stops on exit
                    isRunning = false;
                }
                else
                {
                    // this code gets called if input is not recognized
                }
            }
        }

        private int GetCurrentInt()
        {
            return numberGenerator.currentNumber;
        }
        
        public void CheckGuess()
        {
            // if the guess matches the number, it returns true
            // otherwise it will return false
            if (number == GetCurrentInt())
            {
                hintManager.OnRightAnswer();
            }
            else
            {
                hintManager.OnWrongAnswer();
            }
        }

    }
}
