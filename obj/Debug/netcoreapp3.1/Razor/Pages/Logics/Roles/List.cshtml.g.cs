#pragma checksum "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\Roles\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1166b9a35747cb5035c80b740fe8da4f4d947dc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ApprovalProcess.Pages.Logics.Roles.Pages_Logics_Roles_List), @"mvc.1.0.razor-page", @"/Pages/Logics/Roles/List.cshtml")]
namespace ApprovalProcess.Pages.Logics.Roles
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\_ViewImports.cshtml"
using ApprovalProcess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\_ViewImports.cshtml"
using ApprovalProcess.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1166b9a35747cb5035c80b740fe8da4f4d947dc5", @"/Pages/Logics/Roles/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ef06527bd536442be760d1716680601d181910", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Logics_Roles_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h3>List of Roles</h3>\r\n<a href=\"/Logics/Roles/Create\" class=\" btn btn-primary\">Create</a>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\Roles\List.cshtml"
 if (Model.Roles.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Name</th>\r\n    </tr>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\Roles\List.cshtml"
         foreach (var item in @Model.Roles)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\Roles\List.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\Roles\List.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\Roles\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>   ");
#nullable restore
#line 27 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\Roles\List.cshtml"
           }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4>No Role exists in the Database</h4>\r\n");
#nullable restore
#line 31 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\Roles\List.cshtml"
            }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApprovalProcess.Pages.Logics.Roles.ListModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ApprovalProcess.Pages.Logics.Roles.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ApprovalProcess.Pages.Logics.Roles.ListModel>)PageContext?.ViewData;
        public ApprovalProcess.Pages.Logics.Roles.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
