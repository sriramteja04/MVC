#pragma checksum "C:\Users\s531441\Documents\C# and .Net\MVC\MVC\Views\Degrees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c7a2d20a9ad36c6e933ae1b2453f3fb34433dac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Degrees_Details), @"mvc.1.0.view", @"/Views/Degrees/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Degrees/Details.cshtml", typeof(AspNetCore.Views_Degrees_Details))]
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
#line 1 "C:\Users\s531441\Documents\C# and .Net\MVC\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#line 2 "C:\Users\s531441\Documents\C# and .Net\MVC\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c7a2d20a9ad36c6e933ae1b2453f3fb34433dac", @"/Views/Degrees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Degrees_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC.Models.Degree>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\s531441\Documents\C# and .Net\MVC\MVC\Views\Degrees\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(71, 106, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Degree</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>");
            EndContext();
            BeginContext(178, 46, false);
#line 13 "C:\Users\s531441\Documents\C# and .Net\MVC\MVC\Views\Degrees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DegreeName));

#line default
#line hidden
            EndContext();
            BeginContext(224, 20, true);
            WriteLiteral(" </dt>\r\n        <dd>");
            EndContext();
            BeginContext(245, 42, false);
#line 14 "C:\Users\s531441\Documents\C# and .Net\MVC\MVC\Views\Degrees\Details.cshtml"
       Write(Html.DisplayFor(model => model.DegreeName));

#line default
#line hidden
            EndContext();
            BeginContext(287, 19, true);
            WriteLiteral("</dd>\r\n        <dt>");
            EndContext();
            BeginContext(307, 54, false);
#line 15 "C:\Users\s531441\Documents\C# and .Net\MVC\MVC\Views\Degrees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DegreeRequirements));

#line default
#line hidden
            EndContext();
            BeginContext(361, 193, true);
            WriteLiteral("  </dt>\r\n        <dd>\r\n            <table class=\"table\">\r\n                <tr>\r\n                    <th>RequirmentId</th>\r\n                    <th>Requirement Name</th>\r\n                </tr>\r\n");
            EndContext();
#line 22 "C:\Users\s531441\Documents\C# and .Net\MVC\MVC\Views\Degrees\Details.cshtml"
                 foreach (var item in Model.DegreeRequirements.OrderBy(r => r.DegreeRequirementId))
                {

#line default
#line hidden
            BeginContext(674, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(729, 54, false);
#line 25 "C:\Users\s531441\Documents\C# and .Net\MVC\MVC\Views\Degrees\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DegreeRequirementId));

#line default
#line hidden
            EndContext();
            BeginContext(783, 36, true);
            WriteLiteral(" </td>\r\n                        <td>");
            EndContext();
            BeginContext(820, 50, false);
#line 26 "C:\Users\s531441\Documents\C# and .Net\MVC\MVC\Views\Degrees\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RequirementName));

#line default
#line hidden
            EndContext();
            BeginContext(870, 37, true);
            WriteLiteral("   </td>\r\n                    </tr>\r\n");
            EndContext();
#line 28 "C:\Users\s531441\Documents\C# and .Net\MVC\MVC\Views\Degrees\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(926, 52, true);
            WriteLiteral("            </table>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(978, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c7a2d20a9ad36c6e933ae1b2453f3fb34433dac6989", async() => {
                BeginContext(1030, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\s531441\Documents\C# and .Net\MVC\MVC\Views\Degrees\Details.cshtml"
                           WriteLiteral(Model.DegreeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1038, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1046, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c7a2d20a9ad36c6e933ae1b2453f3fb34433dac9312", async() => {
                BeginContext(1068, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1084, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC.Models.Degree> Html { get; private set; }
    }
}
#pragma warning restore 1591
