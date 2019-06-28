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

        // GET: api/StudentGrade/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/StudentGrade
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/StudentGrade/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/StudentGrade/5
        public void Delete(int id)
        {
        }
    }
}
