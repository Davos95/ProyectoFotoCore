#pragma checksum "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Session\FavoritePhotos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a1101307f623ba14c33891d83813561bf38ab45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Session_FavoritePhotos), @"mvc.1.0.view", @"/Views/Session/FavoritePhotos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Session/FavoritePhotos.cshtml", typeof(AspNetCore.Views_Session_FavoritePhotos))]
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
#line 1 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Session\FavoritePhotos.cshtml"
using ProyectoFotoCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a1101307f623ba14c33891d83813561bf38ab45", @"/Views/Session/FavoritePhotos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6de92ebe6cb4bf092acae0a3d4ee46870dfebb", @"/Views/_ViewImports.cshtml")]
    public class Views_Session_FavoritePhotos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PHOTO_COMPLEX>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PreviewImage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styleGridImagesFront.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("draggable", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Session\FavoritePhotos.cshtml"
  
    ViewData["Title"] = "FavoritePhotos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(159, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(177, 791, true);
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
        }*/

        /*.gallery .card .card-content {
            padding: 1px;
        }*/


        /*.card-image {
            margin: 1rem;
        }*/

        /*.textPhoto {
            text-align: center;
        }

       

        .triggerImage {
            margin-left: 3.5em;
            cursor: pointer;
        }*/
        .setFavorite {
            cursor: pointer;
        }
        .card-title {
            display: flex;
            align-items: center;
            width: 100%;
        }
    </style>
    ");
                EndContext();
                BeginContext(968, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "05f9019c97f74dbcaf648af335546b05", async() => {
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
                BeginContext(1023, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1029, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "424c3796823d49279aba9847d37e04f8", async() => {
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
                BeginContext(1092, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(1099, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("events", async() => {
                BeginContext(1119, 4862, true);
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
            
            $(""#order"").click(function () {
                var array = new Array();
                $("".img"").each(function () {
                    array.push($(this).attr(""id""));
                });

                var formData = new FormData();
                formData.append(""idPhotos"", array);
                $.ajax({
                    type: ""POST"",
                    url: ""/Images/OrderFavorites"",
                    data: formData,
                    contentType: false,
");
                WriteLiteral(@"                    processData: false,
                    success: function (data) {
                        if (data) {
                            M.toast({ html: 'Se han ordenado las fotos correctamente!' });
                        }
                    }
                });
            });

            $("".setFavorite"").click(function () {
                console.log(""entra"");
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
    ");
                WriteLiteral(@"                });
                } else {
                    $.ajax({
                        type: ""POST"",
                        url: ""/Images/UndoFavorite"",
                        data: formData,
                        dataType: ""json"",
                        contentType: false,
                        processData: false,
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

    ");
                WriteLiteral(@"            /*Intercambio de imagenes*/
                var origenImg = $(""#"" + origen + "">img"").attr('src');
                var destinoImg = $(""#"" + destino + "">img"").attr('src');

                $(""#"" + origen + "">img"").attr('src', destinoImg);
                $(""#"" + destino + "">img"").attr('src', origenImg);

                var origenIdImg = $(""#"" + origen + "">img"").attr('id');
                var destinoIdImg = $(""#"" + destino + "">img"").attr('id');
                $(""#"" + origen + "">img"").attr('id', destinoIdImg);
                $(""#"" + destino + "">img"").attr('id', origenIdImg);

                /* Intercambio de textos */

                var origenTextoImagen = $(""#"" + origen + "">.card-title>span"").text();
                var destinoTextoImagen = $(""#"" + destino + "">.card-title>span"").text();

                $(""#"" + origen + "">.card-title>span"").text(destinoTextoImagen);
                $(""#"" + destino + "">.card-title>span"").text(origenTextoImagen);

                /* Intercamb");
                WriteLiteral(@"io de  iconos e ids booleanos */

                var origenBool = $(""#"" + origen + "">.card-title>i"").text();
                var destinoBool = $(""#"" + destino + "">.card-title>i"").text();

                $(""#"" + origen + "">.card-title>i"").text(destinoBool);
                $(""#"" + destino + "">.card-title>i"").text(origenBool);

                var origenDataVal = $(""#"" + origen + "">.card-title>i"").data(""value"");
                var destinoDataVal = $(""#"" + destino + "">.card-title>i"").data(""value"");

                $(""#"" + origen + "">.card-title>i"").data(""value"", destinoDataVal);
                $(""#"" + destino + "">.card-title>i"").data(""value"", origenDataVal);

                flagImg = true;
            });


        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(5984, 154, true);
            WriteLiteral("\r\n<div class=\"row\" style=\"padding: 1rem 1.2rem;\">\r\n    <div class=\"col s12 m7 l8 xl9\">\r\n        <div class=\"row gallery\">\r\n            <div id=\"photos\">\r\n");
            EndContext();
#line 189 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Session\FavoritePhotos.cshtml"
                 if (Model.Count() > 0)
                {
                    foreach (PHOTO_COMPLEX p in Model)
                    {

#line default
#line hidden
            BeginContext(6277, 95, true);
            WriteLiteral("                        <div class=\"card\">\r\n                            <div class=\"card-image\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 6372, "\"", 6386, 2);
            WriteAttributeValue("", 6377, "div_", 6377, 4, true);
#line 194 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Session\FavoritePhotos.cshtml"
WriteAttributeValue("", 6381, p.Id, 6381, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6387, 35, true);
            WriteLiteral(">\r\n                                ");
            EndContext();
            BeginContext(6422, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "007bad1281db4b34a646ae91c054bba2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6432, "~/images/Session/", 6432, 17, true);
#line 195 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Session\FavoritePhotos.cshtml"
AddHtmlAttributeValue("", 6449, p.SessionName, 6449, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 6463, "/", 6463, 1, true);
#line 195 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Session\FavoritePhotos.cshtml"
AddHtmlAttributeValue("", 6464, p.Picture, 6464, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 195 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Session\FavoritePhotos.cshtml"
AddHtmlAttributeValue("", 6497, p.Id, 6497, 5, false);

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
            BeginContext(6518, 81, true);
            WriteLiteral("\r\n                                <span class=\"card-title\" style=\"width: 100%\">\r\n");
            EndContext();
#line 197 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Session\FavoritePhotos.cshtml"
                                     if (p.Favorite)
                                    {

#line default
#line hidden
            BeginContext(6692, 121, true);
            WriteLiteral("                                        <i class=\"material-icons setFavorite\" style=\"color:red; float: left\" data-value=\"");
            EndContext();
            BeginContext(6814, 4, false);
#line 199 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Session\FavoritePhotos.cshtml"
                                                                                                                    Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(6818, 16, true);
            WriteLiteral("\">favorite</i>\r\n");
            EndContext();
#line 200 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Session\FavoritePhotos.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(6954, 121, true);
            WriteLiteral("                                        <i class=\"material-icons setFavorite\" style=\"color:red; float: left\" data-value=\"");
            EndContext();
            BeginContext(7076, 4, false);
#line 203 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Session\FavoritePhotos.cshtml"
                                                                                                                    Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(7080, 23, true);
            WriteLiteral("\">favorite_border</i>\r\n");
            EndContext();
#line 204 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Session\FavoritePhotos.cshtml"
                                    }

#line default
#line hidden
            BeginContext(7142, 85, true);
            WriteLiteral("                                    <span class=\"triggerImage\" style=\"margin: 0 7em\">");
            EndContext();
            BeginContext(7228, 9, false);
#line 205 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Session\FavoritePhotos.cshtml"
                                                                                Write(p.Picture);

#line default
#line hidden
            EndContext();
            BeginContext(7237, 120, true);
            WriteLiteral("</span>\r\n                                </span>\r\n\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 210 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Session\FavoritePhotos.cshtml"
                    }
                }
                else
                {

#line default
#line hidden
            BeginContext(7440, 116, true);
            WriteLiteral("                    <h1>¡No hay fotos actualmente!</h1>\r\n                    <h1>¡Intenta subir unas cuantas!</h1>\r\n");
            EndContext();
#line 216 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Session\FavoritePhotos.cshtml"
                }

#line default
#line hidden
            BeginContext(7575, 882, true);
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""col s12 m5 l4 xl3"">
        <div class=""card"" style=""height:100%"">
            <div class=""card-content"">
                <div class=""input-field"">
                    <span class=""card-title"" style=""display: flex; justify-content: center; align-items: center;"">
                        <i class=""material-icons"" style=""margin: 0 10px; font-size: 2.2rem"">photo_library</i>Ordenar Fotos
                    </span>
                    <button type=""button"" id=""order"" class=""btn waves-effect waves-darken green"">Ordenar</button>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- The Modal -->
<div id=""modalPreview"" class=""modal-Preview"">
    <span class=""close"">&times;</span>
    <img class=""modal-content-Preview"" id=""imagePreview"">
    <div id=""caption""></div>
</div>");
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
