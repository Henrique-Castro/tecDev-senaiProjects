#pragma checksum "C:\Users\46885473820\Documents\gitHub\Ponto_digital\Views\Cliente\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6861b8f62f3ac55b79d479b7bdd6cbd82a980f0e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6861b8f62f3ac55b79d479b7bdd6cbd82a980f0e", @"/Views/Cliente/Login.cshtml")]
    public class Views_Cliente_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\46885473820\Documents\gitHub\Ponto_digital\Views\Cliente\Login.cshtml"
  
    Layout = "_Layout";
    Html.RenderPartial("_HeaderNavBar");

#line default
#line hidden
            BeginContext(74, 674, true);
            WriteLiteral(@"        <section>
            <h2>Login</h2>
            <form id=""formLogin"" action=""login.php"">
                <div>
                    <label for=""email"">Email</label></br>
                    <input name=""email"" type=""email"" maxlength=""100"" minlength=""15"">
                </div>
                <div>
                    <label for=""senha"">Senha</label></br>
                    <input name=""senha"" type=""password"" maxlength=""25"" minlength=""8""></br>
                </div>
            </form>
            <a href=""#"">Esqueceu a senha?</a>
            <p>Caso ainda não seja cadastrado, <a href=""cadastro.html"">cadastre-se aqui</a></p>
        </section>");
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