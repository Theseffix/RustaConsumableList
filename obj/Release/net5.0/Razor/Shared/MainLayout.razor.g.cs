#pragma checksum "D:\repos\Rusta\RustaConsumerList\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c53662073b49cb1ea03aaa91d827d46b3ed2709"
// <auto-generated/>
#pragma warning disable 1591
namespace RustaConsumerList.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 4 "D:\repos\Rusta\RustaConsumerList\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

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
#line 1 "D:\repos\Rusta\RustaConsumerList\Shared\MainLayout.razor"
using Blazority;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\Rusta\RustaConsumerList\Shared\MainLayout.razor"
using RustaConsumerList.Pages;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "b-hb7tpql49r");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "background-color:#FFDE00;position:fixed;z-index:98;width:100%;height:50px");
            __builder.AddAttribute(4, "b-hb7tpql49r");
            __builder.AddMarkupContent(5, "<img style=\"height:100%;float:left;\" src=\"/images/Rusta.png\" alt=\"Rusta Logo\" asp-append-version=\"true\" b-hb7tpql49r>\r\n        ");
            __builder.AddMarkupContent(6, "<div style=\"height:70%;float:left;padding-left:24px;padding-top:12px;\" b-hb7tpql49r><img style=\"height:100%\" src=\"/images/home-button.svg\" alt=\"Home\" asp-append-version=\"true\" b-hb7tpql49r></div>\r\n        ");
            __builder.OpenComponent<Blazority.Button>(7);
            __builder.AddAttribute(8, "style", "float:right");
            __builder.AddAttribute(9, "Variant", "primary");
            __builder.AddAttribute(10, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\repos\Rusta\RustaConsumerList\Shared\MainLayout.razor"
                                                               () => Navigate(DBNav)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(12, "Databas");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "content-container");
            __builder.AddAttribute(16, "b-hb7tpql49r");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "content-area");
            __builder.AddAttribute(19, "b-hb7tpql49r");
            __builder.AddContent(20, 
#nullable restore
#line 18 "D:\repos\Rusta\RustaConsumerList\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "D:\repos\Rusta\RustaConsumerList\Shared\MainLayout.razor"
 

    string DBNav = "/DB";

    public void Navigate(string URL)
    {
        NavigationManager.NavigateTo(URL);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
