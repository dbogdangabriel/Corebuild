using BethanysPieShopHRM.Shared;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using BethanysPieShopHRM.Api.Services;
using System.Linq;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeOverview
    {
        public IEnumerable<Employee> Employees { get; set; }

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();

        }

    }
}