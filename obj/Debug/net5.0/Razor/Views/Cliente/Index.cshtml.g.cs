#pragma checksum "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d57383710d173333ab5ae01c24ce70e0bb1716ef"
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
#line 1 "C:\dev\standBY_prototype\Views\_ViewImports.cshtml"
using standBY_prototype;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\standBY_prototype\Views\_ViewImports.cshtml"
using standBY_prototype.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d57383710d173333ab5ae01c24ce70e0bb1716ef", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8952f49fa33cc58e81b09cbaff0d9df8b6f83f1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<standBY_prototype.Models.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("buscar-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-mask/dist/jquery.mask.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
  
  ViewData["Title"] = "Client";

  string[] tableTitles = { "Razão Social", "CNPJ", "Data de Fundação", "Capital", "Status", "Ação" };

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n</style>\r\n\r\n<section class=\"container\">\r\n  <section class=\"cliente__header-section\">\r\n    <h4>Cliente</h4>\r\n    <button class=\"btn bg-navbar btn-xs text-white\" type=\"button\"");
            BeginWriteAttribute("onclick", "\r\n      onclick=\"", 451, "\"", 514, 3);
            WriteAttributeValue("", 468, "location.href=\'", 468, 15, true);
#nullable restore
#line 17 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 483, Url.Action("CadastrarEditar"), 483, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 513, "\'", 513, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Cadastrar</button>\r\n  </section>\r\n\r\n  <section class=\"cliente__form-section\">\r\n    <div class=\"col-md-12\">\r\n      <h6>Empresa</h6>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d57383710d173333ab5ae01c24ce70e0bb1716ef5938", async() => {
                WriteLiteral(@"
      <div class=""form-group col-lg-4"">
        <label class=""col-lg-4 col-12"" for=""razaoSocial"">Razão Social&nbsp;</label>
        <input class=""form-control col-lg-8 col-12"" id=""razaoSocial"" name=""razaoSocial"" type=""text""
          placeholder=""Razão Social S/A"" />
      </div>

      <div class=""form-group col-lg-4"">
        <label class=""col-lg-2 col-12"" for=""cnpj"">CNPJ&nbsp;</label>
        <input class=""form-control col-lg-10 col-12"" id=""cnpj"" name=""cnpj"" type=""text"" placeholder=""00.000.000/0000-00"">
      </div>

      <div class=""checkbox col-lg-2 col-12"">
        <label for=""status"">
          <input id=""status"" name=""status"" type=""checkbox"" />&nbsp;Ativo
        </label>
      </div>

      <button id=""botao-buscar"" class=""btn btn-default col-lg-2 col-md-12"" type=""submit"">Buscar</button>

      <div id=""loading"" class=""col-lg-2 removed"">
        <div class=""spinner-border"">
          <span class=""sr-only"">Loading...</span>
        </div>
      </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  </section>\r\n  <section class=\"cliente__table-section\">\r\n    <h6>Clientes</h6>\r\n    <div class=\"table-responsive\">\r\n      <table class=\"table table-bordered table-hover\">\r\n        <thead>\r\n          <tr>\r\n");
#nullable restore
#line 57 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
              
              foreach (var title in tableTitles)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>");
#nullable restore
#line 60 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
               Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 61 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
              }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("          </tr>\r\n        </thead>\r\n        <tbody id=\"table-body\">\r\n");
#nullable restore
#line 66 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
           foreach (var item in Model)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n              <td>\r\n                ");
#nullable restore
#line 70 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
           Write(item.razao_social);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              </td>\r\n              <td>\r\n                ");
