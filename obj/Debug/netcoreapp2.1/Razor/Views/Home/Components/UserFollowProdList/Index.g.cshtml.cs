#pragma checksum "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\UserFollowProdList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4130252666ad31696859b9bf6146806dbd8b6070"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_UserFollowProdList_Index), @"mvc.1.0.view", @"/Views/Home/Components/UserFollowProdList/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Components/UserFollowProdList/Index.cshtml", typeof(AspNetCore.Views_Home_Components_UserFollowProdList_Index))]
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
#line 1 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\_ViewImports.cshtml"
using WebEditor;

#line default
#line hidden
#line 2 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\_ViewImports.cshtml"
using WebEditor.Models;

#line default
#line hidden
#line 1 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\UserFollowProdList\Index.cshtml"
using WebEditor.ViewComponents;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4130252666ad31696859b9bf6146806dbd8b6070", @"/Views/Home/Components/UserFollowProdList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d171ce1015461db1adf8362fcb9ea95002117292", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_UserFollowProdList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 7, true);
            WriteLiteral("<div>\r\n");
            EndContext();
#line 4 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\UserFollowProdList\Index.cshtml"
     foreach (Product item in Model)
    {

#line default
#line hidden
            BeginContext(115, 14, true);
            WriteLiteral("        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 129, "\"", 169, 2);
            WriteAttributeValue("", 136, "/Products/ProductList?id=", 136, 25, true);
#line 6 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\UserFollowProdList\Index.cshtml"
WriteAttributeValue("", 161, item.id, 161, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(170, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(173, 10, false);
#line 6 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\UserFollowProdList\Index.cshtml"
                                                    Write(item.pname);

#line default
#line hidden
            EndContext();
            BeginContext(183, 12, true);
            WriteLiteral(" </a></li>\r\n");
            EndContext();
#line 7 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\UserFollowProdList\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(202, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591