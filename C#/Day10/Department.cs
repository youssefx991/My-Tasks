using System;
using System.Collections.Generic;
using System.Text;

namespace Day10
{
    class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff = new List<Employee>();
        public void AddStaff(Employee E)
        {
            Staff.Add(E);
            ///Try Register for EmployeeLayOff Event Here 
            E.EmployeeLayOff += RemoveStaff;
        }
        ///CallBackMethod 
        public void RemoveStaff(object? sender,
        EmployeeLayOffEventArgs e)
        {
            if (sender is Employee emp)
            {
                if (emp == null) return;
                Staff.Remove(emp);
                emp.EmployeeLayOff -= RemoveStaff;
                Console.WriteLine($"Employee with ID {emp.EmployeeID} has been laid off due to {e.Cause} from Department {DeptName}");
            }
        }
    }

}
