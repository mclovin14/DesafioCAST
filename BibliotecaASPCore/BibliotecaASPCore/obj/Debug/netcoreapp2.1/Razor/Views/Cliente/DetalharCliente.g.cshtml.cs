#pragma checksum "C:\Users\Kelven Barbieri\source\repos\BibliotecaASPCore\BibliotecaASPCore\Views\Cliente\DetalharCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "512d893577d29540e8234179f628f959b770b09a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_DetalharCliente), @"mvc.1.0.view", @"/Views/Cliente/DetalharCliente.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/DetalharCliente.cshtml", typeof(AspNetCore.Views_Cliente_DetalharCliente))]
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
#line 1 "C:\Users\Kelven Barbieri\source\repos\BibliotecaASPCore\BibliotecaASPCore\Views\_ViewImports.cshtml"
using BibliotecaASPCore;

#line default
#line hidden
#line 2 "C:\Users\Kelven Barbieri\source\repos\BibliotecaASPCore\BibliotecaASPCore\Views\_ViewImports.cshtml"
using BibliotecaASPCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"512d893577d29540e8234179f628f959b770b09a", @"/Views/Cliente/DetalharCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f572bb37a134e31217eb717081dccc0f9f4b2bb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_DetalharCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BibliotecaASPCore.Models.Cliente>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Kelven Barbieri\source\repos\BibliotecaASPCore\BibliotecaASPCore\Views\Cliente\DetalharCliente.cshtml"
  
    ViewData["Title"] = "DetalharCliente";

#line default
#line hidden
            BeginContext(94, 129, true);
            WriteLiteral("\r\n<h2>DetalharCliente</h2>\r\n\r\n<div>\r\n    <h4>Cliente</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(224, 38, false);
#line 14 "C:\Users\Kelven Barbieri\source\repos\BibliotecaASPCore\BibliotecaASPCore\Views\Cliente\DetalharCliente.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(262, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(306, 34, false);
#line 17 "C:\Users\Kelven Barbieri\source\repos\BibliotecaASPCore\BibliotecaASPCore\Views\Cliente\DetalharCliente.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(340, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(384, 40, false);
#line 20 "C:\Users\Kelven Barbieri\source\repos\BibliotecaASPCore\BibliotecaASPCore\Views\Cliente\DetalharCliente.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(424, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(468, 36, false);
#line 23 "C:\Users\Kelven Barbieri\source\repos\BibliotecaASPCore\BibliotecaASPCore\Views\Cliente\DetalharCliente.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(504, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(548, 38, false);
#line 26 "C:\Users\Kelven Barbieri\source\repos\BibliotecaASPCore\BibliotecaASPCore\Views\Cliente\DetalharCliente.cshtml"
       Write(Html.DisplayNameFor(model => model.Ra));

#line default
#line hidden
            EndContext();
            BeginContext(586, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(630, 34, false);
#line 29 "C:\Users\Kelven Barbieri\source\repos\BibliotecaASPCore\BibliotecaASPCore\Views\Cliente\DetalharCliente.cshtml"
       Write(Html.DisplayFor(model => model.Ra));

#line default
#line hidden
            EndContext();
            BeginContext(664, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(712, 73, false);
#line 34 "C:\Users\Kelven Barbieri\source\repos\BibliotecaASPCore\BibliotecaASPCore\Views\Cliente\DetalharCliente.cshtml"
Write(Html.ActionLink("Editar cliente", "EditarCliente", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(785, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(793, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bac1bcb0baa450db5aa2f0e59009298", async() => {
                BeginContext(817, 30, true);
                WriteLiteral("Voltar para lista de clientes.");
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
            BeginContext(851, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BibliotecaASPCore.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
