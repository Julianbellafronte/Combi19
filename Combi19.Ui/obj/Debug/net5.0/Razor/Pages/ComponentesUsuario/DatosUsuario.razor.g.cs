#pragma checksum "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45ef98e5e6d9b41a28e7cfeae605268b583ab8e0"
// <auto-generated/>
#pragma warning disable 1591
namespace Combi19.Ui.Pages.ComponentesUsuario
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/datosUsuario")]
    public partial class DatosUsuario : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(8, "<div class=\"modal-header\"><h1>Datos personales</h1></div>\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                  usuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                          Guardar

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
                __builder2.AddMarkupContent(20, "<td>Nombre</td>\r\n                            ");
                __builder2.OpenElement(21, "td");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                          usuario.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => usuario.Nombre = __value, usuario.Nombre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __builder2.OpenElement(27, "td");
                __builder2.AddAttribute(28, "colspan", "2");
                __Blazor.Combi19.Ui.Pages.ComponentesUsuario.DatosUsuario.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 21 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                                        () => usuario.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __builder2.OpenElement(32, "tr");
                __builder2.AddMarkupContent(33, "<td>Apellido</td>\r\n                            ");
                __builder2.OpenElement(34, "td");
                __builder2.OpenElement(35, "input");
                __builder2.AddAttribute(36, "type", "text");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                          usuario.Apellido

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => usuario.Apellido = __value, usuario.Apellido));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                            ");
                __builder2.OpenElement(40, "td");
                __builder2.AddAttribute(41, "colspan", "2");
                __Blazor.Combi19.Ui.Pages.ComponentesUsuario.DatosUsuario.TypeInference.CreateValidationMessage_1(__builder2, 42, 43, 
#nullable restore
#line 26 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                                        () => usuario.Apellido

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.OpenElement(45, "tr");
                __builder2.AddMarkupContent(46, "<td>Dni</td>\r\n                            ");
                __builder2.OpenElement(47, "td");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "type", "text");
                __builder2.AddAttribute(50, "pattern", "[0-9]{7,8}");
                __builder2.AddAttribute(51, "placeholder", "10000000");
                __builder2.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                                                                      usuario.Dni

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => usuario.Dni = __value, usuario.Dni));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                            ");
                __builder2.OpenElement(55, "td");
                __builder2.AddAttribute(56, "colspan", "2");
                __Blazor.Combi19.Ui.Pages.ComponentesUsuario.DatosUsuario.TypeInference.CreateValidationMessage_2(__builder2, 57, 58, 
#nullable restore
#line 31 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                                        () => usuario.Dni

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                        ");
                __builder2.OpenElement(60, "tr");
                __builder2.AddMarkupContent(61, "<td>Fecha de nacimiento</td>\r\n                            ");
                __builder2.OpenElement(62, "td");
                __builder2.OpenElement(63, "input");
                __builder2.AddAttribute(64, "type", "date");
                __builder2.AddAttribute(65, "max", 
#nullable restore
#line 35 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                         mayor.ToString("yyyy-MM-dd")

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                                                              usuario.FechaNacimiento

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => usuario.FechaNacimiento = __value, usuario.FechaNacimiento, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                            ");
                __builder2.OpenElement(69, "td");
                __builder2.AddAttribute(70, "colspan", "2");
                __Blazor.Combi19.Ui.Pages.ComponentesUsuario.DatosUsuario.TypeInference.CreateValidationMessage_3(__builder2, 71, 72, 
#nullable restore
#line 36 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                                        () => usuario.FechaNacimiento

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 38 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                 if (usuario.PlanPremium)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(73, "tr");
                __builder2.AddMarkupContent(74, "<td>Plan contratado: Premium</td>\r\n                                        ");
                __builder2.OpenElement(75, "td");
                __builder2.OpenElement(76, "button");
                __builder2.AddAttribute(77, "type", "button");
                __builder2.AddAttribute(78, "class", "btn btn-outline-danger");
                __builder2.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                                                                              () => CancelarPlan()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(80, "Cancelar plan premium");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                                    ");
                __builder2.OpenElement(82, "tr");
                __builder2.AddMarkupContent(83, "<td><label>Numero de tarjeta</label></td>\r\n                                        ");
                __builder2.OpenElement(84, "td");
                __builder2.OpenElement(85, "input");
                __builder2.AddAttribute(86, "type", "text");
                __builder2.AddAttribute(87, "required");
                __builder2.AddAttribute(88, "pattern", "[0-9]{16}");
                __builder2.AddAttribute(89, "title", "El numero de la tarjeta debe contener 16 digitos");
                __builder2.AddAttribute(90, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                                                                                                                            usuario.NumeroTarjeta

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => usuario.NumeroTarjeta = __value, usuario.NumeroTarjeta));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                                    ");
                __builder2.OpenElement(93, "tr");
                __builder2.AddMarkupContent(94, "<td><label>Vencimiento</label></td>\r\n                                        ");
                __builder2.OpenElement(95, "td");
                __builder2.OpenElement(96, "input");
                __builder2.AddAttribute(97, "type", "month");
                __builder2.AddAttribute(98, "min", 
#nullable restore
#line 52 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                                      fechaHoy.ToString("yyyy-MM")

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(99, "required");
                __builder2.AddAttribute(100, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                                                                                    usuario.Vencimiento

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => usuario.Vencimiento = __value, usuario.Vencimiento, format: "yyyy-MM", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                                    ");
                __builder2.OpenElement(103, "tr");
                __builder2.AddMarkupContent(104, "<td><label>Codigo de seguridad</label></td>\r\n                                        ");
                __builder2.OpenElement(105, "td");
                __builder2.OpenElement(106, "input");
                __builder2.AddAttribute(107, "type", "password");
                __builder2.AddAttribute(108, "pattern", "[0-9]{3}");
                __builder2.AddAttribute(109, "required");
                __builder2.AddAttribute(110, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                                                                      usuario.CodigoSeguridad

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(111, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => usuario.CodigoSeguridad = __value, usuario.CodigoSeguridad));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                                    ");
                __builder2.OpenElement(113, "tr");
                __builder2.AddMarkupContent(114, "<td><label>Nombre de tarjeta</label></td>\r\n                                        ");
                __builder2.OpenElement(115, "td");
                __builder2.OpenElement(116, "input");
                __builder2.AddAttribute(117, "type", "text");
                __builder2.AddAttribute(118, "required");
                __builder2.AddAttribute(119, "oninvalid", "this.setCustomValidity(\'ingrese el nombre que figura en la tarjeta\')");
                __builder2.AddAttribute(120, "onvalid", "this.setCustomValidity(\'\')");
                __builder2.AddAttribute(121, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                                                                                                                                                                     usuario.NombreTarjeta

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(122, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => usuario.NombreTarjeta = __value, usuario.NombreTarjeta));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 62 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(123, "tr");
                __builder2.AddMarkupContent(124, "<td>Plan contratado: Basico</td>\r\n                                        ");
                __builder2.OpenElement(125, "td");
                __builder2.OpenElement(126, "button");
                __builder2.AddAttribute(127, "type", "button");
                __builder2.AddAttribute(128, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(129, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                                                                               () => usuario.PlanPremium = true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(130, "Comprar plan premium");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 69 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(131, "<tr><td colspan=\"2\" style=\"text-align:center\"><button type=\"submit\" class=\"btn btn-outline-primary\" value=\"Guardar\">Guardar</button></td></tr>");
                __builder2.CloseElement();
#nullable restore
#line 76 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                     if (mostrar)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(132, "div");
                __builder2.AddAttribute(133, "class", "alert alert-success alert-dismissible");
                __builder2.AddAttribute(134, "role", "alert");
                __builder2.OpenElement(135, "button");
                __builder2.AddAttribute(136, "type", "button");
                __builder2.AddAttribute(137, "class", "close");
                __builder2.AddAttribute(138, "data-dismiss", "alert");
                __builder2.AddAttribute(139, "aria-label", "Close");
                __builder2.AddAttribute(140, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                                                                                                                      () => Cerrar()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(141, "<span aria-hidden=\"true\">&times;</span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\r\n                            ");
                __builder2.AddContent(143, 
#nullable restore
#line 80 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                             mensaje

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 82 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
                    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(144, "\r\n                <div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesUsuario\DatosUsuario.razor"
       
        AspNetUsersDto usuario = new AspNetUsersDto();
        string mensaje = "";
        bool mostrar = false;
        DateTime fechaHoy = DateTime.Today.AddDays(31);
        DateTime mayor = DateTime.Today.AddYears(-18);

    protected async override Task OnInitializedAsync()
    {
        AuthenticationState astate = await auth.GetAuthenticationStateAsync();
        string user = astate.User.Identity.Name;
        AspNetUsersDto usuarioAux = await servicioUsuario.Obtener(user);

        usuario = await servicioUsuario.Obtener(usuarioAux.IdAux);
    }

    public async Task Guardar()
    {
        await servicioUsuario.Guardar(usuario);
        mostrar = true;
        mensaje = "Se han actualizado los datos correctamente.";
    }
    public void Cerrar()
    {
        mostrar = false;

    }

    public async Task CancelarPlan()
    {
        if (await JSRuntime.Confirm("Anular Suscripcion", "¿Desea cancelar su suscripción Premium?", IJSExtensions.TipoMensajeSweetAlert.question))
        {
            usuario.PlanPremium = false;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioUsuario servicioUsuario { get; set; }
    }
}
namespace __Blazor.Combi19.Ui.Pages.ComponentesUsuario.DatosUsuario
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
