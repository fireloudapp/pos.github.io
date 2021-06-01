// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Shared\MainLayout.razor"
       
    private ThemeManagerTheme _themeManager = new ThemeManagerTheme();

    public bool _drawerOpen = true;
    public bool _themeManagerOpen = false;

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

    void OpenThemeManager(bool value)
    {
        _themeManagerOpen = value;
    }

    void UpdateTheme(ThemeManagerTheme value)
    {
        _themeManager = value;
        StateHasChanged();
    }

    protected override void OnInitialized()
    {
        _themeManager.Theme = new MudBlazorAdminDashboard();
        _themeManager.DrawerClipMode = DrawerClipMode.Always;
        _themeManager.FontFamily = "Montserrat";
        _themeManager.DefaultBorderRadius = 3;
    }

    private List<BreadcrumbItem> _items = new List<BreadcrumbItem>
{
        new BreadcrumbItem("Personal", href: "#"),
        new BreadcrumbItem("Dashboard", href: "#"),
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
