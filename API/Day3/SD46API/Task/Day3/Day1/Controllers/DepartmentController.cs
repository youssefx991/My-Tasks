using Day1.DTOs;
using Day1.Models;
using Day1.Repositories;
using MapsterMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepo DepartmentRepo;
        private readonly IMapper Mapper;
        public DepartmentController(IDepartmentRepo departmentRepo, IMapper mapper)
        {
            DepartmentRepo = departmentRepo;
            Mapper = mapper;
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var departments = DepartmentRepo.GetAllWithStudents();
            var result = Mapper.Map<List<Department>, List<DepartmentWithStudentsDTO>>(departments);
            return Ok(new {data=result, msg="Departments with students retrieved successfully."});
        }

        [HttpGet("alldepts")]
        public IActionResult GetAllDepts()
        {
            var departments = DepartmentRepo.GetAll();

            var result = Mapper.Map<List<Department>, List<DepartmentDTO>>(departments);
            return Ok(new {data=result, msg="Departments retrieved successfully."});
        }


        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var department = DepartmentRepo.GetByID(id);
            if (department == null)
                return NotFound();
            return Ok(new {data=department, msg="Department retrieved successfully."});
        }

        [HttpPost]
        public IActionResult Add(DepartmentDTO departmentDTO)
        {
            var department = Mapper.Map<DepartmentDTO, Department>(departmentDTO);
            DepartmentRepo.Add(department);
            return CreatedAtAction(nameof(Get), new { id = department.ID }, department);

        }

        [HttpPut]
        public IActionResult Update(DepartmentDTO departmentDTO)
        {
            var department = Mapper.Map<DepartmentDTO, Department>(departmentDTO);
            DepartmentRepo.Update(department);
            return Ok(new {data=department, msg="Department updated successfully."});
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var department = DepartmentRepo.GetByID(id);
            if (department == null)
                return NotFound();
            DepartmentRepo.Delete(department.ID);
            return Ok(new {data=department, msg="Department deleted successfully."});
        }
    }
}
