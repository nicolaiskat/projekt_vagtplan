#pragma checksum "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8504adaecf698b738b691b12beaf3510a1be05fd"
// <auto-generated/>
#pragma warning disable 1591
namespace vagtplanen.Client.Components.Coordinator_components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using vagtplanen.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using vagtplanen.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class CoordinatorInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show");
            __builder.AddAttribute(2, "id", "myModal");
            __builder.AddAttribute(3, "style", "display:block;");
            __builder.AddAttribute(4, "aria-modal", "true");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog modal-dialog-centered modal-dialog-scrollable");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.AddMarkupContent(12, "<h3>Her kan du rette i dine oplysninger.</h3>\r\n                ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "close");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                                               ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "×");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(21);
            __builder.AddAttribute(22, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                  coor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(24);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group ");
                __builder2.AddMarkupContent(28, "<h5>Du vil automatisk blive logget ud, når du gemmer dine nye oplysninger.</h5>\r\n                        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddMarkupContent(30, "<label>Fornavn:</label>\r\n                            ");
                __builder2.OpenElement(31, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                                         coor.first_name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => coor.first_name = __value, coor.first_name))));
                __builder2.AddAttribute(35, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => coor.first_name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n                                ");
                __Blazor.vagtplanen.Client.Components.Coordinator_components.CoordinatorInfo.TypeInference.CreateValidationMessage_0(__builder2, 37, 38, 
#nullable restore
#line 20 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                                          () => coor.first_name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group ");
                __builder2.OpenElement(42, "div");
                __builder2.AddMarkupContent(43, "<label>Efternavn:</label>\r\n                            ");
                __builder2.OpenElement(44, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                                         coor.last_name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => coor.last_name = __value, coor.last_name))));
                __builder2.AddAttribute(48, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => coor.last_name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n                                ");
                __Blazor.vagtplanen.Client.Components.Coordinator_components.CoordinatorInfo.TypeInference.CreateValidationMessage_1(__builder2, 50, 51, 
#nullable restore
#line 29 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                                          () => coor.last_name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group ");
                __builder2.OpenElement(55, "div");
                __builder2.AddMarkupContent(56, "<label>Mobilnummer:</label>\r\n                            ");
                __builder2.OpenElement(57, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                                         coor.mobile

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => coor.mobile = __value, coor.mobile))));
                __builder2.AddAttribute(61, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => coor.mobile));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n                                ");
                __Blazor.vagtplanen.Client.Components.Coordinator_components.CoordinatorInfo.TypeInference.CreateValidationMessage_2(__builder2, 63, 64, 
#nullable restore
#line 38 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                                          () => coor.mobile

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                    ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group ");
                __builder2.OpenElement(68, "div");
                __builder2.AddMarkupContent(69, "<label>Email:</label>\r\n                            ");
                __builder2.OpenElement(70, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(71);
                __builder2.AddAttribute(72, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                                         coor.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => coor.email = __value, coor.email))));
                __builder2.AddAttribute(74, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => coor.email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n                                ");
                __Blazor.vagtplanen.Client.Components.Coordinator_components.CoordinatorInfo.TypeInference.CreateValidationMessage_3(__builder2, 76, 77, 
#nullable restore
#line 47 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                                          () => coor.email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                    ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group ");
                __builder2.OpenElement(81, "div");
                __builder2.AddMarkupContent(82, "<label>Adresse:</label>\r\n                            ");
                __builder2.OpenElement(83, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(84);
                __builder2.AddAttribute(85, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                                         coor.address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => coor.address = __value, coor.address))));
                __builder2.AddAttribute(87, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => coor.address));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n                                ");
                __Blazor.vagtplanen.Client.Components.Coordinator_components.CoordinatorInfo.TypeInference.CreateValidationMessage_4(__builder2, 89, 90, 
#nullable restore
#line 56 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                                          () => coor.address

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                    ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "form-group ");
                __builder2.OpenElement(94, "div");
                __builder2.AddMarkupContent(95, "<label>CPR-nummer:</label>\r\n                            ");
                __builder2.OpenElement(96, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(97);
                __builder2.AddAttribute(98, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                                         coor.cpr

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => coor.cpr = __value, coor.cpr))));
                __builder2.AddAttribute(100, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => coor.cpr));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\r\n                                ");
                __Blazor.vagtplanen.Client.Components.Coordinator_components.CoordinatorInfo.TypeInference.CreateValidationMessage_5(__builder2, 102, 103, 
#nullable restore
#line 65 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                                          () => coor.cpr

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n                    ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "form-group ");
                __builder2.OpenElement(107, "div");
                __builder2.AddMarkupContent(108, "<label>Køn:</label>\r\n                            ");
                __builder2.OpenElement(109, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(110);
                __builder2.AddAttribute(111, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                                         coor.gender

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(112, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => coor.gender = __value, coor.gender))));
                __builder2.AddAttribute(113, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => coor.gender));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(114, "\r\n                                ");
                __Blazor.vagtplanen.Client.Components.Coordinator_components.CoordinatorInfo.TypeInference.CreateValidationMessage_6(__builder2, 115, 116, 
#nullable restore
#line 74 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                                          () => coor.gender

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n            ");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "class", "modal-footer");
            __builder.OpenElement(120, "button");
            __builder.AddAttribute(121, "type", "button");
            __builder.AddAttribute(122, "class", "btn btn-primary");
            __builder.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
                                                                         ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(124, "Gem");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/CoordinatorInfo.razor"
       

    [Parameter]
    public Coordinator coor { get; set; }

    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    private Task ModalCancel()
    {
        return OnClose.InvokeAsync(false);
    }

    private async Task ModalOk()
    {
        await Http.PutAsJsonAsync<Coordinator>("api/coordinator", coor);
        await OnClose.InvokeAsync(true);
        Reload();
    }


    public void Reload()
    {
        uriHelper.NavigateTo(uriHelper.Uri, forceLoad: true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.vagtplanen.Client.Components.Coordinator_components.CoordinatorInfo
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
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
