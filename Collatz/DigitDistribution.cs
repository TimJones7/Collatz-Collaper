using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzTesting.Collatz
{
    public class DigitDistribution
    {
        public int Num_Ones { get; set; }
        public int num_Twos { get; set; }
        public int num_Threes { get; set; }
        public int num_Fours { get; set; }
        public int num_Fivess { get; set; }
        public int num_Sixes { get; set; }
        public int num_Sevens { get; set; }
        public int num_Eights { get; set; }
        public int num_Nines { get; set; }



        public void printDistribution()
        {
            Console.WriteLine($"Numbers of 1's: {this.Num_Ones}");
            Console.WriteLine($"Numbers of 2's: {this.num_Twos}");
            Console.WriteLine($"Numbers of 3's: {this.num_Threes}");
            Console.WriteLine($"Numbers of 4's: {this.num_Fours}");
            Console.WriteLine($"Numbers of 5's: {this.num_Fivess}");
            Console.WriteLine($"Numbers of 6's: {this.num_Sixes}");
            Console.WriteLine($"Numbers of 7's: {this.num_Sevens}");
            Console.WriteLine($"Numbers of 8's: {this.num_Eights}");
            Console.WriteLine($"Numbers of 9's: {this.num_Nines}");
        }

    }
}


