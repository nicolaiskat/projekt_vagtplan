#pragma checksum "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ebe8d7dadf68f14634543b20864f599bfdc2376"
// <auto-generated/>
#pragma warning disable 1591
namespace vagtplanen.Client.Pages
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
#nullable restore
#line 1 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
using vagtplanen.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
using vagtplanen.Client.Components.Volunteer_components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
using vagtplanen.Client.Components.Team_components;

#line default
#line hidden
#nullable disable
    public partial class TeamPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row px-3");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "type", "button");
            __builder.AddAttribute(4, "class", "btn btn-primary");
            __builder.AddAttribute(5, "id", "right");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                                                        ReloadPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Log ud");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                  tea

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(12, "h1");
                __builder2.AddContent(13, "Velkommen ");
#nullable restore
#line 13 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
__builder2.AddContent(14, tea.name);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(16);
                __builder2.AddAttribute(17, "class", "w-6");
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(19, "div");
                    __builder3.AddAttribute(20, "class", "row");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(21);
                    __builder3.AddAttribute(22, "class", "w-7");
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(24, "div");
                        __builder4.AddAttribute(25, "class", "row");
                        __builder4.AddMarkupContent(26, "<div class=\"col-md-10\"><b>Ledige vagter:</b>\r\n                        <div>Her kan du se og vælge tilgængelige ledige vagter.</div></div>\r\n                    ");
                        __builder4.OpenElement(27, "div");
                        __builder4.AddAttribute(28, "class", "col-md-6");
                        __builder4.OpenElement(29, "button");
                        __builder4.AddAttribute(30, "class", "btn btn-success");
                        __builder4.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                                                  () => OpenAvailableTeamtasksDialog()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(32, "Se vagter");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(34);
                    __builder3.AddAttribute(35, "class", "w-7");
                    __builder3.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(37, "div");
                        __builder4.AddAttribute(38, "class", "row");
                        __builder4.AddMarkupContent(39, "<div class=\"col-md-10\"><b>Personlige oplysninger:</b>\r\n                        <div>Her kan du se og ændre dine personlige oplysninger.</div></div>\r\n                    ");
                        __builder4.OpenElement(40, "div");
                        __builder4.AddAttribute(41, "class", "col-md-6");
                        __builder4.OpenElement(42, "button");
                        __builder4.AddAttribute(43, "class", "btn btn-success");
                        __builder4.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                                                  () => OpenTeamInfoDialog()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(45, "Se oplysninger");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n\r\n     ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "teamtask");
#nullable restore
#line 43 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
         if (teamtask == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(49, "<p><em>...Loading teamtask</em></p>");
#nullable restore
#line 44 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                            }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(50, "<h2>Teamets vagter</h2>\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<TeamTask>>(51);
                __builder2.AddAttribute(52, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                                                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "FilterCaseSensitivity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 48 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                                                                                                            FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<TeamTask>>(
#nullable restore
#line 49 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                    teamtask.Where(x => (x.end_time.Ticks > DateTime.Now.Ticks) && (x.team.team_id == tea.team_id))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "class", "vagter-ting");
                __builder2.AddAttribute(58, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<TeamTask>>(59);
                    __builder3.AddAttribute(60, "Property", "teamtask.description");
                    __builder3.AddAttribute(61, "Title", "Beskrivelse");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<TeamTask>>(63);
                    __builder3.AddAttribute(64, "Property", "start_time");
                    __builder3.AddAttribute(65, "Title", "Start tidspunkt");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<TeamTask>>(67);
                    __builder3.AddAttribute(68, "Property", "end_time");
                    __builder3.AddAttribute(69, "Title", "Slut tidspunkt");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<TeamTask>>(71);
                    __builder3.AddAttribute(72, "Property", "teamtask_id");
                    __builder3.AddAttribute(73, "Title", "Frigiv vagt");
                    __builder3.AddAttribute(74, "Width", "85px");
                    __builder3.AddAttribute(75, "Filterable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                                                                                                               false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "Sortable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                                                                                                                                false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(77, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TeamTask>)((teamtask) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(78);
                        __builder4.AddAttribute(79, "Icon", "delete_forever");
                        __builder4.AddAttribute(80, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                                                        args => OnRelease(teamtask)

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
                __builder2.AddComponentReferenceCapture(81, (__value) => {
#nullable restore
#line 48 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                  grid = (Radzen.Blazor.RadzenDataGrid<TeamTask>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
#nullable restore
#line 61 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 67 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
 if (AvailableTeamtasksDialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Components.Team_components.AvailableTeamtasks>(82);
            __builder.AddAttribute(83, "tea", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<vagtplanen.Shared.Models.Team>(
#nullable restore
#line 69 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                              tea

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<(System.Boolean, vagtplanen.Shared.Models.TeamTask)>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<(System.Boolean, vagtplanen.Shared.Models.TeamTask)>(this, 
#nullable restore
#line 69 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                              (args)=> OnAvailableTeamtasksDialogClose(args.Item1,args.Item2)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 70 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
 if (TeamInfoDialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Components.Team_components.TeamInfo>(85);
            __builder.AddAttribute(86, "tea", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<vagtplanen.Shared.Models.Team>(
#nullable restore
#line 74 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                    tea

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 74 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
                                   OnTeamInfoDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 75 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/TeamPage.razor"
       

    [Parameter] public Team tea { get; set; }
    RadzenDataGrid<TeamTask> grid;
    public List<TeamTask> teamtask;

    protected override async Task OnInitializedAsync()
    {
        teamtask = await Http.GetFromJsonAsync<List<TeamTask>>("api/teamtask");
    }


    // Kode til Available Teamtasks Modal Dialog
    public bool AvailableTeamtasksDialogOpen { get; set; }

    public void OpenAvailableTeamtasksDialog()
    {
        AvailableTeamtasksDialogOpen = true;
        StateHasChanged();
    }

    public void OnAvailableTeamtasksDialogClose(bool accepted, TeamTask task)
    {
        teamtask.Add(task);
        tea.teamtasks.Add(task);
        grid.Reload();
        AvailableTeamtasksDialogOpen = false;
        StateHasChanged();
    }

    // Kode til TeamInfo Modal Dialog
    public bool TeamInfoDialogOpen { get; set; }

    public void OpenTeamInfoDialog()
    {
        TeamInfoDialogOpen = true;
        StateHasChanged();
    }

    public void OnTeamInfoDialogClose(bool accepted)
    {
        TeamInfoDialogOpen = false;
        StateHasChanged();
    }
    public async void OnRelease(TeamTask tt)
    {
        teamtask.Remove(tt);
        tt.team = tea;
        await Http.PostAsJsonAsync<TeamTask>("api/method/deassignteamtask", tt);
        tt.taken = false;
        tt.team = new Team();
        await grid.Reload();
    }
    public void ReloadPage()
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
#pragma warning restore 1591
