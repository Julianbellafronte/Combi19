// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Combi19.Ui.Pages.ComponentesRuta
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
#line 8 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\PefilRuta.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/perfilRuta/{id:int}")]
    public partial class PefilRuta : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\PefilRuta.razor"
       
    [Parameter]
    public int id { get; set; }

    Ciudad ciudad1 = new Ciudad();
    Ciudad ciudad2 = new Ciudad();
    Provincia p1 = new Provincia();
    Provincia p2 = new Provincia();
    Combi combi = new Combi();
    Ruta ruta = new Ruta();
    AspNetUsersDto chofer = new AspNetUsersDto();

    protected async override Task OnInitializedAsync()
    {
        if (id > 0) //If no Id has been passed, then it is a new Category
        {
            ruta = await servicioRuta.Obtener(id);
            ciudad1 = await servicioCiudad.Obtener(ruta.IdCiudad1);
            ciudad2 = await servicioCiudad.Obtener(ruta.IdCiudad2);
            p1 = await servicioProvincia.Obtener(ciudad1.IdProvincia);
            p2 = await servicioProvincia.Obtener(ciudad2.IdProvincia);
            combi = await servicioCombi.Obtener(ruta.IdCombi);
            chofer = await servicioChofer.Obtener(combi.IdChofer);
        }
    }

    public void Volver()
    {
        navigationManager.NavigateTo("/rutas");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioChofer servicioChofer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioCombi servicioCombi { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioProvincia servicioProvincia { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioCiudad servicioCiudad { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioRuta servicioRuta { get; set; }
    }
}
#pragma warning restore 1591