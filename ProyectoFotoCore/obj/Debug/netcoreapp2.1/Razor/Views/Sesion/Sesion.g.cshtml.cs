#pragma checksum "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\Sesion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "281ac1de0e970c6f5a62ef62d6ee6eb3cb82f09b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sesion_Sesion), @"mvc.1.0.view", @"/Views/Sesion/Sesion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sesion/Sesion.cshtml", typeof(AspNetCore.Views_Sesion_Sesion))]
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
#line 1 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\Sesion.cshtml"
using ProyectoFotoCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281ac1de0e970c6f5a62ef62d6ee6eb3cb82f09b", @"/Views/Sesion/Sesion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267c2fc42ddfc0a9968444e0eeaa937a360de349", @"/Views/_ViewImports.cshtml")]
    public class Views_Sesion_Sesion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SESSION>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\Sesion.cshtml"
  
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
#line 21 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\Sesion.cshtml"
                 if (Model != null)
                {

#line default
#line hidden
            BeginContext(490, 39, true);
            WriteLiteral("                    <div class=\"row\">\r\n");
            EndContext();
#line 24 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\Sesion.cshtml"
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
#line 32 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\Sesion.cshtml"
                                                                               Write(s.Name);

#line default
#line hidden
            EndContext();
            BeginContext(995, 121, true);
            WriteLiteral("</div>\r\n                                        <div class=\"card-action\">\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1116, "\"", 1193, 1);
#line 34 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\Sesion.cshtml"
WriteAttributeValue("", 1123, Url.Action("DeleteSesion","Sesion",new { id = s.Id, name = s.Name  }), 1123, 70, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1194, 128, true);
            WriteLiteral(" style=\"float: right\"><i class=\"material-icons\" style=\"color:red\">delete</i></a>\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1322, "\"", 1381, 1);
#line 35 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\Sesion.cshtml"
WriteAttributeValue("", 1329, Url.Action("EditSesion","Sesion",new { id = s.Id }), 1329, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1382, 130, true);
            WriteLiteral(" style=\"float: right\"><i class=\"material-icons\" style=\"color: black;\">edit</i></a>\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1512, "\"", 1579, 1);
#line 36 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\Sesion.cshtml"
WriteAttributeValue("", 1519, Url.Action("ManagePhotos","Sesion",new { idSesion = s.Id }), 1519, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1580, 261, true);
            WriteLiteral(@" style=""float: right""><i class=""material-icons"" style=""color: black;"">photo_library</i></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
            EndContext();
#line 41 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\Sesion.cshtml"
                        }

#line default
#line hidden
            BeginContext(1868, 28, true);
            WriteLiteral("                    </div>\r\n");
            EndContext();
#line 43 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\Sesion.cshtml"
                }

#line default
#line hidden
            BeginContext(1915, 126, true);
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"fixed-action-btn\" style=\"margin-bottom:100px\">\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2041, "\"", 2084, 1);
#line 51 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\Sesion.cshtml"
WriteAttributeValue("", 2048, Url.Action("CreateSesion","Sesion"), 2048, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2085, 116, true);
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