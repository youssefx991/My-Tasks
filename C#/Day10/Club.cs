using System;
using System.Collections.Generic;
using System.Text;

namespace Day10
{
    class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members = new List<Employee>();

        public void AddMember(Employee E)
        {
            Members.Add(E);
            ///Try Register for EmployeeLayOff Event Here 
            E.EmployeeLayOff += RemoveMember;
        }
        ///CallBackMethod 
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            
            if (sender is Employee emp && !(sender is BoardMember))
            {
                if (e.Cause == LayOffCause.EmployeeVacationStockLessThanZero || e.Cause == LayOffCause.EmployeeNotAchievedTarget)
                {
                    if (emp == null) return;
                    Members.Remove(emp);
                    emp.EmployeeLayOff -= RemoveMember;
                    Console.WriteLine($"Employee with ID {emp.EmployeeID} has been laid off due to {e.Cause} from Club {ClubName}");
                }
            }
            ///Employee Will not be removed from the Club if Age>60 
            ///Employee will be removed from Club if Vacation Stock < 0 
        }
    }
}
