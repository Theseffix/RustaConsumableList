#pragma checksum "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beb218a315a06890945b131c1dcdd73328b006c8"
// <auto-generated/>
#pragma warning disable 1591
namespace RustaConsumerList.Pages
{
    #line hidden
    using System;
#nullable restore
#line 1 "D:\repos\Rusta\RustaConsumerList\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\Rusta\RustaConsumerList\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\Rusta\RustaConsumerList\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos\Rusta\RustaConsumerList\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos\Rusta\RustaConsumerList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repos\Rusta\RustaConsumerList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repos\Rusta\RustaConsumerList\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repos\Rusta\RustaConsumerList\_Imports.razor"
using RustaConsumerList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\repos\Rusta\RustaConsumerList\_Imports.razor"
using RustaConsumerList.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
using RustaConsumerList.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
using Blazority;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
using RustaConsumerList.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
using RustaConsumerList.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class ItemList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div style=\"height:60px\"></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "width:100%");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "width:95%;");
            __builder.AddMarkupContent(5, "<br>");
#nullable restore
#line 20 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
         if (!CategoryClicked)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
             foreach (string Category in Categories)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "background-color:lightgray;min-width:150px;min-height:200px;width:15%;float:left;margin-left:2%;margin-top:2%");
            __builder.AddMarkupContent(8, "<img src=\"~/images/ImageMissing.png\" alt=\"Image Missing\" style=\"margin-left:auto;margin-right:auto;margin-top:6px;display:block;\">\r\n                    ");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, 
#nullable restore
#line 26 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                        Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                      () => DivClicked(Category)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, 
#nullable restore
#line 27 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                                                   Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
         if (CategoryClicked)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
             foreach (var item in AllItems)
            {
                if (item.Category == CatChoise)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "style", "background-color:lightgray;min-width:150px;min-height:200px;width:15%;float:left;margin-left:2%;margin-top:2%");
            __builder.AddMarkupContent(17, "<img src=\"~/images/ImageMissing.png\" alt=\"Image Missing\" style=\"margin-left:auto;margin-right:auto;margin-top:6px;display:block;\">\r\n                        ");
            __builder.OpenElement(18, "p");
            __builder.AddContent(19, 
#nullable restore
#line 40 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                            item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
      
    protected override async Task OnInitializedAsync()
    {
        AllItems = (await ConItemDb.GetItems()).ToList();
        foreach (var item in AllItems)
        {
            if (!Categories.Contains(item.Category))
            {
                Categories.Add(item.Category);
            }
        }
        this.StateHasChanged();
    }

    #region Categorys
    public List<ConsumptionProduct> AllItems = new List<ConsumptionProduct>();
    public static List<string> Categories = new List<string>();

    public static bool CategoryClicked = false;

    public static string CatChoise = "";

    private async Task DivClicked(string Category)
    {
        CategoryClicked = true;
        CatChoise = Category;
    }
    #endregion


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ConsItemService ConItemDb { get; set; }
    }
}
#pragma warning restore 1591
