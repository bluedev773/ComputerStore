#pragma checksum "C:\Users\litvi\source\repos\part4\part4\Pages\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1449a3930a970eccb549b5f22f45d610216ef46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(part4.Pages.Pages_Order), @"mvc.1.0.razor-page", @"/Pages/Order.cshtml")]
namespace part4.Pages
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
#line 1 "C:\Users\litvi\source\repos\part4\part4\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\litvi\source\repos\part4\part4\Pages\_ViewImports.cshtml"
using part4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\litvi\source\repos\part4\part4\Pages\_ViewImports.cshtml"
using part4.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1449a3930a970eccb549b5f22f45d610216ef46", @"/Pages/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9b94a39f83a803d221ef541f1ea14a9eb4af83d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Order : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\litvi\source\repos\part4\part4\Pages\Order.cshtml"
  
    ViewData["Title"] = "Place Your Order";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"bg\">\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\litvi\source\repos\part4\part4\Pages\Order.cshtml"
   Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"row mainRow\">\r\n        <div class=\"col-sm-8\" id=\"productCard\">\r\n            <div class=\"card card-cascade wider shadow p-3 mb-5 \">\r\n                <div class=\"view view-cascade overlay text-center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d1449a3930a970eccb549b5f22f45d610216ef464917", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 423, "~/images/products/", 423, 18, true);
#nullable restore
#line 13 "C:\Users\litvi\source\repos\part4\part4\Pages\Order.cshtml"
AddHtmlAttributeValue("", 441, Model.Product.ImageName, 441, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 472, "Image", 472, 5, true);
            AddHtmlAttributeValue(" ", 477, "of", 478, 3, true);
