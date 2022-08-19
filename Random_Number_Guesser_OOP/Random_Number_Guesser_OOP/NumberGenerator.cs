using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Guesser_OOP
{
    internal class NumberGenerator
    {
        public int currentNumber { get; init; }

        public NumberGenerator()
        {
            this.currentNumber = GenerateNumber();
        }

        private int GenerateNumber()
        {
            Random r = new Random();
            return r.Next();
        }
    }
}
