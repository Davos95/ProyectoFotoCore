#pragma checksum "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\works.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e8673b0d79dddeb4944e044dbac21aac0fc71c1"
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
#line 1 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\_ViewImports.cshtml"
using ProyectoFotoCore;

#line default
#line hidden
#line 1 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\works.cshtml"
using ProyectoFotoCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e8673b0d79dddeb4944e044dbac21aac0fc71c1", @"/Views/PartnerWork/works.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6de92ebe6cb4bf092acae0a3d4ee46870dfebb", @"/Views/_ViewImports.cshtml")]
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
#line 3 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\works.cshtml"
  
    ViewBag.Title = "Works";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("styles", async() => {
                BeginContext(146, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(152, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1f1968c491ae471984ac9864119799d0", async() => {
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
                BeginContext(208, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(211, 243, true);
            WriteLiteral("\n<div class=\"row \" style=\"padding: 1rem 1.2rem;\">\n    <div class=\"card col s12 m4 l4 xl3 offset-m1 offset-l1 offset-xl1\">\n        <div class=\"card-title center-align title\"><i class=\"material-icons iconTitle\">note_add</i>Trabajo</div>\n        ");
            EndContext();
            BeginContext(454, 499, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1afe743882584616bd80606c0b659e98", async() => {
                BeginContext(474, 472, true);
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
            BeginContext(953, 229, true);
            WriteLiteral("\n    </div>\n    <div class=\"card col s12 m6 l5 xl4 offset-m2 offset-l2 offset-xl2\">\n        <div class=\"card-title center-align title\">Trabajos</div>\n        <div class=\"card-content\">\n            <table>\n                <tbody>\n");
            EndContext();
#line 31 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\works.cshtml"
                     foreach (WORK w in Model)
                    {

#line default
#line hidden
            BeginContext(1251, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(1305, 6, false);
#line 34 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\works.cshtml"
                       Write(w.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1311, 36, true);
            WriteLiteral("</td>\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1347, "\"", 1412, 1);
#line 35 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\works.cshtml"
WriteAttributeValue("", 1354, Url.Action("DeleteWork", "PartnerWork", new { id = w.Id}), 1354, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1413, 107, true);
            WriteLiteral("><i class=\"material-icons\" style=\"color:red; float:right\">backspace</i></a></td>\n                    </tr>\n");
            EndContext();
#line 37 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\works.cshtml"
                    }

#line default
#line hidden
            BeginContext(1542, 78, true);
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n</div>");
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
