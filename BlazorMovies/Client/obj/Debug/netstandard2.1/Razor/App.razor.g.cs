#pragma checksum "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6192934de8e46eafc2349d63f8e539f4bfb3a71b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 1 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(4);
                __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 3 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\App.razor"
                                        routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 3 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\App.razor"
                                                                   typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n                ");
                    __builder3.AddMarkupContent(9, "<text> Custom Authorizing...</text>\r\n            ");
                }
                ));
                __builder2.AddAttribute(10, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n                ");
                    __builder3.AddMarkupContent(12, "<text>Custom Not Authorized...</text>\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
            }
            ));
            __builder.AddAttribute(14, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(16);
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(18, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(19);
                    __builder3.AddAttribute(20, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 14 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(22, "\r\n                ");
                        __builder4.OpenComponent<BlazorMovies.Client.Shared.CustomNotFound>(23);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(24, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
