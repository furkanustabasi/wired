#pragma checksum "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78d597caff1863a61cb3805e2d4ad76e681d0020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Exam), @"mvc.1.0.view", @"/Views/Home/Exam.cshtml")]
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
#line 1 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\_ViewImports.cshtml"
using Wired.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\_ViewImports.cshtml"
using Wired.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
using Wired.Service.Models.Response;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78d597caff1863a61cb3805e2d4ad76e681d0020", @"/Views/Home/Exam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a09f654893bbb916c75be4bda7db7c5fc1117316", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Exam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
  
    ViewData["Title"] = "Home Page";
    var myArticle = (ArticleResponseModel)ViewData["myArticle"];
    var myQuestions = (QuestionResponseModel)ViewData["myQuestions"];
    var myOptions = (OptionResponseModel)ViewData["myOptions"];

    string[] q = new string[4];
    string[] a = new string[4];
    int counter = 0;
    foreach (var item in myQuestions.Questions)
    {
        q[counter] = item.Contect;
        a[counter] = item.Answer;
        counter = counter + 1;
    }

    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <div class=\"container\" style=\"width:initial\">\r\n        <h1 style=\"text-align:center\">\r\n            ");
#nullable restore
#line 23 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
       Write(myArticle.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n        <div class=\"align-content-around\">\r\n            <p style=\"font-size:large; margin-top:1em; border:1px solid #c3c3c3; padding:15px\" class=\"display-4\">\r\n                ");
#nullable restore
#line 27 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
           Write(myArticle.Contect);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </p>
        </div>
    </div>
    <hr />
    <div class=""text-center"" style=""margin-top:2em"">
        <div class=""text-center"" style=""margin-top:2em"">
            <div class=""col-md-6 float-left"">
                <p style=""font-size:large"" class=""display-4"">");
#nullable restore
#line 35 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
                                                        Write(q[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 36 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
                 foreach (var option in myOptions.Options1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"options\">\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 1338, "\"", 1355, 1);
#nullable restore
#line 39 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
WriteAttributeValue("", 1343, "a"+count, 1343, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"alert alert-secondary\" role=\"alert\">\r\n                            ");
#nullable restore
#line 40 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
                       Write(option.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 43 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
                    count = count + 1;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"text-center\" style=\"margin-top:2em\">\r\n            <div class=\"col-md-6 float-left\">\r\n                <p style=\"font-size:large\" class=\"display-4\">");
#nullable restore
#line 49 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
                                                        Write(q[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 50 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
                 foreach (var option in myOptions.Options2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"options\">\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 1931, "\"", 1948, 1);
#nullable restore
#line 53 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
WriteAttributeValue("", 1936, "b"+count, 1936, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"alert alert-secondary\" role=\"alert\">\r\n                            ");
#nullable restore
#line 54 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
                       Write(option.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 57 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
                    count = count + 1;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <br />\r\n        <div class=\"text-center\" style=\"margin-top:2em\">\r\n            <div class=\"col-md-6 float-left\">\r\n                <p style=\"font-size:large\" class=\"display-4\">");
#nullable restore
#line 64 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
                                                        Write(q[2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 65 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
                 foreach (var option in myOptions.Options3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"options\">\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 2540, "\"", 2557, 1);
#nullable restore
#line 68 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
WriteAttributeValue("", 2545, "c"+count, 2545, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"alert alert-secondary\" role=\"alert\">\r\n                            ");
#nullable restore
#line 69 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
                       Write(option.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 72 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
                    count = count + 1;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"text-center\" style=\"margin-top:2em\">\r\n            <div class=\"col-md-6 float-left\">\r\n                <p style=\"font-size:large\" class=\"display-4\">");
#nullable restore
#line 78 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
                                                        Write(q[3]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 79 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
                 foreach (var option in myOptions.Options4)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"options\">\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 3133, "\"", 3150, 1);
#nullable restore
#line 82 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
WriteAttributeValue("", 3138, "d"+count, 3138, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"alert alert-secondary\" role=\"alert\">\r\n                            ");
#nullable restore
#line 83 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
                       Write(option.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 86 "C:\Users\furka\source\repos\Wired\Wired.Web\Views\Home\Exam.cshtml"
                    count = count + 1;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div class=\"text-center\">\r\n        <button class=\"btn btn-primary\">Sınavı Tamamla</button>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78d597caff1863a61cb3805e2d4ad76e681d002012386", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(document).ready(function () {



    });

    $(""#options"").click(function (event) {
        $.ajax({
            type: ""POST"",
            url: ""/home/result?textId=5"",
            dataType: ""json"",
            success: function (data) {

            }
        });
        var answer = event.target.id.replace('option', '');
        if (answer === 'A') {
            $(""#optionA"").css(""background-color"", ""rgba(0, 230, 64, 1)"");
        }
    });
</script>");
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
