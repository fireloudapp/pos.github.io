#pragma checksum "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Pages\Pages\Authentication\Forgot.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "504eebbfd634fc64319ac1be62c125af6be4ab3d"
// <auto-generated/>
#pragma warning disable 1591
namespace AdminDashboard.Server.Pages.Pages.Authentication
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/pages/authentication/forgot-password")]
    public partial class Forgot : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudText>(0);
            __builder.AddAttribute(1, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 6 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Pages\Pages\Authentication\Forgot.razor"
               Typo.h4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Pages\Pages\Authentication\Forgot.razor"
                                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Forgot Password?");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenComponent<MudBlazor.MudText>(6);
            __builder.AddAttribute(7, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 8 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Pages\Pages\Authentication\Forgot.razor"
               Typo.subtitle2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(9, "Enter the email address linked to your account and you will recieve an email containing a link to reset your password.");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\n\n");
            __builder.OpenComponent<MudBlazor.MudTextField<string>>(11);
            __builder.AddAttribute(12, "Label", "E-mail");
            __builder.AddAttribute(13, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 10 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Pages\Pages\Authentication\Forgot.razor"
                                                 Variant.Outlined

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "Class", "my-4");
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\n\n");
            __builder.OpenComponent<MudBlazor.MudButton>(16);
            __builder.AddAttribute(17, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 12 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Pages\Pages\Authentication\Forgot.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 12 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Pages\Pages\Authentication\Forgot.razor"
                                           Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "Link", "/pages/authentication/reset-password");
            __builder.AddAttribute(20, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 12 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Pages\Pages\Authentication\Forgot.razor"
                                                                                                            Size.Large

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Pages\Pages\Authentication\Forgot.razor"
                                                                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "Class", "mt-3");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(24, "Reset Password");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
