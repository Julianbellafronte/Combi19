#pragma checksum "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c025f72b971371851130d32071ada42d5de4bac"
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
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", "Admin");
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "<div class=\"icono\"><a href=\"/\"><img src=\"/logo_blanco.png\" width=\"80\"></a></div>\r\n        ");
                __builder2.AddMarkupContent(4, "<form style=\"margin:5px\" method=\"get\" action=\"Identity/Account/Manage/ChangePassword\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Cambia tu contrase??a</button></form>\r\n        ");
                __builder2.AddMarkupContent(5, "<form style=\"margin:5px\" method=\"post\" action=\"Identity/Account/LogOut\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Cerrar sesion</button></form>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(7);
            __builder.AddAttribute(8, "Roles", "Normal");
            __builder.AddAttribute(9, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "<div class=\"icono\"><a href=\"/\"><img src=\"/logo_blanco.png\" width=\"80\"></a></div>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "acomodar");
                __builder2.OpenComponent<Combi19.Ui.Pages.ComponenteCompra.BuscarViaje>(13);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.AddMarkupContent(15, "<form style=\"margin:5px\" method=\"get\" action=\"datosUsuario\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Mi cuenta</button></form>\r\n        ");
                __builder2.AddMarkupContent(16, "<form style=\"margin:5px\" method=\"get\" action=\"Identity/Account/Manage/ChangePassword\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Cambia tu contrase??a</button></form>\r\n        ");
                __builder2.AddMarkupContent(17, "<form style=\"margin:5px\" method=\"post\" action=\"Identity/Account/LogOut\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473 \">Cerrar sesion</button></form>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(19);
            __builder.AddAttribute(20, "Roles", "Chofer");
            __builder.AddAttribute(21, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(22, "<div class=\"icono\"><a href=\"/\"><img src=\"/logo_blanco.png\" width=\"80\"></a></div>\r\n        ");
                __builder2.AddMarkupContent(23, "<form style=\"margin:5px\" method=\"get\" action=\"datosChofer\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Mi cuenta</button></form>\r\n        ");
                __builder2.AddMarkupContent(24, "<form style=\"margin:5px\" method=\"get\" action=\"Identity/Account/Manage/ChangePassword\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Cambia tu contrase??a</button></form>\r\n        ");
                __builder2.AddMarkupContent(25, "<form style=\"margin:5px\" method=\"post\" action=\"Identity/Account/LogOut\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473 \">Cerrar sesion</button></form>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(27);
            __builder.AddAttribute(28, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(29, "<div class=\"icono\"><a href=\"/\"><img src=\"/logo_blanco.png\" width=\"80\"></a></div>\r\n        ");
                __builder2.AddMarkupContent(30, "<form style=\"margin:5px\" method=\"get\" action=\"Identity/Account/Register\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Registrar</button></form>\r\n        ");
                __builder2.AddMarkupContent(31, "<form style=\"margin:5px\" method=\"get\" action=\"Identity/Account/Login\"><button type=\"submit\" class=\"btn btn-primary border-0\" style=\"background-color: #005473\">Iniciar sesion</button></form>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
