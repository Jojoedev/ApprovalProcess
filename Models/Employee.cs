using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApprovalProcess.Models
{
    public class Employee : IdentityUser
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        
    }
}
