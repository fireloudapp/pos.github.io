#pragma checksum "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Shared\LoginLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d28f9798a9b5f975541effe02645cdd5b299b25"
// <auto-generated/>
#pragma warning disable 1591
namespace AdminDashboard.Server.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\_Imports.razor"
using AdminDashboard.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\_Imports.razor"
using AdminDashboard.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\_Imports.razor"
using AdminDashboard.Server.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
    public partial class LoginLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.AddAttribute(1, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 4 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Shared\LoginLayout.razor"
                         _currentTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n\n");
            __builder.OpenComponent<MudBlazor.MudContainer>(5);
            __builder.AddAttribute(6, "MaxWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 7 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Shared\LoginLayout.razor"
                        MaxWidth.Small

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Class", "d-flex align-center");
            __builder.AddAttribute(8, "Style", "height: 100vh;");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "d-flex flex-column mud-width-full");
                __builder2.OpenComponent<MudBlazor.MudPaper>(12);
                __builder2.AddAttribute(13, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Shared\LoginLayout.razor"
                             25

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Class", "pa-8");
                __builder2.AddAttribute(15, "Width", "100%");
                __builder2.AddAttribute(16, "MaxWidth", "500px");
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIcon>(18);
                    __builder3.AddAttribute(19, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Shared\LoginLayout.razor"
                            Icons.Custom.Brands.MudBlazor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 10 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Shared\LoginLayout.razor"
                                                                 Size.Large

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Style", "width:100px; height:100px;");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\n            ");
                    __builder3.AddContent(23, 
#nullable restore
#line 11 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Shared\LoginLayout.razor"
             Body

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudAlert>(25);
                __builder2.AddAttribute(26, "Severity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Severity>(
#nullable restore
#line 13 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Shared\LoginLayout.razor"
                            Severity.Info

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "Class", "mt-8 mud-width-full");
                __builder2.AddAttribute(28, "Style", "max-width:500px;");
                __builder2.AddAttribute(29, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Shared\LoginLayout.razor"
                                                                                                           25

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(31, "No authentication is required, click sign in.");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Shared\LoginLayout.razor"
       
    private MudTheme _currentTheme = new MudBlazorAdminDashboard();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
