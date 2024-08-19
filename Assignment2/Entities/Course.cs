using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Entities
{
    internal class Course
    {
        
        public int ID { get; set; }
        [Range(0,3)]
        [Required]
        public int Duration { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Description { get; set; }
        [ForeignKey("Top_ID")]
        
        public Topic? Topic { get; set; }
        [InverseProperty("Course_ID")]
        ICollection<Stud_Course> Students { get; set; } = new HashSet<Stud_Course>();
        [InverseProperty("Course_ID")]
        ICollection<Course_Inst> Instructors { get; set; } = new HashSet<Course_Inst>();

    }
}
