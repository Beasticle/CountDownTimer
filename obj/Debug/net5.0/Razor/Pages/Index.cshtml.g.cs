#pragma checksum "C:\Users\ServiceOps\source\repos\Test\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "446372c821e3fd7023a8bb9f0fbfb641085644c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Test.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Test.Pages
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
#line 1 "C:\Users\ServiceOps\source\repos\Test\Pages\_ViewImports.cshtml"
using Test;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"446372c821e3fd7023a8bb9f0fbfb641085644c1", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51b046f8f0016a7cb416e5bc00663fd1b2383587", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ServiceOps\source\repos\Test\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">IT\'S THE FINAL COUNTDOWN</h1>\r\n    <p>Count down timers for when I get car back and when I get my license back.</p>\r\n</div>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\ServiceOps\source\repos\Test\Pages\Index.cshtml"
   
    DateTime today = DateTime.Today;
    DateTime carDate = new DateTime(2022, 3, 8);
    DateTime licenseDate = new DateTime(2022, 8, 12);
    String timeLeft(DateTime date)
    {
        TimeSpan diff = today - date;
        return diff.ToString("%d") + " days";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <p>There is ");
#nullable restore
#line 24 "C:\Users\ServiceOps\source\repos\Test\Pages\Index.cshtml"
            Write(timeLeft(carDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" until you can drive your car.</p>\r\n    <p>There is ");
#nullable restore
#line 25 "C:\Users\ServiceOps\source\repos\Test\Pages\Index.cshtml"
            Write(timeLeft(licenseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" until you get your license back. </p>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
