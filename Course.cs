using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class Course
    {

        [Key]
        [Display(Name = "CourseId")]
        public int CourseId { get; set; }
       
       

        [Display(Name = "CourseName")]
        [Column(TypeName = "Varchar(100)")]
        public string CourseName { get; set; }

        [Display(Name = "Description")]
        [Column(TypeName = "Varchar(500)")]
        public string Description { get; set; }

        [Display(Name = "InstructorId")]
        [Column(TypeName = "Varchar(20)")]
        public int InstructorId { get; set; }

       [ForeignKey("InstructorId")]


        [Display(Name = "Instructor")]
        [Column(TypeName = "Varchar(20)")]
        public Student Instructor { get; set; }
        [ForeignKey("InstructorId")]

        public ICollection<Enrollment> Enrollments { get; set; }
            
        
    }
}