using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprovalProcess.Data;
using ApprovalProcess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ApprovalProcess.Pages.Logics
{
    public class UpdateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public UpdateModel(ApplicationDbContext context)
        {
            _context = context;

        }

        [BindProperty]
        public Request request { get; set; }

        public SelectList department { get; set; }
        public ActionResult OnGet(int? id)
        {
            if(id != null)
            {
                request = (from n in _context.Requests
                                 where n.RequestId == id
                                 select n).FirstOrDefault();
                department = new SelectList(_context.Departments.ToList(), "Id", "Name");
               
               
            }
            return Page();

        }

        public ActionResult OnPost(Request request)
        {
            if(ModelState.IsValid)
            {
               // _Context.Entry(StockItem).Property(X => X.StockName).IsModified = false;
                _context.Entry(request).Property(x => x.RequestId).IsModified = false;
                _context.Entry(request).Property(x => x.RequesterName).IsModified = true;
                 _context.Entry(request).Property(x => x.DepartmentId).IsModified = false;
                _context.Entry(request).Property(x => x.RequestedDate).IsModified = false;
                //_context.Entry(request).Property(x => x.Departments.Name).IsModified = true;


                _context.Entry(request).Property(x => x.RequestDescription).IsModified = true;
                _context.Entry(request).Property(x => x.RequestAmount).IsModified = true;
                _context.Entry(request).Property(x => x.SupportingDoc).IsModified = true;


                
                _context.SaveChanges();

            }

            return RedirectToPage("List");
        }
    }
}
