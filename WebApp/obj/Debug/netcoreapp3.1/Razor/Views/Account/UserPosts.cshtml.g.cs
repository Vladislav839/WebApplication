#pragma checksum "D:\Рабочий стол\WebApp\WebApplication\WebApp\Views\Account\UserPosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "256eb7c87d3a0159cf69a50833f6dd4c66c1d915"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_UserPosts), @"mvc.1.0.view", @"/Views/Account/UserPosts.cshtml")]
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
#line 1 "D:\Рабочий стол\WebApp\WebApplication\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Рабочий стол\WebApp\WebApplication\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"256eb7c87d3a0159cf69a50833f6dd4c66c1d915", @"/Views/Account/UserPosts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_UserPosts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Рабочий стол\WebApp\WebApplication\WebApp\Views\Account\UserPosts.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"searchresults\" class=\"text-dark\">\r\n            <div class=\"media border p-3\">\r\n            <div class=\"media-body\">\r\n                <h4 style=\"color: red;\">");
#nullable restore
#line 10 "D:\Рабочий стол\WebApp\WebApplication\WebApp\Views\Account\UserPosts.cshtml"
                                   Write(Model.Owner);

#line default
#line hidden
#nullable disable
            WriteLiteral("<small><i style=\"color: red;\">Posted on ");
#nullable restore
#line 10 "D:\Рабочий стол\WebApp\WebApplication\WebApp\Views\Account\UserPosts.cshtml"
                                                                                       Write(Model.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></small></h4>\r\n                <p style=\"color: red;\">");
#nullable restore
#line 11 "D:\Рабочий стол\WebApp\WebApplication\WebApp\Views\Account\UserPosts.cshtml"
                                  Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591