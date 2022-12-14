using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Guesser_OOP
{
    public class HintManager
    {
        TryCounter tryCounter = new TryCounter();

        public void OnRightAnswer()
        {
            int countOfTries = tryCounter.count;
            Console.WriteLine("You guessed the number correctly. Well done!");
            Console.WriteLine($"It took you {countOfTries} tries to guess it.\n");
        }

        public void OnWrongAnswer(int number, int currentInt)
        {
            if (number > currentInt)
            {
                Console.WriteLine("Your guess was greater than the secret number. Try again.\n");
            }
            else
            {
                Console.WriteLine("Your guess was below the the secret number. Try again.\n");
            }

            // counts up every time there's a wrong guess
            tryCounter.CountUp();
        }
    }
}
