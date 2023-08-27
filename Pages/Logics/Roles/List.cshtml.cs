using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApprovalProcess.Pages.Logics.Roles
{
    public class ListModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public ListModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [BindProperty]
        public List<IdentityRole> Roles { get; set; }
        public void OnGet()
        {
            Roles = _roleManager.Roles.ToList();
        }
    }
}
