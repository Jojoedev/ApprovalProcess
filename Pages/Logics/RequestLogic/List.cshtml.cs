using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprovalProcess.Data;
using ApprovalProcess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ApprovalProcess.Pages
{
    [Authorize(Roles ="IT, Line Manager")]
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _Context;
        public ListModel(ApplicationDbContext context)
        {
            _Context = context;
        }

        
        public Department Department { get; set; }
        public Vendor Vendor { get; set; }
        public Status Status { get; set; }


        [BindProperty]
        public List<Request> RequestObj { get; set; }
        public void OnGet()
        {
                 RequestObj = _Context.Requests.OrderByDescending(x =>x.RequestedDate)
                .Include(a => a.Vendor)
                .Include(x => x.Department)
                .Include(y => y.Status)
                .ToList();
        }
    }
}
