#pragma checksum "C:\Users\jbomh\source\repos\BlazorHostingSwap\BlazorHostingSwap.Shared\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28414dcd6c12b9eb776aebfefd2b35058b127d1e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorHostingSwap.Shared.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\jbomh\source\repos\BlazorHostingSwap\BlazorHostingSwap.Shared\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\jbomh\source\repos\BlazorHostingSwap\BlazorHostingSwap.Shared\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\jbomh\source\repos\BlazorHostingSwap\BlazorHostingSwap.Shared\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "C:\Users\jbomh\source\repos\BlazorHostingSwap\BlazorHostingSwap.Shared\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\jbomh\source\repos\BlazorHostingSwap\BlazorHostingSwap.Shared\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\jbomh\source\repos\BlazorHostingSwap\BlazorHostingSwap.Shared\_Imports.razor"
using BlazorHostingSwap.Shared.Shared;

#line default
#line hidden
#line 2 "C:\Users\jbomh\source\repos\BlazorHostingSwap\BlazorHostingSwap.Shared\Pages\FetchData.razor"
using BlazorHostingSwap.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 38 "C:\Users\jbomh\source\repos\BlazorHostingSwap\BlazorHostingSwap.Shared\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("weatherforecast");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
