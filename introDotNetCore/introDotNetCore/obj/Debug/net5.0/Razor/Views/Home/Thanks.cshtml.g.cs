#pragma checksum "C:\Users\turka\source\repos\Kurumsal\Vakıfbank\.NET Core Part I\introDotNetCore\introDotNetCore\Views\Home\Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a37785ae1c272bc77276a452685d9ee8d453798"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Thanks), @"mvc.1.0.view", @"/Views/Home/Thanks.cshtml")]
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
#line 1 "C:\Users\turka\source\repos\Kurumsal\Vakıfbank\.NET Core Part I\introDotNetCore\introDotNetCore\Views\_ViewImports.cshtml"
using introDotNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a37785ae1c272bc77276a452685d9ee8d453798", @"/Views/Home/Thanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b24226fcd6cd4da0705da8b319e88b997c7b6a82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IncomingUsers>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n    Teşekkürler!\r\n\r\n    <h2> Gelen kullanıcılar: </h2>\r\n");
#nullable restore
#line 11 "C:\Users\turka\source\repos\Kurumsal\Vakıfbank\.NET Core Part I\introDotNetCore\introDotNetCore\Views\Home\Thanks.cshtml"
     if (Model.UserResponses.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table>\r\n");
#nullable restore
#line 14 "C:\Users\turka\source\repos\Kurumsal\Vakıfbank\.NET Core Part I\introDotNetCore\introDotNetCore\Views\Home\Thanks.cshtml"
             foreach (var item in Model.UserResponses)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 18 "C:\Users\turka\source\repos\Kurumsal\Vakıfbank\.NET Core Part I\introDotNetCore\introDotNetCore\Views\Home\Thanks.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 18 "C:\Users\turka\source\repos\Kurumsal\Vakıfbank\.NET Core Part I\introDotNetCore\introDotNetCore\Views\Home\Thanks.cshtml"
                               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 21 "C:\Users\turka\source\repos\Kurumsal\Vakıfbank\.NET Core Part I\introDotNetCore\introDotNetCore\Views\Home\Thanks.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 23 "C:\Users\turka\source\repos\Kurumsal\Vakıfbank\.NET Core Part I\introDotNetCore\introDotNetCore\Views\Home\Thanks.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IncomingUsers> Html { get; private set; }
    }
}
#pragma warning restore 1591
