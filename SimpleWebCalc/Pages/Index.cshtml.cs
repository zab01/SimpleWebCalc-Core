using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SimpleWebCalc.Pages
{

    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            RedirectToPage("Pages/Calc.cshtml");
        }
    }
}
