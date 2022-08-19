using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.App.Pages
{
    public class IndexBase : ComponentBase
    {
        public Employee Employee { get; set; }

        protected override Task OnInitializedAsync()
        {
            Employee = new Employee
            {
                FirstName = "Bethany",
                LastName = "Smith",
            };
            return base.OnInitializedAsync();
        }


        public void Button_Click()
        {
            Employee.FirstName = "Gill";
        }
    }

}
