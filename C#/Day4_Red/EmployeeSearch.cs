
using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_Red
{
    /// <summary>
    /// provide methods to search faster for employees
    /// </summary>
    public class EmployeeSearch
    {
        /// <summary>
        /// list of natioal ids of employees
        /// </summary>
        public int[] nationalIDs;

        /// <summary>
        /// list of all employees
        /// </summary>
        public Employee[] employees;

        /// <summary>
        /// creates instance of employee search with the given national ids and employees
        /// </summary>
        /// <param name="_ids">all employees national ids</param>
        /// <param name="_employees">all employees</param>
        public EmployeeSearch(int[] _ids, Employee[] _employees)
        {
            nationalIDs = _ids;
            employees = _employees;
        }

        // searching
        /// <summary>
        /// method to search for employee by national id
        /// </summary>
        /// <param name="id">id t osearch for its employee</param>
        /// <returns>employee if found, dummy one if not</returns>
        public Employee SearchByNationalID(int id)
        {
            for (int i = 0; i < nationalIDs.Length; i++)
            {
                if (nationalIDs[i] == id)
                    return employees[i];
            }

            Console.WriteLine($"Employee with national id = {id} is not found");
            return new Employee();

        }

        /// <summary>
        /// method to search for employee by national hiring date
        /// </summary>
        /// <param name="date">hiring date to search for its employee</param>
        /// <returns>employee if found, dummy one if not</returns>
        public Employee SearchByHiringDate(HiringDate date)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].hire_date.day == date.day &&
                    employees[i].hire_date.month == date.month &&
                    employees[i].hire_date.year == date.year)
                    return employees[i];
            }

            Console.WriteLine($"Employee with hiring date = {date} is not found");
            return new Employee();

        }

        /// <summary>
        /// method to search for employees by national name
        /// </summary>
        /// <param name="name">name to search for its employee</param>
        /// <returns>all employees with given name as array if found, dummy one if not</returns>
        public Employee[] SearchByName(string name)
        {
            List<Employee> result_employees = new List<Employee>();
      
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].name.ToLower().Equals(name.ToLower()))
                    result_employees.Add(employees[i]);
            }

            return result_employees.ToArray();

        }

        // indexers

        /// <summary>
        /// meghod to access employee by national id using indexer
        /// </summary>
        /// <param name="id">id to get its employee</param>
        /// <returns>requested employee</returns>
        public Employee this[int id]
        {
            get
            {
                return SearchByNationalID(id);
            }
        }

        /// <summary>
        /// method to get employee by hiring date using indexer
        /// </summary>
        /// <param name="date">hiring date to get its employee</param>
        /// <returns>requested employee</returns>
        public Employee this[HiringDate date]
        {
            get
            {
                return SearchByHiringDate(date);
            }
        }

        /// <summary>
        /// method to get employee by name using indexer
        /// </summary>
        /// <param name="name">name to search for its employees</param>
        /// <returns>array of all employees with given name</returns>
        public Employee[] this[string name]
        {
            get { return SearchByName(name); }
        }

    }
}
