#pragma checksum "C:\Users\Ata Ustundag\source\repos\CodesisWebApp\CodesisWebApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fa20669732139a92c60599b85a3b815220e7000"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CodesisWebApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace CodesisWebApp.Pages
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
#line 1 "C:\Users\Ata Ustundag\source\repos\CodesisWebApp\CodesisWebApp\Pages\_ViewImports.cshtml"
using CodesisWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fa20669732139a92c60599b85a3b815220e7000", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df621270cb4d091662b939429792ae2ab5142915", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/RedSkyLogIn.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/RedSkyDatabase.zip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Ata Ustundag\source\repos\CodesisWebApp\CodesisWebApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "RedSky Database";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    body {
        background-color: #303658;
        color: #303658;
    }
    #menu{
        background-color: ghostwhite;
        width: 100%;
        height: 100px;
    }
    #menu table {
        font-size: 20px;
        color: #303658;
        width: 100%;
        line-height: 100px;
        /*inline-size: 100px;*/
    }

    #menu td {
        width: 25%;
        font-weight: 400;
    }
    #About{
        width:100%;
        height: 1100px;
        background-color: white;
    }
    #About h1{
        font-size: 80px;
        color: #303658;
    }
    #About p {
        float: left;
        padding-left: 20px;
        padding-right: 20px;
        font-size: 20px;
    }
    #Use {
        width: 100%;
        height: 1300px;
        background-color: ghostwhite;
    }
    #Use h1 {
            font-size: 80px;
            color: #303658;
    }
    #Use p {
        float: left;
        padding-left: 20px;
        padding-right: 20px;
        font");
            WriteLiteral(@"-size: 20px;
    }
    #Use table {
        font-size: 20px;
        color: #303658;
        width: 100%;
    }
    #Use td {
        width: 50%;
        font-weight: 400;
    }
    #Version {
        width: 100%;
        height: 400px;
        background-color: white;
    }

        #Version h1 {
            font-size: 80px;
            color: #303658;
        }

        #Version p {
            padding-left: 20px;
            padding-right: 20px;
            font-size: 20px;
        }

        #Version table {
            font-size: 20px;
            color: #303658;
            width: 100%;
        }

        #Version td {
            width: 50%;
            font-weight: 400;
        }
    a:active {
        color: #303658;
    }
    a:hover {
        color: #303658;
    }
    a:visited {
        color: #303658;
    }
    a:link {
        color: #303658;
    }
</style>
<section id=""menu"">
    <div class=""text-center"">
        <table style=""width:100%;"">
");
            WriteLiteral(@"            <tr>
                <td><a href=""#1"">About</a></td>
                <td><a href=""#Use"">How-To-Use</a></td>
                <td><a href=""#Version"">Version-History</a></td>
                <td><a href=""https://www.github.com/simpleappsin/"">GitHub</a></td>
            </tr>
        </table>
    </div>
</section>
<section id=""About"">
    <div class=""text-center"">
        <h1 class=""display-4"">RedSky Database</h1>
        <hr style=""width: 50%;"">
        <img src=""RedSky.png"" id=""1""");
            BeginWriteAttribute("alt", " alt=\"", 2633, "\"", 2639, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width:100%;"">
        <br>
        <br>
        <div class=""text-left"" style=""margin-top: 25px;"">
            <p class=""display-4"">
                RedSky Database is an software where you can Create Databases, Delete Databases, create Tables, Delete Tables, BackUp Databases and Alter your Tables
                easily in only one software without using, typing or knowing any type of SQL code. In the software I tried to keep
                everything simple for anyone to use the software wheter they know how to use such a software or don't know.
                The software will be updated constantly. I will bring new features such as injection for you to test your database
                for safety of your data. The software will remain to be stay free and all the features will be added also for free.
            </p>
            <p class=""display-4"">
                The RedSky Database software is built with C# programming language and using MySQL Package for you to connect to your dat");
            WriteLiteral(@"abase.
                C# programming language gives the software power and quickness for you to use.
            </p>
            <br>
            <br>
        </div>
    </div>
</section>

<section id=""Use"">
    <div class=""text-center"">
        <br>
        <br>
        <h2 class=""display-4"" style=""padding-left: 20px; padding-right: 20px; font-size:38px;"">How To Use <br>RedSky Database</h2>
        <hr style=""width: 50%;"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4fa20669732139a92c60599b85a3b815220e70009174", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div class=""text-left"" style=""margin-top: 25px;"">
            <p class=""display-4"">
                When you run the software you have to Log In your informations to connect to your database each time. The reason you have to Log In each time
                is that I don't want you guys to be worried about your privacy or your customer's privacy. Once you get into the software menu leave the rest to the RedSky Database software.
                Only thing you needd to do is just give no code instructions to the software such as naming the Database/Table/BackUp file etc.
                The software will do the rest for you and will notify you that the task is completed or if there was any error messages.
                Just enjoy your life. The RedSky Database is here to make your life easier.
            </p>
            <p class=""display-4"">
                Your feedbacks are very important to me because future of my softwares are depending on my users experiences. If there is any bug or");
            WriteLiteral(@" any type of thing that
                creates problem to you please give me feedback and I will take care of it in the next upcomming version update.
                Please suuport me and my projects.
                <br>
                <br>
            </p>
        </div>
        <table style=""width:100%;"">
            <tr>
                <td><a href=""https://www.buymeacoffee.com/simpleapps"" "">Buy Me a Coffee</a></td>
                <td><a href=""https://www.youtube.com/channel/UCnI2fV_2-pvYrwjI7KFW0pA"">YouTube</a></td>
            </tr>
        </table>
        
</section>
<section id=""Version"">
    <div class=""text-center"">
        <br>
        <br>
        <h2 class=""display-4"" style=""padding-left: 20px; padding-right: 20px; font-size:38px;"">Version History <br>RedSky Database</h2>
        <hr style=""width: 50%;"">
        <div class=""text-center"">
");
            WriteLiteral("            <p style=\"text-align: center;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fa20669732139a92c60599b85a3b815220e700012500", async() => {
                WriteLiteral("Download Version: 1.0");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("download", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
