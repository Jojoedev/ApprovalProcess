using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprovalProcess.Data;
using ApprovalProcess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ApprovalProcess.Pages.Logics
{
    [Authorize(Roles = "IT, CTO, MD")]
    public class UpdateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public UpdateModel(ApplicationDbContext context)
        {
            _context = context;

        }

        [BindProperty]
        public Request request { get; set; }

        public SelectList Deptdropdown { get; set; }
        public SelectList Vendordropdown { get; set; }
        public SelectList StatusDropDown { get; set; }
        
        public ActionResult OnGet(int? id)
        {
            if(id != null)
            {
                LoadData();
                request = _context.Requests.Where(x => x.RequestId == id).FirstOrDefault();
                int a = request.RequestId;
            }
            return Page();
        }

        public ActionResult OnPost(Request request)
        {
            LoadData();


            if (ModelState.IsValid)
            {
              
                _context.Entry(request).Property(x => x.RequestId).IsModified = false;
                _context.Entry(request).Property(x => x.RequesterName).IsModified = false;
               _context.Entry(request).Property(x => x.RequestedDate).IsModified = false;
                _context.Entry(request).Property(x => x.DepartmentId).IsModified = false;
                _context.Entry(request).Property(x => x.RequestDescription).IsModified = false;
                _context.Entry(request).Property(x => x.RequestAmount).IsModified = true;
                _context.Entry(request).Property(x => x.VendorId).IsModified = false;
                _context.Entry(request).Property(x => x.SupportingDoc).IsModified = false;
                _context.Entry(request).Property(x => x.StatusId).IsModified = true;
                _context.Entry(request).Property(x => x.Remark).IsModified = true;


                _context.SaveChanges();

            }

            return RedirectToPage("List");
        }

        public void LoadData()
        {
            Deptdropdown = new SelectList(_context.Departments.ToList(), "Id", "Name");
            Vendordropdown = new SelectList(_context.Vendors.ToList(), "Id", "VendorName");
            StatusDropDown = new SelectList(_context.Statuses.ToList(), "Id", "Name");
        }
    }
}
