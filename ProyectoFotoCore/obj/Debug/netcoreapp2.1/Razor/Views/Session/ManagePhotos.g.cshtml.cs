#pragma checksum "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "805010930c11610618c89d8b622a35cd3135585c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"805010930c11610618c89d8b622a35cd3135585c", @"/Views/Session/ManagePhotos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267c2fc42ddfc0a9968444e0eeaa937a360de349", @"/Views/_ViewImports.cshtml")]
    public class Views_Session_ManagePhotos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PHOTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PreviewImage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/scriptUploadImages.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(163, 528, true);
                WriteLiteral(@"
    <style>
        .btn {
            width: 100%;
            margin: 1.5em 0;
            height: 3rem;
        }
        .img {
            width: 240px;
            height: 240px;
            object-fit: contain;
        }
        .gallery .card .card-content {
            padding: 1px;
        }
        .check {
            visibility: hidden;
        }
        .card-image {
            margin: 1rem;
        }
        .textPhoto {
            text-align: center;
        }
    </style>

    ");
                EndContext();
                BeginContext(691, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d5e59b8a74234fdca1b77840e071d87c", async() => {
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
                BeginContext(746, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(751, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("events", async() => {
                BeginContext(769, 1388, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            M.AutoInit();

            var flag = true;

            $("".triggerImage"").click(function () {
                $(""#modalPreview"").css(""display"", ""block"");
                console.log($(this).parents("".box""));
                $(""#imagePreview"").attr(""src"", $(this).parents("".box"").children("".card-image"").children(""label"").children(""img"").attr(""src""));

            });

            $(""#modalPreview"").click(function () {
                $(this).css(""display"", ""none"");
            });

            $("".img"").click(function () {

                if (!$(this).parents("".box"").children("".card-image"").children(""input"").prop(""checked"")) {
                    $(this).parents("".box"").children("".card-content"").children("".card-action"").children(""div"").children("".check"").css(""visibility"", ""visible"");
                }
                else {
                    $(this).parents("".box"").children("".card-content"").children("".card-action"").ch");
                WriteLiteral(@"ildren(""div"").children("".check"").css(""visibility"", ""hidden"");
                }

            });

            $(""#delete"").click(function () {
                var array = new Array();
                $(""input[type=checkbox]:checked"").each(function () {
                    array.push($(this).attr(""id""));
                });
                var sesion = ");
                EndContext();
                BeginContext(2158, 16, false);
#line 72 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                        Write(ViewBag.IdSesion);

#line default
#line hidden
                EndContext();
                BeginContext(2174, 1808, true);
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
                BeginContext(3983, 16, false);
#line 122 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                        Write(ViewBag.IdSesion);

#line default
#line hidden
                EndContext();
                BeginContext(3999, 4757, true);
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

                    /* Intercambio de imagenes *");
                WriteLiteral(@"/
                    var origenImagen = $(""#"" + origenCaja + "">.card-image>label>img"").attr('src');
                    var destinoImagen = $(""#"" + destinoCaja + "">.card-image>label>img"").attr('src');

                    $(""#"" + destinoCaja + "">.card-image>label>img"").attr('src',origenImagen);
                    $(""#"" + origenCaja + "">.card-image>label>img"").attr('src', destinoImagen);

                    /* Intercambio de ids en checkboxes y referencias de labels */
                    var origenCheck = $(""#"" + origenCaja + "">.card-image>input"").attr(""id"");

                    var destinoCheck = $(""#"" + destinoCaja + "">.card-image>input"").attr(""id"");

                    $(""#"" + origenCaja + "">.card-image>input"").attr(""id"", destinoCheck);
                    $(""#"" + origenCaja + "">.card-image>label"").attr('for',destinoCheck);
                    $(""#"" + destinoCaja + "">.card-image>input"").attr(""id"", origenCheck);
                    $(""#"" + destinoCaja + "">.card-image>label"").attr('for', ");
                WriteLiteral(@"origenCheck);


                    /* Intercambio textos */
                    var origenTextoImagen = $(""#"" + origenCaja + "">.card-content>.card-action>div>span"").text();
                    var destinoTextoImagen = $(""#"" + destinoCaja + "">.card-content>.card-action>div>span"").text();

                    $(""#"" + origenCaja + "">.card-content>.card-action>div>span"").text(destinoTextoImagen);
                    $(""#"" + destinoCaja + "">.card-content>.card-action>div>span"").text(origenTextoImagen);

                    console.log(origenTextoImagen);

                    flag = true;
                });

        });

    </script>
    ");
                EndContext();
                BeginContext(8756, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6998c3598794defa5e8278203a09365", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8806, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(8811, 125, true);
            WriteLiteral("\r\n<div class=\"row\" style=\"padding: 1rem 1.2rem;\">\r\n\r\n    <div class=\"col s12 m7 l8 xl9\">\r\n        <div class=\"row gallery\">\r\n");
            EndContext();
#line 243 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
             if (Model.Count() > 0)
            {
                foreach (PHOTO p in Model)
                {

#line default
#line hidden
            BeginContext(9051, 130, true);
            WriteLiteral("                    <div class=\"col s12 m3\">\r\n                        <div class=\"card col s12\">\r\n                            <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 9181, "\"", 9195, 2);
            WriteAttributeValue("", 9186, "div_", 9186, 4, true);
#line 249 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
WriteAttributeValue("", 9190, p.Id, 9190, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9196, 131, true);
            WriteLiteral(" class=\"box\">\r\n                                <div class=\"card-image\">\r\n                                    <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 9327, "\"", 9337, 1);
#line 251 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
WriteAttributeValue("", 9332, p.Id, 9332, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9338, 9, true);
            WriteLiteral(" /><label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 9347, "\"", 9358, 1);
#line 251 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
WriteAttributeValue("", 9353, p.Id, 9353, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9359, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(9360, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "96b2d3f3c3d34e65b8155cb628200a9b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9370, "~/images/Session/", 9370, 17, true);
#line 251 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
AddHtmlAttributeValue("", 9387, ViewBag.SessionName, 9387, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 9407, "/", 9407, 1, true);
#line 251 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
AddHtmlAttributeValue("", 9408, p.Picture, 9408, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9441, "img_", 9441, 4, true);
#line 251 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
AddHtmlAttributeValue("", 9445, p.Id, 9445, 5, false);

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
            BeginContext(9466, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
            BeginContext(9818, 299, true);
            WriteLiteral(@"                                </div>
                                <div class=""card-content"">
                                    <div class=""card-action"">
                                        <div class=""textPhoto"">
                                            <span class=""triggerImage"">");
            EndContext();
            BeginContext(10118, 9, false);
#line 261 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                                                  Write(p.Picture);

#line default
#line hidden
            EndContext();
            BeginContext(10127, 130, true);
            WriteLiteral("</span>\r\n                                            <i class=\"material-icons check\" style=\"color:green; float: right\">check</i>\r\n");
            EndContext();
#line 263 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                             if (p.Favorite)
                                            {

#line default
#line hidden
            BeginContext(10366, 130, true);
            WriteLiteral("                                                <i class=\"material-icons setFavorite\" style=\"color:red; float: right\" data-value=\"");
            EndContext();
            BeginContext(10497, 4, false);
#line 265 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                                                                                                             Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(10501, 16, true);
            WriteLiteral("\">favorite</i>\r\n");
            EndContext();
#line 266 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(10661, 133, true);
            WriteLiteral("                                                <a><i class=\"material-icons setFavorite\" style=\"color:red; float: right\" data-value=\"");
            EndContext();
            BeginContext(10795, 4, false);
#line 269 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                                                                                                                Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(10799, 27, true);
            WriteLiteral("\">favorite_border</i></a>\r\n");
            EndContext();
#line 270 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                            }

#line default
#line hidden
            BeginContext(10873, 230, true);
            WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                </div>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 278 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"

                }

            }
            else
            {

#line default
#line hidden
            BeginContext(11174, 108, true);
            WriteLiteral("                <h1>¡No hay fotos actualmente!</h1>\r\n                <h1>¡Intenta subir unas cuantas!</h1>\r\n");
            EndContext();
#line 286 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
            }

#line default
#line hidden
            BeginContext(11297, 492, true);
            WriteLiteral(@"
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
            BeginContext(11789, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cba582932864306afc27415655f695a", async() => {
                BeginContext(11828, 22, true);
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
            BeginContext(11859, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 300 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                         foreach (SESSION s in ViewBag.Sessions)
                        {

#line default
#line hidden
            BeginContext(11954, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(11982, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "416a9fdfdea34c8dafe620e93d509fe6", async() => {
                BeginContext(12005, 6, false);
#line 302 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                             Write(s.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 302 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
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
            BeginContext(12020, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 303 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                        }

#line default
#line hidden
            BeginContext(12049, 1153, true);
            WriteLiteral(@"                    </select>
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
<!-- The Modal -->
<div id=""modalPreview"" class=""modal-Preview"">
    <spa");
            WriteLiteral("n class=\"close\">&times;</span>\r\n    <img class=\"modal-content-Preview\" id=\"imagePreview\">\r\n    <div id=\"caption\"></div>\r\n</div>\r\n");
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
