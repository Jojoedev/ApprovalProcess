#pragma checksum "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\Approval.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e68c02a1f55039c4748c564ee46f09822d26a6f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ApprovalProcess.Pages.Logics.RequestLogic.Pages_Logics_RequestLogic_Approval), @"mvc.1.0.razor-page", @"/Pages/Logics/RequestLogic/Approval.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e68c02a1f55039c4748c564ee46f09822d26a6f1", @"/Pages/Logics/RequestLogic/Approval.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ef06527bd536442be760d1716680601d181910", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Logics_RequestLogic_Approval : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h3>Finance Director</h3>    

<table class=""table table-bordered"">
    <thead>
        <tr>

          <th>Requester</th>
            <th>Dept</th>
            <th>Vendor</th>
            <th>Details</th>
            <th>Amount</th>
            <th>Date</th>
            <th>SupDoc</th>
            <th>Status</th>
            <th>Remark</th>
            <th>LMgr</th>
            <th>FDir</th>
             

        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 29 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\Approval.cshtml"
         foreach (var item in Model.RequestObj)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
            WriteLiteral("            <td>");
#nullable restore
#line 33 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\Approval.cshtml"
           Write(item.RequesterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\Approval.cshtml"
           Write(item.Department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\Approval.cshtml"
           Write(item.Vendor.VendorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\Approval.cshtml"
           Write(item.RequestDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\Approval.cshtml"
           Write(item.RequestAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\Approval.cshtml"
           Write(item.RequestedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\Approval.cshtml"
           Write(item.SupportingDoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\Approval.cshtml"
           Write(item.Status.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\Approval.cshtml"
           Write(item.Remark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <th>");
#nullable restore
#line 42 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\Approval.cshtml"
           Write(item.LineManager);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 43 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\Approval.cshtml"
           Write(item.FinanceDirector);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
            WriteLiteral("          \r\n           <td> <a");
            BeginWriteAttribute("href", " href=\"", 1233, "\"", 1294, 2);
            WriteAttributeValue("", 1240, "/Logics/RequestLogic/ApprovalUpdate?id=", 1240, 39, true);
#nullable restore
#line 46 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\Approval.cshtml"
WriteAttributeValue("", 1279, item.RequestId, 1279, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Review</a> </td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 49 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\RequestLogic\Approval.cshtml"
        
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>    \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApprovalProcess.Pages.Logics.RequestLogic.ApprovalModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ApprovalProcess.Pages.Logics.RequestLogic.ApprovalModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ApprovalProcess.Pages.Logics.RequestLogic.ApprovalModel>)PageContext?.ViewData;
        public ApprovalProcess.Pages.Logics.RequestLogic.ApprovalModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591