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


  
        //  Constructor auto-sets the bottom node
        //  and adds it to "seen" list
        public CollatzTree()
        {
            Numbers_Seen = new SortedList<int,Number>();
            bottom = new Number(1);
            Numbers_Seen.Add(1,bottom);

        }


        //  Print numbers from {}
        //  If doesn't exist, fill in
        public void PrintFromNumber(int x)
        {
            //  Check if number has been seen.
            //  If not start process of adding numbers until we find one we've seen
            if(!Numbers_Seen.ContainsKey(x))
            {
                ChainCompleter_Process(x);
            }
            
            //  The following code should only execute
            //  if the chain has been completed and exists
            //  from x -> 1 
            Number startingNum = Numbers_Seen[x];
            Number currentNum = startingNum;

            while(currentNum.Next_Number != null)
            {
                Console.WriteLine(currentNum.value);
                currentNum = currentNum.Next_Number;
            }
        
        }


        private void ChainCompleter_Process(int x)
        {
            //  This should be recursive
            //  Create new number
            Number newNumber = CreateNumber(x);

        }

        private Number CreateNumber(int x)
        {
            //  Entry needs created and then look to see if next number exists,
            //  if so, then set new number's next_number to the Number object
            //  that it is and set the next numbers from above/below value
            //  as the number we just created
            //  If the next number doesn't exist, we want to recurse until
            //  we arrive at a number that does exist
            Number newNum = new Number(x);

            //  Add number to Numbers_Seen list
            Numbers_Seen.Add(x, newNum);

            int next_Num = findNextNum(x);

            //  If we've not seen the next number, recursively create it
            if (!Numbers_Seen.ContainsKey(next_Num))
            {
                newNum.Next_Number = CreateNumber(next_Num);
            }
            //  If we have seen the next number, get that objext and set it equal to the proper one
            else if (Numbers_Seen.ContainsKey(next_Num))
            {
                newNum.Next_Number = Numbers_Seen[next_Num];
                //  This part only matters if we want to traverse away from 1
                if(x > next_Num)
                {
                    Numbers_Seen[next_Num].num_From_Above = newNum;
                }
                if (x < next_Num)
                {
                    Numbers_Seen[next_Num].num_From_Below = newNum;
                }
            }
            return newNum;
        }
        
        private int findNextNum(int x)
        {
            if(x % 2 == 0)
            {
                return x/2;
            }
            return (3 * x + 1);
        }
    }
}



