#pragma checksum "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\StatusLogic\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdaa31b9d2b299a1599fce54221b2c7528f010d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ApprovalProcess.Pages.Logics.StatusLogic.Pages_Logics_StatusLogic_List), @"mvc.1.0.razor-page", @"/Pages/Logics/StatusLogic/List.cshtml")]
namespace ApprovalProcess.Pages.Logics.StatusLogic
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdaa31b9d2b299a1599fce54221b2c7528f010d6", @"/Pages/Logics/StatusLogic/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ef06527bd536442be760d1716680601d181910", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Logics_StatusLogic_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h4>List of Status</h4>\r\n<a href=\"/Logics/StatusLogic/Create\" class=\"btn btn-outline-primary\">Create</a>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\StatusLogic\List.cshtml"
 if (Model.Status.Count > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered\">\r\n        <thead>\r\n            <tr>\r\n                <th>Status Item</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\StatusLogic\List.cshtml"
             foreach (var item in Model.Status)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\StatusLogic\List.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> <a");
            BeginWriteAttribute("href", " href=\"", 541, "\"", 584, 2);
            WriteAttributeValue("", 548, "/Logics/StatusLogic/Edit?id=", 548, 28, true);
#nullable restore
#line 23 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\StatusLogic\List.cshtml"
WriteAttributeValue("", 576, item.Id, 576, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-secondary\">Edit</a> </td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\StatusLogic\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 28 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\StatusLogic\List.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(" <h4>No Data exists!</h4>");
#nullable restore
#line 30 "C:\Users\HP\Desktop\CSharp projects\ApprovalProcess\ApprovalProcess\Pages\Logics\StatusLogic\List.cshtml"
                          }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApprovalProcess.Pages.Logics.StatusLogic.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ApprovalProcess.Pages.Logics.StatusLogic.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ApprovalProcess.Pages.Logics.StatusLogic.ListModel>)PageContext?.ViewData;
        public ApprovalProcess.Pages.Logics.StatusLogic.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
