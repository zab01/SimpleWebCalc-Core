using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebCalc
{
    public class Calc : ICalc
    {
        public int soma(int op1, int op2)
        { 
            return op1 + op2;
        }
        
        public int subt(int op1, int op2)
        {
            return op1 - op2;
        }
        
        public int mult(int op1, int op2)
        {
            return op1 * op2;
        }
        
        public int div(int op1, int op2)
        { 
            return op1 / op2;
        }
    }
}