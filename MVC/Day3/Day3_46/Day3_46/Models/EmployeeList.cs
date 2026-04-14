namespace Day3_46.Models
{
    public class EmployeeList
    {
        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee(){ Id = 1, Name = "Emp-1", Age = 11, Email = "Emp_1@Company.com"},
            new Employee(){ Id = 2, Name = "Emp-2", Age = 22, Email = "Emp_2@Company.com"},
            new Employee(){ Id = 3, Name = "Emp-3", Age = 33, Email = "Emp_3@Company.com"},
            new Employee(){ Id = 4, Name = "Emp-4", Age = 44, Email = "Emp_4@Company.com"},
            new Employee(){ Id = 5, Name = "Emp-5", Age = 55, Email = "Emp_5@Company.com"}
        };
    }
}

