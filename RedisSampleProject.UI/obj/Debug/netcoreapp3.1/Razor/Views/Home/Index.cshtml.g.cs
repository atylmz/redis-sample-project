#pragma checksum "C:\Workspace\redis-sample-project\RedisSampleProject.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2825fbd6efa415fe602c202820597027996803ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Workspace\redis-sample-project\RedisSampleProject.UI\Views\_ViewImports.cshtml"
using RedisSampleProject.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workspace\redis-sample-project\RedisSampleProject.UI\Views\_ViewImports.cshtml"
using RedisSampleProject.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Workspace\redis-sample-project\RedisSampleProject.UI\Views\_ViewImports.cshtml"
using RedisSampleProject.UI.Models.DataModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2825fbd6efa415fe602c202820597027996803ad", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b540686bc663a8133255475250d85ee3904b3c74", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserVMList>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Workspace\redis-sample-project\RedisSampleProject.UI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    int index = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .my-custom-scrollbar {
        position: relative;
        height: 200px;
        overflow: auto;
    }

    .table-wrapper-scroll-y {
        display: block;
    }
</style>
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6"">
            <h1>Input</h1>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2825fbd6efa415fe602c202820597027996803ad4641", async() => {
                WriteLiteral(@"
                <div class=""form-group"">
                    <label for=""exampleInputEmail1"">Email Address</label>
                    <input type=""email"" class=""form-control"" id=""email"" aria-describedby=""emailHelp"" name=""eMail"">
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputUsername"">UserName</label>
                    <input type=""text"" class=""form-control"" id=""username"" name=""userName"">
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputPassword1"">Password</label>
                    <input type=""password"" class=""form-control"" id=""password2"" name=""password"">
                </div>
                <button type=""submit"" class=""btn btn-primary"">Submit</button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""col-md-6"">
            <h1>List</h1>
            <div class=""table-wrapper-scroll-y my-custom-scrollbar"">
                <table class=""table table-bordered table-striped mb-0"">
                    <thead>
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">E-mail</th>
                            <th scope=""col"">UserName</th>
                            

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 53 "C:\Workspace\redis-sample-project\RedisSampleProject.UI\Views\Home\Index.cshtml"
                         for (int i = 1; i < Model.Count+1; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 56 "C:\Workspace\redis-sample-project\RedisSampleProject.UI\Views\Home\Index.cshtml"
                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 57 "C:\Workspace\redis-sample-project\RedisSampleProject.UI\Views\Home\Index.cshtml"
                           Write(Model[i-1].Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 58 "C:\Workspace\redis-sample-project\RedisSampleProject.UI\Views\Home\Index.cshtml"
                           Write(Model[i-1].UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 60 "C:\Workspace\redis-sample-project\RedisSampleProject.UI\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        {
                            
                            
                        }
                       
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <hr />
    <div>
        <h3 style=""text-align:center""");
            BeginWriteAttribute("class", " class=", 2504, "", 2525, 1);
#nullable restore
#line 73 "C:\Workspace\redis-sample-project\RedisSampleProject.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 2511, ViewBag.Cache, 2511, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 73 "C:\Workspace\redis-sample-project\RedisSampleProject.UI\Views\Home\Index.cshtml"
                                                      Write(ViewBag.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserVMList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
