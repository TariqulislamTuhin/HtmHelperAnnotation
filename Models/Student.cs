using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace HtmHelperAnnotation.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(10, ErrorMessage = "Name Should be 6 to 10 character ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your Registration No.")]
        public string RegNo { get; set; }
        [Required(ErrorMessage = "Please enter your Email.")]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Please enter a valid email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your Gender.")]
        public string Gender { get; set; }
        [DisplayName("Department")]
        [Required(ErrorMessage = "Please enter your Department.")]
        public string DepartmentId { get; set; }
        [Required(ErrorMessage = "Please enter your Address.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter your Password."),
         StringLength(maximumLength: 30, MinimumLength = 6, ErrorMessage = "Password at least 6 character")]
        public string Password { get; set; }
        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Re-enterYour Password")]
        [StringLength(30, MinimumLength = 6)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }


    }
}