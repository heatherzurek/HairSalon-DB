#pragma checksum "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "450de96f5fb95fecf2fcf7649f8993941f612475"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylist_Show), @"mvc.1.0.view", @"/Views/Stylist/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylist/Show.cshtml", typeof(AspNetCore.Views_Stylist_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"450de96f5fb95fecf2fcf7649f8993941f612475", @"/Views/Stylist/Show.cshtml")]
    public class Views_Stylist_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 239, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "450de96f5fb95fecf2fcf7649f8993941f6124754053", async() => {
                BeginContext(29, 162, true);
                WriteLiteral("\n  <meta charset=\'utf-8\'>\n  <title>Hair Salon</title>\n  <link rel=\'stylesheet\' href=\'https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\'>\n  ");
                EndContext();
                BeginContext(191, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "450de96f5fb95fecf2fcf7649f8993941f6124754598", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(254, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(262, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(263, 889, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "450de96f5fb95fecf2fcf7649f8993941f6124756775", async() => {
                BeginContext(269, 91, true);
                WriteLiteral("\n  <div class=\"container\">\n    <h1>Hair Salon</h1>\n    <h2>View Clients Here</h2>\n    <ol>\n");
                EndContext();
#line 14 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
       if (Model.Count == 0)
      {

#line default
#line hidden
                BeginContext(397, 47, true);
                WriteLiteral("        <p>No clients have been added yet!</p>\n");
                EndContext();
#line 17 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
      }

#line default
#line hidden
                BeginContext(452, 6, true);
                WriteLiteral("      ");
                EndContext();
#line 18 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
       if(Model.Count != 0)
      {
        

#line default
#line hidden
#line 20 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
         foreach (var client in @Model["clients"])
        {

#line default
#line hidden
                BeginContext(549, 16, true);
                WriteLiteral("          <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 565, "\"", 631, 4);
                WriteAttributeValue("", 572, "/stylists/", 572, 10, true);
#line 22 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
WriteAttributeValue("", 582, Model["stylist"].GetId(), 582, 25, false);

#line default
#line hidden
                WriteAttributeValue("", 607, "/clients/", 607, 9, true);
#line 22 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
WriteAttributeValue("", 616, client.GetId(), 616, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(632, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(634, 16, false);
#line 22 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
                                                                               Write(client.GetName());

#line default
#line hidden
                EndContext();
                BeginContext(650, 10, true);
                WriteLiteral("</a></li>\n");
                EndContext();
#line 23 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
        }

#line default
#line hidden
#line 23 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
         
      }

#line default
#line hidden
                BeginContext(678, 16, true);
                WriteLiteral("    </ol>\n    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 694, "\"", 748, 3);
                WriteAttributeValue("", 701, "/stylists/", 701, 10, true);
#line 26 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
WriteAttributeValue("", 711, Model["stylist"].GetId(), 711, 25, false);

#line default
#line hidden
                WriteAttributeValue("", 736, "/clients/new", 736, 12, true);
                EndWriteAttribute();
                BeginContext(749, 37, true);
                WriteLiteral(">Add a new client</a><br><br>\n\n    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 786, "\'", 833, 3);
                WriteAttributeValue("", 793, "/stylists/", 793, 10, true);
#line 28 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
WriteAttributeValue("", 803, Model["stylist"].GetId(), 803, 25, false);

#line default
#line hidden
                WriteAttributeValue("", 828, "/edit", 828, 5, true);
                EndWriteAttribute();
                BeginContext(834, 59, true);
                WriteLiteral(">Edit this item</a>\n    <br>\n    <br>\n    <br>\n\n\n\n    <form");
                EndContext();
                BeginWriteAttribute("action", " action=\'", 893, "\'", 944, 3);
                WriteAttributeValue("", 902, "/stylists/", 902, 10, true);
#line 35 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
WriteAttributeValue("", 912, Model["stylist"].GetId(), 912, 25, false);

#line default
#line hidden
                WriteAttributeValue("", 937, "/delete", 937, 7, true);
                EndWriteAttribute();
                BeginContext(945, 200, true);
                WriteLiteral(" method=\"post\">\n      <button type=\"submit\" class=\"btn btn-dark\">Delete Stylist</button>\n    </form>\n    <a href=\"/stylists\">Return to stylist list</a>\n    <a href=\"/\">Return to homepage</a>\n  </div>\n");
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
            BeginContext(1152, 9, true);
            WriteLiteral("\n</html>\n");
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
