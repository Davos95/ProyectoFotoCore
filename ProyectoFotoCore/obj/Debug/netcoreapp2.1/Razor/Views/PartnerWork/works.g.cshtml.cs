#pragma checksum "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\works.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b4adad05ddaff6d74db0f45f7581a8e9b12534a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PartnerWork_works), @"mvc.1.0.view", @"/Views/PartnerWork/works.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PartnerWork/works.cshtml", typeof(AspNetCore.Views_PartnerWork_works))]
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
#line 1 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\works.cshtml"
using ProyectoFotoCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b4adad05ddaff6d74db0f45f7581a8e9b12534a", @"/Views/PartnerWork/works.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267c2fc42ddfc0a9968444e0eeaa937a360de349", @"/Views/_ViewImports.cshtml")]
    public class Views_PartnerWork_works : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WORK>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/stylePartners.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\works.cshtml"
  
    ViewBag.Title = "Works";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("styles", async() => {
                BeginContext(152, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(160, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d38df3821b4241bca2240aefcaa189ff", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(216, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(221, 247, true);
            WriteLiteral("\r\n<div class=\"row \" style=\"padding: 1rem 1.2rem;\">\r\n    <div class=\"card col s12 m4 l4 xl3 offset-m1 offset-l1 offset-xl1\">\r\n        <div class=\"card-title center-align title\"><i class=\"material-icons iconTitle\">note_add</i>Trabajo</div>\r\n        ");
            EndContext();
            BeginContext(468, 508, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3744c1d69a2a42ab8e0fd63d60f2cead", async() => {
                BeginContext(488, 481, true);
                WriteLiteral(@"
            <div class=""input-field"">
                <input type=""text"" name=""work"" id=""work"" />
                <label for=""work""><i class=""material-icons iconInput"">label</i>Nombre del trabajo</label>
            </div>
            <input type=""number"" name=""id"" id=""id"" hidden />
            <div class=""input-field"">
                <button type=""submit"" name=""option"" value=""0"" class=""btn waves-effect waves-darken green"">Añadir</button>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(976, 236, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"card col s12 m6 l5 xl4 offset-m2 offset-l2 offset-xl2\">\r\n        <div class=\"card-title center-align title\">Trabajos</div>\r\n        <div class=\"card-content\">\r\n            <table>\r\n                <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\works.cshtml"
                     foreach (WORK w in Model)
                    {

#line default
#line hidden
            BeginContext(1283, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1338, 6, false);
#line 34 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\works.cshtml"
                       Write(w.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1344, 37, true);
            WriteLiteral("</td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1381, "\"", 1446, 1);
#line 35 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\works.cshtml"
WriteAttributeValue("", 1388, Url.Action("DeleteWork", "PartnerWork", new { id = w.Id}), 1388, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1447, 109, true);
            WriteLiteral("><i class=\"material-icons\" style=\"color:red; float:right\">backspace</i></a></td>\r\n                    </tr>\r\n");
            EndContext();
#line 37 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\works.cshtml"
                    }

#line default
#line hidden
            BeginContext(1579, 82, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WORK>> Html { get; private set; }
    }
}
#pragma warning restore 1591
