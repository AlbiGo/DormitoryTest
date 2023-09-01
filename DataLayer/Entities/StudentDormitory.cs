using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class StudentDormitory
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Student")]
        public int StudentId { get;}
        public Student Student { get; set; }
        
        [Required]
        [ForeignKey("Dormitory")]
        public int DormitoryID { get; set; }
        public Dormitory Dormitory { get; set; }
    }
}
