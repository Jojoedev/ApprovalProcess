using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApprovalProcess.Data;
using ApprovalProcess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApprovalProcess.Pages.Logics.FApproverLogic
{
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _Context;
        public ListModel(ApplicationDbContext context)
        {
            _Context = context;
        }

        [BindProperty]
        public List<FirstApprover> FirstApprover { get; set; }
        public void OnGet()
        {
            FirstApprover = _Context.FirstApprovers.ToList();
        }
    }
}
