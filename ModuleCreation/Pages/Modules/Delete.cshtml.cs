using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModuleCreation.Models;

namespace ModuleCreation.Pages.Modules
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public List<Module> Mod { get; set; }

        [BindProperty]
        public List<bool> IsSelect { get; set; } //this is needed to allow the user to select the checkbox


        public List<Module> ModToDelete { get; set; } //this variable is a list to collect the selected modules to be deleted

        public IActionResult OnGet()
        {
            
               

            return Page();
        }

        public IActionResult OnPost()
        {
           
           
                return RedirectToPage("/Modules/ViewModule");
        }

    }
}
