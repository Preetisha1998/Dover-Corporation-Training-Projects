#pragma checksum "C:\Users\11035915\source\repos\ProjectSolution_Simplilearn\ProjectSolutionPhase3\MyLaptopStoreApp\Views\Laptops\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60d63b8624da8df8fac897120506a6876a0920cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Laptops_Success), @"mvc.1.0.view", @"/Views/Laptops/Success.cshtml")]
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
#nullable restore
#line 1 "C:\Users\11035915\source\repos\ProjectSolution_Simplilearn\ProjectSolutionPhase3\MyLaptopStoreApp\Views\_ViewImports.cshtml"
using IdentitySecuredApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\11035915\source\repos\ProjectSolution_Simplilearn\ProjectSolutionPhase3\MyLaptopStoreApp\Views\_ViewImports.cshtml"
using IdentitySecuredApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60d63b8624da8df8fac897120506a6876a0920cd", @"/Views/Laptops/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a145d17de92ef3dfb0e194937b36a0a5e5e9230", @"/Views/_ViewImports.cshtml")]
    public class Views_Laptops_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral(@"<div class=""bg-light p-5 rounded-lg m-3"">
    <h1 class=""display-4"">Success👍</h1>
    <p class=""lead"">We will reach out to you when your order is shipped.</p>
    <hr class=""my-4"">
    <!--
    <p>Missed to Order Something! Come Checkout Other Laptops</p>
    <input asp-action=""UserIndex"" asp-route-id=""");
#nullable restore
#line 7 "C:\Users\11035915\source\repos\ProjectSolution_Simplilearn\ProjectSolutionPhase3\MyLaptopStoreApp\Views\Laptops\Success.cshtml"
                                           Write(ViewBag.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" type=\"submit\" value=\"Submit\" class=\"btn btn-success\" />\n    -->\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60d63b8624da8df8fac897120506a6876a0920cd4227", async() => {
                WriteLiteral("Missed to Order Something! Come Checkout Other Laptops");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<pre></pre>
<!--
<footer class=""my-5 pt-5 text-muted text-center text-small"">
    <ul class=""list-inline"">
        <li class=""list-inline-item""><a href=""#"">Privacy</a></li>
        <li class=""list-inline-item""><a href=""#"">Terms</a></li>
        <li class=""list-inline-item""><a href=""#"">Support</a></li>
    </ul>
</footer>
    -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
