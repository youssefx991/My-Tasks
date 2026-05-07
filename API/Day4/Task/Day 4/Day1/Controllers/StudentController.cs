using Day1.DTOs;
using Day1.Filters;
using Day1.Models;
using Day1.Repositories;
using MapsterMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAll")]

    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IGenericRepo<Student> StudentRepo;
        private readonly IMapper Mapper;

        public StudentController(IGenericRepo<Student> studentRepo, IMapper mapper)
        {
            StudentRepo = studentRepo;
            Mapper = mapper;
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var students = StudentRepo.GetAll();
            var result = Mapper.Map<List<Student>, List<StudentDTO>>(students);

            return Ok(new { data = result, msg = "Students Retrieved Successfully" });
        }

        [HttpGet("{id:int}")]
        public IActionResult GetByID(int id)
        {
            var student = StudentRepo.GetByID(id);
            if (student == null)
                return NotFound($"No Student Found with this ID: {id}");
            var result = Mapper.Map<StudentDTO>(student);
            return Ok(new { data = result, msg = $"Student with ID {id} Retrieved Successfully" });
        }

        //[HttpGet("{name}")]
        //public IActionResult GetByName(string name)
        //{
        //    var students = Context.Students.Where(s => s.Name == name).ToList();
        //    if (students.Count == 0)
        //        return NotFound($"No Student Found with this Name: {name}");
        //    return Ok(new { data = students, msg = $"Student with Name {name} Retrieved Successfully" });
        //}

        [HttpPost]
        public IActionResult Add(StudentDTO studentDTO)
        {
            var student = Mapper.Map<Student>(studentDTO);

            StudentRepo.Add(student);


            return CreatedAtAction(nameof(GetByID), new { id = student.ID }, new { data = student, msg = $"Student with ID {student.ID} Added Successfully" });
        }


        [HttpPut]
        public IActionResult Update(StudentDTO studentDTO)
        {
            var student = Mapper.Map<Student>(studentDTO);
            StudentRepo.Update(student);
            return Ok(new { data = student, msg = $"Student with ID {student.ID} Updated Successfully" });
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var student = StudentRepo.GetByID(id);
            if (student == null)
                return NotFound($"No Student Found with this ID: {id}");
            StudentRepo.Delete(student.ID);
            return Ok(new { data = student, msg = $"Student with ID {student.ID} Deleted Successfully" });
        }


        [HttpGet("throw")]


        public IActionResult ThrowException()
        {
            throw new Exception("Exception in Student action");
        }

        [HttpGet("result")]
        [ResultFilter]

        public IActionResult Result()
        {
            Console.WriteLine("Executing Result Action");
            return Ok("Result Action Executed Successfully");
        }
    }
}
