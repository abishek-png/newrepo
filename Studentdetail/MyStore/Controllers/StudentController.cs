using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyStore.Db;
using MyStore.Model;

namespace Studentcrudoperation.Controllers {
    [Route("api")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly Databasecls _db;
        public StudentController(Databasecls db)
        {
            _db = db;

        }
        [HttpPost]
        [Route ("create")]
        public IActionResult create([FromBody]Student s)
        {
            _db.Add(s);
            _db.SaveChanges();

            return Ok(s);
        }
        [HttpGet]
        [Route("Get")]
        public IActionResult getAll() {
        List<Student> students =new List<Student>();
            students=_db.Students.ToList();
            return Ok(students);
        }
        [HttpGet]
        [Route("getbyid")]
        public IActionResult GetbyId(int id)
        {
            Student student = _db.Students.FirstOrDefault(x=>x.Id == id);
            return Ok(student);
        }
        [HttpPut]
        [Route("update")]
        public IActionResult Update(Student stu)
        {
            _db.Update(stu);
            _db.SaveChanges();
            return Ok(stu);
        }
        [HttpDelete]
        [Route("delete")]
        public IActionResult DeleteById(int id) {
            Student st = _db.Students.FirstOrDefault(x => x.Id == id);
            return Ok(st);
        }
    }
}
