#pragma checksum "C:\project\vlad\WebApplication\WebApp\Views\Dialog\Dialog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48e8f5150009f945e542171ac3b5b2b8826df36e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dialog_Dialog), @"mvc.1.0.view", @"/Views/Dialog/Dialog.cshtml")]
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
#line 1 "C:\project\vlad\WebApplication\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\project\vlad\WebApplication\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\project\vlad\WebApplication\WebApp\Views\Dialog\Dialog.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\project\vlad\WebApplication\WebApp\Views\Dialog\Dialog.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48e8f5150009f945e542171ac3b5b2b8826df36e", @"/Views/Dialog/Dialog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dec085bf195b01abb92852e860e2ca042d6a2857", @"/Views/_ViewImports.cshtml")]
    public class Views_Dialog_Dialog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Models.Dialog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dialog.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\project\vlad\WebApplication\WebApp\Views\Dialog\Dialog.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Dialog";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e8f5150009f945e542171ac3b5b2b8826df36e7256", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 13 "C:\project\vlad\WebApplication\WebApp\Views\Dialog\Dialog.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "48e8f5150009f945e542171ac3b5b2b8826df36e7873", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "48e8f5150009f945e542171ac3b5b2b8826df36e9051", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "48e8f5150009f945e542171ac3b5b2b8826df36e10229", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e8f5150009f945e542171ac3b5b2b8826df36e12112", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">
        <div class=""content"">
<header>
    <div class=""container-fluid"">
            <div class=""row bg-dark align-items-center"">
                <div class=""col-md-2 text-center text-white mb-3 mt-4"">SOCIAL ME</div>
                <div class=""col-md-4 mt-4 mb-3"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e8f5150009f945e542171ac3b5b2b8826df36e12701", async() => {
                    WriteLiteral("\r\n                        <input type=\"text\" class=\"form-control\" placeholder=\"Искать здесь...\">\r\n                        <button class=\"bth btn-success ml-2\">Search</button>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-3 d-flex offset-md-3 mt-3 text-white\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 1203, "\"", 1310, 1);
#nullable restore
#line 32 "C:\project\vlad\WebApplication\WebApp\Views\Dialog\Dialog.cshtml"
WriteAttributeValue("", 1210, Url.RouteUrl(new { controller = "Account", action = "IndexByName", username =@User.Identity.Name }), 1210, 100, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-light mt-2  mb-3 mr-3\">HOME</a> \r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e8f5150009f945e542171ac3b5b2b8826df36e14940", async() => {
                    WriteLiteral("\r\n                        <input class=\"btn btn-light mt-2  mb-3 mr-3\" type=\"submit\" value=\"Logout\" />\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
        </div>
    <div class=""block-for-messages"">
        <div id=""messages"">
        
        </div>
    </div>
    
        
    <div class=""message-text-class mb-3"" id=""message-text"">
        <textarea placeholder=""Hi"" rows=""3"" class=""form-control input-text"" id=""message_text"" cols=""40"" name=""text_of_message""></textarea>
        <button id=""send-message"" value=""Send"" class=""btn btn-primary"">Send</button>
    </div>
</header>
        </div>
    <footer class=""page-footer bg-dark font-small blue"">
        <div class=""text-center text-gray-dark py-3"">
            © 2020 Copyright:
        </div>
    </footer>
</div>

");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e8f5150009f945e542171ac3b5b2b8826df36e17715", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n<script type=\"text/javascript\">\r\n\r\n    $(document).ready(function(){\r\n      $.ajax({\r\n      type:\'GET\',\r\n      url:\'");
#nullable restore
#line 65 "C:\project\vlad\WebApplication\WebApp\Views\Dialog\Dialog.cshtml"
      Write(Url.Action("GetMessagesOfDialog", "Dialog"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n      data:{\r\n          id: ");
#nullable restore
#line 67 "C:\project\vlad\WebApplication\WebApp\Views\Dialog\Dialog.cshtml"
         Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
      }    
    })
    .done(function (data){
                let count = 0;
                let ddl = ' ';
                $.each(data, function(index, element){
                    count++;
                    ddl += DrawMessage(element);
                });
                console.log(ddl);
                if(count === 0){
                       ddl = '<div id=""no-message"" style=""text-align: center; font-style: italic;"">No messages yet</div>'
                }
                $(ddl).insertBefore(""#messages"");
                
    });
    })
    var DrawMessage = function(element){
        let m = ' ';
        var user =GetUser(element.ownerId);
        m += '<div class=""container-for-message"" style=""width: 40%;"">\n';
        m += '<div class=""media-body"">\n';
        m += '<div class=""container d-flex flex-row"" style=""margin-left: -14px; margin-bottom: 15px;"">' + '<img src=""';
        m += user.path + '""';
        m += 'class=""mr-3 mt-3 rounded-circle"" style=""width:40px; object-fi");
                WriteLiteral(@"t: cover; height: 40px;"">\n';
        m += '<h4 class=""text-dark mt-3"">';
        m += user.nickName;
        m += ' ' + '<i class=""time-color""><small>' + ConvertTimeToMessageFormat(element.sendingTime) + '</small></i></h4></div>\n';
        m += '<div class=""text-of-message"">\n';
        m += '<p class=""text-dark"">' + element.text + '</p>\n';  
        m += '</div>\n';
        m += '</div>\n';
        m += '</div>\n';
        m += '</div>';
        
        return m;
    };
 
 let ConvertTimeToMessageFormat = function(time){
        let t = ' ';
        for(let i = 11; i < 16; i++){
        t += time[i];
        };
        return t;
    };
    var GetTime = function(messageId) {
    let t = ' ';
    $.ajax(
        {
        type: 'Get',
        url:'");
#nullable restore
#line 118 "C:\project\vlad\WebApplication\WebApp\Views\Dialog\Dialog.cshtml"
        Write(Url.Action("GetSendingTimeOfMessageById", "Dialog"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
        async: false,
        data:{
            id: messageId
        }
        }
    ).done(function(time) {
     t = time; 
    });
    return t;
    }
    var GetUser = function(data){
        let u;
        $.ajax({
        type: 'Get',
        url:'");
#nullable restore
#line 133 "C:\project\vlad\WebApplication\WebApp\Views\Dialog\Dialog.cshtml"
        Write(Url.Action("GetUserById", "Dialog"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
        async: false,
        data:{
            id: data
        }
        })   
        .done(function (user){
            u = user;
        });
        return u;
    };
    

         $('#send-message').on('click', function() {
            $.ajax({
              url:'");
#nullable restore
#line 148 "C:\project\vlad\WebApplication\WebApp\Views\Dialog\Dialog.cshtml"
              Write(Url.Action("SaveMessage", "Dialog"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n              type:\'POST\',\r\n              data: {\r\n                  text: $(\'#message_text\').val(),\r\n                  id: ");
#nullable restore
#line 152 "C:\project\vlad\WebApplication\WebApp\Views\Dialog\Dialog.cshtml"
                 Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
              }
            }).done(function(data) {
                $('#no-message').css('visibility', 'none');
                 let ddl = ' ';
                     ddl += DrawMessage(data); 
            $(ddl).insertBefore(""#messages"");              
            })
 
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Models.Dialog> Html { get; private set; }
    }
}
#pragma warning restore 1591
