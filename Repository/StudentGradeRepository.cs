using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StudentGradeRepository<T> : IStudentGradeRepository<T> where T : class
    {
        private StudentGradesContext db;
        private DbSet<T> dbSet;

        public StudentGradeRepository()
        {
            db = new StudentGradesContext();
            dbSet = db.Set<T>();
        }
        public void Delete(object Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();            
        }

        public T GetById(object Id)
        {
            throw new NotImplementedException();
        }
    }
}
