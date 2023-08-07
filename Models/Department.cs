using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ApprovalProcess.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Department")]
        public string Name { get; set; }
    }
}
