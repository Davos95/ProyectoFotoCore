#pragma checksum "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Comision\Comision.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45a138db453f8a0e54f24d90cbee9b35babc471c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comision_Comision), @"mvc.1.0.view", @"/Views/Comision/Comision.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comision/Comision.cshtml", typeof(AspNetCore.Views_Comision_Comision))]
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
#line 1 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Comision\Comision.cshtml"
using ProyectoFotoCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45a138db453f8a0e54f24d90cbee9b35babc471c", @"/Views/Comision/Comision.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6de92ebe6cb4bf092acae0a3d4ee46870dfebb", @"/Views/_ViewImports.cshtml")]
    public class Views_Comision_Comision : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<COMISION>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styleComision.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formComision"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Comision\Comision.cshtml"
  
    ViewBag.Title = "Comision";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("styles", async() => {
                BeginContext(158, 12, true);
                WriteLiteral("\r\n    \r\n    ");
                EndContext();
                BeginContext(170, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c4f8148bd3e64c9998f51508d743ff18", async() => {
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
                BeginContext(226, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("events", async() => {
                BeginContext(248, 5366, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {


            $(""#photo"").change(function () {
                readImage(this);
            });
            $(""#photo"").mouseenter(function () {
                if (this.files[0]) {
                    $(""#divPreview"").css(""display"", ""block"");
                }
            });
            $(""#photo"").mouseleave(function () {
                if (this.files[0]) {
                    $(""#divPreview"").css(""display"", ""none"");
                }
            });
            var origenImagen = """";
            var origenCaja = """";
            var origenTitulo = """";

            var flag = true;
            $("".box"")
                .on(""dragover"", function (e) {
                    //RECOGEMOS INFORMACION DE LA IMAGEN ORIGEN
                    e.preventDefault();
                    if (flag) {
                        origenCaja = $(this).attr(""id"");
                        origenImagen = $(""#"" + origenCaja + "">img"").attr('src');
     ");
                WriteLiteral(@"                   origenTitulo = $(""#"" + origenCaja + "">.card-title"").text();
                        flag = false;
                    }
                }).on(""drop"", function (e) {
                    //INTERCAMBIAMOS INFORMACION ENTRE LA IMAGEN ORIGEN Y LA DE DESTINO
                    e.preventDefault();
                    var destinoCaja = $(this).attr('id');
                    var destinoImagen = $(""#"" + destinoCaja + "">img"").attr('src');
                    var destinoTitulo = $(""#"" + destinoCaja + "">.card-title"").text();

                    //Intercambio de imagenes
                    $(""#"" + destinoCaja + "">img"").attr('src', origenImagen);
                    $(""#"" + origenCaja + "">img"").attr(""src"", destinoImagen);

                    //Intercambio de titulos
                    $(""#"" + destinoCaja + "">.card-title"").text(origenTitulo);
                    $(""#"" + origenCaja + "">.card-title"").text(destinoTitulo);

                    //Intercambio de inputs
                  ");
                WriteLiteral(@"  //Price
                    var priceOrigen = $(""#"" + origenCaja + "">input[name=price]"").val();
                    var priceDestino = $(""#"" + destinoCaja + "">input[name=price]"").val();
                    $(""#"" + origenCaja + "">input[name=price]"").val(priceDestino);
                    $(""#"" + destinoCaja + "">input[name=price]"").val(priceOrigen);

                    //Description
                    var descriptionOrigen = $(""#"" + origenCaja + "">input[name=description]"").val();
                    var descriptionDestino = $(""#"" + destinoCaja + "">input[name=description]"").val();
                    $(""#"" + origenCaja + "">input[name=description]"").val(descriptionDestino);
                    $(""#"" + destinoCaja + "">input[name=description]"").val(descriptionOrigen);

                    //Intercambio de IDs
                    var idOrigen = origenCaja;
                    var idDestino = destinoCaja;

                    var aux = ""abcdefg""; //Auxiliar para que no se acoplen los ID
         ");
                WriteLiteral(@"           $(""#"" + origenCaja).attr(""id"", aux);
                    $(""#"" + destinoCaja).attr(""id"", idOrigen);
                    $(""#"" + aux).attr(""id"", idDestino);

                    flag = true;
                }).click(function () {
                    var id = $(this).attr(""id"");
                    var price = $(""#"" + id + "">input[name=price]"").val();
                    var description = $(""#"" + id + "">input[name=description]"").val();
                    console.log(price);
                    console.log(description);

                    //Poner valores de las comisiones en el formulario
                    $(""#formComision input[name=name]"").focus();
                    $(""#formComision input[name=name]"").val($(""#"" + id + "">.card-title"").text().trim());

                    $(""#formComision textarea[name=description]"").val(description);

                    $(""#formComision input[name=price]"").focus();
                    $(""#formComision input[name=price]"").val(price);

    ");
                WriteLiteral(@"                $(""#formComision input[name=price]"").blur();

                    $(""#formComision input[name=id]"").val(id);

                });

            $(""#btnOrdenar"").click(function () {
                var arrayId = $("".box"");
                var arrayId = [];
                $.each($("".box""), function (index, value) {
                    arrayId.push($(value).attr('id'));
                });
                console.log(arrayId);
                var json = { order: arrayId };
                $.ajax({
                    method: ""POST"",
                    url: ""/Comision/OrderComision"",
                    data: json,
                    success: function (data) {
                        M.toast({ html: '¡Se han ordenado correctamente!' })
                    }
                });
            });
        });

        function readImage(input) {
            if (input.files[0]) {
                var reader = new FileReader();
            } else {
                $(""#divPre");
                WriteLiteral("view\").css(\"display\", \"none\");\r\n            }\r\n            reader.onload = function (e) {\r\n                $(\"#preview\").attr(\"src\", e.target.result);\r\n            }\r\n            reader.readAsDataURL(input.files[0]);\r\n        }\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(5617, 321, true);
            WriteLiteral(@"<div class=""row"" style=""padding: 1rem 1.2rem;"">
    <div class=""col s12 m7 l6 xl5 "">
        <div class=""card"">
            <div class=""card-title center-align"" style=""margin:0 !important; padding: 0 !important"">Comisión</div>
            <div class=""card-content"" style=""padding-top: 0 !important"">
                ");
            EndContext();
            BeginContext(5938, 2131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b29f8759732c4e9a8fd710be724b2ddc", async() => {
                BeginContext(6006, 2056, true);
                WriteLiteral(@"
                    <div class=""input-field"">
                        <input type=""text"" name=""name"" id=""name"" />
                        <label for=""name""><i class=""material-icons iconInput"">label</i>Nombre</label>
                    </div>
                    <div class=""input-field"">
                        <textarea name=""description"" id=""description"" placeholder=""Descripcion"" style=""resize:none; height:70px;""></textarea>
                    </div>
                    <div class=""input-field"">
                        <input type=""file"" name=""photo"" id=""photo"" />
                        <!-- Preview Div -->
                        <div id=""divPreview"" style=""z-index: 10; display:none; position:absolute;"">
                            <div class=""card"" style=""width:70%;"">
                                <div class=""card-content"">
                                    <img id=""preview"" style=""width: 100%; margin:0 auto;"" />
                                </div>
                            </d");
                WriteLiteral(@"iv>
                        </div>
                        <!-- End Preview Div-->
                    </div>
                    <div class=""input-field"">
                        <input type=""number"" name=""price"" id=""price"" min=""0"" style=""width: 150px"" /> &nbsp; €
                        <label for=""price"">Precio</label>
                        <input type=""hidden"" name=""id"" value="""" />
                    </div>
                    <div class=""input-field"">
                        <button type=""submit"" name=""option"" value=""ADD"" class=""btn waves-effect waves-darken green"">Añadir</button>
                        <div class=""divider""></div>
                        <button type=""submit"" name=""option"" value=""UPDATE"" class=""btn waves-effect waves-darken green"">Modificar</button>
                        <div class=""divider""></div>
                        <button type=""submit"" name=""option"" value=""DELETE"" class=""btn waves-effect waves-darken red"">Eliminar</button>
                    </div>
        ");
                WriteLiteral("        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8069, 166, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col s12 m7 l6 xl5 offset-xl2\">\r\n        <div class=\"card\">\r\n            <div class=\"card-content\">\r\n");
            EndContext();
#line 181 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Comision\Comision.cshtml"
                 if (Model != null)
                {
                    foreach (COMISION comision in Model)
                    {

#line default
#line hidden
            BeginContext(8372, 214, true);
            WriteLiteral("                        <div class=\"card\" style=\"height:150px; width: 80%; margin: auto; margin-bottom:20px;\">\r\n                            <div class=\"card-image\">\r\n                                <div class=\"box\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 8586, "\"", 8603, 1);
#line 187 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Comision\Comision.cshtml"
WriteAttributeValue("", 8591, comision.Id, 8591, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8604, 43, true);
            WriteLiteral(">\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 8647, "\"", 8681, 1);
#line 188 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Comision\Comision.cshtml"
WriteAttributeValue("", 8653, Url.Content(comision.Photo), 8653, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8682, 146, true);
            WriteLiteral(" style=\"height:150px;\" draggable=\"true\" />\r\n                                    <div class=\"card-title\">\r\n                                        ");
            EndContext();
            BeginContext(8829, 13, false);
#line 190 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Comision\Comision.cshtml"
                                   Write(comision.Name);

#line default
#line hidden
            EndContext();
            BeginContext(8842, 113, true);
            WriteLiteral("\r\n                                    </div>\r\n                                    <input type=\"text\" name=\"price\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8955, "\"", 8978, 1);
#line 192 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Comision\Comision.cshtml"
WriteAttributeValue("", 8963, comision.Price, 8963, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8979, 85, true);
            WriteLiteral(" hidden />\r\n                                    <input type=\"text\" name=\"description\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9064, "\"", 9093, 1);
#line 193 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Comision\Comision.cshtml"
WriteAttributeValue("", 9072, comision.Description, 9072, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9094, 120, true);
            WriteLiteral(" hidden />\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 197 "G:\Proyectos\ProyectoFotoCore\ProyectoFotoCore\Views\Comision\Comision.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(9256, 164, true);
            WriteLiteral("            </div>\r\n        </div>\r\n        <button id=\"btnOrdenar\" type=\"button\" class=\"btn waves-effect waves-darken green\">Ordenar</button>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<COMISION>> Html { get; private set; }
    }
}
#pragma warning restore 1591
