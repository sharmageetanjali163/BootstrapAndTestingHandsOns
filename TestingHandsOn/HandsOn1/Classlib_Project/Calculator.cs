using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcultorLib
{
    public class Calculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            if (firstNumber > 0 && secondNumber > 0)
            {
                return firstNumber + secondNumber;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
