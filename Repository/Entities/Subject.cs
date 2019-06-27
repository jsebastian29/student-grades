using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    [Table("Subjects")]
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        public string SubjectName { get; set; }

        public ICollection<StudentGrade> StudentGrade { get; set; }
    }
}
