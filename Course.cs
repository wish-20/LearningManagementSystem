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

       [Display(Name = "Id")]
public int Id { get; set; }
       
       

[Display(Name = "CourseName")]

public string CourseName { get; set; }

[Display(Name = "Description")]

public string Description { get; set; }

[Display(Name = "InstructorId")]

public int InstructorId { get; set; }


[Display(Name = "InstructorName")]

public Student InstructorName { get; set; }
       





public ICollection<Enrollment> Enrollments { get; set; }
public ICollection<Video> Video { get; set; }
        
    }
}
