#pragma checksum "/Users/dallinjared/Box/BYU/2021 Winter/IS413/Projects/Assignment5/Assignment5/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e0dab1650725be250feea72922be96942d4d80f"
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
#line 1 "/Users/dallinjared/Box/BYU/2021 Winter/IS413/Projects/Assignment5/Assignment5/Views/_ViewImports.cshtml"
using Assignment5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dallinjared/Box/BYU/2021 Winter/IS413/Projects/Assignment5/Assignment5/Views/_ViewImports.cshtml"
using Assignment5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e0dab1650725be250feea72922be96942d4d80f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61665519b41838e6b755733af02d48e6858089e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/dallinjared/Box/BYU/2021 Winter/IS413/Projects/Assignment5/Assignment5/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("<div class=\"text-center\">\n    <h1 class=\"display-4\">Daintree Books</h1>\n</div>\n\n");
#nullable restore
#line 10 "/Users/dallinjared/Box/BYU/2021 Winter/IS413/Projects/Assignment5/Assignment5/Views/Home/Index.cshtml"
 foreach (var x in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card items-center\">\n        <div class=\"card-body text-center\">\n            <h4 class=\"card-title text-center\">");
#nullable restore
#line 14 "/Users/dallinjared/Box/BYU/2021 Winter/IS413/Projects/Assignment5/Assignment5/Views/Home/Index.cshtml"
                                          Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            <h6 class=\"card-subtitle mb-2 text-muted text-center\">");
#nullable restore
#line 15 "/Users/dallinjared/Box/BYU/2021 Winter/IS413/Projects/Assignment5/Assignment5/Views/Home/Index.cshtml"
                                                             Write(x.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n            <br />\n            <div>\n                <p class=\"card-text\">Publisher : ");
#nullable restore
#line 18 "/Users/dallinjared/Box/BYU/2021 Winter/IS413/Projects/Assignment5/Assignment5/Views/Home/Index.cshtml"
                                            Write(x.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p class=\"card-text\">Genre : ");
#nullable restore
#line 19 "/Users/dallinjared/Box/BYU/2021 Winter/IS413/Projects/Assignment5/Assignment5/Views/Home/Index.cshtml"
                                        Write(x.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p class=\"card-text\">ISBN : ");
#nullable restore
#line 20 "/Users/dallinjared/Box/BYU/2021 Winter/IS413/Projects/Assignment5/Assignment5/Views/Home/Index.cshtml"
                                       Write(x.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p class=\"card-text\">Price : $");
#nullable restore
#line 21 "/Users/dallinjared/Box/BYU/2021 Winter/IS413/Projects/Assignment5/Assignment5/Views/Home/Index.cshtml"
                                         Write(x.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 25 "/Users/dallinjared/Box/BYU/2021 Winter/IS413/Projects/Assignment5/Assignment5/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591