#pragma checksum "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Shared\Rating.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5729256911ebbdcd24d051e59ee9cb68933ff84d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    public partial class Rating : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Shared\Rating.razor"
 for (int i = 1; i <= MaximumRating; i++)
{
    var starNumber = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "span");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Shared\Rating.razor"
                  () => onclickHandle(starNumber)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Shared\Rating.razor"
                      () => onmouseoverHandle(starNumber)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "style", "cursor:pointer;");
            __builder.AddAttribute(4, "class", "fa" + " fa-star" + " " + (
#nullable restore
#line 9 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Shared\Rating.razor"
                          SelectedRating >= i ? "checked" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\n\n");
            __builder.CloseElement();
#nullable restore
#line 11 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Shared\Rating.razor"
       }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Shared\Rating.razor"
        [Parameter] public int MaximumRating { get; set; }
    [Parameter] public int SelectedRating { get; set; }
    [Parameter] public EventCallback<int> OnVote { get; set; }
    [CascadingParameter] public Task<AuthenticationState> AuthenticationState { get; set; }

    private bool voted = false;

    private async Task onclickHandle(int starNumber)
    {
        var authState = await AuthenticationState;
        var user = authState.User;

        if (!user.Identity.IsAuthenticated)
        {
            //await displayMessage.DisplayErrorMessage("You must login in order to vote");
            return;
        }

        SelectedRating = starNumber;
        voted = true;
        await OnVote.InvokeAsync(SelectedRating);
    }

    private void onmouseoverHandle(int starNumber)
    {
        if (!voted)
        {
            SelectedRating = starNumber;
        }
    } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
