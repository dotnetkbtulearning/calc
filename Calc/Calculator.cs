using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    /// <summary>
    /// My class for calc
    /// </summary>
    class Calculator
    {
        /// <summary>
        /// dasdsadsd
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// dasdsadad
        /// </summary>
        public double B { get; set; }
        
        /// <summary>
        /// dasdasdasdad
        /// </summary>
        /// <param name="operation">dasdasdasd</param>
        /// <returns></returns>
        public double Execute(string operation)
        {
            double res = 0;

            if (operation == "+")
            {
                res = A + B;
            }
            else if (operation == "-")
            {
                res = A - B;
            }
            else if (operation == "/")
            {
                res = A / B;
            }
            else if (operation == "*")
            {
                res = A * B;
            }
            else if (operation == "!")
            {
                res = GetFact(Convert.ToInt32(A));
            }
            else if (operation == "div")
            {
                res = Math.Floor(A / B);
            }
            else if (operation == "mod")
            {
                res = GetFact(Convert.ToInt32(A));
            }
            else
            {
                throw new Exception("Operation not founded:" + operation);
            }

            return res;
        }

        /// <summary>
        /// dasdadaasd
        /// </summary>
        /// <param name="val">dasdasdasdasd</param>
        /// <returns></returns>
        private double GetFact(int val)
        {
            double res = 1;

            if (val > 1)
            {
                res *= val;
                val--;
                return GetFact(val) * res;
            }
            return res;
        }

    }
}
