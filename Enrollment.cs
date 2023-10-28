using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class Enrollment
    {
        //Enrollment_id  CourseId  CycleId  StudenId  EnrollmentDate

        [Key]
        [Display(Name = "Enrollment_id")]
        public int Enrollment_id { get; set; }
       


        [Display(Name = "CourseId")]
        [Column(TypeName = "Varchar(14)")]
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]


        [Display(Name = "CycleId")]
        public int CycleId { get; set; }
        [ForeignKey("CycleId")]


        [Display(Name = "StudentId")]
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]


        [Display(Name = "EnrollmentDate")]
        [Column(TypeName = "Varchar(15)")]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }
        
       


    }
}