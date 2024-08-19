using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Entities
{
    internal class Stud_Course
    {

        [ForeignKey("stud_ID")]
        public Student? Student { get; set; }
        [Required]
        [ForeignKey("Course_ID")]
        public Course? Course { get; set; }
        [Range(0,100)]
        public int Grade { get; set; }
    }
}
