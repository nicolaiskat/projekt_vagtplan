#pragma checksum "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/Components/Team_components/AvailableTeamtasks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d094c276c91c875565993647ad4856538542f10"
// <auto-generated/>
#pragma warning disable 1591
namespace vagtplanen.Client.Components.Team_components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/_Imports.razor"
using vagtplanen.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/_Imports.razor"
using vagtplanen.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/Components/Team_components/AvailableTeamtasks.razor"
using vagtplanen.Shared.Models;

#line default
#line hidden
#nullable disable
    public partial class AvailableTeamtasks : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(10, "<div class=\"modal-header\"><h3>Alle ledige teamopgaver</h3></div>\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-body");
#nullable restore
#line 12 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/Components/Team_components/AvailableTeamtasks.razor"
                 if (tasks == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<p>Loading...</p>");
#nullable restore
#line 15 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/Components/Team_components/AvailableTeamtasks.razor"
                }
            else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(14);
            __builder.AddAttribute(15, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/Components/Team_components/AvailableTeamtasks.razor"
                              tea

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<TeamTask>>(17);
                __builder2.AddAttribute(18, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/Components/Team_components/AvailableTeamtasks.razor"
                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/Components/Team_components/AvailableTeamtasks.razor"
                                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/Components/Team_components/AvailableTeamtasks.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "FilterCaseSensitivity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 19 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/Components/Team_components/AvailableTeamtasks.razor"
                                                                                                                    FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<TeamTask>>(
#nullable restore
#line 20 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/Components/Team_components/AvailableTeamtasks.razor"
                                                   tasks.Where(x => x.locked == false && x.taken == false && x.start_time.Ticks > DateTime.Now.Ticks)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<TeamTask>>(24);
                    __builder3.AddAttribute(25, "Property", "description");
                    __builder3.AddAttribute(26, "Title", "Beskrivelse");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<TeamTask>>(28);
                    __builder3.AddAttribute(29, "Property", "start_time");
                    __builder3.AddAttribute(30, "Title", "Starttidspunkt");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<TeamTask>>(32);
                    __builder3.AddAttribute(33, "Property", "end_time");
                    __builder3.AddAttribute(34, "Title", "Sluttidspunkt");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<TeamTask>>(36);
                    __builder3.AddAttribute(37, "Property", "people_needed");
                    __builder3.AddAttribute(38, "Title", "Personer");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<TeamTask>>(40);
                    __builder3.AddAttribute(41, "Property", "locked");
                    __builder3.AddAttribute(42, "Title", "Tag opgave");
                    __builder3.AddAttribute(43, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TeamTask>)((task) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(44);
                        __builder4.AddAttribute(45, "Icon", "check_circle");
                        __builder4.AddAttribute(46, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/Components/Team_components/AvailableTeamtasks.razor"
                                                                          args => OnTake(task)

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
                __builder2.AddComponentReferenceCapture(47, (__value) => {
#nullable restore
#line 20 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/Components/Team_components/AvailableTeamtasks.razor"
                                      grid = (Radzen.Blazor.RadzenDataGrid<TeamTask>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 34 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/Components/Team_components/AvailableTeamtasks.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "modal-footer");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "class", "btn btn-primary");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/Components/Team_components/AvailableTeamtasks.razor"
                                                                         ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(55, "Luk");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "/Users/nicolaiskat/Projects/LetsGoGreenRepo/projekt_vagtplan/Client/Components/Team_components/AvailableTeamtasks.razor"
       
    public List<TeamTask> tasks = new();
    public RadzenDataGrid<TeamTask> grid;
    public TeamTask takenTask = new();
    public TaskClass task = new();

    protected async override Task OnInitializedAsync()
    {
        tasks = await Http.GetFromJsonAsync<List<TeamTask>>("api/teamtask");
    }

    [Parameter]
    public EventCallback<(bool, TeamTask)> OnClose { get; set; }

    [Parameter]
    public Team tea { get; set; }


    private Task ModalOk()
    {
        return OnClose.InvokeAsync((true, takenTask));
    }

    async void OnTake(TeamTask task)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Du er ved at tage en teamopgave. Tryk OK for at bekræfte.");
        if (confirmed)
        {
            task.taken = true;
            takenTask = task;
            takenTask.team = tea;
            await Http.PostAsJsonAsync($"api/method/assignteamtask", takenTask);
            await grid.Reload();
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
