#pragma checksum "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7919914c47749327a6ab0c6b71a5e14396f5c99e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Session_ManagePhotos), @"mvc.1.0.view", @"/Views/Session/ManagePhotos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Session/ManagePhotos.cshtml", typeof(AspNetCore.Views_Session_ManagePhotos))]
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
#line 1 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
using ProyectoFotoCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7919914c47749327a6ab0c6b71a5e14396f5c99e", @"/Views/Session/ManagePhotos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267c2fc42ddfc0a9968444e0eeaa937a360de349", @"/Views/_ViewImports.cshtml")]
    public class Views_Session_ManagePhotos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PHOTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PreviewImage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styleGridImagesFront.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("draggable", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "null", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
  
    ViewBag.Title = "ManagePhotos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(163, 882, true);
                WriteLiteral(@"
    <style>
        .btn {
            width: 100%;
            margin: 1.5em 0;
            height: 3rem;
        }

        /*.img {
            width: 240px;
            height: 240px;
            object-fit: contain;
        }

        .gallery .card .card-content {
            padding: 1px;
        }*/

        .check {
            visibility: hidden;
            padding: 0 0 0 0.5rem;
        }

        /*.card-image {
            margin: 1rem;
        }*/

        /*.textPhoto {
            text-align: center;
        }*/

        .setFavorite {
            cursor: pointer;
        }

        .card-title {
            display: flex;
            align-items: center;
            width: 100%;
        }

        /*.triggerImage {
            margin-left: 3.5em;
            cursor: pointer;
        }*/
    </style>

    ");
                EndContext();
                BeginContext(1045, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "26d5b4898318439fa2e57379c5bd535b", async() => {
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
                BeginContext(1100, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1106, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "68d1956a59ba450c85f39726c979e0aa", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1169, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1174, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("events", async() => {
                BeginContext(1192, 1360, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            M.AutoInit();

            var flag = true;

            $("".triggerImage"").click(function () {
                $(""#modalPreview"").css(""display"", ""block"");
                console.log($(this).parents("".card-image""));
                $(""#imagePreview"").attr(""src"", $(this).parents("".card-image"").children(""img"").attr(""src""));

            });

            $(""#modalPreview"").click(function () {
                $(this).css(""display"", ""none"");
            });

            $("".img"").click(function () {

                if (!$(this).parents("".box"").children("".card-image"").children(""input"").prop(""checked"")) {
                    $(this).parents("".box"").children("".card-content"").children("".card-action"").children(""div"").children("".check"").css(""visibility"", ""visible"");
                }
                else {
                    $(this).parents("".box"").children("".card-content"").children("".card-action"").children(""div"").children("".che");
                WriteLiteral(@"ck"").css(""visibility"", ""hidden"");
                }

            });

            $(""#delete"").click(function () {
                var array = new Array();
                $(""input[type=checkbox]:checked"").each(function () {
                    array.push($(this).attr(""id""));
                });
                var sesion = ");
                EndContext();
                BeginContext(2553, 16, false);
#line 94 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                        Write(ViewBag.IdSesion);

#line default
#line hidden
                EndContext();
                BeginContext(2569, 1808, true);
                WriteLiteral(@";
                console.log(array);
                console.log(sesion);

                var formData = new FormData();
                formData.append(""idPhotos"", array);
                formData.append(""idSesion"", sesion);
                $.ajax({
                    type: ""POST"",
                    url: ""/Images/DeleteImages"",
                    data: formData,
                    contentType: false,
                    processData: false,
                    success: function (data) {
                        if (data) {
                            location.reload();
                        }
                    }
                });

            });

            $(""#order"").click(function () {
                var array = new Array();
                $(""input[type=checkbox]"").each(function () {
                    array.push($(this).attr(""id""));
                });
                console.log(array);

                var formData = new FormData();
                formData");
                WriteLiteral(@".append(""idPhotos"", array);
                $.ajax({
                    type: ""POST"",
                    url: ""/Images/OrderPhotos"",
                    data: formData,
                    contentType: false,
                    processData: false,
                    success: function (data) {
                        if (data) {
                            M.toast({ html: 'Se han ordenado las fotos correctamente!' });
                        }
                    }
                });
            });

            $(""#move"").click(function () {
                var array = new Array();
                $(""input[type=checkbox]:checked"").each(function () {
                    array.push($(this).attr(""id""));
                });
                var sesion = ");
                EndContext();
                BeginContext(4378, 16, false);
#line 144 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                        Write(ViewBag.IdSesion);

#line default
#line hidden
                EndContext();
                BeginContext(4394, 5699, true);
                WriteLiteral(@";
                var destinationSession = $(""#sessions"").val();

                console.log(array);
                console.log(sesion);
                console.log(destinationSession);

                var formData = new FormData();
                formData.append(""idPhotos"", array);
                formData.append(""oldSession"", sesion);
                formData.append(""session"", destinationSession);

                $.ajax({
                    type: ""POST"",
                    url: ""/Images/MovePhotos"",
                    data: formData,
                    contentType: false,
                    processData: false,
                    success: function (data) {
                        if (data) {
                            M.toast({ html: 'Se han movido las fotos a otra sesión correctamente!' });
                        }
                        setTimeout(function () {
                            location.reload();
                        },2000);
                    }
     ");
                WriteLiteral(@"           });

            });

            $("".setFavorite"").click(function () {

                var id = $(this).data(""value"");
                var formData = new FormData();
                var objet = $(this);
                formData.append(""idPhoto"", id);

                if (objet.text() != ""favorite"") {
                    $.ajax({
                        type: ""POST"",
                        url: ""/Images/SetFavorite"",
                        data: formData,
                        contentType: false,
                        processData: false,
                        success: function (data) {
                            objet.text(""favorite"");
                        }
                    });
                } else {
                    $.ajax({
                        type: ""POST"",
                        url: ""/Images/UndoFavorite"",
                        data: formData,
                        dataType: ""json"",
                        contentType: false,
         ");
                WriteLiteral(@"               processData: false,
                        success: function (data) {
                            objet.text(""favorite_border"");
                        }
                    });
                }

            });

            var origenCaja = """";

            $("".box"")
                .on(""dragover"", function (e) {
                    //RECOGEMOS INFORMACION DE LA IMAGEN ORIGEN
                    e.preventDefault();
                    if (flag) {
                        origenCaja = $(this).attr(""id"");
                        //origenCaja = origenCaja.split('_')[1];
                        console.log(origenCaja);
                        flag = false;
                    }
                }).on(""drop"", function (e) {
                    //INTERCAMBIAMOS INFORMACION ENTRE LA IMAGEN ORIGEN Y LA DE DESTINO
                    e.preventDefault();
                    var destinoCaja = $(this).attr('id');

                    /* Intercambio de imagenes */
              ");
                WriteLiteral(@"      var origenImagen = $(""#"" + origenCaja + "">.card-image>label>img"").attr('src');
                    var destinoImagen = $(""#"" + destinoCaja + "">.card-image>label>img"").attr('src');

                    $(""#"" + destinoCaja + "">.card-image>label>img"").attr('src',origenImagen);
                    $(""#"" + origenCaja + "">.card-image>label>img"").attr('src', destinoImagen);

                    /* Intercambio de ids en checkboxes y referencias de labels */
                    var origenCheck = $(""#"" + origenCaja + "">.card-image>input"").attr(""id"");

                    var destinoCheck = $(""#"" + destinoCaja + "">.card-image>input"").attr(""id"");

                    $(""#"" + origenCaja + "">.card-image>input"").attr(""id"", destinoCheck);
                    $(""#"" + origenCaja + "">.card-image>label"").attr('for',destinoCheck);
                    $(""#"" + destinoCaja + "">.card-image>input"").attr(""id"", origenCheck);
                    $(""#"" + destinoCaja + "">.card-image>label"").attr('for', origenCheck);

");
                WriteLiteral(@"
                    /* Intercambio textos */
                    var origenTextoImagen = $(""#"" + origenCaja + "">.card-content>.card-action>div>span"").text();
                    var destinoTextoImagen = $(""#"" + destinoCaja + "">.card-content>.card-action>div>span"").text();

                    $(""#"" + origenCaja + "">.card-content>.card-action>div>span"").text(destinoTextoImagen);
                    $(""#"" + destinoCaja + "">.card-content>.card-action>div>span"").text(origenTextoImagen);

                    /* Intercambio de  iconos e ids booleanos */
                    var origenBool = $(""#"" + origenCaja + "">.card-content>.card-action>div>.setFavorite"").text();
                    var destinoBool = $(""#"" + destinoCaja + "">.card-content>.card-action>div>.setFavorite"").text();

                    $(""#"" + origenCaja + "">.card-content>.card-action>div>.setFavorite"").text(destinoBool);
                    $(""#"" + destinoCaja + "">.card-content>.card-action>div>.setFavorite"").text(origenBool);

      ");
                WriteLiteral(@"              var origenDataVal = $(""#"" + origenCaja + "">.card-content>.card-action>div>.setFavorite"").data(""value"");
                    var destinoDataVal = $(""#"" + destinoCaja + "">.card-content>.card-action>div>.setFavorite"").data(""value"");

                    $(""#"" + origenCaja + "">.card-content>.card-action>div>.setFavorite"").data(""value"", destinoDataVal);
                    $(""#"" + destinoCaja + "">.card-content>.card-action>div>.setFavorite"").data(""value"", origenDataVal);

                    flag = true;
                });

        });

    </script>
");
                EndContext();
            }
            );
            BeginContext(10096, 156, true);
            WriteLiteral("\r\n<div class=\"row\" style=\"padding: 1rem 1.2rem;\">\r\n\r\n    <div class=\"col s12 m7 l8 xl9\">\r\n        <div class=\"row gallery\">\r\n            <div id=\"photos\">\r\n");
            EndContext();
#line 276 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                 if (Model.Count() > 0)
                {
                    foreach (PHOTO p in Model)
                    {

#line default
#line hidden
            BeginContext(10383, 95, true);
            WriteLiteral("                        <div class=\"card\">\r\n                            <div class=\"card-image\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 10478, "\"", 10492, 2);
            WriteAttributeValue("", 10483, "div_", 10483, 4, true);
#line 281 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
WriteAttributeValue("", 10487, p.Id, 10487, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10493, 57, true);
            WriteLiteral(">\r\n                                <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 10550, "\"", 10560, 1);
#line 282 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
WriteAttributeValue("", 10555, p.Id, 10555, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10561, 9, true);
            WriteLiteral(" /><label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 10570, "\"", 10581, 1);
#line 282 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
WriteAttributeValue("", 10576, p.Id, 10576, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10582, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(10583, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "118db536d5ad407d8022661eeb962458", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10593, "~/images/Session/", 10593, 17, true);
#line 282 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
AddHtmlAttributeValue("", 10610, ViewBag.SessionName, 10610, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 10630, "/", 10630, 1, true);
#line 282 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
AddHtmlAttributeValue("", 10631, p.Picture, 10631, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10664, "img_", 10664, 4, true);
#line 282 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
AddHtmlAttributeValue("", 10668, p.Id, 10668, 5, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10689, 89, true);
            WriteLiteral("</label>\r\n                                <span class=\"card-title\" style=\"width: 100%\">\r\n");
            EndContext();
#line 284 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                     if (p.Favorite)
                                    {

#line default
#line hidden
            BeginContext(10871, 121, true);
            WriteLiteral("                                        <i class=\"material-icons setFavorite\" style=\"color:red; float: left\" data-value=\"");
            EndContext();
            BeginContext(10993, 4, false);
#line 286 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                                                                                                    Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(10997, 16, true);
            WriteLiteral("\">favorite</i>\r\n");
            EndContext();
#line 287 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(11133, 121, true);
            WriteLiteral("                                        <i class=\"material-icons setFavorite\" style=\"color:red; float: left\" data-value=\"");
            EndContext();
            BeginContext(11255, 4, false);
#line 290 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                                                                                                    Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(11259, 23, true);
            WriteLiteral("\">favorite_border</i>\r\n");
            EndContext();
#line 291 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                    }

#line default
#line hidden
            BeginContext(11321, 198, true);
            WriteLiteral("                                    <i class=\"material-icons check\" style=\"color:green; float: right\">check</i>\r\n                                    <span class=\"triggerImage\" style=\"margin: 0 7em\">");
            EndContext();
            BeginContext(11520, 9, false);
#line 293 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                                                                Write(p.Picture);

#line default
#line hidden
            EndContext();
            BeginContext(11529, 118, true);
            WriteLiteral("</span>\r\n                                </span>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 297 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                    }
                }
                else
                {

#line default
#line hidden
            BeginContext(11730, 116, true);
            WriteLiteral("                    <h1>¡No hay fotos actualmente!</h1>\r\n                    <h1>¡Intenta subir unas cuantas!</h1>\r\n");
            EndContext();
#line 303 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                }

#line default
#line hidden
            BeginContext(11865, 542, true);
            WriteLiteral(@"            </div>
        </div>
        </div>

        <div class=""col s12 m5 l4 xl3"">
            <div class=""card"" style=""height:100%"">
                <div class=""card-content"">
                    <div class=""input-field"">
                        <span class=""card-title"" style=""display: flex;
    justify-content: center;
    align-items: center;""><i class=""material-icons"" style=""margin: 0 10px; font-size:2.2rem;"">panorama</i>Mover Fotos</span>
                        <select id=""sessions"">
                            ");
            EndContext();
            BeginContext(12407, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e66eaf8b2d6c44b8bf63731c7704bc48", async() => {
                BeginContext(12446, 22, true);
                WriteLiteral("Selecciona una sessión");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
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
            BeginContext(12477, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 317 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                             foreach (SESSION s in ViewBag.Sessions)
                            {

#line default
#line hidden
            BeginContext(12580, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(12612, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "848f111011ad49f1aa8ab9aae0ff4a9d", async() => {
                BeginContext(12635, 6, false);
#line 319 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                                 Write(s.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 319 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                   WriteLiteral(s.Id);

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
            BeginContext(12650, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 320 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                            }

#line default
#line hidden
            BeginContext(12683, 1243, true);
            WriteLiteral(@"                        </select>
                        <button type=""button"" id=""move"" class=""btn waves-effect waves-darken green"">Mover</button>
                    </div>
                    <div class=""input-field"">
                        <span class=""card-title"" style=""display: flex;
    justify-content: center;
    align-items: center;""><i class=""material-icons"" style=""margin: 0 10px; font-size: 2.2rem"">photo_library</i>Ordenar Fotos</span>
                        <button type=""button"" id=""order"" class=""btn waves-effect waves-darken green"">Ordenar</button>
                    </div>
                    <div class=""separador"" style=""width: 100%;    height: 1px;background: rgba(0, 0, 0, 0.12941176470588237);""></div>
                    <div class=""input-field"">
                        <button type=""button"" id=""delete"" class=""btn waves-effect waves-darken red"">Eliminar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- The Mo");
            WriteLiteral("dal -->\r\n    <div id=\"modalPreview\" class=\"modal-Preview\">\r\n        <span class=\"close\">&times;</span>\r\n        <img class=\"modal-content-Preview\" id=\"imagePreview\">\r\n        <div id=\"caption\"></div>\r\n    </div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PHOTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
