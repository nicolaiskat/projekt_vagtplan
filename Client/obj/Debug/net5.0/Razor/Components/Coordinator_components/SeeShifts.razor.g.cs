#pragma checksum "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b0d9e9d17819d586951ce245c0dae0d440ac514"
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
    public partial class SeeShifts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show ");
            __builder.AddAttribute(2, "id", "myModal");
            __builder.AddAttribute(3, "style", "display:block;");
            __builder.AddAttribute(4, "aria-modal", "true");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog modal-dialog-centered modal-dialog-scrollable ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.AddMarkupContent(10, "<div class=\"modal-header\"><h3>Alle vagter</h3></div>\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-body");
#nullable restore
#line 10 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor"
                 if (shifts == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenDataGrid<Shift>>(14);
            __builder.AddAttribute(15, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor"
                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor"
                                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor"
                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 16 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor"
                                                                                                                FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Shift>>(
#nullable restore
#line 17 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor"
                                                shifts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(21);
                __builder2.AddAttribute(22, "Property", "shift_id");
                __builder2.AddAttribute(23, "Title", "ID");
                __builder2.AddAttribute(24, "Width", "70px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(26);
                __builder2.AddAttribute(27, "Property", "description");
                __builder2.AddAttribute(28, "Title", "Beskrivelse");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(30);
                __builder2.AddAttribute(31, "Property", "start_time");
                __builder2.AddAttribute(32, "Title", "Start tidspunkt");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(34);
                __builder2.AddAttribute(35, "Property", "end_time");
                __builder2.AddAttribute(36, "Title", "Slut tidspunkt");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(38);
                __builder2.AddAttribute(39, "Property", "taken");
                __builder2.AddAttribute(40, "Title", "Er taget");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(42);
                __builder2.AddAttribute(43, "Property", "locked");
                __builder2.AddAttribute(44, "Title", "Låst");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Shift>>(46);
                __builder2.AddAttribute(47, "Property", "locked");
                __builder2.AddAttribute(48, "Title", "Lås/Lås op");
                __builder2.AddAttribute(49, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Shift>)((shift) => (__builder3) => {
#nullable restore
#line 27 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor"
                             if (shift.locked == false)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(50);
                    __builder3.AddAttribute(51, "Icon", "lock_outline");
                    __builder3.AddAttribute(52, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor"
                                                                          args => OnLock(shift)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
#nullable restore
#line 30 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(53);
                    __builder3.AddAttribute(54, "Icon", "lock_open");
                    __builder3.AddAttribute(55, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor"
                                                                       args => OnLock(shift)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
#nullable restore
#line 34 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor"
                            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(56, (__value) => {
#nullable restore
#line 17 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor"
                                   grid = (Radzen.Blazor.RadzenDataGrid<Shift>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 39 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n            ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "modal-footer");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "type", "button");
            __builder.AddAttribute(62, "class", "btn btn-primary");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor"
                                                                         ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(64, "Luk");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/SeeShifts.razor"
       

    public List<Shift> shifts;
    public RadzenDataGrid<Shift> grid;

    protected async override Task OnInitializedAsync()
    {
        shifts = await Http.GetFromJsonAsync<List<Shift>>("api/shift");
    }

    [Parameter]
    public EventCallback<bool> OnClose { get; set; }


    private Task ModalOk()
    {
        return OnClose.InvokeAsync(true);
    }

    async void OnLock(Shift s)
    {
        await Http.PostAsJsonAsync($"api/method/lockshift", s);
        if (s.locked == false)
        {
            s.locked = true;
        }
        else if (s.locked == true)
        {
            s.locked = false;
        };
        await grid.Reload();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
