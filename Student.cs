using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace LMS.Models
{
    public class Student
    {

        //StudentID  studentname  Email Birthdate Password PhoneNo
        //do i have to impelement the role?
        [Key]
        [Display(Name ="Id")]
        public int StudentID { get; set; }


        [Display(Name = "Name")]
        [Column(TypeName = "Varchar(200)")]
        public string studentname { get; set; }


        [Display(Name = "Email")]
        [Column(TypeName = "Varchar(200)")]
        public string Email { get; set; }


        [Display(Name = "Birthdate")]
        [Column(TypeName = "Varchar(15)")]
        public DateTime Birthdate { get; set; }


        [Display(Name = "Password")]
        [Column(TypeName = "Varchar(25)")]
        public DateTime Password { get; set; }



        [Display(Name = "PhoneNo")]
        [Column(TypeName = "Varchar(20)")]
        [DataType(DataType.Date)]
        public string PhoneNo { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }


    }
}