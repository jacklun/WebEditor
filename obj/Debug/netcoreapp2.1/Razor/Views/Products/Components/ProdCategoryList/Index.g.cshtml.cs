#pragma checksum "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Products\Components\ProdCategoryList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0d925a5c1a0a7b71b8a340149f46aebfcca25ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Components_ProdCategoryList_Index), @"mvc.1.0.view", @"/Views/Products/Components/ProdCategoryList/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Components/ProdCategoryList/Index.cshtml", typeof(AspNetCore.Views_Products_Components_ProdCategoryList_Index))]
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
#line 1 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Products\Components\ProdCategoryList\Index.cshtml"
using WebEditor.ViewComponents;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d925a5c1a0a7b71b8a340149f46aebfcca25ec", @"/Views/Products/Components/ProdCategoryList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d171ce1015461db1adf8362fcb9ea95002117292", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Components_ProdCategoryList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProdCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 7, true);
            WriteLiteral("<div>\r\n");
            EndContext();
#line 4 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Products\Components\ProdCategoryList\Index.cshtml"
     foreach (ProdCategory item in Model)
    {

#line default
#line hidden
            BeginContext(125, 14, true);
            WriteLiteral("        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 139, "\"", 182, 2);
            WriteAttributeValue("", 146, "/ProductMain/ProductList?id=", 146, 28, true);
#line 6 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Products\Components\ProdCategoryList\Index.cshtml"
WriteAttributeValue("", 174, item.id, 174, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(183, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(186, 9, false);
#line 6 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Products\Components\ProdCategoryList\Index.cshtml"
                                                       Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(195, 12, true);
            WriteLiteral(" </a></li>\r\n");
            EndContext();
#line 7 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Products\Components\ProdCategoryList\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(214, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProdCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
