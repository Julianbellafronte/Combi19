#pragma checksum "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "210659dcf1ec789bc5164f1412ba34c1cf04dcc3"
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
#line 3 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
           [Authorize(Roles = "Chofer")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/añadirChofer")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/editarChofer/{id:int}")]
    public partial class DetallesChofer : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(8, "<div class=\"modal-header\"><h1>Datos de chofer</h1></div>\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                                  chofer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
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
#line 21 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                                                          chofer.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => chofer.Nombre = __value, chofer.Nombre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __builder2.OpenElement(27, "td");
                __builder2.AddAttribute(28, "colspan", "2");
                __Blazor.Combi19.Ui.Pages.ComponentesChofer.DetallesChofer.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 22 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                                                                        () => chofer.Nombre

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
#line 26 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                                                          chofer.Apellido

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => chofer.Apellido = __value, chofer.Apellido));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                            ");
                __builder2.OpenElement(40, "td");
                __builder2.AddAttribute(41, "colspan", "2");
                __Blazor.Combi19.Ui.Pages.ComponentesChofer.DetallesChofer.TypeInference.CreateValidationMessage_1(__builder2, 42, 43, 
#nullable restore
#line 27 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                                                                        () => chofer.Apellido

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.OpenElement(45, "tr");
                __builder2.AddMarkupContent(46, "<td>Email</td>\r\n                            ");
                __builder2.OpenElement(47, "td");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "type", "email");
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                                                           chofer.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => chofer.Email = __value, chofer.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.OpenElement(52, "h6");
                __builder2.AddAttribute(53, "style", "color:red");
                __builder2.AddContent(54, 
#nullable restore
#line 31 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                                                                                                  Message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                            ");
                __builder2.OpenElement(56, "td");
                __builder2.AddAttribute(57, "colspan", "2");
                __Blazor.Combi19.Ui.Pages.ComponentesChofer.DetallesChofer.TypeInference.CreateValidationMessage_2(__builder2, 58, 59, 
#nullable restore
#line 32 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                                                                        () => chofer.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 34 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                         if (id == 0)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(60, "tr");
                __builder2.AddMarkupContent(61, "<td>Clave</td>\r\n                                ");
                __builder2.OpenElement(62, "td");
                __builder2.OpenElement(63, "input");
                __builder2.AddAttribute(64, "type", "password");
                __builder2.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                                                                  chofer.Clave

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => chofer.Clave = __value, chofer.Clave));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.OpenElement(67, "h6");
                __builder2.AddAttribute(68, "style", "color:red");
                __builder2.AddContent(69, 
#nullable restore
#line 38 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                                                                                                         Message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                                ");
                __builder2.OpenElement(71, "td");
                __builder2.AddAttribute(72, "colspan", "2");
                __Blazor.Combi19.Ui.Pages.ComponentesChofer.DetallesChofer.TypeInference.CreateValidationMessage_3(__builder2, 73, 74, 
#nullable restore
#line 39 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                                                                            () => chofer.Clave

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 41 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(75, "tr");
                __builder2.AddMarkupContent(76, "<td>DNI</td>\r\n                            ");
                __builder2.OpenElement(77, "td");
                __builder2.OpenElement(78, "input");
                __builder2.AddAttribute(79, "type", "text");
                __builder2.AddAttribute(80, "pattern", "[0-9]{7,8}");
                __builder2.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                                                                               chofer.Dni

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => chofer.Dni = __value, chofer.Dni));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                            ");
                __builder2.OpenElement(84, "td");
                __builder2.AddAttribute(85, "colspan", "2");
                __Blazor.Combi19.Ui.Pages.ComponentesChofer.DetallesChofer.TypeInference.CreateValidationMessage_4(__builder2, 86, 87, 
#nullable restore
#line 45 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                                                                        () => chofer.Dni

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                        ");
                __builder2.OpenElement(89, "tr");
                __builder2.AddMarkupContent(90, "<td>Telefono</td>\r\n                            ");
                __builder2.OpenElement(91, "td");
                __builder2.OpenElement(92, "input");
                __builder2.AddAttribute(93, "type", "tel");
                __builder2.AddAttribute(94, "placeholder", "111-111-11111");
                __builder2.AddAttribute(95, "required");
                __builder2.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                                                                                              chofer.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => chofer.PhoneNumber = __value, chofer.PhoneNumber));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                            ");
                __builder2.OpenElement(99, "td");
                __builder2.AddAttribute(100, "colspan", "2");
                __Blazor.Combi19.Ui.Pages.ComponentesChofer.DetallesChofer.TypeInference.CreateValidationMessage_5(__builder2, 101, 102, 
#nullable restore
#line 50 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                                                                        () => chofer.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                        ");
                __builder2.OpenElement(104, "tr");
                __builder2.OpenElement(105, "td");
                __builder2.AddAttribute(106, "colspan", "2");
                __builder2.AddAttribute(107, "style", "text-align:center");
                __builder2.AddMarkupContent(108, "<button type=\"submit\" class=\"btn btn-outline-primary\" value=\"Guardar\">Guardar</button>\r\n                                ");
                __builder2.OpenElement(109, "button");
                __builder2.AddAttribute(110, "type", "button");
                __builder2.AddAttribute(111, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
                                                                                                  ( ) => navigationManager.NavigateTo("/Choferes")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(113, "Cancelar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(114, "\r\n                <div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesChofer\DetallesChofer.razor"
       
    [Parameter]
    public int id { get; set; }
    AspNetUsersDto chofer = new AspNetUsersDto();
    AspNetUsers choferNuevo = new AspNetUsers();
    IEnumerable<AspNetUsersDto> choferes = new List<AspNetUsersDto>();
    string Message, email;

    protected async override Task OnInitializedAsync()
    {
        if (id > 0) //If no Id has been passed, then it is a new Category
        {
            chofer = await servicioChofer.Obtener(id);
            email = chofer.Email;
        }
        else
        {
            choferes = await servicioChofer.ObtenerTodos();
        }
    }

    public async Task Guardar()
    {
        AspNetUsersDto c = await servicioChofer.ExisteEmail(chofer.Email);
        if (id != 0)
        {
            if ( c ==null|| chofer.Email == email)
            {
                await servicioChofer.Guardar(chofer);
                navigationManager.NavigateTo($"/perfilChofer/{id}");
            }
            else
            {
                Message = "El email ya se encuentra registrado";
                navigationManager.NavigateTo($"/editarChofer/{id}");
            }
        }
        else
        {
            await registrar();
        }
    }

    protected async Task registrar()
    {
        var user = new AspNetUsers
        {
            UserName = chofer.Email,
            Email = chofer.Email,
            Nombre = chofer.Nombre,
            Apellido = chofer.Apellido,
            Dni = chofer.Dni,
            PhoneNumber = chofer.PhoneNumber
        };
        var result = await UserManager.CreateAsync(user, chofer.Clave);
        if (result.Succeeded)
        {
            result = await UserManager.AddToRoleAsync(user, "Chofer");
        }
        navigationManager.NavigateTo($"/Choferes");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioChofer servicioChofer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<AspNetUsers> UserManager { get; set; }
    }
}
namespace __Blazor.Combi19.Ui.Pages.ComponentesChofer.DetallesChofer
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
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591