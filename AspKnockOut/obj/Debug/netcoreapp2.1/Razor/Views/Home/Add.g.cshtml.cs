#pragma checksum "/Users/damianruta/WORKSPACE/EXER/cs/ExAspKnockOut/AspKnockOut/Views/Home/Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de54867836559eb7d39450e9d9d37a2cdfe29198"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Add), @"mvc.1.0.view", @"/Views/Home/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Add.cshtml", typeof(AspNetCore.Views_Home_Add))]
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
#line 1 "/Users/damianruta/WORKSPACE/EXER/cs/ExAspKnockOut/AspKnockOut/Views/_ViewImports.cshtml"
using AspKnockOut;

#line default
#line hidden
#line 2 "/Users/damianruta/WORKSPACE/EXER/cs/ExAspKnockOut/AspKnockOut/Views/_ViewImports.cshtml"
using AspKnockOut.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de54867836559eb7d39450e9d9d37a2cdfe29198", @"/Views/Home/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f709be5f65eddbdd0adbcb466fa5ff64d82c5e5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/addtask.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/damianruta/WORKSPACE/EXER/cs/ExAspKnockOut/AspKnockOut/Views/Home/Add.cshtml"
  
    ViewData["Title"] = "Dodaj adres";

#line default
#line hidden
            BeginContext(44, 193, true);
            WriteLiteral("\n<div class=\"row\" style=\"margin-top: 40px\">\n    <a href=\"/Home/\" class=\"btn btn-default\">Lista adresów</a>\n</div>\n\n<div class=\"row\" style=\"margin-top: 40px\">\n    <div class=\"col-sm-6\">\n        ");
            EndContext();
            BeginContext(237, 2229, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51f4e5144dee45f7b5452629c684e93c", async() => {
                BeginContext(277, 2182, true);
                WriteLiteral(@"
            <div class=""form-group"">
            <label class=""control-label col-sm-2"" for=""fname"">Imię</label>
            <div class=""col-sm-10"">
                <input data-bind=""value: firstName"" type=""fname"" class=""form-control"" id=""fname"" placeholder=""Imię..."" name=""fname"">
            </div>
            </div>
            
            <div class=""form-group"">
            <label class=""control-label col-sm-2"" for=""lname"">Nazwisko</label>
            <div class=""col-sm-10"">
                <input data-bind=""value: lastName"" type=""lname"" class=""form-control"" id=""lname"" placeholder=""Nazwisko..."" name=""lname"">
            </div>
            </div>

            <div class=""form-group"">
            <label class=""control-label col-sm-2"" for=""city"">Miasto</label>
            <div class=""col-sm-10"">
                <input data-bind=""value: city"" type=""city"" class=""form-control"" id=""city"" placeholder=""Miasto..."" name=""city"">
            </div>
            </div>

            <div class=""form-group"">
            ");
                WriteLiteral(@"<label class=""control-label col-sm-2"" for=""country"">Kraj</label>
            <div class=""col-sm-10"">
                <input data-bind=""value: country"" type=""country"" class=""form-control"" id=""country"" placeholder=""Kraj..."" name=""country"">
            </div>
            </div>

            <div class=""form-group"">
            <label class=""control-label col-sm-2"" for=""phone"">Telefon</label>
            <div class=""col-sm-10"">
                <input data-bind=""value: phone"" type=""phone"" class=""form-control"" id=""phone"" placeholder=""Telefon..."" name=""phone"">
            </div>
            </div>

            <div class=""form-group"">
            <label class=""control-label col-sm-2"" for=""email"">E-mail</label>
            <div class=""col-sm-10"">
                <input data-bind=""value: email"" type=""email"" class=""form-control"" id=""email"" placeholder=""E-mail..."" name=""email"">
            </div>
            </div>

            <div class=""form-group"">        
            <div class=""col-sm-offset-2 col-sm-10"">
        ");
                WriteLiteral("        <button data-bind=\"click: save\" type=\"\" class=\"btn btn-default\">Zapisz</button>\n            </div>\n            </div>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2466, 19, true);
            WriteLiteral("\n    </div>\n</div>\n");
            EndContext();
            BeginContext(2485, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b9b81e3d1a14e4aa2f1bffa66242d3b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
