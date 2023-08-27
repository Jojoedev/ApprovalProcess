using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprovalProcess.Data;
using ApprovalProcess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApprovalProcess.Pages.Logics.VendorLogic
{
    [Authorize(Roles = "IT")]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CreateModel(ApplicationDbContext contex)
        {
            _context = contex;
        }

        [BindProperty]
        public Vendor Vendor { get; set; }
        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost(Vendor Vendor)
        {
            if (ModelState.IsValid)
            {
                _context.Vendors.Add(Vendor);
                _context.SaveChanges();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
