#pragma checksum "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/CreateTeamtask.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de8167463de8c4ecc0f8160d08d8e54faad82051"
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
#nullable restore
#line 3 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/CreateTeamtask.razor"
using vagtplanen.Shared.Models;

#line default
#line hidden
#nullable disable
    public partial class CreateTeamtask : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(12, "<h3>Opret teamopgave</h3>\n                ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "close");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/CreateTeamtask.razor"
                                                               ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "??");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(21);
            __builder.AddAttribute(22, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/CreateTeamtask.razor"
                                      createTT

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(24);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(26);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n                        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.OpenElement(30, "div");
                __builder2.AddMarkupContent(31, "<label>Beskrivelse:</label>\n                                ");
                __builder2.OpenElement(32, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/CreateTeamtask.razor"
                                                             createTT.description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => createTT.description = __value, createTT.description))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => createTT.description));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\n                         ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.OpenElement(40, "div");
                __builder2.AddMarkupContent(41, "<label>Antal personer:</label>\n                                ");
                __builder2.OpenElement(42, "div");
                __Blazor.vagtplanen.Client.Components.Coordinator_components.CreateTeamtask.TypeInference.CreateInputNumber_0(__builder2, 43, 44, 
#nullable restore
#line 29 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/CreateTeamtask.razor"
                                                               createTT.people_needed

#line default
#line hidden
#nullable disable
                , 45, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => createTT.people_needed = __value, createTT.people_needed)), 46, () => createTT.people_needed);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\n                         ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group");
                __builder2.OpenElement(50, "div");
                __builder2.AddMarkupContent(51, "<label>Vagt startdato:</label>\n                                ");
                __builder2.OpenElement(52, "div");
                __builder2.OpenElement(53, "input");
                __builder2.AddAttribute(54, "type", "date");
                __builder2.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/CreateTeamtask.razor"
                                                               startdate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => startdate = __value, startdate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\n                        ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddMarkupContent(60, "<label>Vagt starttid:</label>\n                            ");
                __builder2.OpenElement(61, "div");
                __builder2.OpenElement(62, "input");
                __builder2.AddAttribute(63, "type", "time");
                __builder2.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/CreateTeamtask.razor"
                                                           starttime

#line default
#line hidden
#nullable disable
                , format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => starttime = __value, starttime, format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\n                        ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __builder2.OpenElement(69, "div");
                __builder2.AddMarkupContent(70, "<label>Vagt slutdato:</label>\n                                ");
                __builder2.OpenElement(71, "div");
                __builder2.OpenElement(72, "input");
                __builder2.AddAttribute(73, "type", "date");
                __builder2.AddAttribute(74, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/CreateTeamtask.razor"
                                                               enddate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(75, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => enddate = __value, enddate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\n                        ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group");
                __builder2.OpenElement(79, "div");
                __builder2.AddMarkupContent(80, "<label>Vagt sluttid:</label>\n                                ");
                __builder2.OpenElement(81, "div");
                __builder2.OpenElement(82, "input");
                __builder2.AddAttribute(83, "type", "time");
                __builder2.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/CreateTeamtask.razor"
                                                               endtime

#line default
#line hidden
#nullable disable
                , format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => endtime = __value, endtime, format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\n            ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "modal-footer");
            __builder.OpenElement(89, "button");
            __builder.AddAttribute(90, "type", "button");
            __builder.AddAttribute(91, "class", "btn btn-success");
            __builder.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/CreateTeamtask.razor"
                                                                         ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(93, "Opret");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "/Users/andreasskovaagaard/Dropbox/EAAA/IT-Arkitektur/Kode/2. Semester Eksamen/projekt_vagtplan/Client/Components/Coordinator_components/CreateTeamtask.razor"
       


    public static TeamTask createTT = new();
   


    public DateTime startdate = DateTime.Now;
    public DateTime starttime = DateTime.Now;

    public DateTime enddate = DateTime.Now;
    public DateTime endtime = DateTime.Now;


    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    private Task ModalCancel()
    {
        return OnClose.InvokeAsync(false);
    }

    private async Task ModalOk()
    {
        DateTime start = startdate.Date.Add(starttime.TimeOfDay);
        createTT.start_time = start;

        DateTime end = enddate.Date.Add(endtime.TimeOfDay);
        createTT.end_time = end;

        await Http.PostAsJsonAsync("api/teamtask", createTT);

        await JsRuntime.InvokeVoidAsync("alert", "Bekr??ftelse. Teamopgaven er oprettet.");


        await OnClose.InvokeAsync(true);
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.vagtplanen.Client.Components.Coordinator_components.CreateTeamtask
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
