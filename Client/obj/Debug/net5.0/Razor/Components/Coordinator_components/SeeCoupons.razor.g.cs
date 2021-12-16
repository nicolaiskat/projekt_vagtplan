#pragma checksum "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/SeeCoupons.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e52f9187283338e1e28122e669647f4eb05b5b6b"
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
    public partial class SeeCoupons : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(10, "<div class=\"modal-header\"><h3>Alle kuponer</h3></div>\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-body");
#nullable restore
#line 10 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/SeeCoupons.razor"
                 if (coupons == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/SeeCoupons.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenDataGrid<Coupon>>(14);
            __builder.AddAttribute(15, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/SeeCoupons.razor"
                                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/SeeCoupons.razor"
                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/SeeCoupons.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "FilterCaseSensitivity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 16 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/SeeCoupons.razor"
                                                                                                                        FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Coupon>>(
#nullable restore
#line 17 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/SeeCoupons.razor"
                                           coupons

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Coupon>>(21);
                __builder2.AddAttribute(22, "Property", "coupon_id");
                __builder2.AddAttribute(23, "Title", "ID");
                __builder2.AddAttribute(24, "Width", "70px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Coupon>>(26);
                __builder2.AddAttribute(27, "Property", "description");
                __builder2.AddAttribute(28, "Title", "Beskrivelse");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Coupon>>(30);
                __builder2.AddAttribute(31, "Property", "price");
                __builder2.AddAttribute(32, "Title", "Pris");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 25 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/SeeCoupons.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "modal-footer");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "class", "btn btn-primary");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/SeeCoupons.razor"
                                                                         ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Luk");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Components/Coordinator_components/SeeCoupons.razor"
       

    public Coupon[] coupons;

    protected async override Task OnInitializedAsync()
    {
        coupons = await Http.GetFromJsonAsync<Coupon[]>("api/coupon");
    }

    [Parameter]
    public EventCallback<bool> OnClose { get; set; }


    private Task ModalOk()
    {
        return OnClose.InvokeAsync(true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
