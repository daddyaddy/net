#pragma checksum "C:\Users\Adrian\source\repos\flangery-net\flangery-net\Views\Song\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46c78ae9739b5094eec72f575547d5e28565bace"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(flangery_net.Pages.Views_Song_Index), @"mvc.1.0.view", @"/Views/Song/Index.cshtml")]
namespace flangery_net.Pages
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
#line 1 "C:\Users\Adrian\source\repos\flangery-net\flangery-net\Views\Song\_ViewImports.cshtml"
using flangery_net;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46c78ae9739b5094eec72f575547d5e28565bace", @"/Views/Song/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ac5b10ce09e8396883f2c161f3f5efe2cca25c", @"/Views/Song/_ViewImports.cshtml")]
    public class Views_Song_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<flangery_net.SongModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Adrian\source\repos\flangery-net\flangery-net\Views\Song\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista dodanych utworów</h1>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 10 "C:\Users\Adrian\source\repos\flangery-net\flangery-net\Views\Song\Index.cshtml"
Write(Html.ActionLink("Add song", "Create", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Adrian\source\repos\flangery-net\flangery-net\Views\Song\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cover));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Adrian\source\repos\flangery-net\flangery-net\Views\Song\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Adrian\source\repos\flangery-net\flangery-net\Views\Song\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.artist));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\Adrian\source\repos\flangery-net\flangery-net\Views\Song\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 737, "\"", 767, 1);
#nullable restore
#line 33 "C:\Users\Adrian\source\repos\flangery-net\flangery-net\Views\Song\Index.cshtml"
WriteAttributeValue("", 743, Url.Content(item.cover), 743, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\Adrian\source\repos\flangery-net\flangery-net\Views\Song\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\Adrian\source\repos\flangery-net\flangery-net\Views\Song\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.artist));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\Adrian\source\repos\flangery-net\flangery-net\Views\Song\Index.cshtml"
               Write(Html.ActionLink("Edytuj", "Edit", new { id=item.songId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 44 "C:\Users\Adrian\source\repos\flangery-net\flangery-net\Views\Song\Index.cshtml"
               Write(Html.ActionLink("Szczegóły", "Details", new { id=item.songId  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Adrian\source\repos\flangery-net\flangery-net\Views\Song\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<flangery_net.SongModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
