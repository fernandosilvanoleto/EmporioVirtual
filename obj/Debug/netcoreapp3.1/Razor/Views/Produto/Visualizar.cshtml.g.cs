#pragma checksum "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b219e9175393c6205c71777758d62049ba55b097"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b219e9175393c6205c71777758d62049ba55b097", @"/Views/Produto/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"724e259fa9af6dd93a7124e837d66b24b585dfff", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmporioVirtual.Models.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
  
    ViewData["Title"] = "Visualizar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de Produtos</h1>\r\n\r\n<h3>Produto:</h3>\r\n<b>Código: </b>");
#nullable restore
#line 10 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
          Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n<b>Nome: </b>");
#nullable restore
#line 11 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
        Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n<b>Descrição: </b>");
#nullable restore
#line 12 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
             Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n<b>Valor: </b>");
#nullable restore
#line 13 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
         Write(Model.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n\r\n<br />\r\n\r\n");
#nullable restore
#line 17 "G:\Programação_Udemy\C#\EmporioVirtual\Views\Produto\Visualizar.cshtml"
Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmporioVirtual.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
