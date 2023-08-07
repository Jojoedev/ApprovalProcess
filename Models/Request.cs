using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApprovalProcess.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public string RequesterName { get; set; }
        
        public int DepartmentId { get; set; }
        public virtual Department Departments { get; set; }

        //public string RequesterDepartment { get; set; } //Dropdown list
        public string RequestDescription { get; set; }
        public decimal RequestAmount { get; set; }
        public DateTime RequestedDate { get; set; }
        public string SupportingDoc { get; set; }
        public string RequestStatus {get; set;} 
       


    }
        
}
