#pragma checksum "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7879e68e956aa8b1e07ebcaae07797cc213e2857"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sesion_EditSesion), @"mvc.1.0.view", @"/Views/Sesion/EditSesion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sesion/EditSesion.cshtml", typeof(AspNetCore.Views_Sesion_EditSesion))]
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
#line 1 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
using ProyectoFotoCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7879e68e956aa8b1e07ebcaae07797cc213e2857", @"/Views/Sesion/EditSesion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267c2fc42ddfc0a9968444e0eeaa937a360de349", @"/Views/_ViewImports.cshtml")]
    public class Views_Sesion_EditSesion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SESSION>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/styleEditSession.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
  
    ViewBag.Title = "Editar Sesion";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("styles", async() => {
                BeginContext(159, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(165, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5661759e14a64208be968ccf1f330814", async() => {
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
                BeginContext(228, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            DefineSection("events", async() => {
                BeginContext(251, 1234, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            M.AutoInit();
            $(""#Partner>.collection-item"").click(function () {
                if ($(this).css(""background-color"") == ""rgb(224, 224, 224)"") {
                    $(""#Partner>.collection-item"").css(""background-color"", ""white"");
                    $(""#idPartner"").val("""");
                } else {
                    $(""#Partner>.collection-item"").css(""background-color"", ""white"");
                    $(this).css(""background-color"", ""rgb(224, 224, 224)"");

                    $(""#idPartner"").val($(this).data(""partner""));
                }
            });
            $(""#Work>.collection-item"").click(function () {
                if ($(this).css(""background-color"") == ""rgb(224, 224, 224)"") {
                    $(""#Work>.collection-item"").css(""background-color"", ""white"");

                    $(""#idWork"").val();
                } else {
                    $(""#Work>.collection-item"").css(""background-color"", ""white");
                WriteLiteral("\");\r\n                    $(this).css(\"background-color\", \"rgb(224, 224, 224)\");\r\n\r\n                    $(\"#idWork\").val($(this).data(\"work\"));\r\n                }\r\n            });\r\n        });\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(1488, 142, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col s12 m3 l3 xl3\">\r\n        <div class=\"card\">\r\n            <div class=\"card-content\">\r\n                ");
            EndContext();
            BeginContext(1630, 1881, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9100bbcf63914ca79c86ade3176708de", async() => {
                BeginContext(1650, 113, true);
                WriteLiteral("\r\n                    <div class=\"input-field\">\r\n                        <input type=\"text\" name=\"name\" id=\"name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1763, "\"", 1782, 1);
#line 50 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
WriteAttributeValue("", 1771, Model.Name, 1771, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1783, 275, true);
                WriteLiteral(@" />
                        <label for=""name""><i class=""material-icons iconInput"">label</i>Nombre de la sesión</label>
                    </div>
                    <div class=""input-field"">
                        <textarea name=""description"" placeholder=""Descripcion"">");
                EndContext();
                BeginContext(2059, 17, false);
#line 54 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                                                                          Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(2076, 152, true);
                WriteLiteral("</textarea>\r\n                    </div>\r\n                    <div class=\"input-field\">\r\n                        <input type=\"date\" name=\"date\" id=\"date\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2228, "\"", 2249, 1);
#line 57 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
WriteAttributeValue("", 2236, ViewBag.Date, 2236, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2250, 264, true);
                WriteLiteral(@" />
                        <label for=""date""><i class=""material-icons iconInput"">date_range</i>Fecha de la sesión</label>
                    </div>
                    <div class=""input-field"">
                        <select name=""comision"" id=""comision"">
");
                EndContext();
#line 62 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                             foreach (COMISION c in ViewBag.Comision)
                            {
                                if (c.Id == Model.IdComision)
                                {

#line default
#line hidden
                BeginContext(2714, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(2750, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32dbbcc7502a4e10914850675164255c", async() => {
                    BeginContext(2782, 6, false);
#line 66 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                                                              Write(c.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 66 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                                       WriteLiteral(c.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2797, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 67 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(2907, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(2943, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a3c757810e249f59d99e63ea4e65490", async() => {
                    BeginContext(2966, 6, false);
#line 70 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                                                     Write(c.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 70 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                                       WriteLiteral(c.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2981, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 71 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                                }
                            }

#line default
#line hidden
                BeginContext(3049, 249, true);
                WriteLiteral("                        </select>\r\n                        <label for=\"comision\">Selecciona una Comision</label>\r\n                    </div>\r\n                    <div class=\"input-field\">\r\n                        <input type=\"hidden\" name=\"idSesion\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3298, "\"", 3315, 1);
#line 77 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
WriteAttributeValue("", 3306, Model.Id, 3306, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3316, 188, true);
                WriteLiteral(" />\r\n                        <button type=\"submit\" name=\"option\" value=\"MODIFY\" class=\"btn waves-effect waves-darken green\">Modificar</button>\r\n                    </div>\r\n                ");
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
            BeginContext(3511, 610, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""col s12 m9 l9 xl9"">
        <div class=""card"">
            <div class=""card-content"">
                <div class=""row"">
                    <div class=""col m5"">
                        <table>
                            <thead>
                                <tr>
                                    <th>Nombre</th>
                                    <th>Trabajo</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 99 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                                 if (ViewBag.Workers != null)
                                {
                                    foreach (Worker_Session_Complex w in ViewBag.Workers)
                                    {

#line default
#line hidden
            BeginContext(4349, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(4444, 9, false);
#line 104 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                                           Write(w.Partner);

#line default
#line hidden
            EndContext();
            BeginContext(4453, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4509, 6, false);
#line 105 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                                           Write(w.Work);

#line default
#line hidden
            EndContext();
            BeginContext(4515, 57, true);
            WriteLiteral("</td>\r\n                                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4572, "\"", 4702, 1);
#line 106 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
WriteAttributeValue("", 4579, Url.Action("DeletePartnerWorkFromSesion","Sesion",new { idSesion = Model.Id, idPartner = w.IdPartner, idWork = w.IdWork }), 4579, 123, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4703, 139, true);
            WriteLiteral(" style=\"float: right\"><i class=\"material-icons\" style=\"color: red;\">backspace</i></a></td>\r\n                                        </tr>\r\n");
            EndContext();
#line 108 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(4916, 222, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                    <div class=\"col m1\">\r\n                        <div class=\"divAddButton\">\r\n                            ");
            EndContext();
            BeginContext(5138, 494, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fadc35e93f9c4cc68b610bbb9dad1711", async() => {
                BeginContext(5158, 70, true);
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"idSesion\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5228, "\"", 5245, 1);
#line 116 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
WriteAttributeValue("", 5236, Model.Id, 5236, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5246, 379, true);
                WriteLiteral(@" />
                                <input type=""hidden"" name=""idPartner"" id=""idPartner"" />
                                <input type=""hidden"" name=""idWork"" id=""idWork"" />
                                <button type=""submit"" name=""option"" value=""ADD"" class=""btn-floating btn-large green""><i class=""large material-icons"">add_circle</i></button>
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
            BeginContext(5632, 266, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col m3"">
                        <div class=""collection with-header"" id=""Partner"">
                            <div class=""collection-header""><b>Participantes</b></div>
");
            EndContext();
#line 126 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                             foreach (WORKER p in ViewBag.Partner)
                            {

#line default
#line hidden
            BeginContext(5997, 75, true);
            WriteLiteral("                                <div class=\"collection-item\" data-partner=\"");
            EndContext();
            BeginContext(6073, 4, false);
#line 128 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                                                                      Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(6077, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(6080, 6, false);
#line 128 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                                                                             Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(6086, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 129 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                            }

#line default
#line hidden
            BeginContext(6125, 258, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col m3"">
                        <div class=""collection with-header"" id=""Work"">
                            <div class=""collection-header""><b>Trabajos</b></div>
");
            EndContext();
#line 136 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                             foreach (WORK w in ViewBag.Work)
                            {

#line default
#line hidden
            BeginContext(6477, 72, true);
            WriteLiteral("                                <div class=\"collection-item\" data-work=\"");
            EndContext();
            BeginContext(6550, 4, false);
#line 138 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                                                                   Write(w.Id);

#line default
#line hidden
            EndContext();
            BeginContext(6554, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(6557, 6, false);
#line 138 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                                                                          Write(w.Name);

#line default
#line hidden
            EndContext();
            BeginContext(6563, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 139 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Sesion\EditSesion.cshtml"
                            }

#line default
#line hidden
            BeginContext(6602, 144, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SESSION> Html { get; private set; }
    }
}
#pragma warning restore 1591
