using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Guesser_OOP
{
    internal class TryCounter
    {
        public int count { get; set; } = 0;

        public void CountUp()
        {
            count++;
        }
    }
}
