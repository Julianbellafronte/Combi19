#pragma checksum "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesInsumo\EliminarInsumo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47879ba345013c4ae45bb59458ddcbc08de64d78"
// <auto-generated/>
#pragma warning disable 1591
namespace Combi19.Ui.Pages.ComponentesInsumo
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
#line 4 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesInsumo\EliminarInsumo.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eliminarInsumo/{id:int}")]
    public partial class EliminarInsumo : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(8, "<div class=\"modal-header\"><h1>Datos de Insumo</h1></div>\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesInsumo\EliminarInsumo.razor"
                                  insumo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesInsumo\EliminarInsumo.razor"
                                                         Eliminar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n                    ");
                __builder2.OpenElement(17, "table");
                __builder2.AddAttribute(18, "class", "table");
                __builder2.OpenElement(19, "tr");
                __builder2.AddMarkupContent(20, "<td>Producto</td>\r\n                            ");
                __builder2.OpenElement(21, "td");
                __builder2.AddContent(22, 
#nullable restore
#line 18 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesInsumo\EliminarInsumo.razor"
                                 insumo.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                        ");
                __builder2.OpenElement(24, "tr");
                __builder2.AddMarkupContent(25, "<td>Descripcion</td>\r\n                            ");
                __builder2.OpenElement(26, "td");
                __builder2.AddContent(27, 
#nullable restore
#line 22 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesInsumo\EliminarInsumo.razor"
                                 insumo.Descripcion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __builder2.OpenElement(29, "tr");
                __builder2.AddMarkupContent(30, "<td>Precio</td>\r\n                            ");
                __builder2.OpenElement(31, "td");
                __builder2.AddContent(32, "$");
                __builder2.AddContent(33, 
#nullable restore
#line 26 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesInsumo\EliminarInsumo.razor"
                                  insumo.Precio

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                        ");
                __builder2.OpenElement(35, "tr");
                __builder2.OpenElement(36, "td");
                __builder2.AddAttribute(37, "colspan", "2");
                __builder2.AddAttribute(38, "style", "text-align:center");
                __builder2.AddMarkupContent(39, "<button type=\"submit\" class=\"btn btn-outline-danger\" value=\"Eliminar\">Eliminar</button>\r\n                                ");
                __builder2.OpenElement(40, "button");
                __builder2.AddAttribute(41, "type", "button");
                __builder2.AddAttribute(42, "class", "btn btn-outline-secondary");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesInsumo\EliminarInsumo.razor"
                                                                                                  Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(44, "Cancelar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesInsumo\EliminarInsumo.razor"
       

    [Parameter]
    public int id { get; set; }

    Insumo insumo = new Insumo();

    protected async override Task OnInitializedAsync()
    {
        if (id > 0)
            insumo = await servicioInsumo.Obtener(id);
    }

    protected async Task Eliminar()
    {
        await servicioInsumo.Eliminar(id);

        navigationManager.NavigateTo("/insumos");
    }
    public void Cancelar()
    {
        navigationManager.NavigateTo("/insumos");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioInsumo servicioInsumo { get; set; }
    }
}
#pragma warning restore 1591
