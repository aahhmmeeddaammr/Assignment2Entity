using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Entities
{
    internal class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }


        [Required]
        public string Name { get; set; }


        [Required]
        public decimal Bonus { get; set; }


        [Required]
        [Column(TypeName ="money")]
        public decimal Salary { get; set; }
        public string Address { get; set; }

        [Required]
        [Range(0 , int.MaxValue)]
        public decimal HourRate { get; set; }


        [ForeignKey("Dept_ID")]
        public Department? Department { get; set; }
        [NotMapped]
        
        public Department? ManageDepartment { get; set; }

        [InverseProperty("inst_ID")]
        ICollection<Course_Inst> Courses{ get;}=new HashSet<Course_Inst>();
    }
}
