using ApprovalProcess.Data;
using ApprovalProcess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApprovalProcess.Pages.Logics.RequestLogic
{
    [Authorize(Roles ="IT, MD")]
    public class LastApprovalModel : PageModel
    {
        private readonly ApplicationDbContext _Context;
        public LastApprovalModel(ApplicationDbContext context)
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
            RequestObj = _Context.Requests.Where(b => b.RequestAmount >= 5000000).OrderByDescending(x => x.RequestedDate)
                .Include(x=> x.Department)
                .Include(x=> x.Vendor)
                .Include(x=> x.Status)
                .ToList();
        }
    }
}
