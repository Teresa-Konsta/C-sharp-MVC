#pragma checksum "D:\Centennial\semester 3\Web Application Development (SEC. 002) - comp229\Assignments\Assignment2\Assignment1\Views\Home\ViewRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3e4cca5737000da93f6d971897b6d210cc2a1cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewRecipe), @"mvc.1.0.view", @"/Views/Home/ViewRecipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewRecipe.cshtml", typeof(AspNetCore.Views_Home_ViewRecipe))]
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
#line 2 "D:\Centennial\semester 3\Web Application Development (SEC. 002) - comp229\Assignments\Assignment2\Assignment1\Views\_ViewImports.cshtml"
using Assignment1.Models;

#line default
#line hidden
#line 3 "D:\Centennial\semester 3\Web Application Development (SEC. 002) - comp229\Assignments\Assignment2\Assignment1\Views\_ViewImports.cshtml"
using Assignment1.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3e4cca5737000da93f6d971897b6d210cc2a1cf", @"/Views/Home/ViewRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5e08d41729ab1aa639a49fccc8a89279eb43cfc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Centennial\semester 3\Web Application Development (SEC. 002) - comp229\Assignments\Assignment2\Assignment1\Views\Home\ViewRecipe.cshtml"
  
    ViewBag.Title = "View Recipe";

#line default
#line hidden
            BeginContext(60, 141, true);
            WriteLiteral("\r\n<h1>Recipe preview:</h1> <br/>\r\n<div class=\"card card-outline-primary m-1 p-1\">\r\n<div class=\"bg-faded p-1\">\r\n<div>\r\n    <h3>Name:</h3><br/>");
            EndContext();
            BeginContext(202, 16, false);
#line 11 "D:\Centennial\semester 3\Web Application Development (SEC. 002) - comp229\Assignments\Assignment2\Assignment1\Views\Home\ViewRecipe.cshtml"
                  Write(Model.RecipeName);

#line default
#line hidden
            EndContext();
            BeginContext(218, 48, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    <h3>Description:</h3><br />");
            EndContext();
            BeginContext(267, 17, false);
#line 14 "D:\Centennial\semester 3\Web Application Development (SEC. 002) - comp229\Assignments\Assignment2\Assignment1\Views\Home\ViewRecipe.cshtml"
                          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(284, 48, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    <h3>Ingredients:</h3><br />");
            EndContext();
            BeginContext(333, 17, false);
#line 17 "D:\Centennial\semester 3\Web Application Development (SEC. 002) - comp229\Assignments\Assignment2\Assignment1\Views\Home\ViewRecipe.cshtml"
                          Write(Model.Ingredients);

#line default
#line hidden
            EndContext();
            BeginContext(350, 41, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    <h3>Chef:</h3><br />");
            EndContext();
            BeginContext(392, 10, false);
#line 20 "D:\Centennial\semester 3\Web Application Development (SEC. 002) - comp229\Assignments\Assignment2\Assignment1\Views\Home\ViewRecipe.cshtml"
                   Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(402, 53, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    <h3>Preparation time:</h3><br />");
            EndContext();
            BeginContext(456, 21, false);
#line 23 "D:\Centennial\semester 3\Web Application Development (SEC. 002) - comp229\Assignments\Assignment2\Assignment1\Views\Home\ViewRecipe.cshtml"
                               Write(Model.PreparationTime);

#line default
#line hidden
            EndContext();
            BeginContext(477, 44, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    <h3>Reviews:</h3><br />");
            EndContext();
            BeginContext(522, 12, false);
#line 26 "D:\Centennial\semester 3\Web Application Development (SEC. 002) - comp229\Assignments\Assignment2\Assignment1\Views\Home\ViewRecipe.cshtml"
                      Write(Model.Review);

#line default
#line hidden
            EndContext();
            BeginContext(534, 24, true);
            WriteLiteral("\r\n</div>\r\n</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
