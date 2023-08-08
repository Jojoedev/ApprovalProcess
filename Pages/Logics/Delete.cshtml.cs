using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprovalProcess.Data;
using ApprovalProcess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApprovalProcess.Pages.Logics
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Request request { get; set; }
        public ActionResult OnGet(int? id)
        {
            var DelItem = (from x in _context.Requests
                           where x.RequestId == id
                           select x).FirstOrDefault();
            if(DelItem == null)
            {
                return NotFound();
            }

            _context.Remove(DelItem);
            _context.SaveChanges();
            return RedirectToPage("List");
        }
    }
}
