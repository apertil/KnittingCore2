#pragma checksum "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "703591308f7f753aca0bb1e34ec26cc71407c220"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patrones_Details), @"mvc.1.0.view", @"/Views/Patrones/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patrones/Details.cshtml", typeof(AspNetCore.Views_Patrones_Details))]
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
#line 1 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\_ViewImports.cshtml"
using KnittingCore2;

#line default
#line hidden
#line 2 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\_ViewImports.cshtml"
using KnittingCore2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"703591308f7f753aca0bb1e34ec26cc71407c220", @"/Views/Patrones/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e4be28638f0baffb677571a1501d1dc6f6bdf9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Patrones_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KnittingCore2.Models.Patrones>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Patrones</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(206, 48, false);
#line 14 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NombrePatron));

#line default
#line hidden
            EndContext();
            BeginContext(254, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(298, 44, false);
#line 17 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayFor(model => model.NombrePatron));

#line default
#line hidden
            EndContext();
            BeginContext(342, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(386, 42, false);
#line 20 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Patron));

#line default
#line hidden
            EndContext();
            BeginContext(428, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(472, 38, false);
#line 23 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayFor(model => model.Patron));

#line default
#line hidden
            EndContext();
            BeginContext(510, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(554, 47, false);
#line 26 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AutorPatron));

#line default
#line hidden
            EndContext();
            BeginContext(601, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(645, 57, false);
#line 29 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayFor(model => model.AutorPatron.IdAutorPatron));

#line default
#line hidden
            EndContext();
            BeginContext(702, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(746, 46, false);
#line 32 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GeneroEdad));

#line default
#line hidden
            EndContext();
            BeginContext(792, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(836, 50, false);
#line 35 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayFor(model => model.GeneroEdad.IdGenEd));

#line default
#line hidden
            EndContext();
            BeginContext(886, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(930, 41, false);
#line 38 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Lanas));

#line default
#line hidden
            EndContext();
            BeginContext(971, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1015, 44, false);
#line 41 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayFor(model => model.Lanas.IdLana));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1103, 43, false);
#line 44 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Prendas));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1190, 49, false);
#line 47 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prendas.IdPrendas));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1283, 44, false);
#line 50 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Revistas));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1371, 51, false);
#line 53 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayFor(model => model.Revistas.IdRevistas));

#line default
#line hidden
            EndContext();
            BeginContext(1422, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1466, 56, false);
#line 56 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TiposCaracteristicas));

#line default
#line hidden
            EndContext();
            BeginContext(1522, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1566, 66, false);
#line 59 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayFor(model => model.TiposCaracteristicas.IdTiposCaract));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1676, 48, false);
#line 62 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TiposDeTejer));

#line default
#line hidden
            EndContext();
            BeginContext(1724, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1768, 58, false);
#line 65 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
       Write(Html.DisplayFor(model => model.TiposDeTejer.NombreDeTejer));

#line default
#line hidden
            EndContext();
            BeginContext(1826, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1873, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "109d66ae48604c75af9979d4534df33b", async() => {
                BeginContext(1931, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\alvaro.lopezparrondo\source\repos\KnittingCore2\KnittingCore2\Views\Patrones\Details.cshtml"
                           WriteLiteral(Model.IdNombrePatron);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1939, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1947, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "809eaf7ea2dd4564a5e2579c5456365e", async() => {
                BeginContext(1969, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1985, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KnittingCore2.Models.Patrones> Html { get; private set; }
    }
}
#pragma warning restore 1591
