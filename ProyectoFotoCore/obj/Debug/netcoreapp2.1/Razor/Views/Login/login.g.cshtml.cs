#pragma checksum "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Login\login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e10b1bf4e71df09a0ab86ee204efd39804a6263"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_login), @"mvc.1.0.view", @"/Views/Login/login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/login.cshtml", typeof(AspNetCore.Views_Login_login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e10b1bf4e71df09a0ab86ee204efd39804a6263", @"/Views/Login/login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267c2fc42ddfc0a9968444e0eeaa937a360de349", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/styleLogin.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Login\login.cshtml"
  
    ViewBag.Title = "login";

#line default
#line hidden
            DefineSection("styles", async() => {
                BeginContext(56, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(62, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bbb0218ed88849c5be7428b6ddf0a217", async() => {
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
                BeginContext(119, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(124, 340, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col s12"" style=""text-align:center"">
        <h3>Picture Manager</h3>
    </div>
    <div class=""row""></div>
    <div class=""row"" style=""margin-top:5%"">
        <div class=""col s12 m6 l6 xl4 offset-m3 offset-l3 offset-xl4"">
            <div class=""card"">
                <div class=""card-content"">
");
            EndContext();
#line 17 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Login\login.cshtml"
                     using (Html.BeginForm())
                    {

#line default
#line hidden
            BeginContext(534, 749, true);
            WriteLiteral(@"                        <div class=""input-field"">
                            <input type=""text"" name=""nick"" id=""nick"" />
                            <label for=""nick""><i class=""material-icons loginIcon"">person</i>Nickname</label>
                        </div>
                        <div class=""input-field"">
                            <input type=""password"" name=""password"" id=""password"" />
                            <label for=""password""><i class=""material-icons loginIcon"">vpn_key</i>Password</label>
                        </div>
                        <div class=""input-field"">
                            <button type=""submit"" class=""btn green waves waves-effect waves-darken"">ENTRAR</button>
                        </div>
");
            EndContext();
#line 30 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Login\login.cshtml"
                    }

#line default
#line hidden
            BeginContext(1306, 82, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
