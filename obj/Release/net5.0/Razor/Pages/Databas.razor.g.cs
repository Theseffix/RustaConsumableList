#pragma checksum "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a88d41819f348898660e6b556e0382a1574ba99f"
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
#line 2 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
using RustaConsumerList.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
using Blazority;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
using RustaConsumerList.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
using RustaConsumerList.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DB")]
    public partial class Databas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div style=\"height:60px\"></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "padding-left:12px;padding-right:12px;");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(3);
            __builder.AddAttribute(4, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 19 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                         OnInputFileChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "multiple", true);
            __builder.CloseComponent();
#nullable restore
#line 20 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
     if (Error) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Fel med filen. ");
            __builder.AddContent(8, 
#nullable restore
#line 20 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                     ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                                      }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "<br>");
#nullable restore
#line 22 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
     if (!spinner && !NoFile) {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazority.Button>(10);
            __builder.AddAttribute(11, "Variant", "Primary");
            __builder.AddAttribute(12, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                                                   Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                                                                     () => AddProducts()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(15, "Skapa");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 22 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                                                                                                         }
    else if (spinner || Error || NoFile){

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazority.Button>(16);
            __builder.AddAttribute(17, "Variant", "Primary");
            __builder.AddAttribute(18, "Disabled", true);
            __builder.AddAttribute(19, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                                                                      () => AddProducts()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(21, "Skapa");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 23 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                                                                                                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
     if (spinner) {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazority.Spinner>(22);
            __builder.AddAttribute(23, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazority.SpinnerSize>(
#nullable restore
#line 25 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                   SpinnerSize.Small

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddContent(24, " ");
            __builder.OpenElement(25, "h4");
            __builder.AddContent(26, 
#nullable restore
#line 25 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                                                      Done

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, "/");
            __builder.AddContent(28, 
#nullable restore
#line 25 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                                                            ProductsToDo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, " klart.");
            __builder.CloseElement();
#nullable restore
#line 25 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                                                                                    }
    else if (Success) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<h4>Success!</h4>");
#nullable restore
#line 26 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                         }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "<br>\r\n\r\n    ");
            __Blazor.RustaConsumerList.Pages.Databas.TypeInference.CreateDatagrid_0(__builder, 32, 33, 
#nullable restore
#line 29 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                     Products

#line default
#line hidden
#nullable disable
            , 34, 
#nullable restore
#line 29 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                        u => u.Category

#line default
#line hidden
#nullable disable
            , 35, 
#nullable restore
#line 29 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                                                  true

#line default
#line hidden
#nullable disable
            , 36, (__builder2) => {
                __builder2.OpenComponent<Blazority.DatagridColumn<ConsumptionProduct>>(37);
                __builder2.AddAttribute(38, "Title", "Article Number");
                __builder2.AddAttribute(39, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<ConsumptionProduct, System.Object>>>(
#nullable restore
#line 30 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                                                                    c => c.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "CanSort", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.OpenComponent<Blazority.DatagridColumn<ConsumptionProduct>>(42);
                __builder2.AddAttribute(43, "Title", "Article Name");
                __builder2.AddAttribute(44, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<ConsumptionProduct, System.Object>>>(
#nullable restore
#line 31 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                                                                  c => c.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "CanSort", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
                                                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\repos\Rusta\RustaConsumerList\Pages\Databas.razor"
 

    public List<ConsumptionProduct> Products = new();
    private List<ConsumptionProduct> NewExcelList = new();
    private List<ConsumptionProduct> ProductsToRemove = new();
    private List<ConsumptionProduct> ProductsToAdd = new();
    private List<ConsumptionProduct> ProductsToUpdate = new();

    bool Error = false;
    bool spinner = false;
    bool Success = false;
    bool NoFile = true;

    int Done { get; set; }
    int ProductsToDo { get; set; }

    string ErrorMessage { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Products = (await ConItemDb.Get()).ToList();
        this.StateHasChanged();
    }

    string Message = "No file selected";
    IReadOnlyList<IBrowserFile> selectedFiles;

    async void OnInputFileChange(InputFileChangeEventArgs e)
    {
        Error = false;
        spinner = false;
        Success = false;
        NoFile = false;

        selectedFiles = e.GetMultipleFiles();
        Message = $"{selectedFiles.Count} file selected";
        try
        {
            await PreviewList();
        }
        catch (Exception ex)
        {
            Error = true;
            ErrorMessage = ex.ToString();
        }
        this.StateHasChanged();
    }

    public async Task PreviewList()
    {
        if (selectedFiles != null)
        {
            foreach (var file in selectedFiles)
            {
                //Beh??vs f??r filstorlek
                Stream stream = file.OpenReadStream(10140555, default);
                var path = $"{env.WebRootPath}\\db.xlsx";
                FileStream fs = File.Create(path);
                await stream.CopyToAsync(fs);
                stream.Close();
                fs.Close();
            }

            ConsumptionProduct excelProduct = new();
            NewExcelList = excelProduct.MassImportProducts();

            if(NewExcelList.Count() <= 0)
            {
                Error = true;
            }
            else
            {
                Products = new();
                Products = (await ConItemDb.Get()).ToList();

                ProductsToRemove = Products.Where(aItem => NewExcelList.All(bItem => aItem.Id != bItem.Id)).ToList();
                Products.RemoveAll(aItem => NewExcelList.All(bItem => aItem.Id != bItem.Id));
                Products.ForEach(aItem => { aItem.Name = NewExcelList.First(bItem => aItem.Id == bItem.Id).Name; aItem.Category = NewExcelList.First(bItem => aItem.Id == bItem.Id).Category;});
                ProductsToAdd = NewExcelList.Where(bItem => Products.All(aItem => aItem.Id != bItem.Id)).ToList();
                Products.AddRange(NewExcelList.Where(bItem => Products.All(aItem => aItem.Id != bItem.Id)));

            }
        }
    }

    public async Task AddProducts()
    {
        spinner = true;
        Success = false;

        ProductsToDo = ProductsToRemove.Count() + ProductsToAdd.Count() + Products.Count();
        Done = 0;

        foreach (var p in ProductsToRemove)
        {
            await ConItemDb.Delete(p.Id);
            Done++;
            this.StateHasChanged();
        }

        foreach(var p in Products)
        {
            await ConItemDb.Update(p);
            Done++;
            this.StateHasChanged();
        }

        foreach (var p in ProductsToAdd)
        {
            await ConItemDb.Insert(p);
            Done++;
            this.StateHasChanged();
        }


        Products = new();
        Products = (await ConItemDb.Get()).ToList();
        spinner = false;
        Success = true;
        selectedFiles = null;
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ConsItemService ConItemDb { get; set; }
    }
}
namespace __Blazor.RustaConsumerList.Pages.Databas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDatagrid_0<TRowData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.ICollection<TRowData> __arg0, int __seq1, global::System.Func<TRowData, global::System.Object> __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Blazority.Datagrid<TRowData>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "GroupBy", __arg1);
        __builder.AddAttribute(__seq2, "Compact", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
