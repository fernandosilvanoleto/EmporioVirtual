#pragma checksum "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da1251f910e687b270f2fa20bf50c2902801c8f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da1251f910e687b270f2fa20bf50c2902801c8f7", @"/Views/Produto/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10f5cc74b529dc306eee10dff722b885756f8533", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmporioVirtual.Models.ProdutoAgregador.Produto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Img_Padrao.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Img_Padrao.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdicionarItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
  
    ViewData["Title"] = "Visualizar";
    //@DateTime.Now.Year

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <section id=""product_detail"">
            <div id=""code_prod_detail"">
                <div class=""card"">
                    <div class=""row no-gutters"">
                        <aside class=""col-sm-5 border-right"">
                            <article class=""gallery-wrap"">
                                <div class=""img-big-wrap"">
                                    <div>
");
#nullable restore
#line 16 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
                                         if (Model.Imagens != null && Model.Imagens.Count > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a");
            BeginWriteAttribute("href", " href=\"", 735, "\"", 777, 1);
#nullable restore
#line 18 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 742, Model.Imagens.ElementAt(0).Caminho, 742, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-fancybox><img");
            BeginWriteAttribute("src", " src=\"", 797, "\"", 838, 1);
#nullable restore
#line 18 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 803, Model.Imagens.ElementAt(0).Caminho, 803, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n");
#nullable restore
#line 19 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da1251f910e687b270f2fa20bf50c2902801c8f77670", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "da1251f910e687b270f2fa20bf50c2902801c8f77886", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-fancybox", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div> <!-- slider-product.// -->\r\n                                <div class=\"img-small-wrap\">\r\n");
#nullable restore
#line 27 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
                                     if (Model.Imagens != null && Model.Imagens.Count > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
                                         foreach (Imagem imagem in Model.Imagens)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"item-gallery\"> <img");
            BeginWriteAttribute("src", " src=\"", 1653, "\"", 1674, 1);
#nullable restore
#line 31 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 1659, imagem.Caminho, 1659, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 32 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div> <!-- slider-nav.// -->
                            </article> <!-- gallery-wrap .end// -->
                        </aside>
                        <aside class=""col-sm-7"">
                            <article class=""p-5"">
                                <h3 class=""title mb-3"">");
#nullable restore
#line 39 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
                                                  Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                                <div class=\"mb-3\">\r\n                                    <var class=\"price h3 text-warning\"><span class=\"num\">");
#nullable restore
#line 42 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
                                                                                    Write(Model.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </var>
                                    <span>/por unidade</span>
                                </div> <!-- price-detail-wrap .// -->
                                <dl>
                                    <dt>Descrição</dt>
                                    <dd>
                                        <p>
                                            ");
#nullable restore
#line 50 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
                                       Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        
                                        </p>
                                    </dd>
                                </dl>
                                <dl class=""row"">
                                    <dt class=""col-sm-3"">Peso(kg)</dt>
                                    <dd class=""col-sm-9"">");
#nullable restore
#line 56 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
                                                    Write(Model.Peso.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n                                    <dt class=\"col-sm-3\">Largura</dt>\r\n                                    <dd class=\"col-sm-9\">");
#nullable restore
#line 59 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
                                                    Write(Model.Largura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n                                    <dt class=\"col-sm-3\">Altura</dt>\r\n                                    <dd class=\"col-sm-9\">");
#nullable restore
#line 62 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
                                                    Write(Model.Altura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n                                    <dt class=\"col-sm-3\">Comprimento</dt>\r\n                                    <dd class=\"col-sm-9\">");
#nullable restore
#line 65 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
                                                    Write(Model.Comprimento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n                                    <dt class=\"col-sm-3\">Quantidade em estoque</dt>\r\n                                    <dd class=\"col-sm-9\">");
#nullable restore
#line 68 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
                                                    Write(Model.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                                </dl>\r\n                                <hr>\r\n                                <hr>                                \r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da1251f910e687b270f2fa20bf50c2902801c8f716177", async() => {
                WriteLiteral(" <i class=\"fas fa-shopping-cart\"></i> Adicionar ao carrinho ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
                                                                                          WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </article> <!-- card-body.// -->
                        </aside> <!-- col.// -->
                    </div> <!-- row.// -->
                </div> <!-- card.// -->
            </div> <!-- code-wrap.// -->
        </section>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmporioVirtual.Models.ProdutoAgregador.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
