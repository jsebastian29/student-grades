using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StudentGradesContext: DbContext
    {
        public StudentGradesContext() : base("name=DBStudentsConnection")
        {
            Database.SetInitializer<StudentGradesContext>(new DBInitialize());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentGrade> StudentGrades { get; set; }
    }
}
