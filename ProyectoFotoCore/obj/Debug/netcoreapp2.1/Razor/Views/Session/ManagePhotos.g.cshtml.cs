#pragma checksum "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9fd13af021a96c59a92579acfda5e7369d9c227"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9fd13af021a96c59a92579acfda5e7369d9c227", @"/Views/Session/ManagePhotos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267c2fc42ddfc0a9968444e0eeaa937a360de349", @"/Views/_ViewImports.cshtml")]
    public class Views_Session_ManagePhotos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PHOTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PreviewImage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styleGridImagesFront.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("draggable", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img triggerImage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(163, 1337, true);
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
        .card-title-foto {
            background-color: rgba(0,0,0,0.3);
            padding: 4px !important;
        }
        label {
            font-size: inherit !important;
            color: white !important;
        }
    ");
                WriteLiteral(@"    .toCheck {
            position: relative;
            left: 6em;
            cursor: pointer;
        }
        [type=""checkbox""]:not(:checked), [type=""checkbox""]:checked {
            position: absolute;
            opacity: 0;
            pointer-events: visible;
        }

    </style>

    ");
                EndContext();
                BeginContext(1500, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "77298b88fcfe4d5181722e96a2d480d0", async() => {
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
                BeginContext(1555, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1561, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cfe69e61f946483a8884ca0218bb1261", async() => {
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
                BeginContext(1624, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1629, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("events", async() => {
                BeginContext(1647, 1490, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            M.AutoInit();

            $("".triggerImage"").click(function () {
                $(""#modalPreview"").css(""display"", ""block"");
                console.log($(this).parents("".card-image""));
                $(""#imagePreview"").attr(""src"", $(this).parents("".card-image"").children(""img"").attr(""src""));

            });

            $(""#modalPreview"").click(function () {
                $(this).css(""display"", ""none"");
            });

            $("".toCheck"").click(function () {
                
                if (!$(this).parents("".card-title"").children(""input"").prop(""checked"")) {
                    console.log(""visible"");
                    $(this).parents("".card-title"").children(""input"").prop(""checked"", true);
                    $(this).parents("".card-title"").children("".check"").css(""visibility"", ""visible"");
                }
                else {
                    console.log(""invisible"");
                    $(this).p");
                WriteLiteral(@"arents("".card-title"").children(""input"").prop(""checked"", false);
                    $(this).parents("".card-title"").children("".check"").css(""visibility"", ""hidden"");
                }

            });

            $(""#delete"").click(function () {
                var array = new Array();
                $(""input[type=checkbox]:checked"").each(function () {
                    array.push($(this).attr(""id""));
                });
                var sesion = ");
                EndContext();
                BeginContext(3138, 16, false);
#line 112 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                        Write(ViewBag.IdSesion);

#line default
#line hidden
                EndContext();
                BeginContext(3154, 1808, true);
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
                BeginContext(4963, 16, false);
#line 162 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                        Write(ViewBag.IdSesion);

#line default
#line hidden
                EndContext();
                BeginContext(4979, 8621, true);
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

            var origen;
            var flagImg = true;
            $("".card-image"").on(""dragover"", function (e) {
                e.preventDefault();
                //Recogemos el id del origen
                if (flagImg) {
                    origen = $(this).attr('id');
                    flagImg = false;
                }
            }).on(""drop"", function (e) {
                e.preventDefault();
                var destino = $(this).attr('id');

                console.log(origen);
                console.log(destino);
                
                /*Intercambio de imagenes*/
                var origenImg = $(""#"" + origen + "">img"").attr('src');
                var destinoImg = $(""#"" + destino + "">img"").attr('src');

                $(""#"" + or");
                WriteLiteral(@"igen + "">img"").attr('src', destinoImg);
                $(""#"" + destino + "">img"").attr('src', origenImg);

                var origenIdImg = $(""#"" + origen + "">img"").attr('id');
                var destinoIdImg = $(""#"" + destino + "">img"").attr('id');

                $(""#"" + origen + "">img"").attr('id', destinoIdImg);
                $(""#"" + destino + "">img"").attr('id', origenIdImg);


                /* Intercambio de textos */

                var origenTextoImagen = $(""#"" + origen + "">span>label"").text();
                var destinoTextoImagen = $(""#"" + destino + "">span>label"").text();

                $(""#"" + origen + "">span>label"").text(destinoTextoImagen);
                $(""#"" + destino + "">span>label"").text(origenTextoImagen);

                /* Intercambio de ids en checkboxes y referencias de labels */
                var origenCheck = $(""#"" + origen + "">.card-title>input"").attr(""id"");
                var destinoCheck = $(""#"" + destino + "">.card-title>input"").attr(""id"");

     ");
                WriteLiteral(@"           $(""#"" + origen + "">.card-title>input"").attr(""id"", destinoCheck);
                $(""#"" + destino + "">.card-title>input"").attr(""id"", origenCheck);
                

                /* Intercambio de  iconos e ids booleanos */

                var origenBool = $(""#"" + origen + "">span>.setFavorite"").text();
                var destinoBool = $(""#"" + destino + "">span>.setFavorite"").text();

                console.log(origenBool);
                console.log(destinoBool);

                $(""#"" + origen + "">span>.setFavorite"").text(destinoBool);
                $(""#"" + destino + "">span>.setFavorite"").text(origenBool);

                var origenDataVal = $(""#"" + origen + "">span>.setFavorite"").data(""value"");
                var destinoDataVal = $(""#"" + destino + "">span>.setFavorite"").data(""value"");

                $(""#"" + origen + "">span>.setFavorite"").data(""value"", destinoDataVal);
                $(""#"" + destino + "">span>.setFavorite"").data(""value"", origenDataVal);

              ");
                WriteLiteral(@"  flagImg = true;
            });



            //$("".box"")
            //    .on(""dragover"", function (e) {
            //        //RECOGEMOS INFORMACION DE LA IMAGEN ORIGEN
            //        e.preventDefault();
            //        if (flag) {
            //            origenCaja = $(this).attr(""id"");
            //            //origenCaja = origenCaja.split('_')[1];
            //            console.log(origenCaja);
            //            flag = false;
            //        }
            //    }).on(""drop"", function (e) {
            //        //INTERCAMBIAMOS INFORMACION ENTRE LA IMAGEN ORIGEN Y LA DE DESTINO
            //        e.preventDefault();
            //        var destinoCaja = $(this).attr('id');

            //        /* Intercambio de imagenes */
            //        var origenImagen = $(""#"" + origenCaja + "">.card-image>label>img"").attr('src');
            //        var destinoImagen = $(""#"" + destinoCaja + "">.card-image>label>img"").attr('src');

          ");
                WriteLiteral(@"  //        $(""#"" + destinoCaja + "">.card-image>label>img"").attr('src',origenImagen);
            //        $(""#"" + origenCaja + "">.card-image>label>img"").attr('src', destinoImagen);

            //        /* Intercambio de ids en checkboxes y referencias de labels */
            //        var origenCheck = $(""#"" + origenCaja + "">.card-image>input"").attr(""id"");

            //        var destinoCheck = $(""#"" + destinoCaja + "">.card-image>input"").attr(""id"");

            //        $(""#"" + origenCaja + "">.card-image>input"").attr(""id"", destinoCheck);
            //        $(""#"" + origenCaja + "">.card-image>label"").attr('for',destinoCheck);
            //        $(""#"" + destinoCaja + "">.card-image>input"").attr(""id"", origenCheck);
            //        $(""#"" + destinoCaja + "">.card-image>label"").attr('for', origenCheck);


            //        /* Intercambio textos */
            //        var origenTextoImagen = $(""#"" + origenCaja + "">.card-content>.card-action>div>span"").text();
            //  ");
                WriteLiteral(@"      var destinoTextoImagen = $(""#"" + destinoCaja + "">.card-content>.card-action>div>span"").text();

            //        $(""#"" + origenCaja + "">.card-content>.card-action>div>span"").text(destinoTextoImagen);
            //        $(""#"" + destinoCaja + "">.card-content>.card-action>div>span"").text(origenTextoImagen);

            //        /* Intercambio de  iconos e ids booleanos */
            //        var origenBool = $(""#"" + origenCaja + "">.card-content>.card-action>div>.setFavorite"").text();
            //        var destinoBool = $(""#"" + destinoCaja + "">.card-content>.card-action>div>.setFavorite"").text();

            //        $(""#"" + origenCaja + "">.card-content>.card-action>div>.setFavorite"").text(destinoBool);
            //        $(""#"" + destinoCaja + "">.card-content>.card-action>div>.setFavorite"").text(origenBool);

            //        var origenDataVal = $(""#"" + origenCaja + "">.card-content>.card-action>div>.setFavorite"").data(""value"");
            //        var destinoDataVal ");
                WriteLiteral(@"= $(""#"" + destinoCaja + "">.card-content>.card-action>div>.setFavorite"").data(""value"");

            //        $(""#"" + origenCaja + "">.card-content>.card-action>div>.setFavorite"").data(""value"", destinoDataVal);
            //        $(""#"" + destinoCaja + "">.card-content>.card-action>div>.setFavorite"").data(""value"", origenDataVal);

            //        flag = true;
            //    });

        });

    </script>
");
                EndContext();
            }
            );
            BeginContext(13603, 170, true);
            WriteLiteral("\r\n    <div class=\"row\" style=\"padding: 1rem 1.2rem;\">\r\n        <div class=\"col s12 m7 l8 xl9\">\r\n            <div class=\"row gallery\">\r\n                <div id=\"photos\">\r\n");
            EndContext();
#line 359 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                     if (Model.Count() > 0)
                    {
                        foreach (PHOTO p in Model)
                        {

#line default
#line hidden
            BeginContext(13920, 87, true);
            WriteLiteral("                    <div class=\"card\">\r\n                        <div class=\"card-image\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 14007, "\"", 14021, 2);
            WriteAttributeValue("", 14012, "div_", 14012, 4, true);
#line 364 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
WriteAttributeValue("", 14016, p.Id, 14016, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(14022, 35, true);
            WriteLiteral(">\r\n\r\n\r\n                            ");
            EndContext();
            BeginContext(14057, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ce9eb5f9bde4fe0861ed19f57d665cc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 14067, "~/images/Session/", 14067, 17, true);
#line 367 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
AddHtmlAttributeValue("", 14084, ViewBag.SessionName, 14084, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 14104, "/", 14104, 1, true);
#line 367 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
AddHtmlAttributeValue("", 14105, p.Picture, 14105, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 367 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
AddHtmlAttributeValue("", 14138, p.Id, 14138, 5, false);

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
            BeginContext(14172, 93, true);
            WriteLiteral("\r\n                            <span class=\"card-title card-title-foto\" style=\"width: 100%\">\r\n");
            EndContext();
#line 369 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                 if (p.Favorite)
                                {

#line default
#line hidden
            BeginContext(14350, 117, true);
            WriteLiteral("                                    <i class=\"material-icons setFavorite\" style=\"color:red; float: left\" data-value=\"");
            EndContext();
            BeginContext(14468, 4, false);
#line 371 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                                                                                                Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(14472, 16, true);
            WriteLiteral("\">favorite</i>\r\n");
            EndContext();
#line 372 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(14596, 117, true);
            WriteLiteral("                                    <i class=\"material-icons setFavorite\" style=\"color:red; float: left\" data-value=\"");
            EndContext();
            BeginContext(14714, 4, false);
#line 375 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                                                                                                Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(14718, 23, true);
            WriteLiteral("\">favorite_border</i>\r\n");
            EndContext();
#line 376 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                }

#line default
#line hidden
            BeginContext(14776, 166, true);
            WriteLiteral("                                <i class=\"material-icons check\" style=\"color:white; float: left\">check_box</i>\r\n                                <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 14942, "\"", 14952, 1);
#line 378 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
WriteAttributeValue("", 14947, p.Id, 14947, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 14953, "\"", 14965, 1);
#line 378 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
WriteAttributeValue("", 14960, p.Id, 14960, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(14966, 66, true);
            WriteLiteral(" />\r\n                                <label class=\"toCheck\"><span>");
            EndContext();
            BeginContext(15033, 9, false);
#line 379 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                                        Write(p.Picture);

#line default
#line hidden
            EndContext();
            BeginContext(15042, 144, true);
            WriteLiteral("</span></label>\r\n\r\n                            </span>\r\n\r\n                        </div>\r\n                        \r\n                    </div>\r\n");
            EndContext();
#line 386 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                            
                        }
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(15315, 124, true);
            WriteLiteral("                        <h1>¡No hay fotos actualmente!</h1>\r\n                        <h1>¡Intenta subir unas cuantas!</h1>\r\n");
            EndContext();
#line 393 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                    }

#line default
#line hidden
            BeginContext(15462, 550, true);
            WriteLiteral(@"                </div>
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
            BeginContext(16012, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78fb53da059c4d73a339b492026fc94f", async() => {
                BeginContext(16051, 22, true);
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
            BeginContext(16082, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 407 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                             foreach (SESSION s in ViewBag.Sessions)
                            {

#line default
#line hidden
            BeginContext(16185, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(16217, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56558dc31de54578a58fbe003bfc6114", async() => {
                BeginContext(16240, 6, false);
#line 409 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                                                 Write(s.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 409 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
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
            BeginContext(16255, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 410 "C:\Users\AlumnoMCSD\source\Github\ProyectoFotoCore\ProyectoFotoCore\Views\Session\ManagePhotos.cshtml"
                            }

#line default
#line hidden
            BeginContext(16288, 1249, true);
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



    <!-- ");
            WriteLiteral("The Modal -->\r\n    <div id=\"modalPreview\" class=\"modal-Preview\">\r\n        <span class=\"close\">&times;</span>\r\n        <img class=\"modal-content-Preview\" id=\"imagePreview\">\r\n        <div id=\"caption\"></div>\r\n    </div>\r\n\r\n\r\n\r\n");
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
