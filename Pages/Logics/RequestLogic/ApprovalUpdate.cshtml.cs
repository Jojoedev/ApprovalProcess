using ApprovalProcess.Data;
using ApprovalProcess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace ApprovalProcess.Pages.Logics.RequestLogic
{
    [Authorize(Roles = "IT, Finance Director")]
    public class ApprovalUpdateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public ApprovalUpdateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public SelectList Deptdropdown { get; set; }
        public SelectList Vendordropdown { get; set; }
        public SelectList StatusDropDown { get; set; }
        
        [BindProperty]
        public Request request { get; set; }

        public ActionResult OnGet(int id)
        {
            request = _context.Requests.Where(z => z.RequestId == id).FirstOrDefault();
            if(request == null)
            {
                return NotFound();
            }
            LoadData();
            return Page();
        }


        public ActionResult OnPost(Request request)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(request).Property(x => x.RequestId).IsModified = false;
                _context.Entry(request).Property(x => x.RequesterName).IsModified = false;
                _context.Entry(request).Property(x => x.RequestedDate).IsModified = false;
                _context.Entry(request).Property(x => x.DepartmentId).IsModified = false;
                _context.Entry(request).Property(x => x.RequestDescription).IsModified = false;
                _context.Entry(request).Property(x => x.RequestAmount).IsModified = false;
                _context.Entry(request).Property(x => x.VendorId).IsModified = false;
                _context.Entry(request).Property(x => x.SupportingDoc).IsModified = false;
                _context.Entry(request).Property(x => x.StatusId).IsModified = false;
                _context.Entry(request).Property(x => x.Remark).IsModified = true;
                _context.Entry(request).Property(x => x.LineManager).IsModified = false;
                _context.Entry(request).Property(x => x.FinanceDirector).IsModified = true;

                _context.SaveChanges();
                return RedirectToPage("DefaultList");
            }
            return Page();
        }


        public void LoadData()
        {
            Deptdropdown = new SelectList(_context.Departments.ToList(), "Id", "Name");
            Vendordropdown = new SelectList(_context.Vendors.ToList(), "Id", "VendorName");
            StatusDropDown = new SelectList(_context.Statuses.ToList(), "Id", "Name");
        }
    }
}
