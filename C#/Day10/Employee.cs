using System;
using System.Collections.Generic;
using System.Text;

namespace Day10
{
    class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff.Invoke(this, e);
        }

        public int EmployeeID { get; set; }

        public DateTime BirthDate
        {
            get;
            set;
        }

        public int VacationStock
        {
            get;
            set;
        }

        public bool RequestVacation(DateTime From, DateTime To)
        {
            if (To < From)
                throw new ArgumentException("Invalid Date Range");
            int DaysRequested = (To - From).Days;
            VacationStock -= DaysRequested;
            if (VacationStock < 0)
            {
                LayOffCause cause = LayOffCause.EmployeeVacationStockLessThanZero;
                EmployeeLayOffEventArgs args = new() { Cause = cause };
                OnEmployeeLayOff(args);
                return false;
            }
            return true;
        }

        public void EndOfYearOperation()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            if (age > 60)
            {
                LayOffCause cause = LayOffCause.EmployeeAgeBiggerThan60;
                EmployeeLayOffEventArgs args = new() { Cause = cause };
                OnEmployeeLayOff(args);
            }
        }
    }
    public class EmployeeLayOffEventArgs
    {
        public LayOffCause Cause { get; set; }
    }

}
