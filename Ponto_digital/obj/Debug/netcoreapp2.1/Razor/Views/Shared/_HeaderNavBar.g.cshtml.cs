#pragma checksum "C:\Users\46885473820\Documents\gitHub\tecDev-senaiProjects\Ponto_digital\Views\Shared\_HeaderNavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93c928f78de2c165063d0049ba36a96d3d81dfcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderNavBar), @"mvc.1.0.view", @"/Views/Shared/_HeaderNavBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_HeaderNavBar.cshtml", typeof(AspNetCore.Views_Shared__HeaderNavBar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93c928f78de2c165063d0049ba36a96d3d81dfcb", @"/Views/Shared/_HeaderNavBar.cshtml")]
    public class Views_Shared__HeaderNavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("menuButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("ToggleMenu()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Iconografia/hambIcon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("invisible1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("\'Hamburguer\' icon, press to slide the menu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 34, true);
            WriteLiteral("<header id=\"inicio\">\r\n            ");
            EndContext();
            BeginContext(34, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2a9c21017f50424bb550dff117d2fa0b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            BeginContext(181, 102, true);
            WriteLiteral("\r\n        <nav id=\"navMenu\">\r\n            <ul id=\"menuList\" class=\"invisible\">\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", "  href=\'", 283, "\'", 319, 1);
#line 5 "C:\Users\46885473820\Documents\gitHub\tecDev-senaiProjects\Ponto_digital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 291, Url.Action("Index", "Home"), 291, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(320, 38, true);
            WriteLiteral(">Home</a></li>\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 358, "\'", 400, 2);
#line 6 "C:\Users\46885473820\Documents\gitHub\tecDev-senaiProjects\Ponto_digital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 365, Url.Action("Index", "Home"), 365, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 393, "#planos", 393, 7, true);
            EndWriteAttribute();
            BeginContext(401, 40, true);
            WriteLiteral(">Planos</a></li>\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 441, "\'", 476, 1);
#line 7 "C:\Users\46885473820\Documents\gitHub\tecDev-senaiProjects\Ponto_digital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 448, Url.Action("Sobre", "Home"), 448, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(477, 43, true);
            WriteLiteral(">Sobre nós</a></li>\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 520, "\'", 561, 1);
#line 8 "C:\Users\46885473820\Documents\gitHub\tecDev-senaiProjects\Ponto_digital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 527, Url.Action("Atendimento", "Home"), 527, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(562, 56, true);
            WriteLiteral(">Atendimento</a></li>\r\n                <li id=\"login\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 618, "\'", 656, 1);
#line 9 "C:\Users\46885473820\Documents\gitHub\tecDev-senaiProjects\Ponto_digital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 625, Url.Action("Index", "Cliente"), 625, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(657, 150, true);
            WriteLiteral(">Login/Cadastro</a></li>\r\n            </ul>\r\n            <div class=\"navBar\"></div>\r\n            <h1>Ponto Digital</h1>\r\n        </nav>\r\n    </header>");
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
