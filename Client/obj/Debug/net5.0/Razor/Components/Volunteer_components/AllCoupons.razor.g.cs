#pragma checksum "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cb69739363109430f197981eea761ca3ea5b8a0"
// <auto-generated/>
#pragma warning disable 1591
namespace vagtplanen.Client.Components.Volunteer_components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/_Imports.razor"
using vagtplanen.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/_Imports.razor"
using vagtplanen.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class AllCoupons : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(10, "<div class=\"modal-header\"><h3>Alle kuponer</h3></div>\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-body");
            __builder.OpenElement(13, "h2");
            __builder.AddContent(14, "Du har ");
            __builder.AddContent(15, 
#nullable restore
#line 11 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor"
                            vol.points

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " point");
            __builder.CloseElement();
#nullable restore
#line 12 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor"
                 if (coupons == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<p><em>Loading...</em></p>");
#nullable restore
#line 15 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(18);
            __builder.AddAttribute(19, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor"
                                      vol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Coupon>>(21);
                __builder2.AddAttribute(22, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor"
                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor"
                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor"
                                                                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 19 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor"
                                                                                                                            FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Coupon>>(
#nullable restore
#line 20 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor"
                                               coupons

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Coupon>>(28);
                    __builder3.AddAttribute(29, "Property", "description");
                    __builder3.AddAttribute(30, "Title", "Beskrivelse");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n                                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Coupon>>(32);
                    __builder3.AddAttribute(33, "Property", "price");
                    __builder3.AddAttribute(34, "Title", "Pris p?? kupon (point)");
                    __builder3.AddAttribute(35, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 23 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor"
                                                                                                                               TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\n                                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Coupon>>(37);
                    __builder3.AddAttribute(38, "Property", "coupon_id");
                    __builder3.AddAttribute(39, "Title", "K??b");
                    __builder3.AddAttribute(40, "Width", "60px");
                    __builder3.AddAttribute(41, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor"
                                                                                                                               false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor"
                                                                                                                                                false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Coupon>)((coupon) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(44);
                        __builder4.AddAttribute(45, "Icon", "add_shopping_cart");
                        __builder4.AddAttribute(46, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor"
                                                                                       args => OnBuy(coupon)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 32 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "modal-footer");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "type", "button");
            __builder.AddAttribute(52, "class", "btn btn-primary");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor"
                                                                         ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Luk");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AllCoupons.razor"
       

    public List<Coupon> coupons;

    [Parameter]
    public Volunteer vol { get; set; }

    protected async override Task OnInitializedAsync()
    {
        coupons = await Http.GetFromJsonAsync<List<Coupon>>("api/coupon");
    }

    [Parameter]
    public EventCallback<bool> OnClose { get; set; }


    private Task ModalOk()
    {
        return OnClose.InvokeAsync(true);
    }

    async void OnBuy(Coupon coupon)
    {
        if (vol.points >= coupon.price)
        {
            bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Du er ved at k??be en kupon. Tryk OK for at bekr??fte.");
            if (confirmed)
            {
                vol.coupons.Add(coupon);
                await Http.PostAsJsonAsync($"api/method/buycoupon/{vol.volunteer_id}", coupon);
                await JsRuntime.InvokeVoidAsync("alert", "Kuponen er nu tilf??jet til mine kuponer");
            }
            await JsRuntime.InvokeVoidAsync("alert", "Du har annulleret dette k??b.");
        }
        else
        {
            await JsRuntime.InvokeVoidAsync("alert", "Du har ikke nok point til denne kupon.");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
