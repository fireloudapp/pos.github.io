// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AdminDashboard.Server.Pages.Applications.Email
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
    public partial class EmailNavList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Temp\MudBlazor.NET\MudBlazor.Templates-master\MudBlazor.Template.AdminDashboard\AdminDashboard.Server\Pages\Applications\Email\EmailNavList.razor"
       

    [Parameter] public string folder { get; set; }

    public string GetClass(string _folder)
    {
        if (folder == _folder)
        {
            return "my-2 rounded mud-primary-text";
        }
        else
        {
            return "my-2 rounded";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
