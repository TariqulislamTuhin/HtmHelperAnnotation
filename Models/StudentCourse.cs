using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HtmHelperAnnotation.Models
{
    public class StudentCourse
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Student")]
        [Required]
        public int StudentId { get; set; }
        [Display(Name = "Course Title")]
        [Required]
        public int CourseId { get; set; }
        [Display(Name = "Department")]
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public DateTime EnrollDate { get; set; }
    }
}