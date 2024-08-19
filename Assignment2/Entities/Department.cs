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
    internal class Department
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Name { get; set; }

        [ForeignKey("Ins_Id")]
        public Instructor? Instructor { get; set; }
        public DateTime HiringDate { get; set; }

        ICollection<Instructor> Instructors { get; set; }= new HashSet<Instructor>();
        ICollection<Student> students { get;}=new HashSet<Student>();
    }
}
