#pragma checksum "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\Shared\PersonCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a3f4a5e557dac4702767b62c0a5d260d76f6afa"
// <auto-generated/>
#pragma warning disable 1591
namespace AdminDashboard.Wasm.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\_Imports.razor"
using AdminDashboard.Wasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\_Imports.razor"
using AdminDashboard.Wasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\_Imports.razor"
using AdminDashboard.Wasm.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
    public partial class PersonCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudCard>(0);
            __builder.AddAttribute(1, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 1 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\Shared\PersonCard.razor"
                    0

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Square", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 1 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\Shared\PersonCard.razor"
                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Class", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 1 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\Shared\PersonCard.razor"
                                             Class

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Style", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 1 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\Shared\PersonCard.razor"
                                                            Style

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCardHeader>(6);
                __builder2.AddAttribute(7, "CardHeaderAvatar", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudAvatar>(8);
                    __builder3.AddAttribute(9, "Image", "images/avatar_jonny.jpg");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(10, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(11);
                    __builder3.AddAttribute(12, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 7 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\Shared\PersonCard.razor"
                           Typo.body2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(14, "Jonny Larsson");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenComponent<MudBlazor.MudText>(16);
                    __builder3.AddAttribute(17, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 8 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\Shared\PersonCard.razor"
                           Typo.caption

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(19, "IT Consultant");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Wasm\Shared\PersonCard.razor"
       
    [Parameter] public string Class { get; set; }
    [Parameter] public string Style { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
