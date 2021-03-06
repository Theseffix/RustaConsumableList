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
#line 2 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList - Copy.razor"
using RustaConsumerList.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList - Copy.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList - Copy.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList - Copy.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList - Copy.razor"
using Blazority;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList - Copy.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList - Copy.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList - Copy.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList - Copy.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList - Copy.razor"
using RustaConsumerList.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList - Copy.razor"
using RustaConsumerList.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class ItemList___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList - Copy.razor"
      
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

    #region ExcelModalRegion

    public bool ExcelModal { get; set; }

    string Message = "No file selected";

    private ExcelModel model = new ExcelModel();
    IReadOnlyList<IBrowserFile> selectedFiles;

    public class ExcelModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }

    public void ExcelButtonClick()
    {
        ExcelModal = true;
        this.StateHasChanged();
    }

    async void OnInputFileChange(InputFileChangeEventArgs e)
    {

        selectedFiles = e.GetMultipleFiles();
        Message = $"{selectedFiles.Count} file selected";
        try
        {
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        this.StateHasChanged();
    }
    #endregion


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ConsItemService ConItemDb { get; set; }
    }
}
#pragma warning restore 1591
