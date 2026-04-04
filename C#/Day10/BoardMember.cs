using System;
using System.Collections.Generic;
using System.Text;

namespace Day10
{
    class BoardMember : Employee
    {
        public void Resign()
        {
            LayOffCause cause = LayOffCause.EmployeeResigned;
            EmployeeLayOffEventArgs e = new EmployeeLayOffEventArgs() { Cause = cause };
            base.OnEmployeeLayOff(e);
        }

        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.EmployeeResigned)
                base.OnEmployeeLayOff(e);
        }
    }


}
