#pragma checksum "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7443b84e87efe7c20c1a82b4159e55b4ef504d0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_PrintNomina), @"mvc.1.0.view", @"/Views/Empleado/PrintNomina.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7443b84e87efe7c20c1a82b4159e55b4ef504d0b", @"/Views/Empleado/PrintNomina.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03934a8a7d47f2a43fed5950159610447dac5492", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_PrintNomina : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CRM.DTO.Nomina>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h5 class=\"mt-5\">Nómina de empleado</h5>\n<h5 class=\"mt-5\">Quincena N° ");
#nullable restore
#line 4 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
                        Write(Model.Quincena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<h5 class=\"mt-5\">Fecha Actual: ");
#nullable restore
#line 5 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
                          Write(DateTime.Now.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<h5>Id : ");
#nullable restore
#line 6 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
    Write(Model.empleado.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<h5>Nombre Completo : ");
#nullable restore
#line 7 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
                 Write(Model.empleado.NombreCompleto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<h5>RFC : ");
#nullable restore
#line 8 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
     Write(Model.empleado.RFC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<h5>Fecha de Ingreso : ");
#nullable restore
#line 9 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
                  Write(Model.empleado.FechaIngreso.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<h5>Días de incapacidad : ");
#nullable restore
#line 10 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
                     Write(Model.DiasDeIncapacidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<h3>DEDUCCIONES</h3>\n");
#nullable restore
#line 12 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
 if (Model.empleado.CreditoInfonavit)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h5>Descuento Credito Infonativ : $");
#nullable restore
#line 14 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
                              Write(Model.empleado.DescuentoInfonavit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>");
#nullable restore
#line 14 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
                                                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h5>IMSS : $");
#nullable restore
#line 15 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
       Write(Model.IMSS);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<h5>ISR : $");
#nullable restore
#line 16 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
      Write(Model.ISR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<h5 class=\"mb-5\">Total de deducciones: $");
#nullable restore
#line 17 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
                                   Write(Model.TotalDeducciones);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\n<h3>INGRESOS</h3>\n<h5>Días Trabajados: ");
#nullable restore
#line 20 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
                Write(Model.DiasTrabajados);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<h5>Sueldo Base: $");
#nullable restore
#line 21 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
             Write(Model.empleado.SueldoBase);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<h5>Bono: $");
#nullable restore
#line 22 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
      Write(Model.Bono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<h5>Apoyo patrón dias incapacidad: $");
#nullable restore
#line 23 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
                               Write(Model.ApoyoPatron);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<h5 class=\"mb-5\">Total de Ingresos: $");
#nullable restore
#line 24 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
                                Write(Model.SueldoAPagar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<h3>TOTAL</h3>\n<h5 class=\"mb-5\">Total a pagar: $");
#nullable restore
#line 26 "C:\Users\joelreyes\Documents\GitHub\CRM\CRM\CRM\Views\Empleado\PrintNomina.cshtml"
                            Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CRM.DTO.Nomina> Html { get; private set; }
    }
}
#pragma warning restore 1591