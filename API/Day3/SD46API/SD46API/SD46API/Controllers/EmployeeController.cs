using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SD46API.Context;
using SD46API.DTOs;

namespace SD46API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //   [EnableCors("PrivateEmp")]
  //  [Authorize]
    public class EmployeeController : ControllerBase
    {
        CompanyContext db;
        public EmployeeController()
        {
            db = new CompanyContext();
        }
        [HttpGet]
        //    [DisableCors]
        //[AllowAnonymous]
        public IActionResult GetAll() //mapster | automapper
        {
            var data = db.Employee.Include(e => e.Department).ToList();
            if(data.Count == 0)
            {
                return NotFound();
            }
          // EmpWithDeptInfoDTO empDTO = new EmpWithDeptInfoDTO();
              

            List<EmpWithDeptInfoDTO> empDTOList = new List<EmpWithDeptInfoDTO>();
            foreach (var emp in data)
            {
                empDTOList.Add(new EmpWithDeptInfoDTO
                {
                    EmpName = emp.Name,
                    Department = emp.Department != null ? emp.Department.Name : "No Department",
                    Msg = $"Employee {emp.Name} works in {emp.Department?.Name ?? "No Department"} department."
                });
            }


            return Ok(empDTOList);
        }
    }
}
