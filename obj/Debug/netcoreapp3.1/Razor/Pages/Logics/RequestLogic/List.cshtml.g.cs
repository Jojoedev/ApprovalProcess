#pragma checksum "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8585907ea15465d5743a1fb57103621a89218706"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ApprovalProcess.Pages.Logics.RequestLogic.Pages_Logics_RequestLogic_List), @"mvc.1.0.razor-page", @"/Pages/Logics/RequestLogic/List.cshtml")]
namespace ApprovalProcess.Pages.Logics.RequestLogic
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8585907ea15465d5743a1fb57103621a89218706", @"/Pages/Logics/RequestLogic/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ef06527bd536442be760d1716680601d181910", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Logics_RequestLogic_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\List.cshtml"
 if(Model.RequestObj.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table"">
    <thead>
        <tr>

            <th>Requester</th>
            <th>Department</th>
            <th>Vendor</th>
            <th>Description</th>
            <th>Amount</th>
            <th>Date</th>
            <th>SupportingDoc</th>
            <th>Status</th>

        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 25 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\List.cshtml"
         foreach (var item in Model.RequestObj)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
            WriteLiteral("            <td>");
#nullable restore
#line 29 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\List.cshtml"
           Write(item.RequesterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\List.cshtml"
           Write(item.Department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\List.cshtml"
           Write(item.Vendor.VendorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\List.cshtml"
           Write(item.RequestDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\List.cshtml"
           Write(item.RequestAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\List.cshtml"
           Write(item.RequestedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\List.cshtml"
           Write(item.SupportingDoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\List.cshtml"
           Write(item.RequestStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 936, "\"", 989, 2);
            WriteAttributeValue("", 943, "/Logics/RequestLogic/Update?id=", 943, 31, true);
#nullable restore
#line 37 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\List.cshtml"
WriteAttributeValue("", 974, item.RequestId, 974, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Edit</a> </td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 1058, "\"", 1111, 2);
            WriteAttributeValue("", 1065, "/Logics/RequestLogic/Delete?id=", 1065, 31, true);
#nullable restore
#line 38 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\List.cshtml"
WriteAttributeValue("", 1096, item.RequestId, 1096, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Do you want to delete this?\')\" class=\"btn btn-outline-primary\">Delete</a> </td>\r\n        </tr> \r\n");
#nullable restore
#line 40 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>      ");
#nullable restore
#line 43 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\List.cshtml"
              }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3> No list exists </h3>\r\n");
#nullable restore
#line 47 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApprovalProcess.Pages.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ApprovalProcess.Pages.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ApprovalProcess.Pages.ListModel>)PageContext?.ViewData;
        public ApprovalProcess.Pages.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591