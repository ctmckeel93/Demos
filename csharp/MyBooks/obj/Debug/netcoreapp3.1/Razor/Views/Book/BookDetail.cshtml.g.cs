#pragma checksum "/Users/coreymckeel/Desktop/Demos/csharp/MyBooks/Views/Book/BookDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bab0e2acd458eab27267247ac88665baae62de33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_BookDetail), @"mvc.1.0.view", @"/Views/Book/BookDetail.cshtml")]
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
#line 1 "/Users/coreymckeel/Desktop/Demos/csharp/MyBooks/Views/_ViewImports.cshtml"
using MyBooks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/coreymckeel/Desktop/Demos/csharp/MyBooks/Views/_ViewImports.cshtml"
using MyBooks.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bab0e2acd458eab27267247ac88665baae62de33", @"/Views/Book/BookDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da1ee1178a931a732d44691a38db717c0fdb5477", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_BookDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"text-center d-flex justify-space-between\">\n    <h1>");
#nullable restore
#line 4 "/Users/coreymckeel/Desktop/Demos/csharp/MyBooks/Views/Book/BookDetail.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1> \n</div>\n<a");
            BeginWriteAttribute("href", " href=\"", 105, "\"", 136, 2);
            WriteAttributeValue("", 112, "/books/add/", 112, 11, true);
#nullable restore
#line 6 "/Users/coreymckeel/Desktop/Demos/csharp/MyBooks/Views/Book/BookDetail.cshtml"
WriteAttributeValue("", 123, Model.BookId, 123, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-success\">Add to Collection</button></a>\n\n<p>Genre: ");
#nullable restore
#line 8 "/Users/coreymckeel/Desktop/Demos/csharp/MyBooks/Views/Book/BookDetail.cshtml"
     Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Author: ");
#nullable restore
#line 9 "/Users/coreymckeel/Desktop/Demos/csharp/MyBooks/Views/Book/BookDetail.cshtml"
      Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<h2><u>Readers</u></h2>\n<ul>\n");
#nullable restore
#line 13 "/Users/coreymckeel/Desktop/Demos/csharp/MyBooks/Views/Book/BookDetail.cshtml"
           
            foreach(Bookshelf shelf in @Model.Owners)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>");
#nullable restore
#line 16 "/Users/coreymckeel/Desktop/Demos/csharp/MyBooks/Views/Book/BookDetail.cshtml"
              Write(shelf.Reader.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "/Users/coreymckeel/Desktop/Demos/csharp/MyBooks/Views/Book/BookDetail.cshtml"
                                      Write(shelf.Reader.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 17 "/Users/coreymckeel/Desktop/Demos/csharp/MyBooks/Views/Book/BookDetail.cshtml"
            }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
