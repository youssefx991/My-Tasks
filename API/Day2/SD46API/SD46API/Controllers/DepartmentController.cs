using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SD46API.Context;
using SD46API.Filters;
using SD46API.Models;
using System.Reflection.Metadata.Ecma335;

namespace SD46API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        //IExceptionFilter;
        //    IActionFilter 
        CompanyContext db;
        public DepartmentController()
        {
            db = new CompanyContext();
        }
        //domain/api/department
        [HttpGet]
        public IActionResult getAll()
        {
            var departments = db.Departments.ToList();
            if (departments.Count == 0)
            {
                return NotFound();
            }
            return Ok(new { data = departments, msg = "Departments retrieved successfully" });
        }
        //api/department?id=1
        [HttpGet("{id:int}")]
       // [Route("{id}")] //api/department/1 --relative path
        public IActionResult getById(int id)
        {
            var department = db.Departments.FirstOrDefault(d => d.Id == id);
            if (department == null)
            {
                return NotFound();
            }
            return Ok(new { data = department, msg = $"Department {department.Name}retrieved successfully" });

        }
        [HttpGet("{name:alpha}")] //api/department/HR
        public IActionResult getByName(string name)
        {
            var department = db.Departments.FirstOrDefault(d => d.Name == name);
            if (department == null)
            {
                return NotFound();
            }
            return Ok(new { data = department, msg = $"Department {department.Name} retrieved successfully" });

        }
        [HttpPost("v1")]
        public IActionResult Add(Department dept)
        {
            // if (dept.Name is null) return BadRequest();
            // if(!ModelState.IsValid) return BadRequest();
           // if (dept.OpenDate > DateTime.Now) ModelState.AddModelError("opnDate", "Date must be in past");
            db.Departments.Add(dept);
            db.SaveChanges();
            return CreatedAtAction(nameof(getById), new { id = dept.Id }, new {  msg = $"Department {dept.Name} added successfully" });
        }
        [HttpPost("v2")]
        [ValidateLocation]
        public IActionResult AddV2(Department dept)
        {
            // if (dept.Name is null) return BadRequest();
            // if(!ModelState.IsValid) return BadRequest();
            // if (dept.OpenDate > DateTime.Now) ModelState.AddModelError("opnDate", "Date must be in past");
         //   if (dept.Location != "USA" || dept.Location != "UK") return BadRequest();
            db.Departments.Add(dept);
            db.SaveChanges();
            return CreatedAtAction(nameof(getById), new { id = dept.Id }, new { msg = $"Department {dept.Name} added successfully" });
        }
        //[HttpPut("{id:int}")]
        //public IActionResult Edit(Department dept, int id)
        //{
        //    var d = db.Departments.FirstOrDefault(d => d.Id == dept.Id);
        //    if (d == null) return NotFound();
        //    d.Name = dept.Name;
        //    d.Manager = dept.Manager;
        //    db.SaveChanges();
        //    return Ok(new { msg = $"Department {dept.Name} updated successfully" });
        //}
        [HttpPut]

        public IActionResult Edit(Department d)
        {
          //  if (d.OpenDate > DateTime.Now) ModelState.AddModelError("opnDate", "Date must be in past");
            if (d.Name is null) return BadRequest();
            db.Departments.Update(d);
            db.SaveChanges();
            return NoContent();

        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var department = db.Departments.FirstOrDefault(d => d.Id == id);
            if (department == null)
            {
                return NotFound();
            }
            db.Departments.Remove(department);
            db.SaveChanges();
            return Ok(department);
        }

    }
}
