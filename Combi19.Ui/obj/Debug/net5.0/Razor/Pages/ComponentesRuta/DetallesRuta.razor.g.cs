#pragma checksum "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4017dd0af833b29f89717fcc3f78916aedcf56f"
// <auto-generated/>
#pragma warning disable 1591
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
#line 8 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/añadirRuta")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/editarRuta/{id:int}")]
    public partial class DetallesRuta : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(8, "<div class=\"modal-header\"><h1>Datos de ruta</h1></div>\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                  ruta

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
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
                __builder2.AddMarkupContent(20, "<td>Origen</td>\r\n                            ");
                __builder2.OpenElement(21, "td");
                __Blazor.Combi19.Ui.Pages.ComponentesRuta.DetallesRuta.TypeInference.CreateInputSelect_0(__builder2, 22, 23, "form-control col-sm-12", 24, 
#nullable restore
#line 23 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                                                                          ruta.IdCiudad1

#line default
#line hidden
#nullable disable
                , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ruta.IdCiudad1 = __value, ruta.IdCiudad1)), 26, () => ruta.IdCiudad1, 27, (__builder3) => {
#nullable restore
#line 24 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                     if (ciudades.Count() > 0)
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(28, "<option value>Seleccione la ciudad de origen</option>");
#nullable restore
#line 27 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                         foreach (Ciudad item in ciudades)
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(29, "option");
                    __builder3.AddAttribute(30, "value", 
#nullable restore
#line 29 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                                            item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(31, 
#nullable restore
#line 29 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                                                      item.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 30 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                         
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(32, "<option disabled>No hay ciudades en el sistema</option>");
#nullable restore
#line 35 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                        ");
                __builder2.OpenElement(34, "tr");
                __builder2.AddMarkupContent(35, "<td>Destino</td>\r\n                            ");
                __builder2.OpenElement(36, "td");
                __Blazor.Combi19.Ui.Pages.ComponentesRuta.DetallesRuta.TypeInference.CreateInputSelect_1(__builder2, 37, 38, "form-control col-sm-12", 39, 
#nullable restore
#line 42 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                                                                          ruta.IdCiudad2

#line default
#line hidden
#nullable disable
                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ruta.IdCiudad2 = __value, ruta.IdCiudad2)), 41, () => ruta.IdCiudad2, 42, (__builder3) => {
#nullable restore
#line 43 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                     if (ciudades.Count() > 0)
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(43, "<option value>Seleccione la ciudad de destino</option>");
#nullable restore
#line 46 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                         foreach (Ciudad item in ciudades)
                                        {
                                            if (ruta.IdCiudad1 != item.Id)
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(44, "option");
                    __builder3.AddAttribute(45, "value", 
#nullable restore
#line 50 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                                                item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(46, 
#nullable restore
#line 50 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                                                          item.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 51 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                            }
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                         
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(47, "<option disabled>No hay ciudades en el sistema</option>");
#nullable restore
#line 57 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.OpenElement(49, "tr");
                __builder2.AddMarkupContent(50, "<td>Distancia</td>\r\n                            ");
                __builder2.OpenElement(51, "td");
                __builder2.OpenElement(52, "input");
                __builder2.AddAttribute(53, "type", "number");
                __builder2.AddAttribute(54, "step", "0.01");
                __builder2.AddAttribute(55, "min", "1");
                __builder2.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                                                                ruta.Km

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ruta.Km = __value, ruta.Km, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                            ");
                __builder2.OpenElement(59, "td");
                __builder2.AddAttribute(60, "colspan", "2");
                __Blazor.Combi19.Ui.Pages.ComponentesRuta.DetallesRuta.TypeInference.CreateValidationMessage_2(__builder2, 61, 62, 
#nullable restore
#line 64 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                                                        () => ruta.Km

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.OpenElement(64, "tr");
                __builder2.AddMarkupContent(65, "<td>Hora de Salida</td>\r\n                            ");
                __builder2.OpenElement(66, "td");
                __builder2.OpenElement(67, "input");
                __builder2.AddAttribute(68, "type", "time");
                __builder2.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                                                ruta.HsSalida

#line default
#line hidden
#nullable disable
                , format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ruta.HsSalida = __value, ruta.HsSalida, format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                            ");
                __builder2.OpenElement(72, "td");
                __builder2.AddAttribute(73, "colspan", "2");
                __Blazor.Combi19.Ui.Pages.ComponentesRuta.DetallesRuta.TypeInference.CreateValidationMessage_3(__builder2, 74, 75, 
#nullable restore
#line 69 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                                                        () => ruta.HsSalida

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                        ");
                __builder2.OpenElement(77, "tr");
                __builder2.AddMarkupContent(78, "<td>Combi</td>\r\n                            ");
                __builder2.OpenElement(79, "td");
                __Blazor.Combi19.Ui.Pages.ComponentesRuta.DetallesRuta.TypeInference.CreateInputSelect_4(__builder2, 80, 81, "form-control col-sm-9", 82, 
#nullable restore
#line 74 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                                                                         ruta.IdCombi

#line default
#line hidden
#nullable disable
                , 83, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ruta.IdCombi = __value, ruta.IdCombi)), 84, () => ruta.IdCombi, 85, (__builder3) => {
#nullable restore
#line 75 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                     if (combies.Count() > 0)
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(86, "<option value>Seleccione una combi</option>");
#nullable restore
#line 78 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                         foreach (Combi item in combies)
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(87, "option");
                    __builder3.AddAttribute(88, "value", 
#nullable restore
#line 80 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                                            item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(89, 
#nullable restore
#line 80 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                                                      item.Modelo

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(90, " ");
                    __builder3.AddContent(91, 
#nullable restore
#line 80 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                                                                   item.Patente

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 81 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                         
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(92, "<option disabled>No hay combis en el sistema</option>");
#nullable restore
#line 86 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                            ");
                __builder2.OpenElement(94, "td");
                __builder2.AddAttribute(95, "colspan", "2");
                __Blazor.Combi19.Ui.Pages.ComponentesRuta.DetallesRuta.TypeInference.CreateValidationMessage_5(__builder2, 96, 97, 
#nullable restore
#line 89 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                                                        () => ruta.IdCombi

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                        ");
                __builder2.OpenElement(99, "tr");
                __builder2.OpenElement(100, "td");
                __builder2.AddAttribute(101, "colspan", "2");
                __builder2.AddAttribute(102, "style", "text-align:center");
                __builder2.AddMarkupContent(103, "<button type=\"submit\" class=\"btn btn-outline-primary\" value=\"Guardar\">Guardar</button>\r\n                                ");
                __builder2.OpenElement(104, "button");
                __builder2.AddAttribute(105, "type", "button");
                __builder2.AddAttribute(106, "class", "btn btn-outline-secondary");
                __builder2.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 94 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                                                                                  Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(108, "Cancelar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                        ");
                __builder2.OpenElement(110, "h6");
                __builder2.AddAttribute(111, "style", "color:red");
                __builder2.AddContent(112, 
#nullable restore
#line 97 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
                                               Message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(113, "\r\n                <div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "D:\DiscoDuro\Facultad Cursando\IngSoft2\ASP-NET\Proyecto\Combi19.Ui\Pages\ComponentesRuta\DetallesRuta.razor"
        [Parameter]
    public int id { get; set; }

    //string horasalida;

    Ruta ruta = new Ruta();
    Ciudad c1 = new Ciudad();
    Ciudad c2 = new Ciudad();
    DateTime hora = new DateTime();
    Combi combi = new Combi();

    private IEnumerable<Ciudad> ciudades = new List<Ciudad>();
    private IEnumerable<Combi> combies = new List<Combi>();
    private IEnumerable<Ruta> rutas = new List<Ruta>();
    private Provincia provincia = new Provincia();
    string Message;

    protected async override Task OnInitializedAsync()
    {
        ciudades = await servicioCiudad.ObtenerTodos();
        combies = await servicioCombi.ObtenerTodos();
        rutas = await servicioRuta.ObtenerTodos();
        if (id > 0) //If no Id has been passed, then it is a new Category
        {
            ruta = await servicioRuta.Obtener(id);
            hora = ruta.HsSalida;
            c1 = await servicioCiudad.Obtener(ruta.IdCiudad1);
            c2 = await servicioCiudad.Obtener(ruta.IdCiudad2);
            combi = await servicioCombi.Obtener(ruta.IdCombi);

        }
    }

    public async Task<bool> existe(int id1, int id2, DateTime hora, int idC)
    { 
    Ruta r = await servicioRuta.Obtener(id1, id2, hora, idC);
   
        return  r != null;
    }

    public async Task Guardar()
    {
        bool hayRuta = await existe(ruta.IdCiudad1, ruta.IdCiudad2, ruta.HsSalida, ruta.IdCombi);
        if (combi.Id > 0)
            combi.Patente = combi.Patente.ToUpper();
        if (c1.Id == ruta.IdCiudad1 && c2.Id == ruta.IdCiudad2 && combi.Id == ruta.IdCombi && hora.ToString("HH:mm") == ruta.HsSalida.ToString("HH:mm") || !hayRuta)
        {
            await servicioRuta.Guardar(ruta);
            if (ruta.Id == 0)
                navigationManager.NavigateTo("/rutas");
            else
                navigationManager.NavigateTo($"/perfilRuta/{ruta.Id}");
        }
        else
        {
            Message = "La ruta ya existe";
            navigationManager.NavigateTo($"/editarRuta/{id}");
        }
    }


    public void Cancelar()
    {
        navigationManager.NavigateTo("/rutas");
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioCombi servicioCombi { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioProvincia servicioProvincia { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioCiudad servicioCiudad { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioRuta servicioRuta { get; set; }
    }
}
namespace __Blazor.Combi19.Ui.Pages.ComponentesRuta.DetallesRuta
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
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
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
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