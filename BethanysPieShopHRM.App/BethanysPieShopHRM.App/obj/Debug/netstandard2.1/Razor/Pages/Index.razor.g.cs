#pragma checksum "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a0cbbd99875a5b9ca25993fe5168181df25f569"
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
#line 1 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : IndexBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"page-title\">Welcome to Bethany\'s Pie Shop HRM!</h1>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<h3>Using this application, you can manage our wonderful staff working for us all over the world, bringing people the best pies ever!</h3>\r\n\r\n");
            __builder.AddMarkupContent(2, "<h1> Hello, data binding in Blazor!</h1>\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<h2>One way data binding</h2>\r\n    Employee first name: ");
            __builder.OpenElement(6, "label");
#nullable restore
#line 10 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\Index.razor"
__builder.AddContent(7, Employee.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    Employee last name: ");
            __builder.OpenElement(9, "lavel");
#nullable restore
#line 11 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\Index.razor"
__builder.AddContent(10, Employee.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.AddMarkupContent(15, "<h2>One way data binding on form controls</h2>\r\n    Employee first name: ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "value", 
#nullable restore
#line 16 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\Index.razor"
                                        Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    Employee last name:  ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "value", 
#nullable restore
#line 17 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\Index.razor"
                                        Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.OpenElement(23, "div");
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.AddMarkupContent(25, "<h2>Two way data binding</h2>\r\n    Employee first name: ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\Index.razor"
                                        Employee.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Employee.FirstName = __value, Employee.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    Employee last name:  ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\Index.razor"
                                        Employee.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Employee.LastName = __value, Employee.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n");
            __builder.OpenElement(35, "div");
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.AddMarkupContent(37, "<h2>Two way data binding on a different event</h2>\r\n    Employee first name: ");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\Index.razor"
                                              Employee.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Employee.FirstName = __value, Employee.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    Employee last name:  ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\Index.razor"
                                              Employee.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Employee.LastName = __value, Employee.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n\r\n");
            __builder.OpenElement(47, "div");
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\bogdan.draghici\source\repos\Corebuild\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\Index.razor"
                      Button_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
