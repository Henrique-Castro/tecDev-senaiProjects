#pragma checksum "C:\Users\46885473820\Documents\gitHub\tecDev-senaiProjects\Ponto_digital\Views\Cliente\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ef38a0f13240784e0fc330cf643d55eaa6a0a8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Login), @"mvc.1.0.view", @"/Views/Cliente/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Login.cshtml", typeof(AspNetCore.Views_Cliente_Login))]
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
#line 1 "C:\Users\46885473820\Documents\gitHub\tecDev-senaiProjects\Ponto_digital\Views\_ViewImports.cshtml"
using Ponto_digital;

#line default
#line hidden
#line 2 "C:\Users\46885473820\Documents\gitHub\tecDev-senaiProjects\Ponto_digital\Views\_ViewImports.cshtml"
using Ponto_digital.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ef38a0f13240784e0fc330cf643d55eaa6a0a8e", @"/Views/Cliente/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d35384fc6eb13a81f1cef53e9d83762e7f084ea5", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Cliente/FazerLogin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\46885473820\Documents\gitHub\tecDev-senaiProjects\Ponto_digital\Views\Cliente\Login.cshtml"
  
    Layout = "_Layout";
    Html.RenderPartial("_HeaderNavBar");

#line default
#line hidden
            BeginContext(74, 29, true);
            WriteLiteral("        \r\n        <section>\r\n");
            EndContext();
#line 7 "C:\Users\46885473820\Documents\gitHub\tecDev-senaiProjects\Ponto_digital\Views\Cliente\Login.cshtml"
              if(!String.IsNullOrEmpty((string)ViewData["Mensagem"])){

#line default
#line hidden
            BeginContext(175, 31, true);
            WriteLiteral("            <p class=\"warning\">");
            EndContext();
            BeginContext(207, 20, false);
#line 8 "C:\Users\46885473820\Documents\gitHub\tecDev-senaiProjects\Ponto_digital\Views\Cliente\Login.cshtml"
                          Write(ViewData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(227, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 9 "C:\Users\46885473820\Documents\gitHub\tecDev-senaiProjects\Ponto_digital\Views\Cliente\Login.cshtml"
            }

#line default
#line hidden
            BeginContext(248, 40, true);
            WriteLiteral("            <h2>Login</h2>\r\n            ");
            EndContext();
            BeginContext(288, 525, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23364806289e4e679ed90f946b771e05", async() => {
                BeginContext(347, 459, true);
                WriteLiteral(@"
                <div>
                    <label for=""email"">Email</label></br>
                    <input name=""email"" type=""email"" maxlength=""100"" minlength=""15"">
                </div>
                <div>
                    <label for=""senha"">Senha</label></br>
                    <input name=""senha"" type=""password"" maxlength=""25"" minlength=""5""></br>
                </div>
                <input value=""Entrar"" type=""submit""/>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            BeginContext(813, 98, true);
            WriteLiteral("\r\n            <a href=\"#\">Esqueceu a senha?</a>\r\n            <p>Caso ainda não seja cadastrado, <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 911, "\'", 952, 1);
#line 23 "C:\Users\46885473820\Documents\gitHub\tecDev-senaiProjects\Ponto_digital\Views\Cliente\Login.cshtml"
WriteAttributeValue("", 918, Url.Action("Cadastro", "Cliente"), 918, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(953, 45, true);
            WriteLiteral(">cadastre-se aqui</a></p>\r\n        </section>");
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
