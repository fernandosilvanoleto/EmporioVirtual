#pragma checksum "G:\Programação_Udemy\C#\EmporioVirtual\Views\Home\Contato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "719dcc2788fc9c0ca6f839e5bb8748e9158ddda1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contato), @"mvc.1.0.view", @"/Views/Home/Contato.cshtml")]
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
#nullable restore
#line 1 "G:\Programação_Udemy\C#\EmporioVirtual\Views\_ViewImports.cshtml"
using EmporioVirtual;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Programação_Udemy\C#\EmporioVirtual\Views\_ViewImports.cshtml"
using EmporioVirtual.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719dcc2788fc9c0ca6f839e5bb8748e9158ddda1", @"/Views/Home/Contato.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6304c51393f0f2d87b02b183f7a1a7e9cf950111", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Home\Contato.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Contato";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main role=""main"">
    <br />
    <br />
    <div class=""container"">
        <div class=""row"">
            <aside class=""col-md-6"">
                <h4 class=""subtitle-doc"">
                    # Outros contatos
                    <a href=""#"" data-html=""code_desc_simple"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_desc_simple"">
                    <div class=""box"">
                        <dl>
                            <dt>Devolução/Garantia: </dt>
                            <dd>devolucao@lojavirtual.com.br</dd>
                        </dl>
                        <dl>
                            <dt>Televendas: </dt>
                            <dd>(61) 4000-2000</dd>
                        </dl>
                        <dl>
                            <dt>SAC:</dt>
                            <dd>sac@lojavirtual.com.br</dd>
                        </dl>
                    </div> <!-- box.// -->
                </div> <!-- code-wrap.// -->");
            WriteLiteral(@"
            </aside>
            <aside class=""col-sm-6"">

                <h4 class=""subtitle-doc"">
                    # Contato
                    <a href=""#"" data-html=""code_payment"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_payment"">

                    <article class=""card"">
                        <div class=""card-body p-5"">
                            <p class=""alert alert-success"">Mensagem de sucesso!</p>

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "719dcc2788fc9c0ca6f839e5bb8748e9158ddda15365", async() => {
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <label for=""username"">Nome</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-user""></i></span>
                                        </div>
                                        <input type=""text"" class=""form-control"" name=""username""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2137, "\"", 2151, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", "\r\n                                               required=\"", 2152, "\"", 2211, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div> <!-- input-group.// -->
                                </div> <!-- form-group.// -->

                                <div class=""form-group"">
                                    <label for=""cardNumber"">E-mail</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-at""></i></span>
                                        </div>
                                        <input type=""text"" class=""form-control"" name=""cardNumber""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2873, "\"", 2887, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div> <!-- input-group.// -->
                                </div> <!-- form-group.// -->

                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <div class=""form-group"">
                                            <label><span class=""hidden-xs"">Texto</span> </label>
                                            <div class=""form-inline"">
                                                <textarea class=""form-control"" style=""width:100%""></textarea>

                                            </div>
                                        </div>
                                    </div>
                                </div> <!-- row.// -->
                                <button class=""subscribe btn btn-primary btn-block"" type=""button""> Enviar </button>
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
            WriteLiteral("\r\n                        </div> <!-- card-body.// -->\r\n                    </article> <!-- card.// -->\r\n\r\n                </div> <!-- code-wrap.// -->\r\n\r\n            </aside>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");
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
