#pragma checksum "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "436ba03f761f71cb634e477f93be7e095682173e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Services_Subscribers), @"mvc.1.0.view", @"/Services/Subscribers.cshtml")]
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
#line 6 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"436ba03f761f71cb634e477f93be7e095682173e", @"/Services/Subscribers.cshtml")]
    public class Services_Subscribers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "436ba03f761f71cb634e477f93be7e095682173e4884", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n    <title>");
#nullable restore
#line 13 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - WebApp</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "436ba03f761f71cb634e477f93be7e095682173e5503", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "436ba03f761f71cb634e477f93be7e095682173e6679", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "436ba03f761f71cb634e477f93be7e095682173e8557", async() => {
                WriteLiteral(@"
    <header>
        <div class=""container-fluid"">
        <div class=""row bg-dark align-items-center"">
            <div class=""col-md-2 text-center text-white mb-3 mt-4"">SOCIAL ME</div>
            <div class=""col-md-4 mt-4 mb-3"">
                <form class=""d-flex"">
                    <input type=""text"" class=""form-control"" placeholder=""Искать здесь..."">
                    <button class=""bth btn-success ml-2"">Search</button>
                </form>
            </div>
            <div class=""col-md-3 d-flex offset-md-3 mt-3 text-white"">
<a");
                BeginWriteAttribute("href", " href=\"", 1026, "\"", 1133, 1);
#nullable restore
#line 29 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
WriteAttributeValue("", 1033, Url.RouteUrl(new { controller = "Account", action = "IndexByName", username =@User.Identity.Name }), 1033, 100, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-light mt-2  mb-3 mr-3"">HOME</a>                <form method=""post"" asp-controller=""Account"" asp-action=""Logout"">
                    <input class=""btn btn-light mt-2  mb-3 mr-3"" type=""submit"" value=""Logout"" />
                </form>
            </div>
        </div>
    </div>
    <div class=""container-fluid"" style=""height: 350px; background: linear-gradient(#7290d6, #36559c); display: flex; flex-direction: column;"">
        <div class=""row align-items-center justify-content-center pt-4"">
            <div style=""width: 200px; height: 200px;"">
                <img");
                BeginWriteAttribute("src", " src=\"", 1720, "\"", 1750, 1);
#nullable restore
#line 38 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
WriteAttributeValue("", 1726, Url.Content(Model.Path), 1726, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""rounded-circle img-fluid"">
            </div>
        </div>
        <div class=""row align-items-center justify-content-center pt-4"">
            <form asp-action=""AddFile"" asp-controller=""Account"" method=""post"" enctype=""multipart/form-data"">
             <div class=""custom-file"">
            <input type=""file"" class=""custom-file-input"" name=""uploadedFile"" id=""customFile"">
            <label class=""custom-file-label"" for=""customFile"">Choose file</label>
             </div>
            <button id=""photo"" type=""submit"" class=""btn btn-primary small"">Change photo</button>
            </form>
        </div>
        <div style=""font-size: 38px; margin-top: -3px;"" class=""text-white text-center"" id=""name"" class=""row align-items-center justify-content-center text-white pt-2"">
            ");
#nullable restore
#line 51 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
       Write(Model.NickName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n");
#nullable restore
#line 53 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
          
            if (User.Identity.Name != Model.NickName)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button id=\"subscribe\" class=\"btn btn-primary small\">Subscribe</button>\n");
#nullable restore
#line 57 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>
    <div class=""container-fluid"" style=""background-color: #35558c;"">
    
        <div class=""container"">
            <div class=""row d-flex justify-content-center align-items-center"">
                <div class=""col-sm-3 text-center mt-3 mb-3""><a class=""text-white"" asp-action=""Index"" asp-controller=""Account""");
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3100, "\"", 3124, 1);
#nullable restore
#line 64 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
WriteAttributeValue("", 3115, Model.Id, 3115, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" >POSTS</a></div>
                <div class=""col-sm-3 text-center mt-3 mb-3""><a class=""text-white"" href=""#"">ABOUT</a></div>
                <div class=""col-sm-3 text-center mt-3 mb-3""><a class=""text-white"" asp-action=""Subscribers"" asp-controller=""Account""");
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3381, "\"", 3405, 1);
#nullable restore
#line 66 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
WriteAttributeValue("", 3396, Model.Id, 3396, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >SUBSCRIBERS (");
#nullable restore
#line 66 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
                                                                                                                                                                      Write(Model.subscribersQuantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(") </a></div>\n                <div class=\"col-sm-3 text-center mt-3 mb-3\"><a class=\"text-white\" asp-action=\"Subscriptions\" asp-controller=\"Account\"");
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3593, "\"", 3617, 1);
#nullable restore
#line 67 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
WriteAttributeValue("", 3608, Model.Id, 3608, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">SUBSCRIPTIONS (");
#nullable restore
#line 67 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
                                                                                                                                                                         Write(Model.subscriptionsQuantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(@")</a></div>
                <div class=""col-sm-3 text-center mt-3 mb-3""><a class=""text-white"" href=""#"">PHOTOS</a></div>
                
            </div>
        </div>
    </div>
</header>
<div id=""subscribers"" style=""display: flex; flex-direction: column; justify-content: center; color: black;"">
   
   
</div>
    
    <div class=""container-fluid"">
    <footer class=""page-footer bg-dark font-small blue"">
        <div class=""text-center text-gray-dark py-3"">
            © 2020 Copyright:
        </div>
    </footer>
    </div>


");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "436ba03f761f71cb634e477f93be7e095682173e15690", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n<script type=\"text/javascript\">\n    $(document).ready(function(){\n      $.ajax({\n      type:\'GET\',\n      url:\'");
#nullable restore
#line 93 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
      Write(Url.Action("GetSubscribersInput", "Account"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\n      data : {\n          id: ");
#nullable restore
#line 95 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
         Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
      }     
    })
    .done(function (data){
                let ddl = ' ';
                $.each(data, function(index, element){
                     ddl += '<div class=""container media border p-3 text-dark"" >\n';
                     ddl +=  '<img src=""';
                     ddl += element.path + '""';
                     ddl += ' class=""mr-3 mt-3 rounded-circle"" style=""width:60px;"">\n';
                     ddl += '<div class=""media-body"">\n';
                     ddl += '<a href=""");
#nullable restore
#line 106 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
                                 Write(Url.RouteUrl(new { controller = "Account", action = "Index", id = 0}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + element.id + '"" class=""text-dark"">' + element.nickName + '<small><i class=""text-dark"">'+ '</i></small></a>\n';               
                     ddl += '<p class=""text-body"">' + ""Subscribers - "" + element.subscribersQuantity +'\n'+ ""Subscriptions - "" + element.subscriptionsQuantity + '</p>\n';
                     ddl +='<a href=""");
#nullable restore
#line 108 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
                                Write(Url.RouteUrl(new { controller = "Dialog", action = "Dialog", id = 0}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + element.id + '"" class=""text-dark"">' + ""Send Message"" + '<small><i class=""text-dark"">'+ '</i></small></a>\n';                 
                     ddl += '</div>\n';
                     ddl += '</div>\n';
                });
                console.log(ddl);
                $(ddl).insertAfter('#subscribers');            
    });
   });
    </script>
<script>
    $('#subscribe').on('click', function() {
                         $.ajax({
                           url:'");
#nullable restore
#line 120 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
                           Write(Url.Action("Subscribe", "Account"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\n                           type:\'POST\',\n                           data: {\n                               target: \'");
#nullable restore
#line 123 "C:\project\vlad\WebApplication\WebApp\Services\Subscribers.cshtml"
                                   Write(Model.NickName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
                           }
                         })
    });

</script>
<script>

        $(""#customFile"").on(""change"", function() {
  var fileName = $(this).val().split(""\\"").pop();
  $(this).siblings("".custom-file-label"").addClass(""selected"").html(fileName);
});
  
</script>
");
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
            WriteLiteral("\n</html>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
