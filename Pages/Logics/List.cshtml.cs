using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprovalProcess.Data;
using ApprovalProcess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApprovalProcess.Pages
{
    /*[Authorize(Policy = "RequireAdmin")]*/
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _Context;
        public ListModel(ApplicationDbContext context)
        {
            _Context = context;
        }

        public Department department { get; set; }
        [BindProperty]
        public List<Request> RequestObj { get; set; }
        public void OnGet()
        {
            // RequestObj = (from n in _Context.Requests
            //             select n).ToList();

            RequestObj = _Context.Requests.ToList();
                       
        }
    }
}
