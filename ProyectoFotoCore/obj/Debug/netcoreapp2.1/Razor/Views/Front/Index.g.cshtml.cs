#pragma checksum "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d71202306815ab69fb1d2cad978368a91f0e19d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Front_Index), @"mvc.1.0.view", @"/Views/Front/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Front/Index.cshtml", typeof(AspNetCore.Views_Front_Index))]
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
#line 1 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Index.cshtml"
using ProyectoFotoCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d71202306815ab69fb1d2cad978368a91f0e19d", @"/Views/Front/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267c2fc42ddfc0a9968444e0eeaa937a360de349", @"/Views/_ViewImports.cshtml")]
    public class Views_Front_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PHOTO_COMPLEX>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutFront.cshtml";

#line default
#line hidden
            BeginContext(153, 48, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col s12\">\r\n");
            EndContext();
#line 10 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Index.cshtml"
         foreach (PHOTO_COMPLEX p in Model)
        {

#line default
#line hidden
            BeginContext(257, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(269, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "054e4f6192664c128831f6d4477410a1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 279, "~/images/session/", 279, 17, true);
#line 12 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Index.cshtml"
AddHtmlAttributeValue("", 296, p.SessionName, 296, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 310, "/", 310, 1, true);
#line 12 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Index.cshtml"
AddHtmlAttributeValue("", 311, p.Picture, 311, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(325, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(338, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PHOTO_COMPLEX>> Html { get; private set; }
    }
}
#pragma warning restore 1591
