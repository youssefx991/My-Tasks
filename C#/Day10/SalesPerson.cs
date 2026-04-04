using System;
using System.Collections.Generic;
using System.Text;

namespace Day10
{
    class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            if (AchievedTarget < Quota)
            {
                LayOffCause cause = LayOffCause.EmployeeNotAchievedTarget;
                EmployeeLayOffEventArgs e = new EmployeeLayOffEventArgs() { Cause = cause};
                base.OnEmployeeLayOff(e);
                return false;
            }

            return true;
        }

        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.EmployeeNotAchievedTarget)
                base.OnEmployeeLayOff(e);
        }
    }
}
