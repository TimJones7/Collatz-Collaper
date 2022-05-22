using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzTesting.Collatz
{
    public class Number
    {
        public int value { get; set; }
        public Number Next_Number { get; set; } //  if value == 1 then == null
        public Number? num_From_Below { get; set; }
        public Number? num_From_Above { get; set; }
        public int stepsToOne { get; set; } 
        public int timesSteppedOn { get; set; } //  possible value to track


        public Number(int x)
        {
            value = x;
        }

    }
}
