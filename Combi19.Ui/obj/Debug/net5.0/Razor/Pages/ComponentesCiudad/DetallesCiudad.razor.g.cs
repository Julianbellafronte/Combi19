#pragma checksum "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb3f6591bebd9f2869fc8d7ab3e8edc2f48474a8"
// <auto-generated/>
#pragma warning disable 1591
namespace Combi19.Ui.Pages.ComponentesCiudad
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
#line 6 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/añadirCiudad")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/editarCiudad/{id:int}")]
    public partial class DetallesCiudad : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(8, "<div class=\"modal-header\"><h1>Datos de ciudad</h1></div>\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor"
                                  ciudad

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor"
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
#line 20 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor"
                                                          ciudad.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ciudad.Nombre = __value, ciudad.Nombre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __builder2.OpenElement(27, "td");
                __builder2.AddAttribute(28, "colspan", "2");
                __Blazor.Combi19.Ui.Pages.ComponentesCiudad.DetallesCiudad.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 21 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor"
                                                                        () => ciudad.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __builder2.OpenElement(32, "tr");
                __builder2.AddMarkupContent(33, "<td>Codigo Postal</td>\r\n                            ");
                __builder2.OpenElement(34, "td");
                __builder2.OpenElement(35, "input");
                __builder2.AddAttribute(36, "type", "text");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor"
                                                          ciudad.CodigoPostal

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ciudad.CodigoPostal = __value, ciudad.CodigoPostal));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddContent(39, " ");
                __builder2.OpenElement(40, "h6");
                __builder2.OpenElement(41, "text");
                __builder2.AddAttribute(42, "style", "color:red");
                __builder2.AddContent(43, 
#nullable restore
#line 25 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor"
                                                                                                               Message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                            ");
                __builder2.OpenElement(45, "td");
                __builder2.AddAttribute(46, "colspan", "2");
                __Blazor.Combi19.Ui.Pages.ComponentesCiudad.DetallesCiudad.TypeInference.CreateValidationMessage_1(__builder2, 47, 48, 
#nullable restore
#line 26 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor"
                                                                        () => ciudad.CodigoPostal

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                        ");
                __builder2.OpenElement(50, "tr");
                __builder2.AddMarkupContent(51, "<td>Provincia</td>\r\n                            ");
                __builder2.OpenElement(52, "td");
                __Blazor.Combi19.Ui.Pages.ComponentesCiudad.DetallesCiudad.TypeInference.CreateInputSelect_2(__builder2, 53, 54, "form-control col-sm-10", 55, 
#nullable restore
#line 31 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor"
                                                                                          ciudad.IdProvincia

#line default
#line hidden
#nullable disable
                , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ciudad.IdProvincia = __value, ciudad.IdProvincia)), 57, () => ciudad.IdProvincia, 58, (__builder3) => {
                    __builder3.AddMarkupContent(59, "<option value>Seleccione una provincia</option>");
#nullable restore
#line 33 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor"
                                     foreach (Provincia item in provincias)
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(60, "option");
                    __builder3.AddAttribute(61, "value", 
#nullable restore
#line 35 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor"
                                                        item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(62, 
#nullable restore
#line 35 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor"
                                                                  item.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 36 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor"
                                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                            ");
                __builder2.OpenElement(64, "td");
                __builder2.AddAttribute(65, "colspan", "2");
                __Blazor.Combi19.Ui.Pages.ComponentesCiudad.DetallesCiudad.TypeInference.CreateValidationMessage_3(__builder2, 66, 67, 
#nullable restore
#line 39 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor"
                                                                        () => ciudad.IdProvincia

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                        ");
                __builder2.OpenElement(69, "tr");
                __builder2.OpenElement(70, "td");
                __builder2.AddAttribute(71, "colspan", "2");
                __builder2.AddAttribute(72, "style", "text-align:center");
                __builder2.AddMarkupContent(73, "<button type=\"submit\" class=\"btn btn-outline-primary\" value=\"Guardar\">Guardar</button>\r\n                                ");
                __builder2.OpenElement(74, "button");
                __builder2.AddAttribute(75, "type", "button");
                __builder2.AddAttribute(76, "class", "btn btn-outline-secondary");
                __builder2.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor"
                                                                                                  Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(78, "Cancelar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(79, "\r\n                <div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesCiudad\DetallesCiudad.razor"
       
    [Parameter]
    public int id { get; set; }
    private IEnumerable<Provincia> provincias = new List<Provincia>();
    private IEnumerable<Ciudad> ciudades = new List<Ciudad>();
    Ciudad ciudad = new Ciudad();
    string codigoOriginal = "";
    public string Message { get; set; } = "";


    protected async override Task OnInitializedAsync()
    {
        try
        {
            provincias = await servicioProvincia.ObtenerTodos();
            ciudades = await servicioCiudad.ObtenerTodos();
        }
        catch (Exception ex)
        {
            Message = "Algo salio mal... " + ex.Message;
        }

        if (id > 0) //If no Id has been passed, then it is a new Category
        {
            ciudad = await servicioCiudad.Obtener(id);
            codigoOriginal = ciudad.CodigoPostal;
        }
    }

    public bool existe(string codigo)
    {
        foreach (Ciudad ciudad in ciudades)
        {
            if (ciudad.CodigoPostal.ToUpper() == codigo.ToUpper())
                return true;
        }
        return false;
    }

    public async Task Guardar()
    {

        if (codigoOriginal.ToUpper() == ciudad.CodigoPostal.ToUpper() || !existe(ciudad.CodigoPostal))
        {
            await servicioCiudad.Guardar(ciudad);
            if (ciudad.Id == 0)
                navigationManager.NavigateTo("/ciudades");
            else
            {
                navigationManager.NavigateTo($"/perfiLCiudad/{ciudad.Id}");
            }
        }
        else
        {
            Message = "La ciudad ya existe";
            navigationManager.NavigateTo($"/editarCiudad/{id}");
        }

    }

    public void Cancelar()
    {
        navigationManager.NavigateTo("/ciudades");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioCiudad servicioCiudad { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioProvincia servicioProvincia { get; set; }
    }
}
namespace __Blazor.Combi19.Ui.Pages.ComponentesCiudad.DetallesCiudad
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
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
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