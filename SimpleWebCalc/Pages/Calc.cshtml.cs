using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SimpleWebCalc;

namespace SimpleWebCalc.Pages
{
    public class CalcModel : PageModel
    {
        private readonly ILogger<CalcModel> _logger;
        public int op1_soma {get; set;}
        public int op2_soma {get; set;}
        public int res_soma {get; set;}
        public int op1_subt {get; set;}
        public int op2_subt {get; set;}
        public int res_subt {get; set;}
        public int op1_mult {get; set;}
        public int op2_mult {get; set;}
        public int res_mult {get; set;}
        public int op1_div {get; set;}
        public int op2_div {get; set;}
        public int res_div {get; set;}
        /*
        [BindProperty]
         public int op1_soma { get; set; }
        [BindProperty]
         public int op2_soma { get; set; }
        [BindProperty]
         public int res_soma { get; set; }
        [BindProperty]
         public int calc1 { get; set; }
        */
        /*
        public void OnPost()
        {
        }
        */
        public void OnPostCalcSoma()
        {
            ICalc c = new Calc();

            op1_soma = int.Parse(Request.Form["op1_soma"]);
            op2_soma = int.Parse(Request.Form["op2_soma"]);
            
            res_soma = op1_soma + op2_soma;
        }
        public void OnPostCalcSubt()
        {
            ICalc c = new Calc();

            op1_subt = int.Parse(Request.Form["op1_subt"]);
            op2_subt = int.Parse(Request.Form["op2_subt"]);
            
            res_subt = op1_subt - op2_subt;
        }
        public void OnPostCalcMult()
        {
            ICalc c = new Calc();

            op1_mult = int.Parse(Request.Form["op1_mult"]);
            op2_mult = int.Parse(Request.Form["op2_mult"]);
            
            res_mult = op1_mult * op2_mult;
        }
        public void OnPostCalcDiv()
        {
            ICalc c = new Calc();

            op1_div = int.Parse(Request.Form["op1_div"]);
            op2_div = int.Parse(Request.Form["op2_div"]);
            
            res_div = op1_div / op2_div;
        }
    }
}
