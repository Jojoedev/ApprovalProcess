using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprovalProcess.Data;
using ApprovalProcess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApprovalProcess.Pages.Logics.DeptLogic
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]

        public Department department { get; set; }

        public void OnGet()
        {
        }

        public ActionResult OnPost(Department department)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Add(department);
                _context.SaveChanges();
                return RedirectToAction("DeptLogic/Index");
            }
            return NotFound();
        }
    }
}
