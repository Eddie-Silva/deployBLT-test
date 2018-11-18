#pragma checksum "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8afaed1cc0b4af20da54cdd4835ba4bfee60510"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Features_AllScenarios), @"mvc.1.0.view", @"/Views/Features/AllScenarios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Features/AllScenarios.cshtml", typeof(AspNetCore.Views_Features_AllScenarios))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8afaed1cc0b4af20da54cdd4835ba4bfee60510", @"/Views/Features/AllScenarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a791b0485978c27180504f22272200d41406b7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Features_AllScenarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ScenariosViewModel>
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
#line 2 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml"
  
    ViewData["Title"] = "AllScenarios";

#line default
#line hidden
            BeginContext(71, 3, true);
            WriteLiteral("\n\n\n");
            EndContext();
            BeginContext(74, 831, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "966014c952f24eecbc3ee9c95204449d", async() => {
                BeginContext(80, 69, true);
                WriteLiteral("\n    <div class=\"main-body content cent\">\n        <h2>All Scenarios: ");
                EndContext();
                BeginContext(150, 18, false);
#line 10 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml"
                      Write(Model.Feature.Name);

#line default
#line hidden
                EndContext();
                BeginContext(168, 43, true);
                WriteLiteral("</h2>\n        <div class=\"scenarios-list\">\n");
                EndContext();
#line 12 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml"
             foreach (var s in Model.Scenarios)
            {

#line default
#line hidden
                BeginContext(273, 57, true);
                WriteLiteral("            <div class=\"steps-list\">\n                <h3>");
                EndContext();
                BeginContext(331, 8, false);
#line 15 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml"
               Write(s.Header);

#line default
#line hidden
                EndContext();
                BeginContext(339, 6, true);
                WriteLiteral("</h3>\n");
                EndContext();
#line 16 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml"
                 if (s.HasBackground == true)
                {

#line default
#line hidden
                BeginContext(409, 24, true);
                WriteLiteral("                    <h4>");
                EndContext();
                BeginContext(434, 12, false);
#line 18 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml"
                   Write(s.Background);

#line default
#line hidden
                EndContext();
                BeginContext(446, 6, true);
                WriteLiteral("</h4>\n");
                EndContext();
#line 19 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml"
                }

#line default
#line hidden
                BeginContext(470, 16, true);
                WriteLiteral("                ");
                EndContext();
#line 20 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml"
                 foreach (var t in s.StepList)
                {

#line default
#line hidden
                BeginContext(535, 23, true);
                WriteLiteral("                    <p>");
                EndContext();
                BeginContext(559, 9, false);
#line 22 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml"
                  Write(t.Content);

#line default
#line hidden
                EndContext();
                BeginContext(568, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
#line 23 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml"
                }

#line default
#line hidden
                BeginContext(591, 16, true);
                WriteLiteral("                ");
                EndContext();
#line 24 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml"
                 if (s.IsOutline == true)
                {

#line default
#line hidden
                BeginContext(651, 37, true);
                WriteLiteral("                    <p>Examples:</p>\n");
                EndContext();
#line 27 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml"
                     foreach (var e in s.Examples)
                    {

#line default
#line hidden
                BeginContext(761, 29, true);
                WriteLiteral("                        <p>| ");
                EndContext();
                BeginContext(791, 1, false);
#line 29 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml"
                        Write(e);

#line default
#line hidden
                EndContext();
                BeginContext(792, 7, true);
                WriteLiteral(" |</p>\n");
                EndContext();
#line 30 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml"
                    }

#line default
#line hidden
#line 30 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(839, 19, true);
                WriteLiteral("            </div>\n");
                EndContext();
#line 33 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Features/AllScenarios.cshtml"
            }

#line default
#line hidden
                BeginContext(872, 26, true);
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
            BeginContext(905, 3, true);
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ScenariosViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
