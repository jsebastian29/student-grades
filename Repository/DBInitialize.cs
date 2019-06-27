using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DBInitialize : DropCreateDatabaseIfModelChanges<StudentGradesContext>
    {
        protected override void Seed(StudentGradesContext context)
        {
            var lstSubjects = new List<Subject>
            {
                new Subject { Id = 1, SubjectName = ""}
            };
            base.Seed(context);
        }
    }
}
