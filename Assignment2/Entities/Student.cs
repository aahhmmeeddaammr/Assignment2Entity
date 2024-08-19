using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Entities
{
    internal class Student
    {        
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public  string Address { get; set; }
        [Range(18,100)]
        public int Age { get; set; }
        [ForeignKey("Dep_Id")]
        public Department? Department { get; set; }
        public ICollection<Stud_Course> Courses { get; set; }=new HashSet<Stud_Course>();
    }
}
