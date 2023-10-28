using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class Progress
    {
        /*
        UserProgress Table (Tracking User Progress in Courses):

     user_progress_id (Primary Key)
     user_id (Foreign Key referencing Users table)
     course_id (Foreign Key referencing Courses table)
     
     lesson_id (Foreign Key referencing Lessons table)
     completion_status
    

             */


        [Key]
        [DisplayName("user_progress_id")]
        public int Id { get; set; }


        [Display(Name = "StudentID")]
        [Column(TypeName = "Varchar(20)")]
        public int StudentID { get; set; }
        [ForeignKey("StudentID")]

        [Display(Name = "CourseId")]
        [Column(TypeName = "Varchar(20)")]
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]


        [Display(Name = "lesson_id ")]
        [Column(TypeName = "Varchar(20)")]
        public int lesson_id { get; set; }
        [ForeignKey("lesson_id")]


        public bool CompletionStatus { get; set; }


    }
}