using Microsoft.AspNetCore.Components;
using MySharedLibrary;

namespace BlazorWebAssemblyApp_46.Pages
{
    public partial class EmployeeDetails
    {
        [Parameter]
        public int EmployeeId { get; set; }

        public Employee? CurEmp { get; set; }

        protected override Task OnInitializedAsync()
        {
            CurEmp = MockContext.Employees.FirstOrDefault(e => e.EmployeeId == EmployeeId);

            return base.OnInitializedAsync();
        }
    }
}
