using Day3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    internal class EmployeeSearch
    {
        public int[] nationalIDs;
        public Employee[] employees;

        public EmployeeSearch(int[] _ids, Employee[] _employees)
        {
            nationalIDs = _ids;
            employees = _employees;
        }

        // searching
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

        public Employee this[int id]
        {
            get
            {
                return SearchByNationalID(id);
            }
        }

        public Employee this[HiringDate date]
        {
            get
            {
                return SearchByHiringDate(date);
            }
        }

        public Employee[] this[string name]
        {
            get { return SearchByName(name); }
        }

    }
}
