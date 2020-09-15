#pragma checksum "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\Books\IndexBooks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cdac80d01c9ec12285dd844f1dd502df5d8076f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.Books
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/books")]
    public partial class IndexBooks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Index Books</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\">\r\n    <a class=\"btn btn-info\" href=\"Book/create\">New Book</a>\r\n</div>\r\n\r\n");
            __Blazor.BlazorMovies.Client.Pages.Books.IndexBooks.TypeInference.CreateGenericList_0(__builder, 2, 3, 
#nullable restore
#line 10 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\Books\IndexBooks.razor"
                   Books

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenElement(6, "table");
                __builder2.AddAttribute(7, "class", "table table-striped");
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.AddMarkupContent(9, "<thead>\r\n                <tr>\r\n                    <th>Name</th>\r\n                </tr>\r\n            </thead>\r\n            ");
                __builder2.OpenElement(10, "tbody");
                __builder2.AddMarkupContent(11, "\r\n");
#nullable restore
#line 19 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\Books\IndexBooks.razor"
                 foreach (var item in Books)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(12, "                    ");
                __builder2.OpenElement(13, "tr");
                __builder2.AddMarkupContent(14, "\r\n                        ");
                __builder2.OpenElement(15, "td");
                __builder2.AddMarkupContent(16, "\r\n                            ");
                __builder2.AddContent(17, 
#nullable restore
#line 23 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\Books\IndexBooks.razor"
                             item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n");
#nullable restore
#line 26 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\Books\IndexBooks.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(21, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\Books\IndexBooks.razor"
       
    List<Book> Books;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Books = await BookRepository.GetBooks();
        }
        catch (Exception)
        {

            throw;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookRepository BookRepository { get; set; }
    }
}
namespace __Blazor.BlazorMovies.Client.Pages.Books.IndexBooks
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::BlazorMovies.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "WholeListTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591