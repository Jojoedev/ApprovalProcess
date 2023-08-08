using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApprovalProcess.Models
{
    public class Request
    {
        public int RequestId { get; set; }

        [Required]
        [Display(Name ="Name of Requester")]
        public string RequesterName { get; set; }
        
        public int? DepartmentId { get; set; }
        
        [Display(Name ="Name of Department")]
        public virtual Department Department { get; set; }
       
        
        [Required]    
        [Display(Name ="Request Description")]
        public string RequestDescription { get; set; }
        
        [Required]
        [Display(Name ="Amount")]
        public decimal RequestAmount { get; set; }

                
        [Display(Name ="Date of Request")]
        public DateTime RequestedDate { get; set; }


        [Required]
        [Display(Name ="Supporting Documents")]
        public string SupportingDoc { get; set; }
        
        [Display(Name ="Request Status")]
        public string RequestStatus {get; set;} 
       


    }
        
}
