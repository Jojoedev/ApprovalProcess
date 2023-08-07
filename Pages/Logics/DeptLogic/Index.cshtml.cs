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
    

    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<Department> departments { get; set; }


        public void OnGet()
        {
            departments = _context.Departments.ToList();
        }
    }
}
