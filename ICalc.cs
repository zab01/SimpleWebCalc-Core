using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebCalc
{
    public interface ICalc
    {
       int soma(int op1, int op2);
       int subt(int op1, int op2);
       int mult(int op1, int op2);
       int div(int op1, int op2);
    }
}