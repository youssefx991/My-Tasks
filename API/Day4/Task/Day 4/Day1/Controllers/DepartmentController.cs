using Day1.DTOs;
using Day1.Models;
using Day1.Repositories;
using Day1.UnitOfWork;
using MapsterMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAll")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper Mapper;
        public DepartmentController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            Mapper = mapper;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken = default)
        {
            var departments = await _uow.DepartmentRepo.GetAllAsync(new string[] { "Students" }, cancellationToken);
            var result = Mapper.Map<List<Department>, List<DepartmentWithStudentsDTO>>(departments);
            return Ok(new { data = result, msg = "Departments with students retrieved successfully." });
        }

        [HttpGet("alldepts")]
        public async Task<IActionResult> GetAllDepts(CancellationToken cancellationToken = default)
        {
            var departments = await _uow.DepartmentRepo.GetAllAsync(cancellationToken: cancellationToken);

            var result = Mapper.Map<List<Department>, List<DepartmentDTO>>(departments);
            return Ok(new { data = result, msg = "Departments retrieved successfully." });
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id, CancellationToken cancellationToken = default)
        {
            var department = await _uow.DepartmentRepo.GetByIDAsync(id, cancellationToken);
            if (department == null)
                return NotFound();
            return Ok(new { data = department, msg = "Department retrieved successfully." });
        }

        [HttpPost]
        public async Task<IActionResult> Add(DepartmentDTO departmentDTO, CancellationToken cancellationToken = default)
        {
            var department = Mapper.Map<DepartmentDTO, Department>(departmentDTO);
            await _uow.DepartmentRepo.AddAsync(department, cancellationToken);
            int affectedRows = await _uow.SaveAsync(cancellationToken);
            return CreatedAtAction(nameof(Get), new { id = department.ID }, new { data = department, rows = affectedRows, msg = "Department created successfully." });

        }

        [HttpPut]
        public async Task<IActionResult> Update(DepartmentDTO departmentDTO, CancellationToken cancellationToken)
        {
            var department = Mapper.Map<DepartmentDTO, Department>(departmentDTO);
            _uow.DepartmentRepo.Update(department);
            int affectedRows = await _uow.SaveAsync(cancellationToken);

            return Ok(new { data = department, rows = affectedRows, msg = "Department updated successfully." });
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            var department = await _uow.DepartmentRepo.GetByIDAsync(id, cancellationToken);
            if (department == null)
                return NotFound();
            await _uow.DepartmentRepo.DeleteAsync(department.ID, cancellationToken);
            int affectedRows = await _uow.SaveAsync(cancellationToken);

            return Ok(new { data = department, rows = affectedRows, msg = "Department deleted successfully." });
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
    }
}
