using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    [Table("StudentGrades")]
    public class StudentGrade
    {
        [Key]
        public int Id { get; set; }

        public int Mark { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
