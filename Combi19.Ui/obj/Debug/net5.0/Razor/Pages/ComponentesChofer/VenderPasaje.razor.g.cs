#pragma checksum "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "888e3e374a63370977ba98c1453eb6d8d24c032b"
// <auto-generated/>
#pragma warning disable 1591
namespace Combi19.Ui.Pages.ComponentesChofer
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
#line 14 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
using Combi19.Ui.Pages.Componentes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
           [Authorize(Roles = "Chofer")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/venderPasaje/{id:int}")]
    public partial class VenderPasaje : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal-content");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Ruta</th>\r\n                <th>Fecha de Salida</th>\r\n                <th>Hora de Salida</th>\r\n                <th>Precio</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 31 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                     viajeCompleto.CiudadOrigen

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, ", ");
            __builder.AddContent(10, 
#nullable restore
#line 31 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                                  viajeCompleto.ProvinciaOrigen

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, "  -  ");
            __builder.AddContent(12, 
#nullable restore
#line 31 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                                                                     viajeCompleto.CiudadDestino

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, ", ");
            __builder.AddContent(14, 
#nullable restore
#line 31 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                                                                                                   viajeCompleto.ProvinciaDestino

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 32 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                     viajeCompleto.FechaSalida.Date.ToString("dd/MM/yy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 33 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                     viajeCompleto.HsSalida.ToString("HH:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 34 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                     viajeCompleto.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
 if (PasajesInfo.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "<p><em>Cargando...</em></p>");
#nullable restore
#line 43 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
     if (viaje.Asientos > 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "style", "text-align: center; ");
            __builder.OpenElement(27, "table");
            __builder.OpenElement(28, "tr");
            __builder.OpenElement(29, "td");
#nullable restore
#line 52 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                         if (cantPasajes < viaje.Asientos)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "style", "margin-left: 10px; margin-top: 10px");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                                                                                                  IncrementarPasaje

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Agregar Pasaje");
            __builder.CloseElement();
#nullable restore
#line 55 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "<p style=\"color: red\">No hay más pasajes disponibles</p>");
#nullable restore
#line 59 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    <td></td>\r\n                    ");
            __builder.OpenElement(37, "td");
#nullable restore
#line 63 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                         if (cantPasajes > 1)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "style", "margin-left: 10px; margin-top: 10px");
            __builder.AddAttribute(40, "class", "btn btn-primary");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                                                                                                  Decrementar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Quitar");
            __builder.CloseElement();
#nullable restore
#line 66 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "<button style=\"margin-left: 10px; margin-top: 10px\" class=\"btn btn-primary\" disabled>Quitar</button>");
#nullable restore
#line 70 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "style", "width:100%; display:flex; justify-content:center");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "style", "width: 30%; float: left");
            __builder.AddMarkupContent(48, "<h3 style=\"text-align:center\">Formulario de Pasajeros</h3>");
#nullable restore
#line 79 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
             for (int i = 0; i < cantPasajes; i++)
            {
                if (PasajesInfo.Count > i)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "style", "float: left; margin-left: 5%; margin-right: 5%; width: 100%");
            __builder.OpenComponent<Combi19.Ui.Pages.Componentes.FormularioPasaje>(51);
            __builder.AddAttribute(52, "Pasajes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Combi19.Model.Pasaje>>(
#nullable restore
#line 84 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                                   PasajesInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "cantConfirmar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.Int32>>(
#nullable restore
#line 85 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                                         cantConfirmar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "Pos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 86 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                               i

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "CantidadPasajes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 87 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                                           cantPasajes

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 90 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(56, "<p><em>Cargando...</em></p>");
#nullable restore
#line 94 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "style", "width: 50%; float: left");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "tabindex", "-1");
            __builder.AddAttribute(62, "style", "display:block");
            __builder.AddAttribute(63, "role", "dialog");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "modal-dialog");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "modal-content");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "modal-header");
            __builder.OpenElement(70, "h2");
            __builder.AddContent(71, "Total: $");
            __builder.AddContent(72, 
#nullable restore
#line 103 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                         total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "modal-body");
            __builder.AddMarkupContent(76, "\r\n                            Pasaje/s:\r\n                            ");
            __builder.OpenElement(77, "ul");
            __builder.OpenElement(78, "li");
            __builder.AddContent(79, 
#nullable restore
#line 109 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                     viaje.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(80, " * ");
            __builder.AddContent(81, 
#nullable restore
#line 109 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                                     PasajesInfo.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(82, " = $");
            __builder.AddContent(83, 
#nullable restore
#line 109 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                                                            viaje.Precio * PasajesInfo.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                            ");
            __builder.OpenElement(85, "h4");
            __builder.AddContent(86, "Monto final: $");
            __builder.AddContent(87, 
#nullable restore
#line 112 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                               total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n            ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "tabindex", "-1");
            __builder.AddAttribute(91, "style", "display:block");
            __builder.AddAttribute(92, "role", "dialog");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "modal-dialog");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "modal-content");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(99);
            __builder.AddAttribute(100, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 121 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                              Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(102, "table");
                __builder2.AddAttribute(103, "class", "table");
                __builder2.OpenElement(104, "tr");
                __builder2.AddMarkupContent(105, "<td>Email</td>\r\n                                        ");
                __builder2.OpenElement(106, "td");
                __builder2.OpenElement(107, "input");
                __builder2.AddAttribute(108, "type", "text");
                __builder2.AddAttribute(109, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 125 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                                                      Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(110, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Email = __value, Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.OpenElement(111, "p");
                __builder2.AddAttribute(112, "style", "color:red");
                __builder2.AddContent(113, 
#nullable restore
#line 125 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                                                                                     mensajeEmail

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                                ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "style", "display:flex; justify-content:center");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "style", "text-align: center;");
                __builder2.OpenElement(119, "button");
                __builder2.AddAttribute(120, "type", "button");
                __builder2.AddAttribute(121, "class", "btn btn-outline-info");
                __builder2.AddAttribute(122, "value", "crearVenta");
                __builder2.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 130 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                                                                                                        (() => Verificar())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(124, "Confirmar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 135 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                         if (comprar)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(125, @"<div class=""alert alert-info alert-dismissible"" role=""alert""><button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                                Email confirmado.
                            </div>");
#nullable restore
#line 141 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(126, @"<div class=""alert alert-danger alert-dismissible"" role=""alert""><button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                                Se debe confirmar el email.
                            </div>");
#nullable restore
#line 148 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 152 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
             if (viaje.Asientos > 0)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "style", "display:flex; justify-content:center");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "style", "text-align: center;");
            __builder.OpenElement(131, "button");
            __builder.AddAttribute(132, "type", "button");
            __builder.AddAttribute(133, "class", "btn btn-outline-info");
            __builder.AddAttribute(134, "value", "crearVenta");
            __builder.AddAttribute(135, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 156 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                                                                                                        (() => crearVenta())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(136, "Vender");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 159 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 160 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
             if (!mostrar)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(137, "div");
            __builder.AddAttribute(138, "class", "alert alert-danger alert-dismissible");
            __builder.AddAttribute(139, "role", "alert");
            __builder.AddMarkupContent(140, "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n                    ");
            __builder.AddContent(141, 
#nullable restore
#line 164 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
                     mensaje

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 166 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 169 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 170 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
 if (viaje.Asientos == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(142, @"<div style=""display:flex; justify-content:center""><div class=""alert alert-danger alert-dismissible"" role=""alert""><button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
            No hay mas pasajes disponibles.
        </div></div>");
#nullable restore
#line 178 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 181 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\VenderPasaje.razor"
           
        [Parameter]
        public int id { get; set; }
public int cantPasajes { get; set; } = 1;
    [Parameter] public List<Pasaje> PasajesInfo { get; set; } = new List<Pasaje>();

    public Pasaje pasaje = new Pasaje();
    public IEnumerable<Viaje> viajes = new List<Viaje>();
    public Combi combi = new Combi();
    public Viaje viaje = new Viaje();
    public Ruta ruta = new Ruta();
    [Parameter] public List<int> cantConfirmar { get; set; } = new List<int>();
    string mensaje = "Se deben confirmar todos los pasajes.";
    string mensajeEmail = "";
    string comprarPasajes = "Se debe verificar el email.";
    bool mostrar = true;
    bool comprar = false;
    double total = 0;

    public ViajeCompleto viajeCompleto = new ViajeCompleto();

    string Email = "";
    AspNetUsersDto comprador;

    protected async override Task OnInitializedAsync()
    {
        cantConfirmar.Add(1);
        PasajesInfo.Add(new Pasaje());
        try
        {
            viaje = await servicioViaje.Obtener(id);
            total = viaje.Precio;
            ruta = await servicioRuta.Obtener(viaje.IdRuta);
            await obtenerCiudadProvincia();
            combi = await servicioCombi.ObtenerCombiRuta(ruta.Id);
        }
        catch (Exception ex)
        {
            string Message = "Algo salio mal... " + ex.Message;
        }
    }

    protected async Task Verificar()
    {
        AspNetUsersDto c = await servicioUsuario.ExisteEmail(Email);
        if (c == null)
        {
            mensajeEmail = "No existe un usuario registrado con ese email.";
        }
        else
        {
            mensajeEmail = "";
            comprador = c;
            comprar = true;
        }
    }

    protected async Task crearVenta()
    {
        if (comprar)
        {
            if (cantConfirmar.Count == 0)
            {
                mostrar = true;
                Venta venta = new Venta("Pendiente", comprador.IdAux, viaje.Precio, viaje.FechaSalida, PasajesInfo, comprador.PlanPremium, viaje.Id);
                Row ident = await servicioVenta.Guardar(venta);
                viaje.Asientos -= venta.CantidadPasajes;
                await servicioViaje.Guardar(viaje);
                foreach (Pasaje item in PasajesInfo)
                {
                    item.IdVenta = ident.Ident;
                    item.IdViaje = id;
                    item.Estado = "Pendiente";
                    await servicioPasaje.Guardar(item);
                }
                venta.Id = ident.Ident;
                await servicioVenta.Actualizar(venta);
                navigationManager.NavigateTo("/");
            }
            else
            {
                mostrar = false;
            }
        }
        else
        {

        }
    }
    public void Cancelar()
    {
        navigationManager.NavigateTo("/buscarViaje");
    }

    public void IncrementarPasaje()
    {
        cantPasajes++;
        cantConfirmar.Add(1);
        PasajesInfo.Add(new Pasaje());
        calcularTotal();
    }

    public void Decrementar()
    {
        cantPasajes--;
        cantConfirmar.Remove(1);
        PasajesInfo.RemoveAt(PasajesInfo.Count() - 1);
        calcularTotal();
    }

    protected async Task obtenerCiudadProvincia()
    {
        Ciudad ciudad1 = new Ciudad();
        Ciudad ciudad2 = new Ciudad();
        Provincia tipoProvincia1 = new Provincia();
        Provincia tipoProvincia2 = new Provincia();

        ciudad1 = await servicioRuta.ObtenerCiudad(ruta.IdCiudad1);
        tipoProvincia1 = await servicioCiudad.ObtenerProvincia(ciudad1.IdProvincia);

        ciudad2 = await servicioRuta.ObtenerCiudad(ruta.IdCiudad2);
        tipoProvincia2 = await servicioCiudad.ObtenerProvincia(ciudad2.IdProvincia);

        viajeCompleto = new ViajeCompleto(viaje.Id, ciudad1.Nombre, tipoProvincia1.Nombre, ciudad2.Nombre, tipoProvincia2.Nombre, viaje.FechaSalida, viaje.Precio, ruta.HsSalida, viaje.Asientos);
    }

    protected void calcularTotal()
    {
        double totalParcial = 0;
        totalParcial += (viaje.Precio * PasajesInfo.Count);
        total = totalParcial;
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioCiudad servicioCiudad { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioListaInsumo servicioListaInsumo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioPasaje servicioPasaje { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioUsuario servicioUsuario { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioVenta servicioVenta { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioRuta servicioRuta { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioViaje servicioViaje { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioCombi servicioCombi { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioInsumo servicioInsumo { get; set; }
    }
}
#pragma warning restore 1591
