using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprovalProcess.Data;
using ApprovalProcess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApprovalProcess.Pages.Logics.StatusLogic
{
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _Context;
        public ListModel(ApplicationDbContext context)
        {
            _Context = context;
        }

        public List<Status> Status { get; set; }
        public void OnGet()
        {
            Status = _Context.Statuses.ToList();
        }
    }
}
