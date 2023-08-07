using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprovalProcess.Data;
using ApprovalProcess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ApprovalProcess.Pages.Logics
{
    /*[Authorize(Policy="RequireAdmin")]*/


    public class CreateModel : PageModel

    {
        private readonly ApplicationDbContext _Context;
        public CreateModel(ApplicationDbContext context)
        {
            _Context = context;
        }

      
        

        [BindProperty]
        public Request RequestObj { get; set; }

        public SelectList Department {get; set;}

        public ActionResult OnGet()
        {
            Department = new SelectList(_Context.Departments.ToList(), "Id", "Name");
            return Page();
        }
       
      
        public ActionResult OnPost(Request RequestObj)
        {

            RequestObj.RequestedDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                _Context.Add(RequestObj);
                _Context.SaveChanges();
                RedirectToPage("/Logics/List");
            }

            return RedirectToPage("/Logics/List");
            
        }

    }
}
