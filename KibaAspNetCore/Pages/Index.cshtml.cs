using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KibaAspNetCore.Pages
{
    public class IndexModel : PageModel
    {
        //http://localhost:19492/index?title=kiba
        public void OnGet()
        { 
            string title = this.Request.Query["title"];
            if (!string.IsNullOrWhiteSpace(title))
            {
                ViewData["Title"] = title;
            }
        }
    }
}
