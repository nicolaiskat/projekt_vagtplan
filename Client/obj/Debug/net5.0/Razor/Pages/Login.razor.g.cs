#pragma checksum "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10233bcb0fff6f789223bfec5bafbe5e0574f4f1"
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
#line 2 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
using vagtplanen.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
 if (page_access == -1)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "login");
            __builder.AddMarkupContent(2, "<h1>Login her</h1>\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(3);
            __builder.AddAttribute(4, "class", "w-1");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.vagtplanen.Client.Pages.Login.TypeInference.CreateRadzenTemplateForm_0(__builder2, 6, 7, 
#nullable restore
#line 12 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
                                       "SimpleLogin"

#line default
#line hidden
#nullable disable
                , 8, (context) => (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLogin>(9);
                    __builder3.AddAttribute(10, "AllowRegister", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
                                            false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "AllowResetPassword", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
                                                                       false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Login", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoginArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoginArgs>(this, 
#nullable restore
#line 13 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
                                                                                      args => OnLogin(args)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(13, "Style", "margin-bottom: 20px;");
                    __builder3.CloseComponent();
#nullable restore
#line 14 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
                 if (isLoading)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<BlazorPro.Spinkit.Chase>(14);
                    __builder3.CloseComponent();
#nullable restore
#line 15 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
                          }

#line default
#line hidden
#nullable disable
                }
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 19 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"

}
else if (page_access == 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Pages.VolunteerPage>(15);
            __builder.AddAttribute(16, "vol", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Volunteer>(
#nullable restore
#line 23 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
                         vol

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 24 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
}
else if (page_access == 10)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Pages.CoordinatorPage>(17);
            __builder.AddAttribute(18, "coor", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Coordinator>(
#nullable restore
#line 27 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
                            coor

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 28 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
}
else if (page_access == 1)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<vagtplanen.Client.Pages.TeamPage>(19);
            __builder.AddAttribute(20, "tea", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<vagtplanen.Shared.Models.Team>(
#nullable restore
#line 31 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
                    tea

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 32 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "/Users/nicolaiskat/Projects/linen/projekt_vagtplan/Client/Pages/Login.razor"
       
    public int page_access = -1;
    public bool isLoading = false;

    public Volunteer vol = new();
    public Coordinator coor = new();
    public Team tea = new();

    async Task OnLogin(LoginArgs args)
    {
        isLoading = true;
        try
        {
            int res = await Http.GetFromJsonAsync<int>($"api/method/login/{args.Username}/{args.Password}");
            if (res == 0)
            {
                vol = await Http.GetFromJsonAsync<Volunteer>($"api/volunteer/{args.Username}");
                page_access = vol.access;
                isLoading = false;
            }
            else if (res == 10)
            {
                coor = await Http.GetFromJsonAsync<Coordinator>($"api/coordinator/{args.Username}");
                page_access = coor.access;
                isLoading = false;
            }
            else if (res == 1)
            {
                tea = await Http.GetFromJsonAsync<Team>($"api/team/{args.Username}");
                page_access = tea.access;
                isLoading = false;
            }
        }
        catch (Exception e)
        {
            isLoading = false;
            Console.WriteLine(e.Message);
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.vagtplanen.Client.Pages.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenTemplateForm_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TItem __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext> __arg1)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenTemplateForm<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
