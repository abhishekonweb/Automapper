using AutomapperApi.Models;
using AutomapperApi.Services;
using AutomapperApi.Models;
using AutomapperApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace Automapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly Icreate create;
        private readonly IMapper mapper;
        public StudentController(Icreate create , IMapper mapper)
        {
            this.create = create;
            this.mapper = mapper;
        }

        [HttpGet("GetData")]
        public async Task<ActionResult<List<Student>>> Getstudent()
        {
            List<Student> students = create.GetStudents();
            return Ok(students.Select(student=>mapper.Map<StudentDto>(student)).ToList());
        }

        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(StudentDto newstudent)
        {
            var student = mapper.Map<Student>(newstudent);
            create.CreateStudent(student);
            return (student);
        }
    }
}
