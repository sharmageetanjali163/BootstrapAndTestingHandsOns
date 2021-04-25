using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace CalculatorLib
{
    public class Calculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Multiply(int firtsNumber, int secondNumber)
        {
            return firtsNumber * secondNumber;
        }


        public int Divide(int firstNumber, int secondNumber)
        {
            if(secondNumber==0)
            {
                return 0;
            }
            else
            {
                return firstNumber / secondNumber;
            }
        }

            static void Main(string[] args)
        {
        }
    }
}
