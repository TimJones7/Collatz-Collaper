using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzTesting.Collatz
{
    public class CollatzTree
    {

        //  This {tail}  might not even be necessary?
        public Number? bottom { get; set; }    //  which will be == 1 

        //  Keep track of numbers seen and what Number object it belongs to
        public SortedList<int,Number>? Numbers_Seen { get; set; }


        //  Need functionality

        //  Add number


        //  Print numbers from {}
        //  If doesn't exist, fill in


        public void PrintFromNumber(int x)
        {
            //  Check if number has been seen.
            //  If not start process of adding numbers until we find one we've seen
            if(!Numbers_Seen.ContainsKey(x))
            {
                CreateNumber_Process(x);
            }
        
        
        
        }







        private void CreateNumber_Process(int x)
        {
            //  This should be recursive
            //  Create new number
            Number newNumber = CreateNumber(x);


            //  Add number to Numbers_Seen list
            Numbers_Seen.Add(x, newNumber);


            //  See if next number exists, if not, set it equal to recursive function

        }


        private Number CreateNumber(int x)
        {
            //  Entry needs created and then look to see if next number exists, if so, then set new number's next_number to the Number object that it is and set the next numbers from above/below value as the number we just created
            Number newNum = new Number(x);
            int next_Num = 0;


            //if(Numbers_Seen.ContainsKey(x))




            return newNum;

        }
        
        private int findNextNum(int x)
        {
            switch (x % 2) {
                case 0:
                    return x / 2;
                case 1:
                    return 3*x +1;

            }
        }

    }


}
