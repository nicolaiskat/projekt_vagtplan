// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class AvailableShifts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Volunteer_components/AvailableShifts.razor"
       

    public List<Shift> shifts;

    [Parameter] public Volunteer vol { get; set; }
    RadzenDataGrid<Shift> grid;

    protected async override Task OnInitializedAsync()
    {
        shifts = await Http.GetFromJsonAsync<List<Shift>>("api/shift");
    }

    public List<Shift> Available()
    {
        var allShifts = shifts;
        var myShifts = vol.shifts;

        List<Shift> availableShifts = new List<Shift>();

        bool available = true;

        foreach (Shift shift in allShifts)
        {
            foreach (Shift myShift in myShifts)
            {
                if (shift.start_time.Ticks <= myShift.start_time.Ticks && shift.end_time.Ticks >= myShift.start_time.Ticks)
                {
                    available = false;
                }
                if (shift.start_time.Ticks <= myShift.end_time.Ticks && shift.end_time.Ticks >= myShift.end_time.Ticks)
                {
                    available = false;
                }
            }
            if (available)
            {
                availableShifts.Add(shift);
            }
            else
            {
                available = true;
            }
        }
        return availableShifts.Where(x => x.taken == false && (x.start_time.Ticks >= DateTime.Now.Ticks)).ToList();
    }

    [Parameter]
    public EventCallback<(bool, Shift)> OnClose { get; set; }

    public Shift takenShift;

    private Task ModalOk()
    {
        return OnClose.InvokeAsync((false, new Shift()));
    }

    async void OnTake(Shift s)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Du er ved at tage en vagt. Tryk OK for at bekræfte.");
        if (confirmed)
        {
            shifts.Remove(s);
            s.taken = true;
            takenShift = s;
            takenShift.volunteer = vol;
            await Http.PostAsJsonAsync($"api/method/assignshift", takenShift);
            await grid.Reload();
            await OnClose.InvokeAsync((true, takenShift));
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