#nullable restore
#line 13 "C:\Users\litvi\source\repos\part4\part4\Pages\Order.cshtml"
AddHtmlAttributeValue(" ", 480, Model.Product.Name, 481, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" <a>
                        <div class=""mask rgba-white-slight""></div>
                    </a>
                </div>
                <div class=""desc"">
                    <div class=""row subRow"">
                        <!--Radio button selections for the mini model-->
");
#nullable restore
#line 20 "C:\Users\litvi\source\repos\part4\part4\Pages\Order.cshtml"
                         if (Model.Product.Id == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1449a3930a970eccb549b5f22f45d610216ef467619", async() => {
                WriteLiteral(@"
                                <div class=""col"">
                                    <h4>CPU</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""CPU: i3 8145u"" name=""CPURadio"" checked=""checked"" />i3 8145u<br />
                                    <input type=""radio"" onclick=""calculate()"" value=50 id=""CPU: i5 8250u"" name=""CPURadio"" />i5 8250u<br />
                                    <input type=""radio"" onclick=""calculate()"" value=100 id=""CPU: i7 8550u"" name=""CPURadio"" />i7 8550u<br />
                                </div>

                                <div class=""col"">
                                    <h4>Memory</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""Memory: 8Gb"" name=""MemoryRadio"" checked=""checked"" />8Gb<br />
                                    <input type=""radio"" onclick=""calculate()"" value=100 id=""Memory: 16Gb"" name=""MemoryRadio"" />16Gb<br />
                                </div>
     ");
                WriteLiteral(@"                           <div class=""col"">
                                    <h4>Storage</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""Storage: 1TB HDD"" name=""StorageRadio"" />1TB HDD<br />
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""Storage: 128GB SSD"" name=""StorageRadio"" checked=""checked"" />128GB SSD<br />
                                    <input type=""radio"" onclick=""calculate()"" value=60 id=""Storage: 256 Gb SSD"" name=""StorageRadio"" />256 Gb SSD<br />
                                    <input type=""radio"" onclick=""calculate()"" value=120 id=""Storage: 512 Gb SSD"" name=""StorageRadio"" />512 Gb SSD<br />
                                </div>
                                <div class=""col"">
                                    <h4>Video</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""Video: Integrated"" name=""VideoRadio"" checked=""checked"" />Integrated<br />
                WriteLiteral(@"
                                </div>
                                <div class=""col"">
                                    <h4>Sound</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""Sound: Integrated"" name=""SoundRadio"" checked=""checked"" />Integrated<br />
                                </div>
                                <div class=""col"">
                                    <h4>OS</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""OS: None"" name=""OSRadio"" checked=""checked"" />None<br />
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""OS: Ubuntu"" name=""OSRadio"" />Ubuntu<br />
                                    <input type=""radio"" onclick=""calculate()"" value=70 id=""OS: Win 10 Home"" name=""OSRadio""  />Win 10 Home<br />
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\litvi\source\repos\part4\part4\Pages\Order.cshtml"

                        }
                        //Radio button selections for the business model
                        else if (Model.Product.Id == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1449a3930a970eccb549b5f22f45d610216ef4612631", async() => {
                WriteLiteral(@"
                                <div class=""col"">
                                    <h4>CPU</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""CPU: i3 10100"" name=""CPURadio"" checked=""checked"" />i3 10100<br />
                                    <input type=""radio"" onclick=""calculate()"" value=50 id=""CPU: i5 10400"" name=""CPURadio"" />i5 10400<br />
                                    <input type=""radio"" onclick=""calculate()"" value=80 id=""CPU: i5 10600"" name=""CPURadio"" />i5 10600<br />
                                    <input type=""radio"" onclick=""calculate()"" value=140 id=""CPU: i7 10700"" name=""CPURadio"" />i7 10700<br />
                                    <input type=""radio"" onclick=""calculate()"" value=200 id=""CPU: i9 10900"" name=""CPURadio"" />i9 10900<br />
                                </div>

                                <div class=""col"">
                                    <h4>Memory</h4>
                                    <input type=""radio"" ");
                WriteLiteral(@"onclick=""calculate()"" value=0 id=""Memory: 8Gb"" name=""MemoryRadio"" checked=""checked"" />8Gb<br />
                                    <input type=""radio"" onclick=""calculate()"" value=100 id=""Memory: 16Gb"" name=""MemoryRadio"" />16Gb<br />
                                    <input type=""radio"" onclick=""calculate()"" value=200 id=""Memory: 32Gb"" name=""MemoryRadio"" />32Gb<br />
                                </div>
                                <div class=""col"">
                                    <h4>Storage</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""Storage: 1TB HDD"" name=""StorageRadio"" checked=""checked""  />1TB HDD<br />
                                    <input type=""radio"" onclick=""calculate()"" value=60 id=""Storage: 256 Gb SSD"" name=""StorageRadio"" />256 Gb SSD<br />
                                    <input type=""radio"" onclick=""calculate()"" value=120 SSD"" id=""Storage: 512 Gb SSD"" name=""StorageRadio"" />512 Gb SSD<br />
                              ");
                WriteLiteral(@"      <input type=""radio"" onclick=""calculate()"" value=240 id=""Storage: 1 Tb SSD"" name=""StorageRadio"" />1 Tb SSD<br />
                                </div>
                                <div class=""col"">
                                    <h4>Video</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""Video: Integrated"" name=""VideoRadio"" checked=""checked"" />Integrated<br />
                                    <input type=""radio"" onclick=""calculate()"" value=300 id=""Video: Quadro P620"" name=""VideoRadio"" />Quadro P620<br />
                                    <input type=""radio"" onclick=""calculate()"" value=550 id=""Video: Quadro P1000"" name=""VideoRadio"" />Quadro P1000<br />
                                </div>
                                <div class=""col"">
                                    <h4>Sound</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""Sound: Integrated"" name=""SoundRadio"" checked=""checked"" />Int");
                WriteLiteral(@"egrated<br />
                                    <input type=""radio"" onclick=""calculate()"" value=40 id=""Sound: Sound Blaster 1000"" name=""SoundRadio"" />Sound Blaster 1000<br />
                                </div>
                                <div class=""col"">
                                    <h4>OS</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""OS: None"" name=""OSRadio"" checked=""checked"" />None<br />
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""OS: Ubuntu"" name=""OSRadio"" />Ubuntu<br />
                                    <input type=""radio"" onclick=""calculate()"" value=70 id=""OS: Win 10 Home"" name=""OSRadio"" />Win 10 Home<br />
                                    <input type=""radio"" onclick=""calculate()"" value=110 id=""OS: Win 10 Pro"" name=""OSRadio"" />Win 10 Pro<br />
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 104 "C:\Users\litvi\source\repos\part4\part4\Pages\Order.cshtml"
                        }
                        //Radio button selections for the gamer model
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1449a3930a970eccb549b5f22f45d610216ef4618742", async() => {
                WriteLiteral(@"
                                <div class=""col"">
                                    <h4>CPU</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""CPU: i5 9400"" name=""CPURadio"" checked=""checked"" />i5 9400<br />
                                    <input type=""radio"" onclick=""calculate()"" value=75 id=""CPU: i5 10400F"" name=""CPURadio"" />i5 10400F<br />
                                    <input type=""radio"" onclick=""calculate()"" value=150 id=""CPU: i7 10700k"" name=""CPURadio"" />i7 10700k<br />
                                </div>

                                <div class=""col"">
                                    <h4>Memory</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""Memory: 8Gb"" name=""MemoryRadio"" checked=""checked"" />8Gb<br />
                                    <input type=""radio"" onclick=""calculate()"" value=100 id=""Memory: 16Gb"" name=""MemoryRadio"" />16Gb<br />
                                    <input ");
                WriteLiteral(@"type=""radio"" onclick=""calculate()"" value=200 id=""Memory: 32Gb"" name=""MemoryRadio"" />32Gb<br />
                                </div>
                                <div class=""col"">
                                    <h4>Storage</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""Storage: 256 Gb SSD"" name=""StorageRadio"" checked=""checked"" />256 Gb SSD<br />
                                    <input type=""radio"" onclick=""calculate()"" value=120 id=""Storage: 512 Gb SSD"" name=""StorageRadio"" />512 Gb SSD<br />
                                    <input type=""radio"" onclick=""calculate()"" value=240 id=""Storage: 1 Tb SSD"" name=""StorageRadio"" />1 Tb SSD<br />
                                </div>
                                <div class=""col"">
                                    <h4>Video</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""Video: 1650 Ti"" name=""VideoRadio"" checked=""checked"" />1650 Ti<br />
          ");
                WriteLiteral(@"                          <input type=""radio"" onclick=""calculate()"" value=100 id=""Video: 1660 Ti"" name=""VideoRadio"" />1660 Ti<br />
                                    <input type=""radio"" onclick=""calculate()"" value=150 id=""Video: RTX 2060"" name=""VideoRadio"" />RTX 2060<br />
                                    <input type=""radio"" onclick=""calculate()"" value=300 id=""Video: RTX 2070"" name=""VideoRadio"" />RTX 2070<br />
                                </div>
                                <div class=""col"">
                                    <h4>Sound</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""Sound: Integrated"" name=""SoundRadio"" checked=""checked"" />Integrated<br />
                                    <input type=""radio"" onclick=""calculate()"" value=40 id=""Sound: Sound Blaster 5000"" name=""SoundRadio"" />Sound Blaster 5000<br />
                                    <input type=""radio"" onclick=""calculate()"" value=100 id=""Sound: Sound Blaster 10000"" name=""Sou");
                WriteLiteral(@"ndRadio"" />Sound Blaster 10000<br />
                                </div>
                                <div class=""col"">
                                    <h4>OS</h4>
                                    <input type=""radio"" onclick=""calculate()"" value=0 id=""OS: Win 10 Home"" name=""OSRadio"" checked=""checked"" />Win 10 Home<br />
                                    <input type=""radio"" onclick=""calculate()"" value=40 id=""OS: Win 10 Pro"" name=""OSRadio"" />Win 10 Pro<br />
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 147 "C:\Users\litvi\source\repos\part4\part4\Pages\Order.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <script src=""//ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js""></script>


        <div class=""col-sm-4"">
            <div class=""card card-cascade card-ecommerce wider shadow p-3 mb-5 "">
                <div class=""card-body card-body-cascade"">
                    <!--Display Pricing information-->
                    <div class=""card2decs"">
                        <p class=""heading1""><strong>");
#nullable restore
#line 161 "C:\Users\litvi\source\repos\part4\part4\Pages\Order.cshtml"
                                               Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                        <p class=\"total\" id=\"subtotal\">Base Price<span class=\"float-right totalText1\">$<span class=\"totalText2\" id=\"subtotal2\">");
#nullable restore
#line 162 "C:\Users\litvi\source\repos\part4\part4\Pages\Order.cshtml"
                                                                                                                                          Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></span></p>
                        <p class=""total"" id=""options"">Options<span class=""float-right totalText1"">$<span class=""totalText2"" id=""options2"">0</span></span></p>
                        <p class=""total"" id=""total""><strong>Total</strong><span class=""float-right totalText1"">$<span class=""totalText2"" id=""total2"">");
#nullable restore
#line 164 "C:\Users\litvi\source\repos\part4\part4\Pages\Order.cshtml"
                                                                                                                                                Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></span></p>

                    </div>
                    <!--purchase button-->
                    <button onclick=""summary()"" class=""purchaseLink"">
                        <div class=""card-footer text-center""> PURCHASE &#8594; </div>
                    </button>
                </div>
            </div>
        </div>

        <div class=""col-sm-8"" id=""productSummary"" style=""display:none;"">
            <div class=""card card-cascade card-ecommerce wider shadow p-3 mb-5 "">
                <div class=""card2decs"">
                    <h3>Order Summary</h3>
                    <p  id=""summary""></p>
                </div>
            </div>
        </div>

            <script>
            //Script to calculate and print pricing dynamically based off of radio button selections
                var price = 0;

                function addPrice(element, index, array) {
                    if (element.checked) price += +element.value;
                    return price;
            ");
            WriteLiteral(@"    }

            function calculate() {

                    var rdos = Array.prototype.slice.call(document.getElementsByTagName('input'));
                rdos.forEach(addPrice);
                document.getElementById(""options2"").innerHTML = price;
                document.getElementById(""total2"").innerHTML = ");
#nullable restore
#line 198 "C:\Users\litvi\source\repos\part4\part4\Pages\Order.cshtml"
                                                         Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" + price;
                    price = 0;
            }
            //Show order summary
                var name = """";
            function summary() {
                var radios = Array.prototype.slice.call(document.getElementsByTagName('input'));
                radios.forEach(display);
                var x = document.getElementById(""productCard"");
                var y = document.getElementById(""productSummary"");
                x.style.display = ""none"";
                y.style.display = ""block"";
                
            }
            function display(element, index, array) {
                if (element.checked) {
                    name = element.id;
                    console.log(name);
                    document.getElementById(""summary"").insertAdjacentHTML('beforeend', name + ""<br />"");
                }
            }

            </script>
        </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<part4.Pages.OrderModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<part4.Pages.OrderModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<part4.Pages.OrderModel>)PageContext?.ViewData;
        public part4.Pages.OrderModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591