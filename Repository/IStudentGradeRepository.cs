using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IStudentGradeRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetById(object Id);        
    }
}
