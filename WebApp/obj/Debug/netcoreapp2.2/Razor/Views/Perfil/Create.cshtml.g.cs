#pragma checksum "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Perfil\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14a048372d37f056b3d1efd61532d94d871326b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perfil_Create), @"mvc.1.0.view", @"/Views/Perfil/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Perfil/Create.cshtml", typeof(AspNetCore.Views_Perfil_Create))]
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
#line 1 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#line 2 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14a048372d37f056b3d1efd61532d94d871326b6", @"/Views/Perfil/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dec085bf195b01abb92852e860e2ca042d6a2857", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfil_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Entities.Perfil>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("NomePerfil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Perfil\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(70, 97, true);
            WriteLiteral("\n<h1>Adicionar perfil</h1>\n\n<h4>Perfil</h4>\n<hr />\n<div class=\"row\">\n    <div class=\"col-md-10\">\n");
            EndContext();
#line 13 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Perfil\Create.cshtml"
         using (Html.BeginForm(null, null, FormMethod.Post, new { id = "__AjaxAntiForgeryForm" }))
        {
            

#line default
#line hidden
            BeginContext(289, 23, false);
#line 15 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Perfil\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
#line 15 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Perfil\Create.cshtml"
                                    
        }

#line default
#line hidden
            BeginContext(323, 46, true);
            WriteLiteral("\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(369, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14a048372d37f056b3d1efd61532d94d871326b66724", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 19 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Perfil\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NomePerfil);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(427, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(440, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14a048372d37f056b3d1efd61532d94d871326b68393", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 20 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Perfil\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NomePerfil);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(507, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(520, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14a048372d37f056b3d1efd61532d94d871326b610139", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 21 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Perfil\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NomePerfil);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(585, 93, true);
            WriteLiteral("\n        </div>\n\n        <div class=\"form-group\">\n            <input type=\"submit\" data-url=\"");
            EndContext();
            BeginContext(679, 29, false);
#line 25 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Perfil\Create.cshtml"
                                      Write(Url.Action("Create","Perfil"));

#line default
#line hidden
            EndContext();
            BeginContext(708, 74, true);
            WriteLiteral("\" value=\"Salvar\" id=\"btnSalvar\" class=\"btn btn-primary\" />\n        </div>\n");
            EndContext();
#line 27 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Perfil\Create.cshtml"
         if (ViewBag.Funcionalidade.Count > 0)
        {

#line default
#line hidden
            BeginContext(839, 302, true);
            WriteLiteral(@"            <table id=""tablePerfilFunc"" class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Nome Funcionalidade</th>
                        <th>Adicionar Funcionalidade</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 37 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Perfil\Create.cshtml"
                     foreach (var item in ViewBag.Funcionalidade)
                    {

#line default
#line hidden
            BeginContext(1229, 61, true);
            WriteLiteral("                        <tr>\n                            <td>");
            EndContext();
            BeginContext(1291, 21, false);
#line 40 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Perfil\Create.cshtml"
                           Write(item.IdFuncionalidade);

#line default
#line hidden
            EndContext();
            BeginContext(1312, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1351, 9, false);
#line 41 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Perfil\Create.cshtml"
                           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1360, 100, true);
            WriteLiteral("</td>\n                            <td> <input type=\"checkbox\" /></td>\n                        </tr>\n");
            EndContext();
#line 44 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Perfil\Create.cshtml"
                    }

#line default
#line hidden
            BeginContext(1482, 46, true);
            WriteLiteral("                </tbody>\n            </table>\n");
            EndContext();
#line 47 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Perfil\Create.cshtml"
        }

#line default
#line hidden
            BeginContext(1538, 29, true);
            WriteLiteral("    </div>\n</div>\n\n<div>\n    ");
            EndContext();
            BeginContext(1567, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14a048372d37f056b3d1efd61532d94d871326b615034", async() => {
                BeginContext(1589, 18, true);
                WriteLiteral("Voltar para  lista");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1611, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1638, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 56 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Perfil\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Entities.Perfil> Html { get; private set; }
    }
}
#pragma warning restore 1591
