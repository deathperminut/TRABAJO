#pragma checksum "C:\Users\DeLL-PC\Documents\Proyectos\Ganaderia\Ganaderia.App\Ganaderia.App.Frontend\Pages\Inicio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98cd2a13b961caf005b2652f5e8d93d11feb2415"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ganaderia.App.Frontend.Pages.Pages_Inicio), @"mvc.1.0.razor-page", @"/Pages/Inicio.cshtml")]
namespace Ganaderia.App.Frontend.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\DeLL-PC\Documents\Proyectos\Ganaderia\Ganaderia.App\Ganaderia.App.Frontend\Pages\_ViewImports.cshtml"
using Ganaderia.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98cd2a13b961caf005b2652f5e8d93d11feb2415", @"/Pages/Inicio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9937279de087f6649acc00d16a81bc5346bf4a4f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Inicio : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("REGISTRO_FORMULARIO_FORM"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"SESION\">\r\n\r\n        <div class=\"REGISTRO_FORMULARIO\">\r\n\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98cd2a13b961caf005b2652f5e8d93d11feb24153568", async() => {
                WriteLiteral("\r\n                <h2 id=\"FORMULARIO_TEXTO\">USUARIO</h2>\r\n                <input id=\"ENTRADA\" type=\"text\" name=\"usuario\"");
                BeginWriteAttribute("required", " required=\"", 306, "\"", 317, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Ingrese Usuario\">\r\n                <h2 id=\"FORMULARIO_TEXTO\">CONTRASE??A</h2>\r\n                <input id=\"ENTRADA\" type=\"password\" name=\"contrase??a\"");
                BeginWriteAttribute("required", " required=\"", 479, "\"", 490, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Ingrese Contrase??a"">
                <h2 id=""FORMULARIO_TEXTO"">CUENTA</h2>
                <div>
                    <input type=""radio"" id=""GANADERO"" name=""drone"" value=""GANADERO"" checked>
                    <label id=""GANADERO"" for=""GANADERO"">GANADERO</label>
                </div>

                <div>
                    <input type=""radio"" id=""VETERINARIO"" name=""drone"" value=""VETERINARIO"">
                    <label id=""VETERINARIO"" for=""VETERINARIO"">VETERINARIO</label>
                </div>

                <input id=""boton_1"" type=""submit"" value=""Iniciar Sesi??n"">
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ganaderia.App.Frontend.Pages.InicioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ganaderia.App.Frontend.Pages.InicioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ganaderia.App.Frontend.Pages.InicioModel>)PageContext?.ViewData;
        public Ganaderia.App.Frontend.Pages.InicioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
