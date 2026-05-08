using Day1.DTOs;
using Day1.Filters;
using Day1.Models;
using Day1.Repositories;
using Day1.UnitOfWork;
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
        private readonly IUnitOfWork _uow;
        private readonly IMapper Mapper;

        public StudentController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            Mapper = mapper;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
        {
            var students = await _uow.StudentRepo.GetAllAsync(cancellationToken: cancellationToken);
            var result = Mapper.Map<List<Student>, List<StudentDTO>>(students);

            return Ok(new { data = result, msg = "Students Retrieved Successfully" });
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIDAsync(int id, CancellationToken cancellationToken)
        {
            var student = await _uow.StudentRepo.GetByIDAsync(id, cancellationToken);
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
        public async Task<IActionResult> Add(StudentDTO studentDTO, CancellationToken cancellationToken = default)
        {
            var student = Mapper.Map<Student>(studentDTO);

            await _uow.StudentRepo.AddAsync(student, cancellationToken);
            int affectedRows = await _uow.SaveAsync(cancellationToken);


            return CreatedAtAction(nameof(GetByIDAsync), new { id = student.ID }, new { data = student, rows = affectedRows, msg = $"Student with ID {student.ID} Added Successfully" });
        }


        [HttpPut]
        public async Task<IActionResult> Update(StudentDTO studentDTO, CancellationToken cancellationToken = default)
        {
            var student = Mapper.Map<Student>(studentDTO);
            _uow.StudentRepo.Update(student);
            int affectedRows = await _uow.SaveAsync(cancellationToken);
            return Ok(new { data = student, rows = affectedRows, msg = $"Student with ID {student.ID} Updated Successfully" });
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken = default)
        {
            var student = await _uow.StudentRepo.GetByIDAsync(id, cancellationToken);
            if (student == null)
                return NotFound($"No Student Found with this ID: {id}");
            await _uow.StudentRepo.DeleteAsync(student.ID, cancellationToken);
            int affectedRows = await _uow.SaveAsync(cancellationToken);
            return Ok(new { data = student, rows = affectedRows, msg = $"Student with ID {student.ID} Deleted Successfully" });
        }

        [HttpGet("test-cancellation")]
        public async Task<IActionResult> TestCancellation(CancellationToken cancellationToken)
        {
            Console.WriteLine("Started Cancellation Endpoint");

            try
            {
                await Task.Delay(10_000, cancellationToken);

                Console.WriteLine("Finished Cancellation Endpoint");

                return Ok(new
                {
                    msg = "Cancellation test completed."
                });
            }
            catch (TaskCanceledException)
            {
                Console.WriteLine("Task Was Cancelled");


                return BadRequest();
            }
        }

        [HttpGet("test-no-cancellation")]
        public async Task<IActionResult> TestNoCancellation()
        {
            Console.WriteLine("Started No Cancellation Endpoint");

            try
            {
                await Task.Delay(10_000);

                Console.WriteLine("Finished No Cancellation Endpoint");

                return Ok(new
                {
                    msg = "No cancellation test completed."
                });
            }
            catch (TaskCanceledException)
            {
                Console.WriteLine("Task Was Cancelled");


                return BadRequest();
            }
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
