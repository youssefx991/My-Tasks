using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    internal struct Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int security_level {get; set;}
        public double salary {get; set;}
        public HiringDate hire_date {get; set;}
        public Gender gender {get; set;}
        public SecurityPrivilege privilege {get; set;}

        // constructors
        
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
        public override string ToString()
        {

            return string.Format("ID: {0}\nName: {1}\nSecurity Level: {2}\nSalary: {3}\nHire Date: {4}\nGender: {5}\nSecurity Privilege: {6}"
                , id, name, security_level, salary, hire_date, gender, privilege);
        }

        //// setters
        //public void setId(int _id) { id = _id; }
        //public void setSecurityLevel(int _securityLevel) { security_level = _securityLevel; }
        //public void setSalary(double _salary) { salary = _salary; }
        //public void setDate(HiringDate _date) { hire_date = _date; }
        //public void setGender(Gender _gender) { gender = _gender; }
        
        //public void setPrivilege(SecurityPrivilege _privilege) { privilege = _privilege; }

        //// getters
        //public int getId() { return id; }
        //public int getSecurityLevel() { return security_level; }
        //public double getSalary() { return salary; }
        //public HiringDate getDate() { return hire_date; }
        //public Gender getGender() { return gender; }

        //public SecurityPrivilege getPrivilege() { return privilege; }



    }
}
