using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Entities
{
    internal class Topic
    {
        [Required]
        public int ID { get; set; }
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
