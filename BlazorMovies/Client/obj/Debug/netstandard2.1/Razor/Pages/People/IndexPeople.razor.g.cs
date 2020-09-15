#pragma checksum "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\People\IndexPeople.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "431d5b891439757f1cd7b764b99cd2f5077b1e2a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.People
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
#nullable restore
#line 3 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\People\IndexPeople.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/people")]
    public partial class IndexPeople : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Index People</h3>\n\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\">\n    <a class=\"btn btn-info\" href=\"person/create\">New Person</a>\n</div>\n\n");
            __builder.OpenComponent<BlazorMovies.Client.Shared.Pagination>(2);
            __builder.AddAttribute(3, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\People\IndexPeople.razor"
                          paginationDTO.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\People\IndexPeople.razor"
                                                                totalAmountPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 12 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\People\IndexPeople.razor"
                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n\n");
            __Blazor.BlazorMovies.Client.Pages.People.IndexPeople.TypeInference.CreateGenericList_0(__builder, 7, 8, 
#nullable restore
#line 14 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\People\IndexPeople.razor"
                   People

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.OpenElement(11, "table");
                __builder2.AddAttribute(12, "class", "table table-striped");
                __builder2.AddMarkupContent(13, "\n            ");
                __builder2.AddMarkupContent(14, "<thead>\n                <tr>\n                    <th>Name</th>\n                    <th></th>\n                </tr>\n            </thead>\n            ");
                __builder2.OpenElement(15, "tbody");
                __builder2.AddMarkupContent(16, "\n");
#nullable restore
#line 24 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\People\IndexPeople.razor"
                 foreach (var item in People)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(17, "tr");
                __builder2.AddMarkupContent(18, "\n    ");
                __builder2.OpenElement(19, "td");
                __builder2.AddMarkupContent(20, "\n        ");
                __builder2.AddContent(21, 
#nullable restore
#line 28 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\People\IndexPeople.razor"
         item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(22, "\n\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n    ");
                __builder2.OpenElement(24, "td");
                __builder2.AddMarkupContent(25, "\n        ");
                __builder2.OpenElement(26, "a");
                __builder2.AddAttribute(27, "class", "btn btn-success");
                __builder2.AddAttribute(28, "href", "/person/edit/" + (
#nullable restore
#line 32 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\People\IndexPeople.razor"
                                                       item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(29, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n        ");
                __builder2.OpenElement(31, "button");
                __builder2.AddAttribute(32, "class", "btn btn-danger");
                __builder2.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\People\IndexPeople.razor"
                                                   () => DeletePerson(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(34, "Delete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\n");
#nullable restore
#line 36 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\People\IndexPeople.razor"
}

#line default
#line hidden
#nullable disable
                __builder2.AddContent(38, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n    ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\SVU\ATH\Projects\BlazorMovies7\BlazorMovies\Client\Pages\People\IndexPeople.razor"
        List<Person> People;
    PaginationDTO paginationDTO = new PaginationDTO() { RecordsPerPage = 3 };
    private int totalAmountPages;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await LoadPeople();
        }
        catch (Exception ex)
        {

        }
    }

    private async Task LoadPeople()
    {
        var paginatedResponse = await personRepository.GetPeople(paginationDTO);
        People = paginatedResponse.Response;
        totalAmountPages = paginatedResponse.TotalAmountPages;
    }

    private async Task SelectedPage(int page)
    {
        paginationDTO.Page = page;
        await LoadPeople();
    }

    private async Task DeletePerson(int id)
    {
        await personRepository.DeletePerson(id);
        await LoadPeople();
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonRepository personRepository { get; set; }
    }
}
namespace __Blazor.BlazorMovies.Client.Pages.People.IndexPeople
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