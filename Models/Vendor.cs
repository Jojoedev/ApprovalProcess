using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApprovalProcess.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Vendor Name")]
        public string VendorName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
        [Required]

        [Display(Name ="Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [MinLength(11, ErrorMessage ="It must be 11 digits")]
        [MaxLength(11, ErrorMessage ="It must be 11 digits")]
        public string Phone { get; set; }
    }
}
