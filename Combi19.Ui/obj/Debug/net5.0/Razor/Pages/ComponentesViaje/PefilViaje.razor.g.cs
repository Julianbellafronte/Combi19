#pragma checksum "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\PefilViaje.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "893347cb8d24cf9c9d4026b9b2ede5cba6c607db"
// <auto-generated/>
#pragma warning disable 1591
namespace Combi19.Ui.Pages.ComponentesViaje
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/perfilViaje/{id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/perfilViaje/{id:int}/{url}")]
    public partial class PefilViaje : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div style=\"background: linear-gradient(#ffb73f, #ffd23f) \" class=\"top-row px-1 auth border-0 position-relative\"><h1 style=\"color:white\"> Datos de viaje</h1></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal-content");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddMarkupContent(7, "<b>Ruta:</b> ");
            __builder.AddContent(8, 
#nullable restore
#line 15 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\PefilViaje.razor"
                              ciudad1.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, ", ");
            __builder.AddContent(10, 
#nullable restore
#line 15 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\PefilViaje.razor"
                                               tipoProvincia1.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, "  -  ");
            __builder.AddContent(12, 
#nullable restore
#line 15 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\PefilViaje.razor"
                                                                          ciudad2.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, ", ");
            __builder.AddContent(14, 
#nullable restore
#line 15 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\PefilViaje.razor"
                                                                                           tipoProvincia2.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "tr");
            __builder.OpenElement(17, "td");
            __builder.AddMarkupContent(18, "<b>Fecha de salida:</b> ");
            __builder.AddContent(19, 
#nullable restore
#line 18 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\PefilViaje.razor"
                                         viaje.FechaSalida.ToString("dd/MM/yy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "tr");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "<b>Hora de salida:</b> ");
            __builder.AddContent(24, 
#nullable restore
#line 21 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\PefilViaje.razor"
                                        tipoRuta.HsSalida.ToString("HH:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "tr");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "<b>Precio de viaje:</b> ");
            __builder.AddContent(29, 
#nullable restore
#line 24 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\PefilViaje.razor"
                                         viaje.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "tr");
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "colspan", "2");
            __builder.AddAttribute(34, "style", "text-align:center");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "type", "button");
            __builder.AddAttribute(37, "class", "btn btn-outline-dark");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\PefilViaje.razor"
                                                                             Volver

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Volver");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\PefilViaje.razor"
        [Parameter]
    public int id { get; set; }
    [Parameter]
    public string url { get; set; } = "";
    Viaje viaje = new Viaje();
    public string Message { get; set; }

    public IEnumerable<Ruta> rutas = new List<Ruta>();
    private IEnumerable<Ciudad> ciudades = new List<Ciudad>();
    private IEnumerable<Provincia> provincias = new List<Provincia>();
    Ciudad ciudad1 = new Ciudad();
    Ciudad ciudad2 = new Ciudad();
    Ruta tipoRuta = new Ruta();
    Provincia tipoProvincia1 = new Provincia();
    Provincia tipoProvincia2 = new Provincia();

    protected async override Task OnInitializedAsync()
    {
        try
        {
            ciudades = await servicioCiudad.ObtenerTodos();
            provincias = await servicioProvincia.ObtenerTodos();
            rutas = await servicioRuta.ObtenerTodos();
            viaje = await servicioViaje.Obtener(id);
            obtenerCiudadProvincia(viaje.IdRuta);
        }
        catch (Exception ex)
        {
            Message = "Algo salio mal... " + ex.Message;
        }
    }

    protected void obtenerCiudadProvincia(int v1)
    {
        foreach (Ruta ruta in rutas)
        {
            if (ruta.Id == v1)
            {
                tipoRuta = ruta;
                break;
            }
        }
        foreach (Ciudad ciudad in ciudades)
        {
            if (ciudad.Id == tipoRuta.IdCiudad1)
            {
                ciudad1 = ciudad;
                foreach (Provincia provincia in provincias)
                {
                    if (provincia.Id == ciudad.IdProvincia)
                    {
                        tipoProvincia1 = provincia;
                        break;
                    }
                }
            }
        }
        foreach (Ciudad ciudad in ciudades)
        {
            if (ciudad.Id == tipoRuta.IdCiudad2)
            {
                ciudad2 = ciudad;
                foreach (Provincia provincia in provincias)
                {
                    if (provincia.Id == ciudad.IdProvincia)
                    {
                        tipoProvincia2 = provincia;
                        break;
                    }
                }
            }
        }

    }

    public void Volver()
    {
        if (url == "")
            navigationManager.NavigateTo("/viajes");
        else
            navigationManager.NavigateTo($"/{url}");
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioViaje servicioViaje { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioProvincia servicioProvincia { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioCiudad servicioCiudad { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioRuta servicioRuta { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
