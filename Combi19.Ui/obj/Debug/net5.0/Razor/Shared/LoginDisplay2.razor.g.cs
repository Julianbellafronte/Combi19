#pragma checksum "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Shared\LoginDisplay2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd538ff0e95046eb11f56c14bf9a09f36180aa8e"
// <auto-generated/>
#pragma warning disable 1591
namespace Combi19.Ui.Shared
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
    public partial class LoginDisplay2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", "Admin");
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "<form style=\"margin:5px\" method=\"get\" action=\"choferes\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Choferes</button></form>\r\n        ");
                __builder2.AddMarkupContent(4, "<form style=\"margin:5px\" method=\"get\" action=\"ciudades\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Ciudades</button></form>\r\n        ");
                __builder2.AddMarkupContent(5, "<form style=\"margin:5px\" method=\"get\" action=\"combis\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Combis</button></form>\r\n        ");
                __builder2.AddMarkupContent(6, "<form style=\"margin:5px\" method=\"get\" action=\"insumos\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Insumos</button></form>\r\n        ");
                __builder2.AddMarkupContent(7, "<form style=\"margin:5px\" method=\"get\" action=\"rutas\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Rutas</button></form>\r\n        ");
                __builder2.AddMarkupContent(8, "<form style=\"margin:5px\" method=\"get\" action=\"viajes\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Viajes</button></form>\r\n        ");
                __builder2.AddMarkupContent(9, "<form style=\"margin:5px\" method=\"get\" action=\"combis\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Combis</button></form>\r\n        ");
                __builder2.AddMarkupContent(10, "<form style=\"margin:5px\" method=\"get\" action=\"usuarios\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Usuarios</button></form>\r\n        ");
                __builder2.AddMarkupContent(11, "<form style=\"margin:5px\" method=\"get\" action=\"comentarios\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Comentarios</button></form>\r\n        ");
                __builder2.AddMarkupContent(12, "<form style=\"margin:5px\" method=\"get\" action=\"estadisticas\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Estadisticas</button></form>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(14);
            __builder.AddAttribute(15, "Roles", "Normal");
            __builder.AddAttribute(16, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(17, "<form style=\"margin:5px\" method=\"get\" action=\"misCompras\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473;\">Historial</button></form>\r\n        ");
                __builder2.AddMarkupContent(18, "<form style=\"margin:5px\" method=\"get\" action=\"misComentarios\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473;\">Mis comentarios</button></form>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(20);
            __builder.AddAttribute(21, "Roles", "Chofer");
            __builder.AddAttribute(22, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(23, "<form style=\"margin:5px\" method=\"get\" action=\"ViajeEnCurso\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473;\">Viaje en Curso</button></form>\r\n        ");
                __builder2.AddMarkupContent(24, "<form style=\"margin:5px\" method=\"get\" action=\"misViajes\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473;\">Historial de viajes</button></form>\r\n        ");
                __builder2.AddMarkupContent(25, "<form style=\"margin:5px\" method=\"get\" action=\"proximosDestinos\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473;\">Proximos viajes</button></form>\r\n        ");
                __builder2.AddMarkupContent(26, "<form style=\"margin:5px\" method=\"get\" action=\"registrarUsuario\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473;\">Registrar usuario</button></form>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591