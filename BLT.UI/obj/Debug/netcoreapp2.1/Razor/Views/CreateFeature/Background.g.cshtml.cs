#pragma checksum "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/CreateFeature/Background.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bf6bfb08443c147138a29660fa73a6577a7e58d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CreateFeature_Background), @"mvc.1.0.view", @"/Views/CreateFeature/Background.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CreateFeature/Background.cshtml", typeof(AspNetCore.Views_CreateFeature_Background))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bf6bfb08443c147138a29660fa73a6577a7e58d", @"/Views/CreateFeature/Background.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a791b0485978c27180504f22272200d41406b7d", @"/Views/_ViewImports.cshtml")]
    public class Views_CreateFeature_Background : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Feature-Form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/CreateFeature/Background.cshtml"
  
    ViewData["Title"] = "Background";

#line default
#line hidden
            BeginContext(44, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(45, 6257, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0adf2ee100844fda8aed86160ad8c628", async() => {
                BeginContext(51, 2475, true);
                WriteLiteral(@"
    <div class=""cent content"">
         <h2>Create Feature</h2>
         <h3 class =""green"">(PROJECT NAME)</h3>
         <h4>(FEATURE NAME)</h4>
         <hr>
    </div>
    
            <div class=""cent"" id=""add-bg-option"">
                <button type=""button"" onclick=""toggle_div('bg-steps'); hide_block('add-bg-option'); toggle_div('continue-finish-button');"" class=""features-button cent"">Create Background</button> OR <a href=""/CreateFeature/Scenario"" class=""features-button"" id=""create-feature-button"">Create Scenario</a>
            </div>
            <!--dropdown to create background steps-->
            <div class=""create-background hidden-div cent"" id=""bg-steps"">
                <h4>Add Background</h4>
    
                    <div class=""dropdown"" id=""bg-dropdown"">
                        <button class=""dropbtn""><p>(Select Background Step)</p><br>I want to:</button>
                        <div class=""dropdown-content"">
                            <button type=""button"" onclick=""toggle_div('bg-user-is-on");
                WriteLiteral(@"-page'); toggle_captions_visibility('bg-caption-area');"" class=""dropdown-content"">Go to Page</button><br>
                            <button type=""button"" onclick=""toggle_div('bg-user-login'); toggle_captions_visibility('bg-caption-area');"" class=""dropdown-content"">Log In</button><br>
                            <button type=""button"" onclick=""toggle_div('bg-user-inputs'); toggle_captions_visibility('bg-caption-area');"" class=""dropdown-content"">Fill Out Form</button><br>
                            <button type=""button"" onclick=""toggle_div('bg-check-element-contains'); toggle_captions_visibility('bg-caption-area');"" class=""dropdown-content"">Check Page for Content</button><br>
                            <button type=""button"" onclick=""toggle_div('bg-user-clicks'); toggle_captions_visibility('bg-caption-area');"" class=""dropdown-content"">Click Link/Button</button><br>
                            <button type=""button"" onclick=""toggle_div('bg-user-chooses-radio'); toggle_captions_visibility('bg-caption-area');"" cl");
                WriteLiteral(@"ass=""dropdown-content"">Choose Radio Button</button><br>
                        </div> 
                    </div> 

            </div>

            <!--continue to background steps-->

                <div class=""blank-area"" id=""bg-caption-area"">                 
                    <div class=""cent"" id=""bg-step-captions"">   
                        <div class=""hidden-div"" id=""bg-user-is-on-page"">
                         ");
                EndContext();
                BeginContext(2526, 359, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6c12694cc274f46b7bfc501a2b53dca", async() => {
                    BeginContext(2553, 325, true);
                    WriteLiteral(@"
                            <h5 >User is on (web) page.</h5>
                            <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(web address)"">
                            <button type=""button"" onclick=""toggle_div('bg-user-is-on-page')"">Add Step</button>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2885, 129, true);
                WriteLiteral("\n                        </div>\n\n                        <div class=\"hidden-div\" id=\"bg-user-login\">\n                            ");
                EndContext();
                BeginContext(3014, 511, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c588f77f5c154d5e996f3c1af1206222", async() => {
                    BeginContext(3041, 477, true);
                    WriteLiteral(@"
                                <h5 >User logs in with (Username) and (Password).</h5>
                                <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(Username)"">
                                <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(Password)"">
                                <button type=""button"" onclick=""toggle_div('bg-user-login') "">Add Step</button>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3525, 130, true);
                WriteLiteral("\n                        </div>\n\n                        <div class=\"hidden-div\" id=\"bg-user-inputs\">\n                            ");
                EndContext();
                BeginContext(3655, 496, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a499bae304d8422e9ffafdc6f45dc473", async() => {
                    BeginContext(3682, 462, true);
                    WriteLiteral(@"
                                <h5 >User inputs (Content) in (Field).</h5>
                                <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(Conent)"">
                                <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(Field)"">
                                <button type=""button"" onclick=""toggle_div('bg-user-inputs') "">Add Step</button>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4151, 142, true);
                WriteLiteral("\n                        </div> \n\n                        <div class=\"hidden-div\" id=\"bg-check-element-contains\">\n                            ");
                EndContext();
                BeginContext(4293, 513, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51e66cf8fdaf44739e2932488a45f544", async() => {
                    BeginContext(4320, 479, true);
                    WriteLiteral(@"
                                <h5 >Check that (Element) contains (Value).</h5>
                                <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(Elment)"">
                                <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(Value)"">
                                <button type=""button"" onclick=""toggle_div('bg-check-element-contains'); "">Add Step</button>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4806, 130, true);
                WriteLiteral("\n                        </div>\n\n                        <div class=\"hidden-div\" id=\"bg-user-clicks\">\n                            ");
                EndContext();
                BeginContext(4936, 390, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d15160e7f054540af5c1c484ddffb3b", async() => {
                    BeginContext(4963, 356, true);
                    WriteLiteral(@"
                                    <h5 >User clicks (link or button).</h5>
                                    <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(link or button)"">
                                    <button type=""button"" onclick=""toggle_div('bg-user-clicks');"">Add Step</button>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5326, 138, true);
                WriteLiteral(" \n                        </div>\n\n                        <div class=\"hidden-div\" id=\"bg-user-chooses-radio\">\n                            ");
                EndContext();
                BeginContext(5464, 382, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b7fceecca4b43879940b9736a5c0f85", async() => {
                    BeginContext(5491, 348, true);
                    WriteLiteral(@"
                                <h5 >User chooses (radio button).</h5>
                                <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(radio button)"">
                                <button type=""button"" onclick=""toggle_div('bg-user-chooses-radio');"">Add Step</button>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5846, 449, true);
                WriteLiteral(@"
                        </div>

                    </div> 

                    
                </div>

                <br>
                <br>
                
                <div class=""hidden-div"" id=""continue-finish-button"">
                    <div class=""cent"">
                        <a href=""/CreateFeature/Scenario"" class=""features-button"">Continue</a>    
                     </div>
                    <br>
                </div>
");
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
