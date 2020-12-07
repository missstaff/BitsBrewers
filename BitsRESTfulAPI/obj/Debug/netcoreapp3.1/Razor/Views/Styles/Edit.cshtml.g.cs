#pragma checksum "F:\School\CS234N\Term Project\BitsBrewers\BitsRESTfulAPI\Views\Styles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cbcf79b9ee0363b0c563d4f1430878c43d4ac5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Styles_Edit), @"mvc.1.0.view", @"/Views/Styles/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cbcf79b9ee0363b0c563d4f1430878c43d4ac5f", @"/Views/Styles/Edit.cshtml")]
    public class Views_Styles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BitsBrewers.Models.Style>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\School\CS234N\Term Project\BitsBrewers\BitsRESTfulAPI\Views\Styles\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Style</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""StyleId"" />
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Version"" class=""control-label""></label>
                <input asp-for=""Version"" class=""form-control"" />
                <span asp-validation-for=""Version"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CategoryName"" class=""control-label""></label>
                <input asp-for=""CategoryName"" class=""form-control"" />
                <span asp-validat");
            WriteLiteral(@"ion-for=""CategoryName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CategoryNumber"" class=""control-label""></label>
                <input asp-for=""CategoryNumber"" class=""form-control"" />
                <span asp-validation-for=""CategoryNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CategoryLetter"" class=""control-label""></label>
                <input asp-for=""CategoryLetter"" class=""form-control"" />
                <span asp-validation-for=""CategoryLetter"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""StyleGuide"" class=""control-label""></label>
                <input asp-for=""StyleGuide"" class=""form-control"" />
                <span asp-validation-for=""StyleGuide"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""");
            WriteLiteral(@"Type"" class=""control-label""></label>
                <input asp-for=""Type"" class=""form-control"" />
                <span asp-validation-for=""Type"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OgMin"" class=""control-label""></label>
                <input asp-for=""OgMin"" class=""form-control"" />
                <span asp-validation-for=""OgMin"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OgMax"" class=""control-label""></label>
                <input asp-for=""OgMax"" class=""form-control"" />
                <span asp-validation-for=""OgMax"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""FgMin"" class=""control-label""></label>
                <input asp-for=""FgMin"" class=""form-control"" />
                <span asp-validation-for=""FgMin"" class=""text-danger""></span>
            </div>
            <");
            WriteLiteral(@"div class=""form-group"">
                <label asp-for=""FgMax"" class=""control-label""></label>
                <input asp-for=""FgMax"" class=""form-control"" />
                <span asp-validation-for=""FgMax"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""IbuMin"" class=""control-label""></label>
                <input asp-for=""IbuMin"" class=""form-control"" />
                <span asp-validation-for=""IbuMin"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""IbuMax"" class=""control-label""></label>
                <input asp-for=""IbuMax"" class=""form-control"" />
                <span asp-validation-for=""IbuMax"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ColorMin"" class=""control-label""></label>
                <input asp-for=""ColorMin"" class=""form-control"" />
                <span asp-validation-fo");
            WriteLiteral(@"r=""ColorMin"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ColorMax"" class=""control-label""></label>
                <input asp-for=""ColorMax"" class=""form-control"" />
                <span asp-validation-for=""ColorMax"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CarbMin"" class=""control-label""></label>
                <input asp-for=""CarbMin"" class=""form-control"" />
                <span asp-validation-for=""CarbMin"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CarbMax"" class=""control-label""></label>
                <input asp-for=""CarbMax"" class=""form-control"" />
                <span asp-validation-for=""CarbMax"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AbvMin"" class=""control-label""></label>
                <i");
            WriteLiteral(@"nput asp-for=""AbvMin"" class=""form-control"" />
                <span asp-validation-for=""AbvMin"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AbvMax"" class=""control-label""></label>
                <input asp-for=""AbvMax"" class=""form-control"" />
                <span asp-validation-for=""AbvMax"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Notes"" class=""control-label""></label>
                <input asp-for=""Notes"" class=""form-control"" />
                <span asp-validation-for=""Notes"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Profile"" class=""control-label""></label>
                <input asp-for=""Profile"" class=""form-control"" />
                <span asp-validation-for=""Profile"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <l");
            WriteLiteral(@"abel asp-for=""Ingredients"" class=""control-label""></label>
                <input asp-for=""Ingredients"" class=""form-control"" />
                <span asp-validation-for=""Ingredients"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Examples"" class=""control-label""></label>
                <input asp-for=""Examples"" class=""form-control"" />
                <span asp-validation-for=""Examples"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 143 "F:\School\CS234N\Term Project\BitsBrewers\BitsRESTfulAPI\Views\Styles\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BitsBrewers.Models.Style> Html { get; private set; }
    }
}
#pragma warning restore 1591
