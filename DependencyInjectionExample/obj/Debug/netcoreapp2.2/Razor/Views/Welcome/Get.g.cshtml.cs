#pragma checksum "C:\Users\MSI\source\repos\DependencyInjectionExample\DependencyInjectionExample\Views\Welcome\Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c49f462dd84658154631c53d4134dc970f88fb03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Welcome_Get), @"mvc.1.0.view", @"/Views/Welcome/Get.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Welcome/Get.cshtml", typeof(AspNetCore.Views_Welcome_Get))]
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
#line 1 "C:\Users\MSI\source\repos\DependencyInjectionExample\DependencyInjectionExample\Views\_ViewImports.cshtml"
using DependencyInjectionExample;

#line default
#line hidden
#line 2 "C:\Users\MSI\source\repos\DependencyInjectionExample\DependencyInjectionExample\Views\_ViewImports.cshtml"
using DependencyInjectionExample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c49f462dd84658154631c53d4134dc970f88fb03", @"/Views/Welcome/Get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5be280785b153024431c7626fb8144faba1be00e", @"/Views/_ViewImports.cshtml")]
    public class Views_Welcome_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(101, 36, false);
#line 7 "C:\Users\MSI\source\repos\DependencyInjectionExample\DependencyInjectionExample\Views\Welcome\Get.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(137, 71, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(209, 33, false);
#line 12 "C:\Users\MSI\source\repos\DependencyInjectionExample\DependencyInjectionExample\Views\Welcome\Get.cshtml"
           Write(Html.DisplayFor(model=>model.age));

#line default
#line hidden
            EndContext();
            BeginContext(242, 64, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    \r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591