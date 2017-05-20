using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculator
{
    public class Calculator
    {
        public enum Operation
        {
            NONE,
            NUMBER,
            PLUS,
            MINUS,
            EQUAL,
            MS,
            MR,
            MPLUS,
            MMINUS,
            MC,
            C,
            CE
        };
        public Operation operation;
        public int firstNumber, secondNumber;

        public Calculator()
        {
            operation = Operation.NONE;
            firstNumber = 0;
            secondNumber = 0;
        }

        public void saveFirstNumber(string s)
        {
            firstNumber = int.Parse(s);
        }

        public void saveSecondNumber(string d)
        {
            secondNumber = int.Parse(d);
        }

        public int getResultPlus()
        {
            return firstNumber + secondNumber;
        }
    }
}