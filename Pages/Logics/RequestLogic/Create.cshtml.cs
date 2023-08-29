using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ApprovalProcess.Data;
using ApprovalProcess.Data.Migrations;
using ApprovalProcess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ApprovalProcess.Pages.Logics
{
    /*[Authorize(Policy="RequireAdmin")]*/

    [Authorize(Roles = "IT, HR-Request Preparer,CTO")]
    public class CreateModel : PageModel

    {
        private readonly ApplicationDbContext _Context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CreateModel(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _Context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        [BindProperty]
        public Request RequestObj { get; set; }

        public SelectList Deptdropdown { get; set; }
        public SelectList Vendordropdown { get; set; }
        
        public SelectList StatusDropDown {get; set;}

        public ActionResult OnGet()
        {
           LoadDropDown();
            
            return Page();
        }
        public ActionResult OnPost(Request RequestObj)
        {

            RequestObj.RequestedDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                
                if (RequestObj.Image != null)
                {
                    var image = RequestObj.Image;

                    string folder = "Image/docs/";
                    folder += Guid.NewGuid().ToString()+"-"+ image.FileName;
                    string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, folder);
                    
                    image.CopyToAsync(new FileStream(FilePath, FileMode.Create));
                    
                    //OR

                   // FileStream fileStream = new FileStream(FilePath, FileMode.Create);
                    //image.CopyToAsync(fileStream);
                }

                _Context.Add(RequestObj);
                _Context.SaveChanges();
                Statics.ExportToExcel.ToExcel();
                RedirectToPage("/Logics/RequestLogic/List");
            }
            //DeptDropDown = new SelectList(_Context.Departments.ToList(), "Id", "Name");
           return RedirectToPage("/Logics/RequestLogic/List");
            //return Page();
            
        }

        public void LoadDropDown()
        {
            Deptdropdown = new SelectList(_Context.Departments.ToList(), "Id", "Name");
            Vendordropdown = new SelectList(_Context.Vendors.ToList(), "Id", "VendorName");
            StatusDropDown = new SelectList(_Context.Statuses.ToList(), "Id", "Name");

        }
    }
}
