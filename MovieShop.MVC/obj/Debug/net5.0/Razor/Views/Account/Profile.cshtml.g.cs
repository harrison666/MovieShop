#pragma checksum "E:\1_Study\9_CS\15_Antra\HW\MovieShop\MovieShop.MVC\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78d7072243fb2a14b840a50cafbef148a42655bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
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
#line 1 "E:\1_Study\9_CS\15_Antra\HW\MovieShop\MovieShop.MVC\Views\_ViewImports.cshtml"
using MovieShop.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\1_Study\9_CS\15_Antra\HW\MovieShop\MovieShop.MVC\Views\_ViewImports.cshtml"
using MovieShop.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78d7072243fb2a14b840a50cafbef148a42655bc", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ed27a90769d57c4cf1e99ddf07e56b08d479e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationCore.Models.Response.UserProfileResponseModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>\r\n    View Profile\r\n</h2>\r\n\r\n<div>\r\n    <ul>\r\n        <li>\r\n            <span>First Name: ");
#nullable restore
#line 10 "E:\1_Study\9_CS\15_Antra\HW\MovieShop\MovieShop.MVC\Views\Account\Profile.cshtml"
                         Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </li>\r\n        <li>\r\n            <span>Last Name: ");
#nullable restore
#line 13 "E:\1_Study\9_CS\15_Antra\HW\MovieShop\MovieShop.MVC\Views\Account\Profile.cshtml"
                        Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </li>\r\n\r\n        <li>\r\n            <span>Email: ");
#nullable restore
#line 17 "E:\1_Study\9_CS\15_Antra\HW\MovieShop\MovieShop.MVC\Views\Account\Profile.cshtml"
                    Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </li>\r\n        <li>\r\n            <span>Phone Number: ");
#nullable restore
#line 20 "E:\1_Study\9_CS\15_Antra\HW\MovieShop\MovieShop.MVC\Views\Account\Profile.cshtml"
                           Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </li>\r\n        <li>\r\n            <span>Date Of Birth: ");
#nullable restore
#line 23 "E:\1_Study\9_CS\15_Antra\HW\MovieShop\MovieShop.MVC\Views\Account\Profile.cshtml"
                            Write(Model.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </li>\r\n\r\n\r\n\r\n    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationCore.Models.Response.UserProfileResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
