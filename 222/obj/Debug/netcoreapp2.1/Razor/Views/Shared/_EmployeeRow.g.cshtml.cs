#pragma checksum "E:\ЛАБЫ\ссп\222\222\Views\Shared\_EmployeeRow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b566fbd042c78d2937afc1e97268624185399306"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__EmployeeRow), @"mvc.1.0.view", @"/Views/Shared/_EmployeeRow.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_EmployeeRow.cshtml", typeof(AspNetCore.Views_Shared__EmployeeRow))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\ЛАБЫ\ссп\222\222\Views\_ViewImports.cshtml"
using _222;

#line default
#line hidden
#line 2 "E:\ЛАБЫ\ссп\222\222\Views\_ViewImports.cshtml"
using _222.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b566fbd042c78d2937afc1e97268624185399306", @"/Views/Shared/_EmployeeRow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7796b9919d132e1bac6d2c68a0436d87d91e726c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__EmployeeRow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_222.EF.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 70, true);
            WriteLiteral("\r\n<tr>\r\n    <td class=\" col-md-2\">\r\n        <img class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 95, "\"", 121, 1);
#line 5 "E:\ЛАБЫ\ссп\222\222\Views\Shared\_EmployeeRow.cshtml"
WriteAttributeValue("", 101, Model.ImageLocation, 101, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(122, 63, true);
            WriteLiteral(" />\r\n    </td>\r\n    <td class=\"col-md-7\">\r\n        <span>Name: ");
            EndContext();
            BeginContext(186, 10, false);
#line 8 "E:\ЛАБЫ\ссп\222\222\Views\Shared\_EmployeeRow.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(196, 64, true);
            WriteLiteral("</span>\r\n        <br />\r\n        <br />\r\n        <span>Surname: ");
            EndContext();
            BeginContext(261, 13, false);
#line 11 "E:\ЛАБЫ\ссп\222\222\Views\Shared\_EmployeeRow.cshtml"
                  Write(Model.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(274, 68, true);
            WriteLiteral("</span>\r\n        <br />\r\n        <br />\r\n        <span>Description: ");
            EndContext();
            BeginContext(343, 11, false);
#line 14 "E:\ЛАБЫ\ссп\222\222\Views\Shared\_EmployeeRow.cshtml"
                      Write(Model.About);

#line default
#line hidden
            EndContext();
            BeginContext(354, 67, true);
            WriteLiteral("</span>\r\n        <br />\r\n        <br />\r\n        <span>Birth date: ");
            EndContext();
            BeginContext(422, 15, false);
#line 17 "E:\ЛАБЫ\ссп\222\222\Views\Shared\_EmployeeRow.cshtml"
                     Write(Model.BirthDate);

#line default
#line hidden
            EndContext();
            BeginContext(437, 70, true);
            WriteLiteral("</span>\r\n        <br />\r\n        <br />\r\n        <button data-bookid=\"");
            EndContext();
            BeginContext(508, 8, false);
#line 20 "E:\ЛАБЫ\ссп\222\222\Views\Shared\_EmployeeRow.cshtml"
                        Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(516, 94, true);
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#editModal\" class=\"btn btn-warning\">Edit</button>\r\n        ");
            EndContext();
            BeginContext(610, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fadffb04cea4de2b90156cec734e7be", async() => {
                BeginContext(703, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "E:\ЛАБЫ\ссп\222\222\Views\Shared\_EmployeeRow.cshtml"
                                                       WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(713, 18, true);
            WriteLiteral("\r\n    </td>\r\n</tr>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_222.EF.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591