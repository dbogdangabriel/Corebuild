#pragma checksum "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\Pages\EmployeeOverviewVirtual.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfa77c9c1dfda9d1b730f29e88d93d9fbd9df949"
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
#nullable restore
#line 1 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeoverviewvirtual")]
    public partial class EmployeeOverviewVirtual : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Employee Overview</h3>");
#nullable restore
#line 5 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\Pages\EmployeeOverviewVirtual.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 8 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\Pages\EmployeeOverviewVirtual.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "virtualized");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "<thead><tr><th>Employee ID</th>\r\n                <th>First name</th>\r\n                <th>Last name</th></tr></thead>\r\n        ");
            __builder.OpenElement(7, "tbody");
            __Blazor.BethanysPieShopHRM.App.Pages.EmployeeOverviewVirtual.TypeInference.CreateVirtualize_0(__builder, 8, 9, 
#nullable restore
#line 21 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\Pages\EmployeeOverviewVirtual.razor"
                                       LoadEmployees

#line default
#line hidden
#nullable disable
            , 10, 
#nullable restore
#line 21 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\Pages\EmployeeOverviewVirtual.razor"
                                                                itemHeight

#line default
#line hidden
#nullable disable
            , 11, (context) => (__builder2) => {
                __builder2.OpenElement(12, "tr");
                __builder2.SetKey(
#nullable restore
#line 23 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\Pages\EmployeeOverviewVirtual.razor"
                              context.GetHashCode()

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(13, "td");
#nullable restore
#line 24 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\Pages\EmployeeOverviewVirtual.razor"
__builder2.AddContent(14, context.EmployeeId);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n                        ");
                __builder2.OpenElement(16, "td");
#nullable restore
#line 25 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\Pages\EmployeeOverviewVirtual.razor"
__builder2.AddContent(17, context.FirstName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.OpenElement(19, "td");
#nullable restore
#line 26 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\Pages\EmployeeOverviewVirtual.razor"
__builder2.AddContent(20, context.LastName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            , 21, (context) => (__builder2) => {
                __builder2.AddMarkupContent(22, "<tr><td>Loading...</td>\r\n                        <td>Loading...</td>\r\n                        <td>Loading...</td></tr>");
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App5.0\BethanysPieShopHRM.App\Pages\EmployeeOverviewVirtual.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BethanysPieShopHRM.App.Pages.EmployeeOverviewVirtual
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateVirtualize_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate<TItem> __arg0, int __seq1, global::System.Single __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<TItem>>(seq);
        __builder.AddAttribute(__seq0, "ItemsProvider", __arg0);
        __builder.AddAttribute(__seq1, "ItemSize", __arg1);
        __builder.AddAttribute(__seq2, "ItemContent", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
