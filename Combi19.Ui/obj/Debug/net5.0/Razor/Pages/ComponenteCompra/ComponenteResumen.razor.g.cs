#pragma checksum "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponenteCompra\ComponenteResumen.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d388fb2587e2258245c47774fc5b965a44803778"
// <auto-generated/>
#pragma warning disable 1591
namespace Combi19.Ui.Pages.ComponenteCompra
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Combi19.Ui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Combi19.Ui.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Combi19.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Combi19.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Combi19.Ui.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Combi19.Ui.Servicios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Combi19.Data.Repositorios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Combi19.Ui.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Combi19.Ui.Areas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\_Imports.razor"
using Combi19.Ui.Helpers;

#line default
#line hidden
#nullable disable
    public partial class ComponenteResumen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "tabindex", "-1");
            __builder.AddAttribute(2, "style", "display:block");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "modal-dialog");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-content");
            __builder.AddMarkupContent(8, "<div class=\"modal-header\"><h1>Resumen</h1></div>\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddMarkupContent(10, "<h3>Pasajes:</h3>\r\n                ");
            __builder.OpenElement(11, "table");
            __builder.AddMarkupContent(12, "<thead><tr><th>Nombre</th>\r\n                            <th>Apellido</th></tr></thead>\r\n                    ");
            __builder.OpenElement(13, "tbody");
#nullable restore
#line 17 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponenteCompra\ComponenteResumen.razor"
                         foreach (Pasaje item in Resumen.PasajesInfo)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "tr");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 20 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponenteCompra\ComponenteResumen.razor"
                                     item.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 21 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponenteCompra\ComponenteResumen.razor"
                                     item.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponenteCompra\ComponenteResumen.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddMarkupContent(22, "<h3>Insumos:</h3>\r\n                ");
            __builder.OpenElement(23, "table");
            __builder.AddMarkupContent(24, "<thead><tr><th>Nombre</th>\r\n                            <th>Precio</th></tr></thead>\r\n                    ");
            __builder.OpenElement(25, "tbody");
#nullable restore
#line 37 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponenteCompra\ComponenteResumen.razor"
                         foreach (Insumo item in Resumen.InsumosSeleccionados)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "tr");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 40 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponenteCompra\ComponenteResumen.razor"
                                     item.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                                ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 41 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponenteCompra\ComponenteResumen.razor"
                                     item.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponenteCompra\ComponenteResumen.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "div");
            __builder.OpenElement(34, "p");
            __builder.AddContent(35, "Total pasajes: $");
            __builder.AddContent(36, 
#nullable restore
#line 48 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponenteCompra\ComponenteResumen.razor"
                                    PrecioPasaje

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(37, " x ");
            __builder.AddContent(38, 
#nullable restore
#line 48 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponenteCompra\ComponenteResumen.razor"
                                                    Resumen.PasajesInfo.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(39, " = ");
            __builder.AddContent(40, 
#nullable restore
#line 48 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponenteCompra\ComponenteResumen.razor"
                                                                                  PrecioPasaje*Resumen.PasajesInfo.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "p");
            __builder.AddContent(43, "Total insumos: ");
            __builder.AddContent(44, 
#nullable restore
#line 49 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponenteCompra\ComponenteResumen.razor"
                                   calcularInsumos()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "p");
            __builder.AddContent(47, "Monto final: $");
            __builder.AddContent(48, 
#nullable restore
#line 50 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponenteCompra\ComponenteResumen.razor"
                                  montoFinal()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponenteCompra\ComponenteResumen.razor"
       
    [Parameter] public Resumen Resumen { get; set; }
    [Parameter] public double PrecioPasaje { get; set; }

    double montoFinalInsumos = 0;
    double montoPasajes = 0;

    protected string calcularInsumos()
    {
        string montoInsumos = "";
        for (int i = 0; i < Resumen.InsumosSeleccionados.Count; i++)
        {
            if (i != (Resumen.InsumosSeleccionados.Count - 1))
            {
                montoInsumos += "$" + Resumen.InsumosSeleccionados[i].Precio + " + ";
            }
            else
            {
                montoInsumos += "$" + Resumen.InsumosSeleccionados[i].Precio;
            }
            montoFinalInsumos += Resumen.InsumosSeleccionados[i].Precio;
        }
        return montoInsumos;
    }

    protected double montoFinal()
    {
        montoPasajes = PrecioPasaje * Resumen.PasajesInfo.Count;

        return (montoPasajes + montoFinalInsumos);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
