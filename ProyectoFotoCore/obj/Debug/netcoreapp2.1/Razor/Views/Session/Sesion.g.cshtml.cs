#pragma checksum "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2da4927a3c729cefb96a263fb852aeb032e252aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Session_Sesion), @"mvc.1.0.view", @"/Views/Session/Sesion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Session/Sesion.cshtml", typeof(AspNetCore.Views_Session_Sesion))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\_ViewImports.cshtml"
using ProyectoFotoCore;

#line default
#line hidden
#line 1 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
using ProyectoFotoCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2da4927a3c729cefb96a263fb852aeb032e252aa", @"/Views/Session/Sesion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267c2fc42ddfc0a9968444e0eeaa937a360de349", @"/Views/_ViewImports.cshtml")]
    public class Views_Session_Sesion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SESSION>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
  
    ViewBag.Title = "Sesion";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("events", async() => {
                BeginContext(157, 114, true);
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            M.AutoInit();\r\n        });\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(274, 160, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col s12 m10 l10 xl10 offset-m1 offset-l1 offset-xl1\">\r\n        <div class=\"card\">\r\n            <div class=\"card-content\">\r\n");
            EndContext();
#line 21 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
                 if (Model != null)
                {

#line default
#line hidden
            BeginContext(490, 39, true);
            WriteLiteral("                    <div class=\"row\">\r\n");
            EndContext();
#line 24 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
                         foreach (SESSION s in Model)
                        {

#line default
#line hidden
            BeginContext(611, 377, true);
            WriteLiteral(@"                            <div class=""col s12 m8 l6 xl4"">
                                <div class=""card"">
                                    <div class=""card-content"">
                                        <div class=""card-image"">

                                        </div>
                                        <div class=""card-title"" style=""color:black"">");
            EndContext();
            BeginContext(989, 6, false);
#line 32 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
                                                                               Write(s.Name);

#line default
#line hidden
            EndContext();
            BeginContext(995, 121, true);
            WriteLiteral("</div>\r\n                                        <div class=\"card-action\">\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1116, "\"", 1194, 1);
#line 34 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
WriteAttributeValue("", 1123, Url.Action("DeleteSesion","Session",new { id = s.Id, name = s.Name  }), 1123, 71, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1195, 128, true);
            WriteLiteral(" style=\"float: right\"><i class=\"material-icons\" style=\"color:red\">delete</i></a>\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1323, "\"", 1383, 1);
#line 35 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
WriteAttributeValue("", 1330, Url.Action("EditSesion","Session",new { id = s.Id }), 1330, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1384, 130, true);
            WriteLiteral(" style=\"float: right\"><i class=\"material-icons\" style=\"color: black;\">edit</i></a>\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1514, "\"", 1582, 1);
#line 36 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
WriteAttributeValue("", 1521, Url.Action("ManagePhotos","Session",new { idSesion = s.Id }), 1521, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1583, 261, true);
            WriteLiteral(@" style=""float: right""><i class=""material-icons"" style=""color: black;"">photo_library</i></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
            EndContext();
#line 41 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
                        }

#line default
#line hidden
            BeginContext(1871, 28, true);
            WriteLiteral("                    </div>\r\n");
            EndContext();
#line 43 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
                }

#line default
#line hidden
            BeginContext(1918, 126, true);
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"fixed-action-btn\" style=\"margin-bottom:100px\">\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2044, "\"", 2088, 1);
#line 51 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
WriteAttributeValue("", 2051, Url.Action("CreateSesion","Session"), 2051, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2089, 116, true);
            WriteLiteral(" class=\"btn-floating btn-large green\">\r\n        <i class=\"large material-icons\">add_circle</i>\r\n    </a>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SESSION>> Html { get; private set; }
    }
}
#pragma warning restore 1591
