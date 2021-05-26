// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
using RustaConsumerList.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
      

    public double ProductId { get; set; }
    public string ProductName { get; set; }

    public string TestDouble { get; set; }
    public string Image { get; set; }
    public string Status { get; set; }
    public int NewRow { get; set; }
    public int NewRowId = 0;
    public double LastClickedDivId = 0;
    public bool showit = false;
    public List<bool> BoolList { get; set; }
    public List<int> RowList { get; set; }

    protected override async Task OnInitializedAsync()
    {
        BoolList = new();
        RowList = new();
        NewRow = 0;
        NewRowId = 0;
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

    public void HomeDiv_Click()
    {
        CategoryClicked = false;
        BoolList = new();
        this.StateHasChanged();
    }

    public void Div_Click(int RowId, double DivId, string DivName)
    {
        if (BoolList.Contains(false))
        {
            for (int i = 0; i < BoolList.Count(); i++)
            {
                if(i != RowId)
                {
                    BoolList[i] = true;
                }
            }
        }
        if (LastClickedDivId == DivId)
        {
            BoolList[RowId] = !BoolList[RowId];
        }
        else
        {
            BoolList[RowId] = false;
            LastClickedDivId = DivId;
            ProductId = DivId;
            ProductName = DivName;
        }
        StateHasChanged();
    }

    async Task HandleSelection(IFileListEntry[] files)
    {
        if (files != null)
        {
            foreach(var f in files)
            {
                ProductImage PI = new();

                var ms = new MemoryStream();
                await f.Data.CopyToAsync(ms);

                PI.Image = ms.ToArray();
                await ConItemDb.InsertImageToItem(PI, LastClickedDivId);
            }

            Status = $" {files.Count()} filer.";
        }
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
