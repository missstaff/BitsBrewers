#pragma checksum "F:\School\CS234N\Term Project\BitsBrewers\BitsRESTfulAPI\Views\Addresses\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5cfafe65dd82141ca88ed1af4795c664e6e3ea1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Addresses_Create), @"mvc.1.0.view", @"/Views/Addresses/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5cfafe65dd82141ca88ed1af4795c664e6e3ea1", @"/Views/Addresses/Create.cshtml")]
    public class Views_Addresses_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BitsBrewers.Models.Address>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\School\CS234N\Term Project\BitsBrewers\BitsRESTfulAPI\Views\Addresses\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Address</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""StreetLine1"" class=""control-label""></label>
                <input asp-for=""StreetLine1"" class=""form-control"" />
                <span asp-validation-for=""StreetLine1"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""StreetLine2"" class=""control-label""></label>
                <input asp-for=""StreetLine2"" class=""form-control"" />
                <span asp-validation-for=""StreetLine2"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""City"" class=""control-label""></label>
                <input asp-for=""City"" class=""form-control"" />
                <span asp-validation-for=""City"" class=""text-dange");
            WriteLiteral(@"r""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""State"" class=""control-label""></label>
                <input asp-for=""State"" class=""form-control"" />
                <span asp-validation-for=""State"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Zipcode"" class=""control-label""></label>
                <input asp-for=""Zipcode"" class=""form-control"" />
                <span asp-validation-for=""Zipcode"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Country"" class=""control-label""></label>
                <input asp-for=""Country"" class=""form-control"" />
                <span asp-validation-for=""Country"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
");
            WriteLiteral("</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 57 "F:\School\CS234N\Term Project\BitsBrewers\BitsRESTfulAPI\Views\Addresses\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BitsBrewers.Models.Address> Html { get; private set; }
    }
}
#pragma warning restore 1591
