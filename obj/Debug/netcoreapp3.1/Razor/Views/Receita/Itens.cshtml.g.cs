#pragma checksum "C:\NovoG\Dev\source\CursoCS\mvc-001\mvc001\Views\Receita\Itens.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fadda8e2c5f2c81c58642f0fc117c1d23b396317"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receita_Itens), @"mvc.1.0.view", @"/Views/Receita/Itens.cshtml")]
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
#line 1 "C:\NovoG\Dev\source\CursoCS\mvc-001\mvc001\Views\_ViewImports.cshtml"
using mvc001;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\NovoG\Dev\source\CursoCS\mvc-001\mvc001\Views\_ViewImports.cshtml"
using mvc001.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fadda8e2c5f2c81c58642f0fc117c1d23b396317", @"/Views/Receita/Itens.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0605ff8c6ce1831a2b10b86b06d3c9c3ed1784bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Receita_Itens : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Insumo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "receita", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "itens", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "novareceita", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-receitaId", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\NovoG\Dev\source\CursoCS\mvc-001\mvc001\Views\Receita\Itens.cshtml"
   ViewData["Title"] = "Receita.NET"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"
<h3>Meu Carrinho</h3>

<div class=""panel panel-default"">
    <div class=""panel-heading"">

        <div class=""row"">
            <div class=""col-md-6"">
                Item
            </div>
            <div class=""col-md-2 text-center"">
                Preço Unitário
            </div>
            <div class=""col-md-2 text-center"">
                Quantidade
            </div>
            <div class=""col-md-2"">
                <span class=""pull-right"">
                    Subtotal
                </span>
            </div>
        </div>
    </div>
    <div class=""panel-body"">

");
#nullable restore
#line 29 "C:\NovoG\Dev\source\CursoCS\mvc-001\mvc001\Views\Receita\Itens.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row row-center linha-produto\">\n        <div class=\"col-md-3\">\n            <img class=\"img-produto-carrinho\"");
            BeginWriteAttribute("src", " src=\"", 821, "\"", 868, 3);
            WriteAttributeValue("", 827, "/images/produtos/large_", 827, 23, true);
#nullable restore
#line 34 "C:\NovoG\Dev\source\CursoCS\mvc-001\mvc001\Views\Receita\Itens.cshtml"
WriteAttributeValue("", 850, item.Codigo, 850, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 864, ".jpg", 864, 4, true);
            EndWriteAttribute();
            WriteLiteral(" />\n        </div>\n        <div class=\"col-md-3\">");
#nullable restore
#line 36 "C:\NovoG\Dev\source\CursoCS\mvc-001\mvc001\Views\Receita\Itens.cshtml"
                          Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"col-md-2 text-center\">");
#nullable restore
#line 37 "C:\NovoG\Dev\source\CursoCS\mvc-001\mvc001\Views\Receita\Itens.cshtml"
                                      Write(item.Gramas);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" - gramas</div>
        <div class=""col-md-2 text-center"">
            <div class=""input-group"">
                <span class=""input-group-btn"">
                    <button class=""btn btn-default"">
                        <span class=""glyphicon-minus""></span>
                    </button>
                </span>
                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 1340, "\"", 1380, 4);
#nullable restore
#line 45 "C:\NovoG\Dev\source\CursoCS\mvc-001\mvc001\Views\Receita\Itens.cshtml"
WriteAttributeValue("", 1348, item.ColherSopa, 1348, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1366, "-", 1367, 2, true);
            WriteAttributeValue(" ", 1368, "colher", 1369, 7, true);
            WriteAttributeValue(" ", 1375, "sopa", 1376, 5, true);
            EndWriteAttribute();
            WriteLiteral("\n                       class=\"form-control text-center\" />\n                <span class=\"input-group-btn\">\n                    <button class=\"btn btn-default\">\n                        <span class=\"glyphicon-plus\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fadda8e2c5f2c81c58642f0fc117c1d23b3963178349", async() => {
                WriteLiteral("\n                                Continuar Comprando\n                            ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-codigo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\NovoG\Dev\source\CursoCS\mvc-001\mvc001\Views\Receita\Itens.cshtml"
                                      WriteLiteral(item.Codigo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-codigo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                        </span>
                    </button>
                </span>

            </div>
        </div>
        <div class=""col-md-2"">
             <span class=""pull-right"" subtotal>
                
            </span>
        </div>
    </div>
");
#nullable restore
#line 69 "C:\NovoG\Dev\source\CursoCS\mvc-001\mvc001\Views\Receita\Itens.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"panel-footer\">\n        <div class=\"row\">\n            <div class=\"col-md-10\">\n                <span numero-itens>\n                    Total: ");
#nullable restore
#line 76 "C:\NovoG\Dev\source\CursoCS\mvc-001\mvc001\Views\Receita\Itens.cshtml"
                       Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    itens
                </span>
            </div>
            <div class=""col-md-2"">
                 <span class=""pull-right"" total>
                    
                </span>
            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <div class=""pull-right"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fadda8e2c5f2c81c58642f0fc117c1d23b39631712089", async() => {
                WriteLiteral("\n                Voltar a Receita\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-receitaId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["receitaId"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fadda8e2c5f2c81c58642f0fc117c1d23b39631714110", async() => {
                WriteLiteral("\n                Preencher Cadastro\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Insumo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
