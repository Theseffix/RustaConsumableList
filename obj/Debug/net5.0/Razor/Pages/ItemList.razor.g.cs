#pragma checksum "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed745d430c734bd9bd099ed0f7fbd8be1084e14d"
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
            __builder.AddMarkupContent(0, "<link href=\"/css/RustaStyleSheet.css\" rel=\"stylesheet\" type=\"text/css\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "position:fixed;z-index:99;min-width:165px;height:50px;");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                                                              () => HomeDiv_Click()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n<div style=\"height:60px\"></div>\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "style", "width:90%;margin-left:auto;margin-right:auto");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "style", "width:100%;");
            __builder.AddMarkupContent(9, "<br>");
#nullable restore
#line 25 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
         if (!CategoryClicked)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
             foreach (string Category in Categories)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "DivSize hoverOutline");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                                            () => DivClicked(Category)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "<img class=\"imageSize\" src=\"/images/ImageMissing.png\" alt=\"Image Missing\" asp-append-version=\"true\">\r\n                    ");
            __builder.OpenElement(14, "p");
            __builder.AddAttribute(15, "class", "limit");
            __builder.AddContent(16, 
#nullable restore
#line 31 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                      Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
         if (CategoryClicked)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "textbox");
            __builder.AddContent(18, 
#nullable restore
#line 38 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                      TestDouble

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 39 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
            RowList = new();

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
             foreach (var item in AllItems)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                 if (NewRow == 7)
                {
                    NewRow = 0;
                    BoolList.Add(true);



#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "DropDownSize");
            __builder.AddAttribute(21, "hidden", 
#nullable restore
#line 49 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                                       BoolList[NewRowId]

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "style", "padding-left:6px;padding-right:6px;");
            __builder.OpenComponent<Blazority.Tabs>(24);
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazority.Tab>(26);
                __builder2.AddAttribute(27, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(28, "Produktinformation");
                }
                ));
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(30, "p");
                    __builder3.AddContent(31, 
#nullable restore
#line 55 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                            ProductId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(32, "\r\n                                        ");
                    __builder3.OpenElement(33, "p");
                    __builder3.AddContent(34, 
#nullable restore
#line 56 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                            ProductName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(35, "\r\n                                        <br>\r\n                                        ");
                    __builder3.AddMarkupContent(36, "<p>\r\n                                            H??r kommer det produktbeskrivning... bla bla bla.\r\n                                        </p>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                                ");
                __builder2.OpenComponent<Blazority.Tab>(38);
                __builder2.AddAttribute(39, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(40, "Bilder");
                }
                ));
                __builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 66 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                         foreach (var image in ProductImages)
                                        {
                                            if(image.ConProdId == LastClickedDivId)
                                            {
                                                string img = ConvertImageToDisplay(image.Image);

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(42, "img");
                    __builder3.AddAttribute(43, "class", "ProductImageSize");
                    __builder3.AddAttribute(44, "src", 
#nullable restore
#line 71 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                                                                    img

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(45, "alt", 
#nullable restore
#line 71 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                                                                               image.ConProd

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(46, "asp-append-version", "true");
                    __builder3.CloseElement();
#nullable restore
#line 72 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                            }
                                        }

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "class", "drag-drop-zone");
                    __builder3.OpenComponent<BlazorInputFile.InputFile>(49);
                    __builder3.AddAttribute(50, "accept", "image/png,image/gif,image/jpeg");
                    __builder3.AddAttribute(51, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 75 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                                                                                                         HandleSelection

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n                                ");
                __builder2.OpenComponent<Blazority.Tab>(53);
                __builder2.AddAttribute(54, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(55, "Kommentarer(0)");
                }
                ));
                __builder2.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(57, "<p>H??r kommer ett forum f??r kommentarer</p>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 86 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                    NewRowId++;
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                 

                if (item.Category == CatChoise)
                {
                    NewRow++;
                    RowList.Add(NewRowId);
                    item.DynamicRow = NewRowId;

                    if (item.Id == LastClickedDivId)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "DivSize hoverOutline");
            __builder.AddAttribute(60, "style", "outline: 2px solid gray");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                                                                                    e => Div_Click(item.DynamicRow, item.Id, item.Name)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(62, "<img class=\"imageSize\" src=\"/images/ImageMissing.png\" alt=\"Image Missing\">\r\n                            ");
            __builder.OpenElement(63, "p");
            __builder.AddAttribute(64, "class", "limit");
            __builder.AddContent(65, 
#nullable restore
#line 99 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                              item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                            ");
            __builder.OpenElement(67, "p");
            __builder.AddAttribute(68, "class", "limit");
            __builder.AddContent(69, 
#nullable restore
#line 100 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                              item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 102 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "DivSize hoverOutline");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 105 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                                                    e => Div_Click(item.DynamicRow, item.Id, item.Name)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(73, "<img class=\"imageSize\" src=\"/images/ImageMissing.png\" alt=\"Image Missing\">\r\n                            ");
            __builder.OpenElement(74, "p");
            __builder.AddAttribute(75, "class", "limit");
            __builder.AddContent(76, 
#nullable restore
#line 107 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                              item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                            ");
            __builder.OpenElement(78, "p");
            __builder.AddAttribute(79, "class", "limit");
            __builder.AddContent(80, 
#nullable restore
#line 108 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                              item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 110 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                    }

                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
             

            NewRow = 0;
            BoolList.Add(true);



#line default
#line hidden
#nullable disable
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "DropDownSize");
            __builder.AddAttribute(83, "hidden", 
#nullable restore
#line 119 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                                               BoolList[NewRowId]

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(84, "p");
            __builder.AddContent(85, 
#nullable restore
#line 120 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
                    BoolList[NewRowId]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 122 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"

            NewRowId = 0;
            NewRow = 0;
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "D:\repos\Rusta\RustaConsumerList\Pages\ItemList.razor"
 

    public double ProductId { get; set; }
    public string ProductName { get; set; }

    public string TestDouble { get; set; }
    public string Image { get; set; }
    public string Status { get; set; }
    public int NewRow { get; set; }
    public int NewRowId = 0;
    public double LastClickedDivId = 0;
    public bool showit = false;
    public bool ImageUploadDisabled = false;
    public List<bool> BoolList { get; set; }
    public List<int> RowList { get; set; }
    public List<ProductImage> ProductImages = new();

    protected override async Task OnInitializedAsync()
    {
        BoolList = new();
        RowList = new();
        NewRow = 0;
        NewRowId = 0;
        AllItems = (await ConItemDb.GetItems()).ToList();
        ProductImages = (await ConItemDb.GetImages()).ToList();
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
                if (i != RowId)
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
        ImageUploadDisabled = true;
        if (files != null)
        {
            foreach (var f in files)
            {
                ProductImage PI = new();

                var ms = new MemoryStream();
                await f.Data.CopyToAsync(ms);

                PI.ConProdId = LastClickedDivId;
                PI.Image = ms.ToArray();
                await ConItemDb.InsertImageToItem(PI, LastClickedDivId);
            }
            ProductImages = (await ConItemDb.GetImages()).ToList();
            this.StateHasChanged();
        }
        ImageUploadDisabled = false;
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

    public string ConvertImageToDisplay(byte[] Image)
    {
        if (Image != null)
        {
            var base64 = Convert.ToBase64String(Image);
            var fs = string.Format("data:image/jpg;base64,{0}", base64);
            return fs;
        }

        return "";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ConsItemService ConItemDb { get; set; }
    }
}
#pragma warning restore 1591
