#pragma checksum "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Shared\_MessageCrud.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41b7e9fd8b4dc36b5642b846a8f2f1987bfe2c72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MessageCrud), @"mvc.1.0.view", @"/Views/Shared/_MessageCrud.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_MessageCrud.cshtml", typeof(AspNetCore.Views_Shared__MessageCrud))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41b7e9fd8b4dc36b5642b846a8f2f1987bfe2c72", @"/Views/Shared/_MessageCrud.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dec085bf195b01abb92852e860e2ca042d6a2857", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MessageCrud : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Shared\_MessageCrud.cshtml"
 if (TempData["Message"] != null)
{

#line default
#line hidden
            BeginContext(40, 37, true);
            WriteLiteral("    <div class=\"alert alert-success\">");
            EndContext();
            BeginContext(78, 19, false);
#line 4 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Shared\_MessageCrud.cshtml"
                                Write(TempData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(97, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 5 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Shared\_MessageCrud.cshtml"
}

#line default
#line hidden
            BeginContext(108, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Shared\_MessageCrud.cshtml"
 if (TempData["MessageErro"] != null)
{

#line default
#line hidden
            BeginContext(152, 37, true);
            WriteLiteral("    <div class=\"alert alert-success\">");
            EndContext();
            BeginContext(190, 35, false);
#line 9 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Shared\_MessageCrud.cshtml"
                                Write(TempData["MessageError"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(225, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 10 "C:\Users\luiz.reis\Documents\Visual Studio 2019\Projeto\CrudUsuarioNetCore-master\WebApp\Views\Shared\_MessageCrud.cshtml"
}

#line default
#line hidden
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