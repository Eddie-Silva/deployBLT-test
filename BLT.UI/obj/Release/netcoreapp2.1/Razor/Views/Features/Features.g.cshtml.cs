#pragma checksum "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/Features.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d3351110d4717f282be1b97f7162f4a1ba0af24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Features_Features), @"mvc.1.0.view", @"/Views/Features/Features.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Features/Features.cshtml", typeof(AspNetCore.Views_Features_Features))]
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
#line 1 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/_ViewImports.cshtml"
using BLT.UI.ViewModels;

#line default
#line hidden
#line 2 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/_ViewImports.cshtml"
using BLT.Domain.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d3351110d4717f282be1b97f7162f4a1ba0af24", @"/Views/Features/Features.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a791b0485978c27180504f22272200d41406b7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Features_Features : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FeaturesViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/Features.cshtml"
  
    ViewData["Title"] = "Features";

#line default
#line hidden
            BeginContext(66, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(67, 465, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5599882da47043d58017c1be6e4bbbde", async() => {
                BeginContext(73, 165, true);
                WriteLiteral("\n    <div class=\"main-body content just-left\">\n        <h2>Features</h2>\n        <h4 class=\"green\">(PROJECT NAME)</h4>\n        <div class=\"features-list link-font\">\n");
                EndContext();
#line 11 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/Features.cshtml"
             foreach (var f in Model.Features)
            {

#line default
#line hidden
                BeginContext(299, 20, true);
                WriteLiteral("                <h4>");
                EndContext();
                BeginContext(320, 6, false);
#line 13 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/Features.cshtml"
               Write(f.Name);

#line default
#line hidden
                EndContext();
                BeginContext(326, 89, true);
                WriteLiteral("</h4>\n                <button class=\"features-button download-feature\">Download</button>\n");
                EndContext();
                BeginContext(433, 51, false);
#line 16 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/Features.cshtml"
           Write(Html.ActionLink("View", "scenarios", "features", f));

#line default
#line hidden
                EndContext();
#line 16 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/Features.cshtml"
                                                                    
            }

#line default
#line hidden
                BeginContext(499, 26, true);
                WriteLiteral("        </div>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(532, 2, true);
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FeaturesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
