#pragma checksum "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74f6772ddce1ddb8a78d71785ffa7d524abd634e"
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
#nullable restore
#line 10 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
           [Authorize(Roles = "Normal")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/viajesProximos/{dia:int}/{mes:int}/{anio:int}")]
    public partial class ViajesProximos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Lista de Viajes</h1>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, 
#nullable restore
#line 13 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
    Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
 if (viajes == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>");
#nullable restore
#line 18 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "modal-content");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table");
            __builder.AddMarkupContent(8, "<thead><tr><th>Ruta</th>\r\n                    <th>Fecha de Salida</th>\r\n                    <th>Hora de Salida</th>\r\n                    <th>Precio</th>\r\n                    <th></th></tr></thead>\r\n            ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 33 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
                 foreach (ViajeCompleto item in viajesCompletos)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", "/perfilViaje/" + (
#nullable restore
#line 36 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
                                                   item.IdViaje

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, 
#nullable restore
#line 36 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
                                                                  item.CiudadOrigen

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, ", ");
            __builder.AddContent(16, 
#nullable restore
#line 36 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
                                                                                      item.ProvinciaOrigen

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, "  -  ");
            __builder.AddContent(18, 
#nullable restore
#line 36 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
                                                                                                                item.CiudadDestino

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, ", ");
            __builder.AddContent(20, 
#nullable restore
#line 36 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
                                                                                                                                     item.ProvinciaDestino

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 37 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
                             item.FechaSalida.Date.ToString("dd/MM/yy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 38 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
                             item.HsSalida.ToString("HH:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 39 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
                             item.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "td");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "type", "submit");
            __builder.AddAttribute(34, "class", "btn btn-outline-info");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
                                                                                         (()=> Comprar(item.IdViaje))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Comprar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesViaje\ViajesProximos.razor"
       
    [Parameter]
    public int Dia { get; set; }
    [Parameter]
    public int Mes { get; set; }
    [Parameter]
    public int Anio { get; set; }

    public IEnumerable<Viaje> viajes = new List<Viaje>();
    public List<ViajeCompleto> viajesCompletos = new List<ViajeCompleto>();
    public string Message { get; set; }

    protected async override Task OnInitializedAsync()
    {
        try
        {
            string fecha = Dia + "/" + Mes + "/" + Anio;
            viajes = await servicioViaje.ViajesProximos(Convert.ToDateTime(fecha));
            await obtenerCiudadProvincia();
        }
        catch (Exception ex)
        {
            Message = "Algo salio mal... " + ex.Message;
        }
    }

    protected async Task obtenerCiudadProvincia()
    {
        Ciudad ciudad1 = new Ciudad();
        Ciudad ciudad2 = new Ciudad();
        Ruta tipoRuta = new Ruta();
        Provincia tipoProvincia1 = new Provincia();
        Provincia tipoProvincia2 = new Provincia();
        ViajeCompleto viaje;
        foreach (Viaje item in viajes)
        {
            tipoRuta = await servicioRuta.Obtener(item.IdRuta);
            ciudad1 = await servicioRuta.ObtenerCiudad(tipoRuta.IdCiudad1);
            tipoProvincia1 = await servicioCiudad.ObtenerProvincia(ciudad1.IdProvincia);

            ciudad2 = await servicioRuta.ObtenerCiudad(tipoRuta.IdCiudad2);
            tipoProvincia2 = await servicioCiudad.ObtenerProvincia(ciudad2.IdProvincia);

            viaje = new ViajeCompleto(item.Id, ciudad1.Nombre, tipoProvincia1.Nombre, ciudad2.Nombre, tipoProvincia2.Nombre, item.FechaSalida, item.Precio, tipoRuta.HsSalida, item.Asientos);
            viajesCompletos.Add(viaje);
        }
    }

    public async Task Comprar(int id)
    {
        string name;
        AuthenticationState astate = await auth.GetAuthenticationStateAsync();
        name = astate.User.Identity.Name;
        AspNetUsersDto user = await servicioUsuario.Obtener(name);
        if (DateTime.Today.AddDays(-15) <= user.FechaSintoma)
            await JSRuntime.MostrarMensaje("Operacion invalida", "Usted ha presentado sintomas de COVID-19, no puede realizar una compra hasta que no se cumpla el plazo estimado de 15 dias", IJSExtensions.TipoMensajeSweetAlert.error);
        else
            navigationManager.NavigateTo($"/comprarPasaje/{id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioUsuario servicioUsuario { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioViaje servicioViaje { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioProvincia servicioProvincia { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioCiudad servicioCiudad { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioRuta servicioRuta { get; set; }
    }
}
#pragma warning restore 1591