#pragma checksum "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7569eb24234c16dc871468d7e359f1c357e12890"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7569eb24234c16dc871468d7e359f1c357e12890", @"/Views/Stylist/Show.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7569eb24234c16dc871468d7e359f1c357e128904053", async() => {
                BeginContext(29, 162, true);
                WriteLiteral("\n  <meta charset=\'utf-8\'>\n  <title>Hair Salon</title>\n  <link rel=\'stylesheet\' href=\'https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\'>\n  ");
                EndContext();
                BeginContext(191, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7569eb24234c16dc871468d7e359f1c357e128904598", async() => {
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
            BeginContext(263, 1234, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7569eb24234c16dc871468d7e359f1c357e128906776", async() => {
                BeginContext(269, 40, true);
                WriteLiteral("\n  <div class=\"container\">\n    <h2>View ");
                EndContext();
                BeginContext(310, 26, false);
#line 11 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
        Write(Model["stylist"].GetName());

#line default
#line hidden
                EndContext();
                BeginContext(336, 39, true);
                WriteLiteral("\'s Clients Here</h2>\n    <hr>\n    <ol>\n");
                EndContext();
#line 14 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
       if (Model.Count == 0)
      {

#line default
#line hidden
                BeginContext(412, 47, true);
                WriteLiteral("        <p>No clients have been added yet!</p>\n");
                EndContext();
#line 17 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
      }

#line default
#line hidden
                BeginContext(467, 6, true);
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
                BeginContext(564, 16, true);
                WriteLiteral("          <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 580, "\"", 646, 4);
                WriteAttributeValue("", 587, "/stylists/", 587, 10, true);
#line 22 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
WriteAttributeValue("", 597, Model["stylist"].GetId(), 597, 25, false);

#line default
#line hidden
                WriteAttributeValue("", 622, "/clients/", 622, 9, true);
#line 22 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
WriteAttributeValue("", 631, client.GetId(), 631, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(647, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(649, 16, false);
#line 22 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
                                                                               Write(client.GetName());

#line default
#line hidden
                EndContext();
                BeginContext(665, 10, true);
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
                BeginContext(693, 16, true);
                WriteLiteral("    </ol>\n    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 709, "\"", 763, 3);
                WriteAttributeValue("", 716, "/stylists/", 716, 10, true);
#line 26 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
WriteAttributeValue("", 726, Model["stylist"].GetId(), 726, 25, false);

#line default
#line hidden
                WriteAttributeValue("", 751, "/clients/new", 751, 12, true);
                EndWriteAttribute();
                BeginContext(764, 59, true);
                WriteLiteral(">Add a new client</a><br><br>\n\n    <!-- <a href=\'/stylists/");
                EndContext();
                BeginContext(824, 24, false);
#line 28 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
                       Write(Model["stylist"].GetId());

#line default
#line hidden
                EndContext();
                BeginContext(848, 43, true);
                WriteLiteral("/edit\'>Edit this client</a> -->\n\n\n    <form");
                EndContext();
                BeginWriteAttribute("action", " action=\'", 891, "\'", 940, 3);
                WriteAttributeValue("", 900, "/stylists/", 900, 10, true);
#line 31 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
WriteAttributeValue("", 910, Model["stylist"].GetId(), 910, 25, false);

#line default
#line hidden
                WriteAttributeValue("", 935, "/edit", 935, 5, true);
                EndWriteAttribute();
                BeginContext(941, 296, true);
                WriteLiteral(@" method=""post"">
      <button type=""submit"" class=""btn btn-warning"">Edit Stylist</button>
    </form>
    <br>
    <br>
    <br>


    <!-- <form action=""/stylists/{stylistId}/edit"" method=""post"">
      <button class=""btn btn-danger"" type=""submit"">Edit Stylist</button>
    </form> -->

    <form");
                EndContext();
                BeginWriteAttribute("action", " action=\'", 1237, "\'", 1288, 3);
                WriteAttributeValue("", 1246, "/stylists/", 1246, 10, true);
#line 43 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Stylist/Show.cshtml"
WriteAttributeValue("", 1256, Model["stylist"].GetId(), 1256, 25, false);

#line default
#line hidden
                WriteAttributeValue("", 1281, "/delete", 1281, 7, true);
                EndWriteAttribute();
                BeginContext(1289, 201, true);
                WriteLiteral(" method=\"post\">\n      <button type=\"submit\" class=\"btn btn-dark\">Delete Stylist</button>\n    </form>\n\n    <a href=\"/stylists\">Return to stylist list</a>\n    <a href=\"/\">Return to homepage</a>\n  </div>\n");
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
            BeginContext(1497, 9, true);
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
