#pragma checksum "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66d4825b77730e5e09fa63582e67706facdbabbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venta_Venta), @"mvc.1.0.view", @"/Views/Venta/Venta.cshtml")]
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
#line 1 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\_ViewImports.cshtml"
using CRM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\_ViewImports.cshtml"
using CRM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d4825b77730e5e09fa63582e67706facdbabbb", @"/Views/Venta/Venta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03934a8a7d47f2a43fed5950159610447dac5492", @"/Views/_ViewImports.cshtml")]
    public class Views_Venta_Venta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CRM.Domain.Venta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActualizaEnvio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Venta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n\n<div class=\"row mt-5 mb-5\">\n    <h2>Venta Seleccionada</h2>\n    <div class=\"col-12\">\n        <h5>Id de la compra: ");
#nullable restore
#line 11 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml"
                        Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <div>\n            <h5>Fecha: ");
#nullable restore
#line 13 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml"
                  Write(Model.Fecha.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            <h5>Importe: $");
#nullable restore
#line 14 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml"
                     Write(Model.Importe);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
        </div>
    </div>
    <div>
        <h3 class=""mt-3"">Estatus de envío</h3>
    </div>

    <div class=""horizontal-timeline"">

        <ul class=""list-inline items d-flex justify-content-between"">
            <li class=""list-inline-item items-list"">
                <p class=""py-1 px-2 rounded text-white"" style=""background-color: black;"">Ordenado</p>
            </li>
            <li class=""list-inline-item items-list"">
");
#nullable restore
#line 28 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml"
                 if (Model.EstatusEnvio == "Enviado" || Model.EstatusEnvio == "En Camino" || Model.EstatusEnvio == "Entregado")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"py-1 px-2 rounded text-white\" style=\"background-color: black;\">Enviado</p> ");
#nullable restore
#line 30 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml"
                                                                                         }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"py-1 px-2 rounded\">Enviado</p>");
#nullable restore
#line 33 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </li>\n            <li class=\"list-inline-item items-list\">\n");
#nullable restore
#line 36 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml"
                 if (Model.EstatusEnvio == "En Camino" || Model.EstatusEnvio == "Entregado")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"py-1 px-2 rounded text-white\" style=\"background-color: black;\">En Camino</p> ");
#nullable restore
#line 38 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml"
                                                                                           }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"py-1 px-2 rounded\">En Camino</p>");
#nullable restore
#line 41 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </li>\n            <li class=\"list-inline-item items-list text-end\" style=\"margin-right: 8px;\">\n");
#nullable restore
#line 44 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml"
                 if (Model.EstatusEnvio == "Entregado")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"py-1 px-2 rounded text-white\" style=\"background-color: black;\">Entregado</p> ");
#nullable restore
#line 46 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml"
                                                                                           }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"py-1 px-2 rounded\">Entregado</p>");
#nullable restore
#line 49 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </li>\n        </ul>\n    </div>\n");
#nullable restore
#line 53 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml"
     if (Model.EstatusEnvio != "Entregado")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66d4825b77730e5e09fa63582e67706facdbabbb8699", async() => {
                WriteLiteral("\n            <button class=\"btn btn-success font-weight-bold\" style=\"color:white\" type=\"submit\" value=\"ActualizaEnvio\">Siguiente status de envío</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml"
                                                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 58 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Venta\Venta.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <style>
        .horizontal-timeline .items {
            border-top: 2px solid #ddd;
        }

            .horizontal-timeline .items .items-list {
                position: relative;
                margin-right: 0;
            }

                .horizontal-timeline .items .items-list:before {
                    content: """";
                    position: absolute;
                    height: 8px;
                    width: 8px;
                    border-radius: 50%;
                    background-color: #ddd;
                    top: 0;
                    margin-top: -5px;
                }

            .horizontal-timeline .items .items-list {
                padding-top: 15px;
            }
    </style>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CRM.Domain.Venta> Html { get; private set; }
    }
}
#pragma warning restore 1591
