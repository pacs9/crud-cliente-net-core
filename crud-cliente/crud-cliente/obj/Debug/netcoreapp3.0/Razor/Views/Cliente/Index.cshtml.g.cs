#pragma checksum "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1c66d6a3418c8b8b88e1b8e3fb25c5e6a9fb470"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
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
#line 1 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\_ViewImports.cshtml"
using crud_cliente;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\_ViewImports.cshtml"
using crud_cliente.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1c66d6a3418c8b8b88e1b8e3fb25c5e6a9fb470", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"074d211a1c5a4fe1bba7219ee38efe1addaa1dd7", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<view_model.ClienteViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/datatables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/datatables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Clientes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Clientes</h1>\r\n\r\n<div class=\"row float-right\">\r\n    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1c66d6a3418c8b8b88e1b8e3fb25c5e6a9fb4706358", async() => {
                WriteLiteral("\r\n            <span class=\"fas fa-plus\"></span> Adicionar Cliente\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n</div>\r\n<div class=\"row float-right\">\r\n    <table class=\"table\" id=\"datatable\">\r\n        <thead style=\"font-size: small\">\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Dt. Nasc.\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Endereço\r\n                </th>\r\n                <th>\r\n                    Nº\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 39 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Complemento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 42 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 45 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 48 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody style=\"font-size: small\">\r\n");
#nullable restore
#line 54 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td style=\"width: 15%;\">\r\n                        ");
#nullable restore
#line 58 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"width: 10%;\">\r\n                        ");
#nullable restore
#line 61 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DataNascimentoFormatada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"width: 10%;\">\r\n                        ");
#nullable restore
#line 64 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"width: 10%;\">\r\n                        ");
#nullable restore
#line 67 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"width: 10%;\">\r\n                        ");
#nullable restore
#line 70 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"width: 5%;\">\r\n                        ");
#nullable restore
#line 73 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"width: 10%;\">\r\n                        ");
#nullable restore
#line 76 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Complemento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"width: 10%;\">\r\n                        ");
#nullable restore
#line 79 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"width: 5%;\">\r\n                        ");
#nullable restore
#line 82 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"width: 5%;\">\r\n                        ");
#nullable restore
#line 85 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"width: 10%;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1c66d6a3418c8b8b88e1b8e3fb25c5e6a9fb47014803", async() => {
                WriteLiteral(@"
                            <span class=""fa-stack"">
                                <i class=""fa fa-square fa-stack-2x""></i>
                                <i class=""fa fa-pencil-alt fa-stack-1x fa-inverse""></i>
                            </span>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3512, "\"", 3613, 5);
            WriteAttributeValue("", 3522, "confirmaDelecao(\'", 3522, 17, true);
#nullable restore
#line 94 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 3539, Url.Action("Delete", "Cliente"), 3539, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3571, "/", 3571, 1, true);
#nullable restore
#line 94 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 3572, Html.DisplayFor(modelItem => item.Id), 3572, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3610, "\');", 3610, 3, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""table-link danger"" title=""Excluir"">
                            <span class=""fa-stack"">
                                <i class=""fa fa-square fa-stack-2x""></i>
                                <i class=""fa fa-trash fa-stack-1x fa-inverse""></i>
                            </span>
                        </a>
                    </td>
                </tr>
");
#nullable restore
#line 102 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
#nullable restore
#line 106 "C:\Users\1540968\Documents\Crud Cliente\crud-cliente\crud-cliente\Views\Cliente\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f1c66d6a3418c8b8b88e1b8e3fb25c5e6a9fb47019330", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1c66d6a3418c8b8b88e1b8e3fb25c5e6a9fb47020509", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            $('#datatable').dataTable({
                ""language"":
                {
                    ""sEmptyTable"": ""Nenhum registro encontrado"",
                    ""sInfo"": ""Mostrando de _START_ até _END_ de _TOTAL_ registros"",
                    ""sInfoEmpty"": ""Mostrando 0 até 0 de 0 registros"",
                    ""sInfoFiltered"": ""(Filtrados de _MAX_ registros)"",
                    ""sInfoPostFix"": """",
                    ""sInfoThousands"": ""."",
                    ""sLengthMenu"": ""_MENU_ resultados por página"",
                    ""sLoadingRecords"": ""Carregando..."",
                    ""sProcessing"": ""Processando..."",
                    ""sZeroRecords"": ""Nenhum registro encontrado"",
                    ""sSearch"": ""Pesquisar"",
                    ""oPaginate"": {
                        ""sNext"": ""Próximo"",
                        ""sPrevious"": ""Anterior"",
                        ""sFirst"": ""Primeiro"",
                        ""sLa");
                WriteLiteral(@"st"": ""Último""
                    },
                    ""oAria"": {
                        ""sSortAscending"": "": Ordenar colunas de forma ascendente"",
                        ""sSortDescending"": "": Ordenar colunas de forma descendente""
                    },
                    ""select"": {
                        ""rows"": {
                            ""_"": ""Selecionado %d linhas"",
                            ""0"": ""Nenhuma linha selecionada"",
                            ""1"": ""Selecionado 1 linha""
                        }
                    }
                }
            });

            $('#datatable').DataTable();
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<view_model.ClienteViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
