#pragma checksum "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "725a3df10310e658275ad01b055e9c51060c4538"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagamento_Index), @"mvc.1.0.view", @"/Views/Pagamento/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"725a3df10310e658275ad01b055e9c51060c4538", @"/Views/Pagamento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10f5cc74b529dc306eee10dff722b885756f8533", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagamento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmporioVirtual.Models.ProdutoAgregador.ProdutoItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Img_Padrao.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
  
    ViewData["Title"] = "Index";
    decimal SubTotal = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <br />
    <br />
    <div class=""row"">
        <div class=""col-md-6"">
            <aside>
                <h3 class=""subtitle-doc"">
                    Seus produtos
                </h3>
                <div id=""code_itemside_img2"">
                    <div class=""box items-bordered-wrap"">
");
#nullable restore
#line 18 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
                         foreach (var produtoitem in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <figure class=\"itemside\">\r\n                                <div class=\"aside\">\r\n");
#nullable restore
#line 22 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
                                     if (produtoitem.Imagens.Count > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"aside\"><img");
            BeginWriteAttribute("src", " src=\"", 838, "\"", 880, 1);
#nullable restore
#line 24 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
WriteAttributeValue("", 844, produtoitem.Imagens.First().Caminho, 844, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-sm\"></div>\r\n");
#nullable restore
#line 25 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"aside\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "725a3df10310e658275ad01b055e9c51060c45387033", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 29 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <figcaption class=\"text-wrap align-self-center\">\r\n\r\n");
#nullable restore
#line 33 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
                                      
                                        var ResultadoSubTotalItem = produtoitem.Valor * produtoitem.QuantidadeProdutoCarrinho;
                                        SubTotal = SubTotal + ResultadoSubTotalItem;
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <h6 class=\"title\"><strong>");
#nullable restore
#line 38 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
                                                         Write(produtoitem.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6>\r\n                                    <div class=\"price-wrap\">\r\n                                        <span class=\"price-new\">");
#nullable restore
#line 40 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
                                                           Write(produtoitem.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 40 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
                                                                                              Write(produtoitem.QuantidadeProdutoCarrinho);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = <strong>");
#nullable restore
#line 40 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
                                                                                                                                               Write(ResultadoSubTotalItem.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\r\n                                    </div> <!-- price-wrap.// -->\r\n                                </figcaption>\r\n                            </figure>\r\n");
#nullable restore
#line 44 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div> <!-- box.// -->
                    <div class=""box"">
                        <h3> Resumo </h3>
                        <article class=""card-body border-top"">

                            <dl class=""row"">
                                <dt class=""col-sm-10"">Subtotal: <span class=""float-right text-muted"">2 items</span></dt>
                                <dd class=""col-sm-2 text-right subtotal_sub""><strong>");
#nullable restore
#line 52 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
                                                                                Write(SubTotal.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></dd>\r\n\r\n                                <dt class=\"col-sm-10\">Frete -PAC/SEDEX:</dt>\r\n                                <dd class=\"col-sm-2 text-right frete\">");
#nullable restore
#line 55 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
                                                                 Write(ViewBag.Frete.TipoFrete);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 55 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
                                                                                            Write(ViewBag.Frete.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n                                <dt class=\"col-sm-10\">Total:</dt>\r\n");
#nullable restore
#line 58 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
                                  
                                    decimal valorfrete = (decimal)ViewBag.Frete.Valor;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <dd class=\"col-sm-2 text-right total_frete\"><strong>");
#nullable restore
#line 61 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Pagamento\Index.cshtml"
                                                                                Write( (SubTotal + valorfrete).ToString("C") );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></dd>
                            </dl>

                        </article> <!-- card-body.// -->
                    </div>

                </div> <!-- code-wrap.// -->
            </aside>
        </div>
        <div class=""col-md-6"">
            <aside>
                <p>Forma de Pagamento</p>

                <article class=""card"">
                    <div class=""card-body p-5"">

                        <ul class=""nav bg-light nav-pills rounded nav-fill mb-3"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" data-toggle=""pill"" href=""#nav-tab-card"">
                                    <i class=""fa fa-credit-card""></i> Cartão de Crédito
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" data-toggle=""pill"" href=""#nav-tab-paypal"">
                                    <i class=""fab f");
            WriteLiteral(@"a-paypal""></i>  Boleto
                                </a>
                            </li>
                        </ul>

                        <div class=""tab-content"">
                            <div class=""tab-pane fade show active"" id=""nav-tab-card"">
                                <p class=""alert alert-danger"">Some text success or error</p>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "725a3df10310e658275ad01b055e9c51060c453814654", async() => {
                WriteLiteral("\r\n                                    <div class=\"form-group\">\r\n                                        <label for=\"username\">Nome (no Cartão)</label>\r\n                                        <input type=\"text\" class=\"form-control\" name=\"username\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4875, "\"", 4889, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 4890, "\"", 4901, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div> <!-- form-group.// -->

                                    <div class=""form-group"">
                                        <label for=""cardNumber"">Número do Cartão</label>
                                        <div class=""input-group"">
                                            <input type=""text"" class=""form-control"" name=""cardNumber""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5294, "\"", 5308, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            <div class=""input-group-append"">
                                                <span class=""input-group-text text-muted"">
                                                    <i class=""fab fa-cc-visa""></i>   <i class=""fab fa-cc-amex""></i>
                                                    <i class=""fab fa-cc-mastercard""></i>
                                                </span>
                                            </div>
                                        </div>
                                    </div> <!-- form-group.// -->

                                    <div class=""row"">
                                        <div class=""col-sm-8"">
                                            <div class=""form-group"">
                                                <label><span class=""hidden-xs"">Vencimento</span> </label>
                                                <div class=""input-group"">
                                               ");
                WriteLiteral("     <input type=\"number\" class=\"form-control\" placeholder=\"MM\"");
                BeginWriteAttribute("name", " name=\"", 6396, "\"", 6403, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    <input type=\"number\" class=\"form-control\" placeholder=\"YY\"");
                BeginWriteAttribute("name", " name=\"", 6517, "\"", 6524, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""col-sm-4"">
                                            <div class=""form-group"">
                                                <label data-toggle=""tooltip""");
                BeginWriteAttribute("title", " title=\"", 6894, "\"", 6902, 0);
                EndWriteAttribute();
                WriteLiteral(" data-original-title=\"3 digits code on back side of the card\">Cód. de Segurança <i class=\"fa fa-question-circle\"></i></label>\r\n                                                <input type=\"number\" class=\"form-control\"");
                BeginWriteAttribute("required", " required=\"", 7119, "\"", 7130, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div> <!-- form-group.// -->
                                        </div>
                                    </div> <!-- row.// -->
                                    <button class=""subscribe btn btn-primary btn-block"" type=""button""> Confirmar </button>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div> <!-- tab-pane.// -->
                            <div class=""tab-pane fade"" id=""nav-tab-paypal"">
                                <p>Clique no botão para imprimir o boleto bancário</p>
                                <p>
                                    <button type=""button"" class=""btn btn-primary""> <i class=""fab fa-paypal""></i> Imprimir Boleto </button>
                                </p>
                                <a");
            BeginWriteAttribute("href", " href=\"", 7953, "\"", 7960, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">Prosseguir</a>
                            </div>
                        </div> <!-- tab-content .// -->

                    </div> <!-- card-body.// -->
                </article> <!-- card.// -->


            </aside> <!-- col.// -->
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmporioVirtual.Models.ProdutoAgregador.ProdutoItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
