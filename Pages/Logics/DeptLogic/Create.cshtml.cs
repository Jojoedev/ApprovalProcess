using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprovalProcess.Data;
using ApprovalProcess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApprovalProcess.Pages.Logics.DeptLogic
{
    [Authorize(Roles = "IT")]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]

        public Department department { get; set; }

        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost(Department department)
        {
            CheckDuplication(department);
            if (ModelState.IsValid)
            {
                _context.Departments.Add(department);
                _context.SaveChanges();
                
            }
            return RedirectToPage("Index");
        }


        public void CheckDuplication(Department Dept)
        {
             var existDept = _context.Departments.Where(n => n.Name == Dept.Name);
            if(existDept.Any())
            {
                throw new Exception("Duplicate exists");
            }
        }
    }

    
}
