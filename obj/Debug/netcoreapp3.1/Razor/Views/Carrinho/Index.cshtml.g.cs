#pragma checksum "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19ac5d48f9e8a076790cabffba53eefe980dc4ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_Index), @"mvc.1.0.view", @"/Views/Carrinho/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19ac5d48f9e8a076790cabffba53eefe980dc4ba", @"/Views/Carrinho/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10f5cc74b529dc306eee10dff722b885756f8533", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmporioVirtual.Models.ProdutoAgregador.ProdutoItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoverItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\Index.cshtml"
  
    ViewData["Title"] = "Index";
    decimal SubTotal = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <section class=""section-info"" id=""shopping_cart"">
        <div class=""container"">
            <br />
            <br />
            <h1 class=""doc-title"">Carrinho de compras</h1>

            <div class=""alert alert-danger"" style=""display: none"" role=""alert"">

            </div>

            <!-- ============================ COMPONENT CART ================================= -->
            <output id=""code_shopp"">

                <div class=""row"">
                    <aside class=""col-lg-9"">
                        <div class=""card"">

                            <div class=""table-responsive"">

                                <table class=""table table-borderless table-shopping-cart"">
                                    <thead class=""text-muted"">
                                        <tr class=""small text-uppercase"">
                                            <th scope=""col"">Produto</th>
                                            <th scope=""col"" width=""2");
            WriteLiteral(@"50"">Quantidade</th>
                                            <th scope=""col"" width=""50"">Preço</th>
                                            <th scope=""col"" class=""text-right d-none d-md-block"" width=""200""> Ações </th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 38 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\Index.cshtml"
                                         foreach (var Item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <tr>
                                                <td>
                                                    <figure class=""itemside align-items-center"">
                                                        <div class=""aside""><img src=""bootstrap-ecommerce-html/images/items/1.jpg"" class=""img-sm""></div>
                                                        <figcaption class=""info"">
                                                            <a href=""#"" class=""title text-dark"">");
#nullable restore
#line 45 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\Index.cshtml"
                                                                                           Write(Item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                        </figcaption>
                                                    </figure>
                                                </td>
                                                <td>
                                                    <div class=""col-auto"">
                                                        <label class=""sr-only"" for=""inlineFormInputGroup"">Username</label>
                                                        <input type=""hidden"" class=""input_produto_id""");
            BeginWriteAttribute("value", " value=\"", 2731, "\"", 2747, 1);
#nullable restore
#line 52 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\Index.cshtml"
WriteAttributeValue("", 2739, Item.Id, 2739, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                        <input type=\"hidden\" class=\"input_quantidade_produto_estoque\"");
            BeginWriteAttribute("value", " value=\"", 2870, "\"", 2894, 1);
#nullable restore
#line 53 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\Index.cshtml"
WriteAttributeValue("", 2878, Item.Quantidade, 2878, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                        <input type=\"hidden\" class=\"input_valor_unitario\"");
            BeginWriteAttribute("value", " value=\"", 3005, "\"", 3024, 1);
#nullable restore
#line 54 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\Index.cshtml"
WriteAttributeValue("", 3013, Item.Valor, 3013, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                        <div class=""input-group mb-5"">
                                                            <div class=""input-group-append"">
                                                                <a href=""#"" class=""btn btn-primary diminuir""> - </a>
                                                            </div>
                                                            <input type=""text"" readonly=""readonly"" style=""width: 10px; text-align:center"" class=""form-control inputQuantidadeProdutoCarrinho""");
            BeginWriteAttribute("value", " value=\"", 3587, "\"", 3626, 1);
#nullable restore
#line 59 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\Index.cshtml"
WriteAttributeValue("", 3595, Item.QuantidadeProdutoCarrinho, 3595, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <div class=""input-group-append"">
                                                                <a href=""#"" class=""btn btn-primary aumentar"" id=""Save""> + </a>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </td>
");
#nullable restore
#line 66 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\Index.cshtml"
                                                  
                                                    var ResultadoSubTotalItem = Item.Valor * Item.QuantidadeProdutoCarrinho;
                                                    SubTotal = SubTotal + ResultadoSubTotalItem;

                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>\r\n                                                    <div class=\"price-wrap\">\r\n                                                        <var class=\"price\">");
#nullable restore
#line 73 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\Index.cshtml"
                                                                       Write((ResultadoSubTotalItem).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</var>\r\n                                                        <small class=\"text-muted\"> ");
#nullable restore
#line 74 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\Index.cshtml"
                                                                              Write(Item.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" cada</small>
                                                    </div> <!-- price-wrap .// -->
                                                </td>
                                                <td class=""text-right d-none d-md-block"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19ac5d48f9e8a076790cabffba53eefe980dc4ba12704", async() => {
                WriteLiteral(" Remove");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\Index.cshtml"
                                                                                                            WriteLiteral(Item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 81 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </table>

                            </div> <!-- table-responsive.// -->

                            <div class=""card-body border-top"">
                                <p class=""icontext""><i class=""icon text-success fa fa-truck""></i> Free Delivery within 1-2 weeks</p>
                            </div> <!-- card-body.// -->

                        </div> <!-- card.// -->

                    </aside> <!-- col.// -->
                    <aside class=""col-lg-3"">

                        <div class=""card mb-3"">
                            <div class=""card-body"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19ac5d48f9e8a076790cabffba53eefe980dc4ba16195", async() => {
                WriteLiteral(@"
                                    <div class=""form-group"">
                                        <label>Have coupon?</label>
                                        <div class=""input-group"">
                                            <input type=""text"" class=""form-control""");
                BeginWriteAttribute("name", " name=\"", 6289, "\"", 6296, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Coupon code"">
                                            <span class=""input-group-append"">
                                                <button class=""btn btn-primary"">Apply</button>
                                            </span>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div> <!-- card-body.// -->
                        </div> <!-- card.// -->

                        <div class=""card"">
                            <div class=""card-body"">
                                <dl class=""dlist-align"">
                                    <dt>Total price:</dt>
                                    <dd class=""text-right"">$69.97</dd>
                                </dl>
                                <dl class=""dlist-align"">
                                    <dt>Discount:</dt>
                                    <dd class=""text-right text-danger"">- $10.00</dd>
                                </dl>
                                <dl class=""dlist-align"">
                                    <dt>Total:</dt>
                                    <dd class=""text-right text-dark b""><strong>$59.97</strong></dd>
                                </dl>
                                <hr>
                                <p class=""text-center mb-3"">");
            WriteLiteral(@"
                                    <img src=""bootstrap-ecommerce-html/images/misc/payments.png"" height=""26"">
                                </p>
                                <a href=""#"" class=""btn btn-primary btn-block""> Make Purchase </a>
                                <a href=""#"" class=""btn btn-light btn-block"">Continue Shopping</a>
                            </div> <!-- card-body.// -->
                        </div> <!-- card.// -->

                    </aside> <!-- col.// -->
                </div> <!-- row.// -->
            </output>
            <a href=""#"" class=""showcode"" data-html=""code_shopp"">show code</a>
            <!-- ============================ COMPONENT CART END .// ================================= -->

            <hr class=""divider"">

            <div class=""row"">
                <aside class=""col-md-9"">
                    <!-- ============================ COMPONENT 3  ================================= -->
                    <output id=""code_cart_review"">
 ");
            WriteLiteral(@"                       <div class=""card"">
                            <article class=""card-body"">
                                <header class=""mb-4"">
                                    <h4 class=""card-title"">Review cart</h4>
                                </header>
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <figure class=""itemside  mb-3"">
                                            <div class=""aside""><img src=""bootstrap-ecommerce-html/images/items/1.jpg"" class=""border img-xs""></div>
                                            <figcaption class=""info"">
                                                <p>Name of the product goes here or title </p>
                                                <span>2x $290 = Total: $430 </span>
                                            </figcaption>
                                        </figure>
                                    </div> <!-- col.// ");
            WriteLiteral(@"-->
                                    <div class=""col-md-6"">
                                        <figure class=""itemside  mb-3"">
                                            <div class=""aside""><img src=""bootstrap-ecommerce-html/images/items/2.jpg"" class=""border img-xs""></div>
                                            <figcaption class=""info"">
                                                <p>Name of the product goes here or title </p>
                                                <span>2x $290 = Total: $430 </span>
                                            </figcaption>
                                        </figure>
                                    </div> <!-- col.// -->
                                    <div class=""col-md-6"">
                                        <figure class=""itemside mb-3"">
                                            <div class=""aside""><img src=""bootstrap-ecommerce-html/images/items/3.jpg"" class=""border img-xs""></div>
                                    ");
            WriteLiteral(@"        <figcaption class=""info"">
                                                <p>Name of the product goes here or title </p>
                                                <span>1x $290 = Total: $290 </span>
                                            </figcaption>
                                        </figure>
                                    </div> <!-- col.// -->
                                    <div class=""col-md-6"">
                                        <figure class=""itemside  mb-3"">
                                            <div class=""aside""><img src=""bootstrap-ecommerce-html/images/items/4.jpg"" class=""border img-xs""></div>
                                            <figcaption class=""info"">
                                                <p>Name of the product goes here or title </p>
                                                <span>4x $290 = Total: $430 </span>
                                            </figcaption>
                                        </figu");
            WriteLiteral(@"re>
                                    </div> <!-- col.// -->
                                </div> <!-- row.// -->
                            </article> <!-- card-body.// -->
                            <article class=""card-body border-top"">

                                <dl class=""row"">
                                    <dt class=""col-sm-10"">Subtotal: <span class=""float-right text-muted"">2 items</span></dt>
                                    <dd class=""col-sm-2 text-right subtotal_sub""><strong>");
#nullable restore
#line 195 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Carrinho\Index.cshtml"
                                                                                    Write(SubTotal.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></dd>

                                    <dt class=""col-sm-10"">Discount: <span class=""float-right text-muted"">10% offer</span></dt>
                                    <dd class=""col-sm-2 text-danger text-right""><strong>$29</strong></dd>

                                    <dt class=""col-sm-10"">Delivery charge: <span class=""float-right text-muted"">Express delivery</span></dt>
                                    <dd class=""col-sm-2 text-right""><strong>$120</strong></dd>

                                    <dt class=""col-sm-10"">Tax: <span class=""float-right text-muted"">5%</span></dt>
                                    <dd class=""col-sm-2 text-right text-success""><strong>$7</strong></dd>

                                    <dt class=""col-sm-10"">Total:</dt>
                                    <dd class=""col-sm-2 text-right""><strong class=""h5 text-dark"">$1,650</strong></dd>
                                </dl>

                            </article> <!-- card-body.// -->
           ");
            WriteLiteral(@"             </div>
                    </output>
                    <a href=""#"" class=""showcode"" data-html=""code_cart_review"">show code</a>
                    <!-- ============================ COMPONENT 3  ================================= -->

                </aside> <!-- col.// -->
                <aside class=""col-md-3"">

                    <!-- ============================ COMPONENT 4  ================================= -->
                    <output id=""code_cart_dropdown"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <p>Dropdown sample</p>
                                <div class=""dropdown"">
                                    <a href=""#"" class=""btn btn-primary btn-block dropdown-toggle"" data-toggle=""dropdown"">
                                        Show cart
                                    </a>
                                    <div class=""dropdown-menu p-3 dropdown-menu-right"" style=""min-wi");
            WriteLiteral(@"dth:280px;"">
                                        <figure class=""itemside mb-3"">
                                            <div class=""aside""><img src=""bootstrap-ecommerce-html/images/items/1.jpg"" class=""img-sm border""></div>
                                            <figcaption class=""info align-self-center"">
                                                <p class=""title"">Name of item nice iteme</p>
                                                <a href=""#"" class=""float-right""><i class=""fa fa-trash""></i></a>
                                                <div class=""price"">$250</div> <!-- price-wrap.// -->
                                            </figcaption>
                                        </figure>
                                        <figure class=""itemside mb-3"">
                                            <div class=""aside""><img src=""bootstrap-ecommerce-html/images/items/2.jpg"" class=""img-sm border""></div>
                                            <figcaption class=");
            WriteLiteral(@"""info align-self-center"">
                                                <p class=""title"">Some other item name is here</p>
                                                <a href=""#"" class=""float-right""><i class=""fa fa-trash""></i></a>
                                                <div class=""price"">$250</div> <!-- price-wrap.// -->
                                            </figcaption>
                                        </figure>
                                        <figure class=""itemside mb-3"">
                                            <div class=""aside""><img src=""bootstrap-ecommerce-html/images/items/3.jpg"" class=""img-sm border""></div>
                                            <figcaption class=""info align-self-center"">
                                                <p class=""title"">Another name of item  item</p>
                                                <a href=""#"" class=""float-right""><i class=""fa fa-trash""></i></a>
                                                <div c");
            WriteLiteral(@"lass=""price"">$250</div> <!-- price-wrap.// -->
                                            </figcaption>
                                        </figure>
                                        <div class=""price-wrap text-center py-3 border-top"">Subtotal: <strong class=""h5 price"">$1200</strong></div>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 16791, "\"", 16798, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary btn-block""> Checkout </a>
                                    </div> <!-- drowpdown-menu.// -->
                                </div>  <!-- dropdown.// -->

                            </div> <!-- card-body.// -->
                        </div> <!-- card.// -->
                        <!-- ============================ COMPONENT 4 END .// ================================= -->
                    </output>
                    <a href=""#"" class=""showcode"" data-html=""code_cart_dropdown"">show code</a>



                </aside>
            </div> <!-- container.// -->
        </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmporioVirtual.Models.ProdutoAgregador.ProdutoItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
