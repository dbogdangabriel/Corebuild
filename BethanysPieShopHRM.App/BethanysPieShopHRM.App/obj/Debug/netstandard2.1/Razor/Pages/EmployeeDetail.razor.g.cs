#pragma checksum "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44e1f26e87cc7ec42876606c584df5aec3b35904"
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
#line 1 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetail/{EmployeeId}")]
    public partial class EmployeeDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "class", "page-title");
            __builder.AddContent(2, "Details for ");
#nullable restore
#line 5 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
__builder.AddContent(3, Employee.FirstName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, " ");
#nullable restore
#line 5 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
__builder.AddContent(5, Employee.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-12 row");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-2");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 10 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                    $"https://gillcleerenpluralsight.blob.core.windows.net/person/{Employee.EmployeeId}.jpg"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", "img-responsive rounded-circle employee-detail-img");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-10 row");
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-xs-12 col-sm-8");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group row");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.AddMarkupContent(27, "<label class=\"col-sm-4 col-form-label\">Employee ID</label>\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-sm-8");
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "label");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "class", "form-control-plaintext");
#nullable restore
#line 17 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
__builder.AddContent(34, Employee.EmployeeId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group row");
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.AddMarkupContent(41, "<label class=\"col-sm-4 col-form-label\">First name</label>\r\n                ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-sm-8");
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "label");
            __builder.AddAttribute(46, "type", "text");
            __builder.AddAttribute(47, "readonly", true);
            __builder.AddAttribute(48, "class", "form-control-plaintext");
#nullable restore
#line 23 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
__builder.AddContent(49, Employee.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-group row");
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.AddMarkupContent(56, "<label class=\"col-sm-4 col-form-label\">Last name</label>\r\n                ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col-sm-8");
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "label");
            __builder.AddAttribute(61, "type", "text");
            __builder.AddAttribute(62, "readonly", true);
            __builder.AddAttribute(63, "class", "form-control-plaintext");
