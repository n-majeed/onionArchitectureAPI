using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.StudentService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onionArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        #region Property  
        private readonly IStudentService _studentService;
        #endregion

        #region Constructor  
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        #endregion

        [HttpGet(nameof(GetStudent))]
        public IActionResult GetStudent(int id)
        {
            var result = _studentService.GetStudent(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpGet(nameof(GetAllStudents))]
        public IActionResult GetAllStudents()
        {
            var result = _studentService.GetAllStudents();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpPost(nameof(InsertStudent))]
        public IActionResult InsertStudent(Student student)
        {
            _studentService.InsertStudent(student);
            return Ok("Data inserted");

        }
        [HttpPut(nameof(UpdateStudent))]
        public IActionResult UpdateStudent(Student student)
        {
            _studentService.UpdateStudent(student);
            return Ok("Updation done");

        }
        [HttpDelete(nameof(DeleteStudent))]
        public IActionResult DeleteStudent(int Id)
        {
            _studentService.DeleteStudent(Id);
            return Ok("Data Deleted");

        }
    }
}
