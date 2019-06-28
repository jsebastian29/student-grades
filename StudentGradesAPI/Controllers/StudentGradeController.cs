using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentGradesAPI.Controllers
{
    public class StudentGradeController : ApiController
    {
        private IStudentGradeRepository<StudentGradeDetail> _repository = null;
        public StudentGradeController()
        {
            this._repository = new StudentGradeRepository<StudentGradeDetail>();
        }

        // GET: api/StudentGrade
        public IEnumerable<StudentGradeDetail> Get()
        {
            var lstStudentGradeDetails = _repository.GetAll();
            return lstStudentGradeDetails;
        }

        [Route("api/StudentGrade/GetByMark")]
        public IEnumerable<StudentGradeDetail> GetByMark(int mark)
        {
            var lstStudentGradeDetails = _repository.GetAll()
                .Where(x => x.LanguageArts > mark
                        && x.Maths > mark
                        && x.Science > mark
                        && x.SocialStudies > mark);

            return lstStudentGradeDetails;
        }

        [Route("api/StudentGrade/GetByStudentName")]
        public IEnumerable<StudentGradeDetail> GetByStudentName(string studentName)
        {
            var lstStudentGradeDetails = _repository.GetAll().Where(x => x.Student.Contains(studentName));
            return lstStudentGradeDetails;
        }

        [Route("api/StudentGrade/GetByFilters")]
        public IEnumerable<StudentGradeDetail> GetByFilters(int? mark, string StudentName)
        {
            Func<StudentGradeDetail, bool> filter = null;
            IEnumerable<StudentGradeDetail> lstStudentGradeDetails = new List<StudentGradeDetail>();

            if (mark != null)
            {
                if (!string.IsNullOrWhiteSpace(StudentName))
                {
                    filter = (x => x.Student.ToUpper().Contains(StudentName.ToUpper())
                        && x.LanguageArts > mark
                        && x.Maths > mark
                        && x.Science > mark
                        && x.SocialStudies > mark);
                }
                else
                {
                    filter = (x => x.LanguageArts > mark
                        && x.Maths > mark
                        && x.Science > mark
                        && x.SocialStudies > mark);
                }
            }
            else if (!string.IsNullOrWhiteSpace(StudentName))
            {
                filter = (x => x.Student.ToUpper().Contains(StudentName.ToUpper()));
            }
            else
            {
                return lstStudentGradeDetails;
            }

            lstStudentGradeDetails = _repository.GetAll().Where(filter);
            return lstStudentGradeDetails;
        }
    }
}
