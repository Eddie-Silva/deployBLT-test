#pragma checksum "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Home/Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "180314fea887aa24d01e6973ad711774e32a0c1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"180314fea887aa24d01e6973ad711774e32a0c1b", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a791b0485978c27180504f22272200d41406b7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Home/Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(40, 36, true);
            WriteLiteral("\n<div class=\"content cent\">\n    <h2>");
            EndContext();
            BeginContext(77, 17, false);
#line 6 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Home/Contact.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(94, 14, true);
            WriteLiteral("</h2>\n    <h3>");
            EndContext();
            BeginContext(109, 19, false);
#line 7 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/Home/Contact.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(128, 532, true);
            WriteLiteral(@"</h3>

    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title=""Phone"">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong> <a href=""mailto:Support@example.com"">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href=""mailto:Marketing@example.com"">Marketing@example.com</a>
    </address>
    <br>
    <br>
    <a href=""/CreateFeature/NewProject"" class=""features-button"" id=""create-feature-button"">Create Feature</a>

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
