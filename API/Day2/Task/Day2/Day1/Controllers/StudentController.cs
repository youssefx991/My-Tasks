using Day1.Filters;
using Day1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentContext Context { get; }

        public StudentController()
        {
            Context = new();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var students = Context.Students.ToList();
            if (students.Count == 0)
                return NotFound("No Students Found");

            return Ok(new { data = students, msg = "Students Retrieved Successfully" });
        }

        [HttpGet("{id:int}")]
        public IActionResult GetByID(int id)
        {
            var student = Context.Students.FirstOrDefault(s => s.ID == id);
            if (student == null)
                return NotFound($"No Student Found with this ID: {id}");
            return Ok(new { data = student, msg = $"Student with ID {id} Retrieved Successfully" });
        }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            var students = Context.Students.Where(s => s.Name == name).ToList();
            if (students.Count == 0)
                return NotFound($"No Student Found with this Name: {name}");
            return Ok(new { data = students, msg = $"Student with Name {name} Retrieved Successfully" });
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            if (student == null)
                return BadRequest("Student is null");

            Context.Students.Add(student);
            Context.SaveChanges();

            return CreatedAtAction(nameof(GetByID), new { id = student.ID }, new { data = student, msg = $"Student with ID {student.ID} Added Successfully" });
        }


        [HttpPut]
        public IActionResult Update(Student student)
        {
            if (student == null)
                return BadRequest("Student is null");
            Context.Students.Update(student);
            Context.SaveChanges();
            return Ok(new { data = student, msg = $"Student with ID {student.ID} Updated Successfully" });
        }
        
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var student = Context.Students.FirstOrDefault(s => s.ID == id);
            if (student == null)
                return NotFound($"No Student Found with this ID: {id}");
            Context.Students.Remove(student);
            Context.SaveChanges();
            return Ok(new { data = student, msg = $"Student with ID {student.ID} Deleted Successfully" });
        }


        [HttpGet("throw")]
        [ExceptionHandleFilter]

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