#nullable restore
#line 30 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
__builder.AddContent(64, Employee.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\r\n            ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "form-group row");
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.AddMarkupContent(71, "<label class=\"col-sm-4 col-form-label\">Birthdate</label>\r\n                ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "col-sm-8");
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.OpenElement(75, "label");
            __builder.AddAttribute(76, "type", "text");
            __builder.AddAttribute(77, "readonly", true);
            __builder.AddAttribute(78, "class", "form-control-plaintext");
#nullable restore
#line 37 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
__builder.AddContent(79, Employee.BirthDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\r\n            ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "form-group row");
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.AddMarkupContent(86, "<label class=\"col-sm-4 col-form-label\">Email</label>\r\n                ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "col-sm-8");
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.OpenElement(90, "label");
            __builder.AddAttribute(91, "type", "text");
            __builder.AddAttribute(92, "readonly", true);
            __builder.AddAttribute(93, "class", "form-control-plaintext");
#nullable restore
#line 44 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
__builder.AddContent(94, Employee.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n\r\n            ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "form-group row");
            __builder.AddMarkupContent(100, "\r\n                ");
            __builder.AddMarkupContent(101, "<label class=\"col-sm-4 col-form-label\">Street</label>\r\n                ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "col-sm-8");
            __builder.AddMarkupContent(104, "\r\n                    ");
            __builder.OpenElement(105, "label");
            __builder.AddAttribute(106, "type", "text");
            __builder.AddAttribute(107, "readonly", true);
            __builder.AddAttribute(108, "class", "form-control-plaintext");
#nullable restore
#line 51 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
__builder.AddContent(109, Employee.Street);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n\r\n            ");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "form-group row");
            __builder.AddMarkupContent(115, "\r\n                ");
            __builder.AddMarkupContent(116, "<label class=\"col-sm-4 col-form-label\">Zip</label>\r\n                ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "col-sm-8");
            __builder.AddMarkupContent(119, "\r\n                    ");
            __builder.OpenElement(120, "label");
            __builder.AddAttribute(121, "type", "text");
            __builder.AddAttribute(122, "readonly", true);
            __builder.AddAttribute(123, "class", "form-control-plaintext");
#nullable restore
#line 58 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
__builder.AddContent(124, Employee.Zip);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n\r\n            ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "form-group row");
            __builder.AddMarkupContent(130, "\r\n                ");
            __builder.AddMarkupContent(131, "<label class=\"col-sm-4 col-form-label\">City</label>\r\n                ");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "col-sm-8");
            __builder.AddMarkupContent(134, "\r\n                    ");
            __builder.OpenElement(135, "label");
            __builder.AddAttribute(136, "type", "text");
            __builder.AddAttribute(137, "readonly", true);
            __builder.AddAttribute(138, "class", "form-control-plaintext");
#nullable restore
#line 65 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
__builder.AddContent(139, Employee.City);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n\r\n            ");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "form-group row");
            __builder.AddMarkupContent(145, "\r\n                ");
            __builder.AddMarkupContent(146, "<label class=\"col-sm-4 col-form-label\">Phone number</label>\r\n                ");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "col-sm-8");
            __builder.AddMarkupContent(149, "\r\n                    ");
            __builder.OpenElement(150, "label");
            __builder.AddAttribute(151, "type", "text");
            __builder.AddAttribute(152, "readonly", true);
            __builder.AddAttribute(153, "class", "form-control-plaintext");
#nullable restore
#line 72 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
__builder.AddContent(154, Employee.PhoneNumber);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n\r\n            ");
            __builder.OpenElement(158, "div");
            __builder.AddAttribute(159, "class", "form-group row");
            __builder.AddMarkupContent(160, "\r\n                ");
            __builder.AddMarkupContent(161, "<label class=\"col-sm-4 col-form-label\">Gender</label>\r\n                ");
            __builder.OpenElement(162, "div");
            __builder.AddAttribute(163, "class", "col-sm-8");
            __builder.AddMarkupContent(164, "\r\n                    ");
            __builder.OpenElement(165, "label");
            __builder.AddAttribute(166, "type", "text");
            __builder.AddAttribute(167, "readonly", true);
            __builder.AddAttribute(168, "class", "form-control-plaintext");
#nullable restore
#line 79 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
__builder.AddContent(169, Employee.Gender);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n\r\n            ");
            __builder.OpenElement(173, "div");
            __builder.AddAttribute(174, "class", "form-group row");
            __builder.AddMarkupContent(175, "\r\n                ");
            __builder.AddMarkupContent(176, "<label class=\"col-sm-4 col-form-label\">Smoker</label>\r\n                ");
            __builder.OpenElement(177, "div");
            __builder.AddAttribute(178, "class", "col-sm-8");
            __builder.AddMarkupContent(179, "\r\n\r\n");
#nullable restore
#line 87 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                     if (Employee.Smoker)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(180, "                        ");
            __builder.AddMarkupContent(181, "<label type=\"text\" readonly class=\"form-control-plaintext\">Yes</label>\r\n");
#nullable restore
#line 90 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(182, "                        ");
            __builder.AddMarkupContent(183, "<label type=\"text\" readonly class=\"form-control-plaintext\">No</label>\r\n");
#nullable restore
#line 94 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"

                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(184, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(185, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n\r\n            ");
            __builder.OpenElement(187, "div");
            __builder.AddAttribute(188, "class", "form-group row");
            __builder.AddMarkupContent(189, "\r\n                ");
            __builder.AddMarkupContent(190, "<label class=\"col-sm-4 col-form-label\">Joined us</label>\r\n                ");
            __builder.OpenElement(191, "div");
            __builder.AddAttribute(192, "class", "col-sm-8");
            __builder.AddMarkupContent(193, "\r\n                    ");
            __builder.OpenElement(194, "label");
            __builder.AddAttribute(195, "type", "text");
            __builder.AddAttribute(196, "readonly", true);
            __builder.AddAttribute(197, "class", "form-control-plaintext");
#nullable restore
#line 102 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
__builder.AddContent(198, Employee.JoinedDate?.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(201, "\r\n\r\n            ");
            __builder.OpenElement(202, "div");
            __builder.AddAttribute(203, "class", "form-group row");
            __builder.AddMarkupContent(204, "\r\n                ");
            __builder.AddMarkupContent(205, "<label class=\"col-sm-4 col-form-label\">Left us</label>\r\n                ");
            __builder.OpenElement(206, "div");
            __builder.AddAttribute(207, "class", "col-sm-8");
            __builder.AddMarkupContent(208, "\r\n                    ");
            __builder.OpenElement(209, "label");
            __builder.AddAttribute(210, "type", "text");
            __builder.AddAttribute(211, "readonly", true);
            __builder.AddAttribute(212, "class", "form-control-plaintext");
#nullable restore
#line 109 "C:\Users\bogdan.draghici\Desktop\getting-started-blazor (1)\03\demos\Demos\end\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
__builder.AddContent(213, Employee.ExitDate?.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(214, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(215, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(216, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(217, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(218, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
