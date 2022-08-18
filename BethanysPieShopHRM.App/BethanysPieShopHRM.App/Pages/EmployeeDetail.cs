using BethanysPieShopHRM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Components;
using System.Linq;
using BethanysPieShopHRM.Api.Services;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public string EmployeeID { get; set; }

        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeID));
        }

    }
}