#nullable restore
#line 73 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
           Write(Regex.Replace(item.cnpj, @"^(\d{2})(\d{3})(\d{3})(\d{4})(\d{2}).*", "$1.$2.$3/$4-$5"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              </td>\r\n              <td class=\"cliente__table_data_fundacao\">\r\n                ");
#nullable restore
#line 76 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
           Write(item.data_fundacao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              </td>\r\n              <td>\r\n                <div class=\"cliente__table_capital\">\r\n                  <span>R$</span><span>");
#nullable restore
#line 80 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
                                  Write(item.capital.ToString("N2", CultureInfo.GetCultureInfo("pt-BR")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n              </td>\r\n");
#nullable restore
#line 83 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
               if (item.status_cliente)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"cliente__table_status\">\r\n                  Ativo\r\n                </td>\r\n");
#nullable restore
#line 88 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
              }
              else
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"cliente__table_status\">\r\n                  Inativo\r\n                </td>\r\n");
#nullable restore
#line 94 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("              <td class=\"cliente__table_acao\">\r\n                <div class=\"row button-group\">\r\n                  <div class=\"col-md-6\">\r\n                    <button class=\"btn btn-xs\" type=\"button\"");
            BeginWriteAttribute("onclick", "\r\n                    onclick=\"", 3335, "\"", 3432, 3);
            WriteAttributeValue("", 3366, "location.href=\'", 3366, 15, true);
#nullable restore
#line 99 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 3381, Url.Action("CadastrarEditar", new {id = item.Id}), 3381, 50, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3431, "\'", 3431, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                      <span class=\"fa fa-edit\"></span>\r\n                    </button>\r\n                  </div>\r\n                  <div class=\"col-md-6\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3588, "\"", 3622, 3);
            WriteAttributeValue("", 3598, "getClienteById(", 3598, 15, true);
#nullable restore
#line 103 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 3613, item.Id, 3613, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3621, ")", 3621, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    <button class=""btn btn-xs"" type=""button"" data-toggle=""modal"" data-target=""#modal"">
                      <span class=""fa fa-trash""></span>
                    </button>
                  </div>
                </div>
              </td>
            </tr>
");
#nullable restore
#line 111 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n      </table>\r\n    </div>\r\n");
#nullable restore
#line 115 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <p id=\"no-results\" class=\"removed\">\r\n        Sem resultados...\r\n      </p>\r\n");
#nullable restore
#line 120 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <p id=\"no-results\">\r\n        Sem resultados...\r\n      </p>\r\n");
#nullable restore
#line 126 "C:\dev\standBY_prototype\Views\Cliente\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </section>
</section>

<div class=""modal fade"" id=""modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h4 class=""modal-title"" id=""myModalLabel"">Excluir registro</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar""><span
            aria-hidden=""true"">&times;</span></button>
      </div>
      <div class=""modal-body"">
        <h6>Tem certeza que deseja excluir este registro?</h6>
        <div id=""modal-body-content""></div>
      </div>
      <div id=""modal-footer"" class=""modal-footer"">
      </div>
    </div>
  </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d57383710d173333ab5ae01c24ce70e0bb1716ef15341", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

