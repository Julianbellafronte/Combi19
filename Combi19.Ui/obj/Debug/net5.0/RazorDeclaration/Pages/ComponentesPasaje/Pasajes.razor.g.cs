// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Combi19.Ui.Pages.ComponentesPasaje
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/pasajes/{Id:int}")]
    public partial class Pasajes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 126 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesPasaje\Pasajes.razor"
       
    [Parameter]
    public int Id { get; set; }
    public IEnumerable<Pasaje> pasajes { get; set; }
    public string Message { get; set; }
    Viaje viaje = new Viaje();
    AspNetUsersDto user = new AspNetUsersDto();
    Ruta ruta;

    protected async override Task OnInitializedAsync()
    {
        try
        {
            AuthenticationState astate = await auth.GetAuthenticationStateAsync();
            string name = astate.User.Identity.Name;
            user = await servicioUsuario.Obtener(name);
            viaje = await servicioViaje.Obtener(Id);
            ruta = await servicioRuta.Obtener(viaje.IdRuta);
            pasajes = await servicioPasaje.ObtenerTodosViajes(Id);
        }
        catch (Exception ex)
        {
            Message = "Algo salio mal... " + ex.Message;
        }
    }

    public async Task Ausente(Pasaje pasaje)
    {
        if (await JSRuntime.Confirm("Confirmar", "¿Esta seguro que desea marcar el pasaje como Ausente?", IJSExtensions.TipoMensajeSweetAlert.question))
        {
            await servicioPasaje.PasajeAusente(pasaje);
            Viaje v = await servicioViaje.Obtener(pasaje.IdViaje);
            v.Asientos++;
            await servicioViaje.Guardar(v);
            navigationManager.NavigateTo($"/pasajes/{Id}", true);

        }
    }

    public async Task Iniciar()
    {
        Pasaje pendiente = await servicioPasaje.ObtenerPendiente(viaje.Id);
        Viaje curso = await servicioViaje.ViajeEnCurso(user.IdAux);
        if (pendiente != null)
        {
            await JSRuntime.MostrarMensaje("Operacion invalida", "Debe testear o marcar como ausente a todos los pasajeros antes de iniciar el viaje", IJSExtensions.TipoMensajeSweetAlert.error);
        }
        else if (curso != null)
        {
            await JSRuntime.MostrarMensaje("Operacion invalida", "Debe finalizar el viaje que ya se encuentra en curso", IJSExtensions.TipoMensajeSweetAlert.error);
        }
        else if(await JSRuntime.Confirm("Confirmar", "¿Esta seguro que desea iniciar el viaje?", IJSExtensions.TipoMensajeSweetAlert.question))
        {
            viaje.Estado = "En Curso";
            await servicioViaje.Guardar(viaje);
            navigationManager.NavigateTo("/ViajeEnCurso", true);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioUsuario servicioUsuario { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioRuta servicioRuta { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioVenta servicioVenta { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioViaje servicioViaje { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioPasaje servicioPasaje { get; set; }
    }
}
#pragma warning restore 1591