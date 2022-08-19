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
        string? input = "";
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
                    CheckGuess();
                }
                else if (input == "exit")
                {
                    // loop stops on exit
                    isRunning = false;
                }
                else
                {
                    errorHandler.Error(0);
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
                RequestRestart();
            }
            else
            {
                hintManager.OnWrongAnswer(number, GetCurrentInt());
            }
        }

        private void RequestRestart()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Would you like to restart the game? [y|n]");
                    string? response = Console.ReadLine();

                    switch (response)
                    {
                        case "exit":
                        case "n":
                            isRunning = false;
                            break;

                        case "y":
                            // the old number generator gets replaced
                            // this way the number to guess doesn't stay the same
                            numberGenerator = new NumberGenerator();
                            break;

                        default:
                            throw new Exception();
                    }

                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid argument.\n");
                }
            }
        }

    }
}
