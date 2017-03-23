using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mycalculator
{
    public class Calculator
    {
       
        public double firstnumber, secondnumber, result;

        public Calculator()
        {
            firstnumber = 0;
            secondnumber = 0;
        }

        public void saveFirstNumber(string s)
        {
            firstnumber = double.Parse(s);
        }

        public void saveSecondNumber(string d)
        {
            secondnumber = double.Parse(d);
        }
    }
}
