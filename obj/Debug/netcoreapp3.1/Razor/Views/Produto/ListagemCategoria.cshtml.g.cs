#pragma checksum "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\ListagemCategoria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d5b7daa041e5251d5ab51dc134aa3436c582a7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_ListagemCategoria), @"mvc.1.0.view", @"/Views/Produto/ListagemCategoria.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d5b7daa041e5251d5ab51dc134aa3436c582a7f", @"/Views/Produto/ListagemCategoria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10f5cc74b529dc306eee10dff722b885756f8533", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_ListagemCategoria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\ListagemCategoria.cshtml"
  
    ViewData["Title"] = "ListagemCategoria";
    var slog = ViewContext.RouteData.Values["slog"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ListagemCategoria - ");
#nullable restore
#line 7 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\ListagemCategoria.cshtml"
                   Write(slog);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<ul>\r\n");
#nullable restore
#line 9 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\ListagemCategoria.cshtml"
     foreach (Categoria categoria in ViewBag.Categorias)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 11 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\ListagemCategoria.cshtml"
       Write(categoria.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 11 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\ListagemCategoria.cshtml"
                       Write(categoria.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 12 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\ListagemCategoria.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
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