using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    [Table("StudentGradeDetails")]
    public class StudentGradeDetail
    {
        [Key]
        public int Id { get; set; }
        public string Student { get; set; }
        public int LanguageArts { get; set; }
        public int Science { get; set; }
        public int SocialStudies { get; set; }
        public int Maths { get; set; }
    }
}
