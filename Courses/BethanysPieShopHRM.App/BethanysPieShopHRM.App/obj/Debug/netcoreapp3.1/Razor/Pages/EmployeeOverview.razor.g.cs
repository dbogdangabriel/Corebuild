#pragma checksum "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ae8b72edff36bd23086fe5697841246eaddfe6d"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 3 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App;

#line default
#line hidden
#line 8 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App.Shared;

#line default
#line hidden
#line 10 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App.Components;

#line default
#line hidden
#line 12 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary;

#line default
#line hidden
#line 13 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary.Map;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeoverview")]
    public partial class EmployeeOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"page-title\">All employees</h1>\r\n\r\n");
#line 5 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
 if (Employees == null)
{

#line default
#line hidden
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#line 8 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th></th>\r\n                <th>Employee ID</th>\r\n                <th>First name</th>\r\n                <th>Last name</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#line 22 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
             foreach (var employee in Employees)
            {

#line default
#line hidden
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", 
#line 25 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
                                    $"https://gillcleerenpluralsight.blob.core.windows.net/person/{employee.EmployeeId}-small.jpg"

#line default
#line hidden
            );
            __builder.AddAttribute(16, "class", "rounded-circle");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
#line 26 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
__builder.AddContent(19, employee.EmployeeId);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
#line 27 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
__builder.AddContent(22, employee.FirstName);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
#line 28 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
__builder.AddContent(25, employee.LastName);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "href", 
#line 30 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
                                   $"employeedetail/{employee.EmployeeId}"

#line default
#line hidden
            );
            __builder.AddAttribute(31, "class", "btn btn-primary table-btn");
            __builder.AddMarkupContent(32, "\r\n                            <i class=\"fas fa-info-circle\"></i>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "href", 
#line 33 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
                                   $"employeeedit/{employee.EmployeeId}"

#line default
#line hidden
            );
            __builder.AddAttribute(36, "class", "btn btn-primary table-btn");
            __builder.AddMarkupContent(37, "\r\n                            <i class=\"fas fa-edit\"></i>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#line 38 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
            }

#line default
#line hidden
            __builder.AddContent(41, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#line 41 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
}

#line default
#line hidden
            __builder.AddMarkupContent(44, "\r\n");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 43 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
                  QuickAddEmployee

#line default
#line hidden
            ));
            __builder.AddAttribute(47, "class", "btn btn-dark table-btn quick-add-btn");
            __builder.AddContent(48, "  +  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n");
            __builder.OpenComponent<BethanysPieShopHRM.App.Components.AddEmployeeDialog>(50);
            __builder.AddAttribute(51, "CloseEventCallback", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#line 45 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
                                                                 AddEmployeeDialog_OnDialogClose

#line default
#line hidden
            )));
            __builder.AddComponentReferenceCapture(52, (__value) => {
#line 45 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeOverview.razor"
                         AddEmployeeDialog = (BethanysPieShopHRM.App.Components.AddEmployeeDialog)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591