<script>
  function deleteCliente(id) {
    $.ajax({
      url: `/Cliente/Delete/${id}`,
      type: 'POST',
      contentType: 'application/json',
      success: function () {
        location.reload()
      },
      error: function () {
        alert('Erro ao excluir registro.')
      }
    })
  }

  function getClienteById(id) {
    const modalBodyContent = $('#modal-body-content');
    const modalFooter = $('#modal-footer')
    modalBodyContent.empty()
    modalFooter.empty()

    $.ajax({
      url: `/Cliente/GetClienteById/${id}`,
      type: 'GET',
      contentType: 'application/json',
      success: function (cliente) {
        modalBodyContent.html(`
            <p>Razão social: ${cliente.razao_social}</p>
            <p>Cnpj: ${cliente.cnpj.replace(/^(\d{2})(\d{3})(\d{3})(\d{4})(\d{2}).*/, '$1.$2.$3/$4-$5')}</p>
            <p>Data de fundação: ${moment(cliente.data_fundacao).format('DD/MM/YYYY')}</p>
            <p>Capital: ${cliente.capital.toFixed(2).toString().");
                WriteLiteral(@"replace('.', ',').replace(/(\d)(?=(\d\d\d)+(?!\d))/g, ""$1."")}</p>
            <p>Status: ${cliente.status_cliente ? 'Ativo' : 'Inativo'}</p>
          `)
        modalFooter.html(`          
            <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Fechar</button>
            <button id=""button-delete-confirm"" type=""button"" class=""btn btn-danger"" data-dismiss=""modal"" onclick=""deleteCliente(${cliente.id})"">Excluir</button>
          `)
      },
      error: function (data) {
        modalBodyContent.html(`
            <p>Não foi possível recuperar os dados desse registro.</p>
          `)
      }
    })
  }

  function renderTable(clientes) {
    const noResults = $('#no-results')

    if (clientes.length > 0) {
      noResults.addClass('removed')
    }
    else {
      noResults.removeClass('removed')
    }

    let row = ''
    $.each(clientes, function (index, cliente) {
      row += `
            <tr>
              <td>
                ${cliente.razao_soc");
                WriteLiteral(@"ial}
              </td>
              <td>
                ${cliente.cnpj.replace(/^(\d{2})(\d{3})(\d{3})(\d{4})(\d{2}).*/, '$1.$2.$3/$4-$5')}
              </td>
              <td class=""cliente__table_data_fundacao"">
                ${moment(cliente.data_fundacao).format('DD/MM/YYYY')}
              </td>
              <td>
                <div class=""cliente__table_capital"">
                  <span>R$</span><span>${cliente.capital.toFixed(2).toString().replace('.', ',').replace(/(\d)(?=(\d\d\d)+(?!\d))/g, ""$1."")}</span>
                </div>
              </td>
              <td class=""cliente__table_status"">
                ${cliente.status_cliente ? 'Ativo' : 'Inativo'}
              </td>
              <td class=""cliente__table_acao"">
                <div class=""button-group"">
                  <div class=""col-md-6"">
                    <button class=""btn btn-xs"" type=""button"" onclick=""location.href='CadastrarEditar/${cliente.id}'"">
                      <span class=""fa fa-edit""></");
                WriteLiteral(@"span>
                    </button>
                  </div>

                  <div class=""col-md-6"" onclick=""getClienteById(${cliente.id})"">
                    <button class=""btn btn-xs"" type=""button"" data-toggle=""modal"" data-target=""#modal"">
                      <span class=""fa fa-trash""></span>
                    </button>
                </div>
                </div>
              </td>
            </tr>
            `
    })
    $('#table-body').append(row)
  }

  function getClientes() {
    const tableBody = $('#table-body')
    const noResults = $('#no-results')
    tableBody.empty()

    $.ajax({
      url: '/Cliente/GetCliente',
      type: 'GET',
      contentType: 'application/json',
      success: function (clientes) {
        renderTable(clientes)
      },
      error: function (error) {
        noResults.removeClass('removed')
        alert(error)
      }
    })
  }

  function handleSubmit() {
    const tableBody = $('#table-body')
    tableBody.empty()");
                WriteLiteral(@"

    const botaoBuscar = $('#botao-buscar')
    const loading = $('#loading')
    const noResults = $('#no-results')

    const razaoSocial = $('#razaoSocial').val()
    const cnpj = $('#cnpj').val()
    const status = $('#status').is("":checked"")

    botaoBuscar.addClass('removed')
    loading.removeClass('removed')

    $.ajax({
      url: razaoSocial && cnpj
        ? `/Cliente/GetCliente?razaoSocial=${razaoSocial}&cnpj=${cnpj.replaceAll(/\W/g, """")}&status=${status}`
        : razaoSocial
          ? `/Cliente/GetCliente?razaoSocial=${razaoSocial}&status=${status}`
          : `/Cliente/GetCliente?&status=${status}`,
      type: 'GET',
      contentType: 'application/json',
      success: function (clientes) {
        renderTable(clientes)
        botaoBuscar.removeClass('removed')
        loading.addClass('removed')
      },
      error: function (error) {
        botaoBuscar.removeClass('removed')
        loading.addClass('removed')
        noResults.removeClass('removed')
");
                WriteLiteral(@"        alert(error)
      }
    })
  }

  $('document').ready(function () {
    const tableBody = $('#table-body')
    $('#cnpj').mask('00.000.000/0000-00')

    $('#buscar-form').on('submit', function (event) {
      event.preventDefault()

      handleSubmit()
    })
  })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<standBY_prototype.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
