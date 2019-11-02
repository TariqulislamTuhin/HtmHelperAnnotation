using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HtmHelperAnnotation.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Department Name"), Required]
        public string Name { get; set; }
        [Display(Name = "Code Name"),Required]
        public string Code { get; set; }   
    }
}