using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    internal struct Employee
    {
        public int id;
        public int security_level;
        public double salary;
        public HiringDate hire_date;
        public Gender gender;
        public SecurityPrivilege privilege;

        // constructors
        
        public Employee(int _id, int _securityLevel, double _salary, HiringDate date, Gender _gender, SecurityPrivilege _privilege)
        {
            id = _id;
            security_level = _securityLevel;
            salary = _salary;
            hire_date = date;
            gender = _gender;
            privilege = _privilege;
        }



        // toString
        public override string ToString()
        {

            return string.Format("ID: {0}\nSecurity Level: {1}\nSalary: {2:C}\nHire Date: {3}\nGender: {4}\nSecurity Privilege: {5}"
                , id, security_level, salary, hire_date, gender, privilege);
        }

        // setters
        public void setId(int _id) { id = _id; }
        public void setSecurityLevel(int _securityLevel) { security_level = _securityLevel; }
        public void setSalary(double _salary) { salary = _salary; }
        public void setDate(HiringDate _date) { hire_date = _date; }
        public void setGender(Gender _gender) { gender = _gender; }
        
        public void setPrivilege(SecurityPrivilege _privilege) { privilege = _privilege; }

        // getters
        public int getId() { return id; }
        public int getSecurityLevel() { return security_level; }
        public double getSalary() { return salary; }
        public HiringDate getDate() { return hire_date; }
        public Gender getGender() { return gender; }
        public SecurityPrivilege getPrivilege() { return privilege; }



    }
}
