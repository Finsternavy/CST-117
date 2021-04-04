//Corrected by <Christopher Finster>
//Cannot free type titles.  You must comment this out to avoid compile errors
//Program
//use for IC08
//Lydia's code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_IC08_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

        }
    }
}
//Set
//Describe several debugging techniques and scenarios for their use.
// You cannot use the using keyword in the midle of code.  They should be at the top and removed if duplicates
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//Lydia's code - find the errors!
namespace CST117_IC08_console
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                // do not need this else logic. 
                //else
                    // this would cause the method to return false after only checking the first index of elements. Needs removed. 
                    //return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            // Add a new set to hold the values of both sets you want to union
            Set joinedSet = new Set();
            //Copy original elements to the new tempory set
            joinedSet.elements = this.elements.ToList();

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                // the direction state the original set should be unchanged. Using "this" will modify the original set. Need to use a new set to hold the values of both.
                //this.addElement(rhs.elements[i]);
                joinedSet.addElement(rhs.elements[i]);
            }
            // you do not want to return only the values in rhs.  You wont both sets with no duplicates
            //return rhs;
            return joinedSet;
        }
    }
}
