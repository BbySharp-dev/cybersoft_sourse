// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Wallet.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\DELL\Downloads\Documents\CPS\DOTNET_01\Upload_file\Exercise_Buoi28\Wallet\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\DELL\Downloads\Documents\CPS\DOTNET_01\Upload_file\Exercise_Buoi28\Wallet\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\DELL\Downloads\Documents\CPS\DOTNET_01\Upload_file\Exercise_Buoi28\Wallet\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\DELL\Downloads\Documents\CPS\DOTNET_01\Upload_file\Exercise_Buoi28\Wallet\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\DELL\Downloads\Documents\CPS\DOTNET_01\Upload_file\Exercise_Buoi28\Wallet\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\DELL\Downloads\Documents\CPS\DOTNET_01\Upload_file\Exercise_Buoi28\Wallet\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\DELL\Downloads\Documents\CPS\DOTNET_01\Upload_file\Exercise_Buoi28\Wallet\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\DELL\Downloads\Documents\CPS\DOTNET_01\Upload_file\Exercise_Buoi28\Wallet\_Imports.razor"
using Wallet

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\DELL\Downloads\Documents\CPS\DOTNET_01\Upload_file\Exercise_Buoi28\Wallet\_Imports.razor"
using Wallet.Shared

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\DELL\Downloads\Documents\CPS\DOTNET_01\Upload_file\Exercise_Buoi28\Wallet\Pages\FetchData.razor"
 using Wallet.Data

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\DELL\Downloads\Documents\CPS\DOTNET_01\Upload_file\Exercise_Buoi28\Wallet\Pages\FetchData.razor"
      "/fetchdata"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class FetchData : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\DELL\Downloads\Documents\CPS\DOTNET_01\Upload_file\Exercise_Buoi28\Wallet\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 4 "C:\Users\DELL\Downloads\Documents\CPS\DOTNET_01\Upload_file\Exercise_Buoi28\Wallet\Pages\FetchData.razor"
        WeatherForecastService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "C:\Users\DELL\Downloads\Documents\CPS\DOTNET_01\Upload_file\Exercise_Buoi28\Wallet\Pages\FetchData.razor"
                               ForecastService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
