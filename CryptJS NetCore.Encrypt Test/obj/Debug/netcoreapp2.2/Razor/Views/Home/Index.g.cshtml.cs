#pragma checksum "G:\CodeTest\CryptJS NetCore.Encrypt Test\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e72cb70f13977a29525ab00216581c8e92851f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "G:\CodeTest\CryptJS NetCore.Encrypt Test\Views\_ViewImports.cshtml"
using CryptJS_NetCore.Encrypt_Test;

#line default
#line hidden
#line 2 "G:\CodeTest\CryptJS NetCore.Encrypt Test\Views\_ViewImports.cshtml"
using CryptJS_NetCore.Encrypt_Test.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e72cb70f13977a29525ab00216581c8e92851f5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa105f93a37fa90a6145e03bff0bfc79214c1dd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "G:\CodeTest\CryptJS NetCore.Encrypt Test\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 211, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<p id=\"testcrypt\">");
            EndContext();
            BeginContext(257, 17, false);
#line 10 "G:\CodeTest\CryptJS NetCore.Encrypt Test\Views\Home\Index.cshtml"
             Write(ViewBag.CryptCode);

#line default
#line hidden
            EndContext();
            BeginContext(274, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(299, 457, true);
                WriteLiteral(@" 
<script>
    $().ready(function () {
        var key  = CryptoJS.enc.Utf8.parse(""123456789012345678901234567890AA"");
        var iv   = CryptoJS.enc.Utf8.parse(""1234567890ABCDEF"");
        var encrypted = CryptoJS.AES.decrypt($(""#testcrypt"").html(), key, {
            iv: iv,
            mode: CryptoJS.mode.CBC,
            padding: CryptoJS.pad.Pkcs7
        });
        $(""#testcrypt"").html(encrypted.toString());
    });
    
</script>
");
                EndContext();
            }
            );
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
