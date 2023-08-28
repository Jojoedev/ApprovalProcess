using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprovalProcess.Data;
using ApprovalProcess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApprovalProcess.Pages.Logics.StatusLogic
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _Context;
        public CreateModel(ApplicationDbContext context)
        {
            _Context = context;
        }

        [BindProperty]
        public Status Status { get; set; }
        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost(Status Status)
        {
            if (ModelState.IsValid)
            {
                _Context.Statuses.Add(Status);
                _Context.SaveChanges();
                return RedirectToPage("List");
            }
            return Page();
        }

    }
}
