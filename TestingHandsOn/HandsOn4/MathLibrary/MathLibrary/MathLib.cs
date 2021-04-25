using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class MathLib
    {
        

        public int CompareTwoNumbers(int firstNo, int secondNo)
        {
            if (firstNo <= 0 && secondNo <= 0)
            {
                return 0;
            }

            if (firstNo >= secondNo)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
