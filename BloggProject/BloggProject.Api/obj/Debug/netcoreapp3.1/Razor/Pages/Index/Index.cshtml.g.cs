#pragma checksum "C:\Users\ireem\source\repos\BloggProject\BloggProject.Api\Pages\Index\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30ca808b3d3bfbcf7210661ba18f3891c634716e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BloggProject.Api.Pages.Index.Pages_Index_Index), @"mvc.1.0.razor-page", @"/Pages/Index/Index.cshtml")]
namespace BloggProject.Api.Pages.Index
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
#line 1 "C:\Users\ireem\source\repos\BloggProject\BloggProject.Api\Pages\_ViewImports.cshtml"
using BloggProject.Api;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30ca808b3d3bfbcf7210661ba18f3891c634716e", @"/Pages/Index/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6654f53c4d02fd46a11c7464b8fed029f9244d82", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ireem\source\repos\BloggProject\BloggProject.Api\Pages\Index\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>
<div classs=""card-body"">
    <table class=""table-bordered"" id=""Table"">
        <tr>
            <th> Phone </th>
            <th> About </th>
        </tr>
    </table>

  <h1>Onget metodundan gelen deger</h1>
    ");
#nullable restore
#line 22 "C:\Users\ireem\source\repos\BloggProject\BloggProject.Api\Pages\Index\Index.cshtml"
Write(Model.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(" \r\n<script src=\"/Pages/Index/Index.js\"></script>\r\n");
            }
            );
            WriteLiteral(@"<script>
    $(document).ready(function () {
        //var uri = ""https://localhost:44304/api/profile"";
        //console.log(""uri"", uri)
        debugger;
        $.ajax({          
            url: ""https://localhost:44304/api/profile"",
            type: ""GET"",
            contentType: ""application/json;charset-utf-8"",
            dataType:""json"",
            success: function (res) {
                console.log(""data2"", res);
                $.each(res, function (i, item) {                   
                    var rows = ""<tr>"" +
                        ""<td id='phone'>"" + item.phone + ""</td>"" +
                        ""<td id='about'>"" + item.about + ""</td>"" +
                        ""</tr>"";
                    $('#Table').append(rows);
                })
               
            }

        });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
