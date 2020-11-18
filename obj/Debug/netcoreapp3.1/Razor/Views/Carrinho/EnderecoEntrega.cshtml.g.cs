#pragma checksum "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "444c4890190c954652fb828bbda6ee3d2564c6fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_EnderecoEntrega), @"mvc.1.0.view", @"/Views/Carrinho/EnderecoEntrega.cshtml")]
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
#nullable restore
#line 3 "G:\Programação_Udemy\C#\EmporioVirtual\Views\_ViewImports.cshtml"
using EmporioVirtual.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Programação_Udemy\C#\EmporioVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Programação_Udemy\C#\EmporioVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"444c4890190c954652fb828bbda6ee3d2564c6fb", @"/Views/Carrinho/EnderecoEntrega.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10f5cc74b529dc306eee10dff722b885756f8533", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_EnderecoEntrega : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CadastroEnderecoEntrega", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pagamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
  
    ViewData["Title"] = "EnderecoEntrega";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <!-- Listar só os endereços -->
            <table class=""table table-hover"">
                <tbody>
                    <tr>
                        <th scope=""row"">
                            <input type=""radio"" name=""endereco"" value=""0"" id=""0-end"" />
                        </th>
                        <td>
                            <label for=""0-end"">
                                <strong>Nome: </strong> Endereço do Cliente
                                <p>
                                    ");
#nullable restore
#line 20 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                               Write(ViewBag.Cliente.CEP);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 20 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                                                      Write(ViewBag.Cliente.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 20 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                                                                               Write(ViewBag.Cliente.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 20 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                                                                                                        Write(ViewBag.Cliente.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 20 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                                                                                                                                 Write(ViewBag.Cliente.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 20 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                                                                                                                                                            Write(ViewBag.Cliente.Complemento);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 20 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                                                                                                                                                                                          Write(ViewBag.Cliente.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </label>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 25 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                     foreach (EnderecoEntrega endereco in ViewBag.Enderecos)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">\r\n                                <input type=\"radio\" name=\"endereco\"");
            BeginWriteAttribute("value", " value=\"", 1228, "\"", 1248, 1);
#nullable restore
#line 29 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
WriteAttributeValue("", 1236, endereco.Id, 1236, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1249, "\"", 1270, 2);
#nullable restore
#line 29 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
WriteAttributeValue("", 1254, endereco.Id, 1254, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1266, "-end", 1266, 4, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </th>\r\n                            <td>\r\n                                <label");
            BeginWriteAttribute("for", " for=\"", 1383, "\"", 1405, 2);
#nullable restore
#line 32 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
WriteAttributeValue("", 1389, endereco.Id, 1389, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1401, "-end", 1401, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <strong>Nome: </strong> ");
#nullable restore
#line 33 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                                                       Write(endereco.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 35 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                                   Write(endereco.CEP);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 35 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                                                   Write(endereco.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 35 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                                                                     Write(endereco.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 35 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                                                                                       Write(endereco.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 35 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                                                                                                         Write(endereco.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 35 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                                                                                                                             Write(endereco.Complemento);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 35 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                                                                                                                                                    Write(endereco.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </label>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 40 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n            <div class=\"text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "444c4890190c954652fb828bbda6ee3d2564c6fb13972", async() => {
                WriteLiteral("Cadastrar Novo Endereço");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\EnderecoEntrega.cshtml"
                                                                                                          WriteLiteral(Url.Action("EnderecoEntrega", "Carrinho", new { area = "" } ));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>

            <br />

            <div class=""card-group"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">PAC</h5>
                        <p class=""card-text"">Dias </p>
                    </div>
                    <div class=""card-footer"">
                        <small class=""text-muted"">
                            <input type=""radio"" name=""frete"" value=""PAC"" />
                        </small>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">SEDEX</h5>
                        <p class=""card-text"">Dias</p>
                    </div>
                    <div class=""card-footer"">
                        <small class=""text-muted"">
                            <input type=""radio"" name=""frete"" value=""SEDEX"" />
                        </small>
                    <");
            WriteLiteral(@"/div>
                </div>
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">SEDEX10</h5>
                        <p class=""card-text"">Dias</p>
                    </div>
                    <div class=""card-footer"">
                        <small class=""text-muted"">
                            <input type=""radio"" name=""frete"" value=""SEDEX10"" />
                        </small>
                    </div>
                </div>
            </div>


        </div>

        <br />
        <br />
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "444c4890190c954652fb828bbda6ee3d2564c6fb18487", async() => {
                WriteLiteral("Continuar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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