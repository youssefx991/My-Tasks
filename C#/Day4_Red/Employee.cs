using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_Red
{
    /// <summary>
    /// Represents an employee in a company
    /// <remarks>
    /// Employee is identified by ID, Name, Security_level, Salary, HireDate, Gender, and Privilege. 
    /// </remarks>
    /// </summary>
    public struct Employee : IComparable<Employee>
    {
        /// <summary>
        /// gets or sets the unique identifier for the employee.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// gets or sets the name of the employee.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// gets or sets the security level of the employee
        /// </summary>
        public int security_level {get; set;}

        /// <summary>
        /// gets or sets the salary of the employee
        /// </summary>
        public double salary {get; set;}

        /// <summary>
        /// gets or sets the hiring date of the employee
        /// </summary>
        public HiringDate hire_date {get; set;}

        /// <summary>
        /// gets or sets the gender of the employee
        /// </summary>
        public Gender gender {get; set;}

        /// <summary>
        /// gets or sets the security privilege of the employee
        /// </summary>
        public SecurityPrivilege privilege {get; set;}

        // constructors
        
        /// <summary>
        /// initializes a new instance of the employee
        /// </summary>
        /// <param name="_id">employee id</param>
        /// <param name="_name">employee name</param>
        /// <param name="_securityLevel">employee security level</param>
        /// <param name="_salary">employee  salary</param>
        /// <param name="date">employee hiring date</param>
        /// <param name="_gender">employee gender</param>
        /// <param name="_privilege">employee security privilege</param>
        public Employee(int _id, string _name, int _securityLevel, double _salary, HiringDate date, Gender _gender, SecurityPrivilege _privilege)
        {
            id = _id;
            name = _name;
            security_level = _securityLevel;
            salary = _salary;
            hire_date = date;
            gender = _gender;
            privilege = _privilege;
        }



        // toString

        /// <summary>
        /// overrides the ToString method to provide a string representation of the employee's information
        /// </summary>
        /// <returns>
        /// string representation of the employee's information
        /// </returns>
        public override string ToString()
        {

            return string.Format("ID: {0}\nName: {1}\nSecurity Level: {2}\nSalary: {3}\nHire Date: {4}\nGender: {5}\nSecurity Privilege: {6}"
                , id, name, security_level, salary, hire_date, gender, privilege);
        }

        /// <summary>
        /// compares employees based on their hiring date
        /// </summary>
        /// <param name="other">other employee to compare with</param>
        /// <returns>
        /// negative if this employee was hired before the other, 
        /// positive if this employee was hired after the other, 
        /// and zero if they were hired on the same date
        /// </returns>
        public int CompareTo(Employee other)
        {
            return hire_date.CompareTo(other.hire_date);
        }
    }
}
