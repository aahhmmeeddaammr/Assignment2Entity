using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Entities
{
    internal class Course_Inst
    {
        [Required]
        [ForeignKey("inst_ID")]
        public Instructor? Instructor { get; set; }
        [Required]
        [ForeignKey("Course_ID")]
        public Course? Course { get; set; }
        [Required]
        public string Evaluate { get; set; }
    }
}
