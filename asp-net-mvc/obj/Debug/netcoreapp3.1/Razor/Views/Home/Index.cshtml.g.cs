#pragma checksum "F:\GitHub\c#\asp-net-mvc\asp-net-mvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a925866ec94c938b2a3597f68218c4fbf86622d"
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
#line 1 "F:\GitHub\c#\asp-net-mvc\asp-net-mvc\Views\_ViewImports.cshtml"
using asp_net_mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\GitHub\c#\asp-net-mvc\asp-net-mvc\Views\_ViewImports.cshtml"
using asp_net_mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a925866ec94c938b2a3597f68218c4fbf86622d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"925ac3579c879115ad33834b0ad0d20314b86d4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\GitHub\c#\asp-net-mvc\asp-net-mvc\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
    <h2 id=""ajaxTest"">Hello,Index Page!</h2>
    <button onclick=""query()"">click me</button>
    
    <button onclick=""setting()"">send command</button>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""/lib/jquery/dist/jquery.min.js""></script>
    <script type=""text/javascript"">
        function query() {
            $.ajax({
               type: ""GET"",
               // url: ""/api/action"",
               url: ""/api/string"",
               dataType: ""text"",
               contentType: ""application/json;charset=UTF-8"",
               // data: JSON.stringify(params),
               success: function(data) {
                    $(""#ajaxTest"").html(data);
               }
          });
        }
        
        function setting() {
            var params = {""Mac"":""201912176604""};
            $.ajax({
               type: ""POST"",
               url: ""/api/setting"",
               dataType: ""text"",
               contentType: ""application/json;charset=UTF-8"",
               data: JSON.stringify(params),
               success: function(data) {
                    $(""#ajaxTest"").html(data);
               }
          });
        }
    </script>
");
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
