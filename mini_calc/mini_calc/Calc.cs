using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_calc
{
    public class Calc
    {
        public double firstnumber;
        public double secondnumber;
        public double result;

        public double Sum()
        {
            result = firstnumber + secondnumber;
            return result;
        }
        public double Minus()
        {
            result = firstnumber - secondnumber;
            return result;
        }
        public double Multiply()
        {
            result = firstnumber * secondnumber;
            return result;
        }
        public double Divide()
        {
            result = firstnumber / secondnumber;
            return result;
        }
    }
}
