#pragma checksum "C:\Users\adolf\Documents\Repositorios GIT\CitasXWeb\CitasXWeb\CitasXWeb\Views\Home\Registro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bb429aa6dbf877046c75b61316b979b7c45cc6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registro), @"mvc.1.0.view", @"/Views/Home/Registro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Registro.cshtml", typeof(AspNetCore.Views_Home_Registro))]
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
#line 1 "C:\Users\adolf\Documents\Repositorios GIT\CitasXWeb\CitasXWeb\CitasXWeb\Views\_ViewImports.cshtml"
using CitasXWeb;

#line default
#line hidden
#line 2 "C:\Users\adolf\Documents\Repositorios GIT\CitasXWeb\CitasXWeb\CitasXWeb\Views\_ViewImports.cshtml"
using CitasXWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bb429aa6dbf877046c75b61316b979b7c45cc6f", @"/Views/Home/Registro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d058b7e5c18af49c19419e87bb74850a25da38a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("centered"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\adolf\Documents\Repositorios GIT\CitasXWeb\CitasXWeb\CitasXWeb\Views\Home\Registro.cshtml"
  
    ViewData["Title"] = "Registrar paciente";

#line default
#line hidden
            BeginContext(54, 215, true);
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\" integrity=\"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\" />\r\n");
            EndContext();
            BeginContext(269, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52278f7b260c4f3e9fe0354fefe66e97", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(333, 958, true);
            WriteLiteral(@"
<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>

<div class=""container"">
    <div class=""row justify-content-center"">
        <div class=""col-md-6"">
            <div class=""card"" style=""margin-top:30px;"">
                <header class=""card-header"">
                    <h4 class=""card-title mt-2"">Registro</h4>
                </header>
                <article class=""card-body"">
                    ");
            EndContext();
            BeginContext(1291, 4386, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1809b9339af48eab06d9788e8719349", async() => {
                BeginContext(1328, 4342, true);
                WriteLiteral(@"
                        <div class=""form-row"">
                            <div class=""col form-group"">
                                <label>Nombre: </label>
                                <input type=""text"" name=""nombre"" class=""form-control"" placeholder="""">
                            </div>
                            <div class=""col form-group"">
                                <label>Número de seguridad social: </label>
                                <input type=""text"" name=""social"" class=""form-control"" placeholder="" "">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""col form-group"">
                                <label>CURP </label>
                                <input type=""text"" name=""curp"" class=""form-control"" placeholder="""">
                            </div>
                            <div class=""col form-group"">
                                <label>Domicilio </label>");
                WriteLiteral(@"
                                <input type=""text"" name=""domicilio"" class=""form-control"" placeholder="" "">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""col form-group"">
                                <label>Fecha de nacimiento: </label>
                                <input id=""datetimepicker"" type=""date"" name=""domicilio"" class=""form-control"">
                                <script type=""text/javascript"">
                                    $(function () {
                                        $('#datetimepicker').datetimepicker();
                                    });
                                </script>
                            </div>
                            <div class=""col form-group"">
                                <label>Teléfono fijo: </label>
                                <input type=""text"" name=""domicilio"" class=""form-control"" placeholder="" "">
              ");
                WriteLiteral(@"              </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""col form-group"">
                                <label>Código postal: </label>
                                <input type=""number"" name=""curp"" class=""form-control"" placeholder="""">
                            </div>
                            <div class=""col form-group"">
                                <label>Teléfono personal: </label>
                                <input type=""tel"" name=""domicilio"" class=""form-control"" placeholder="" "">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""col form-group"">
                                <label>Ciudad: </label>
                                <input type=""text"" name=""curp"" class=""form-control"" placeholder="""">
                            </div>
                            <div class=""col form-group"">
   ");
                WriteLiteral(@"                             <label>Estado: </label>
                                <input type=""text"" name=""domicilio"" class=""form-control"" placeholder="" "">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label>Sexo: </label>
                            <br />
                            <div class=""form-check form-check-inline"">
                                <input class=""form-check-input"" type=""radio"" name=""masculino"" id=""masculino"" value=""masc"">
                                <label class=""form-check-label"" for=""masculino"">Masculino</label>
                            </div>
                            <div class=""form-check form-check-inline"">
                                <input class=""form-check-input"" type=""radio"" name=""femenino"" id=""femenino"" value=""femenino"">
                                <label class=""form-check-label"" for=""femenino"">Femenino</label>
                            </di");
                WriteLiteral("v>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <button type=\"submit\" class=\"btn btn-primary btn-block\"> Registarse  </button>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            BeginContext(5677, 86, true);
            WriteLiteral("\r\n                </article>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
