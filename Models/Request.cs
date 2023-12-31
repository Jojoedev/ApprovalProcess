﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public int? VendorId { get; set; }
        [Display(Name ="Vendor")]
        public virtual Vendor Vendor { get; set; }


        [Required]
        [Display(Name ="Source Documents")]
        public string SupportingDoc { get; set; }

       
        [Display(Name = "File")]
        [NotMapped]
        public IFormFile Image { get; set; }

        
        [Display(Name ="Request Status")]
        public int? StatusId { get; set; }
        public virtual Status Status {get; set;}

        public string Remark { get; set; }

        public int? FirstApproverId { get; set; }
        public virtual FirstApprover FirstApprover { get; set; }


        //Approvals

        public string LineManager { get; set; }
        public string FinanceDirector { get; set; }
        public string ManagingDirector { get; set; }


    }
        
}
