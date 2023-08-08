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
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Department department { get; set; }
        public ActionResult OnGet(int? id)
        {
            if (id != null)
            {
                var Delitem = (from n in _context.Departments
                               where n.Id == id
                               select n).FirstOrDefault();
                _context.Remove(Delitem);
                _context.SaveChanges();
            }
                
            return RedirectToPage("Index");
           
        }
    }
}
