using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprovalProcess.Data;
using ApprovalProcess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApprovalProcess.Pages.Logics.VendorLogic
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<Vendor> Vendors { get; set; }
        public void OnGet()
        {
            Vendors = _context.Vendors.ToList();
            
        }
    }
}
