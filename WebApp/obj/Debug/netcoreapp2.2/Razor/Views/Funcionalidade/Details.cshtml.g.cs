#pragma checksum "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Funcionalidade\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cff6fcbb1e2b84ee37fc9c09967369d1d0908571"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionalidade_Details), @"mvc.1.0.view", @"/Views/Funcionalidade/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Funcionalidade/Details.cshtml", typeof(AspNetCore.Views_Funcionalidade_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cff6fcbb1e2b84ee37fc9c09967369d1d0908571", @"/Views/Funcionalidade/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dec085bf195b01abb92852e860e2ca042d6a2857", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionalidade_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Entities.Funcionalidade>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Funcionalidade\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 130, true);
            WriteLiteral("\n<h1>Detalhes</h1>\n\n<div>\n    <h4>Funcionalidade</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(210, 52, false);
#line 14 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Funcionalidade\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdFuncionalidade));

#line default
#line hidden
            EndContext();
            BeginContext(262, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(323, 48, false);
#line 17 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Funcionalidade\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdFuncionalidade));

#line default
#line hidden
            EndContext();
            BeginContext(371, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(431, 40, false);
#line 20 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Funcionalidade\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(471, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(532, 36, false);
#line 23 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Funcionalidade\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(568, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(611, 69, false);
#line 28 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Funcionalidade\Details.cshtml"
Write(Html.ActionLink("Editar", "Edit", new { id = Model.IdFuncionalidade}));

#line default
#line hidden
            EndContext();
            BeginContext(680, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(687, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cff6fcbb1e2b84ee37fc9c09967369d1d09085716377", async() => {
                BeginContext(709, 19, true);
                WriteLiteral("Voltar para a lista");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(732, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Entities.Funcionalidade> Html { get; private set; }
    }
}
#pragma warning restore 1591
