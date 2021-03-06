#pragma checksum "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "779e9876a839ae50a20965cb1d4e0657c08c8191"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\_ViewImports.cshtml"
using MayTinh;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\_ViewImports.cshtml"
using MayTinh.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"779e9876a839ae50a20965cb1d4e0657c08c8191", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ccc0fe1c0961240b5ee8476c8dce1d3a42796aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Trang chủ";

    //Danh sách slides
    var ListSlides = (List<MayTinh.Data.Slide>)ViewBag.ListSlides;

    //Danh sách danh mục sản phẩm
    var listCategories = (List<MayTinh.Data.Category>)ViewBag.ListCategories;
    //Danh sách sản phẩm hot
    var ListProductHot = (List<MayTinh.Data.Product>)ViewBag.ListProductHot;
    //Danh sách sản phẩm mới
    var ListProductNew = (List<MayTinh.Data.Product>)ViewBag.ListProductNew;

    //Danh sách tin tức
    var ListNews = (List<MayTinh.Data.News>)ViewBag.ListNews;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main id=\"main\">\r\n    <div class=\"container\">\r\n\r\n        <!--MAIN SLIDE-->\r\n        <div class=\"wrap-main-slide\">\r\n            <div class=\"slide-carousel owl-carousel style-nav-1\" data-items=\"1\" data-loop=\"1\" data-nav=\"true\" data-dots=\"false\">\r\n");
#nullable restore
#line 24 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                 if (ListSlides.Count() > 0)
                {
                    foreach (var item in ListSlides)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item-slide\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1032, "\"", 1048, 1);
#nullable restore
#line 29 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 1038, item.Logo, 1038, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1049, "\"", 1055, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-slide\">\r\n                          \r\n                        </div>\r\n");
#nullable restore
#line 32 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n        </div>\r\n\r\n        <!--BANNER-->\r\n\r\n        <div class=\"wrap-banner style-twin-default\">\r\n");
#nullable restore
#line 40 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
             if (ListSlides.Count() > 0)
            {
                foreach (var item in ListSlides.Take(2).ToList())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"banner-item\">\r\n                        <a href=\"#\" class=\"link-banner banner-effect-1\">\r\n                            <figure><img");
            BeginWriteAttribute("src", " src=\"", 1608, "\"", 1624, 1);
#nullable restore
#line 46 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 1614, item.Logo, 1614, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1625, "\"", 1631, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"580\" height=\"190\"></figure>\r\n                        </a>\r\n                    </div>\r\n");
#nullable restore
#line 49 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                  
                </div>
        <!--On Sale-->
        <div class=""wrap-show-advance-info-box style-1 has-countdown"">
            <h3 class=""title-box"">Sản phẩm nổi bật</h3>
            <div class=""wrap-countdown mercado-countdown"" data-expire=""2020/12/12 12:34:56""></div>
            <div class=""wrap-products slide-carousel owl-carousel style-nav-1 equal-container "" data-items=""5"" data-loop=""false"" data-nav=""true"" data-dots=""false"" data-responsive='{""0"":{""items"":""1""},""480"":{""items"":""2""},""768"":{""items"":""3""},""992"":{""items"":""4""},""1200"":{""items"":""5""}}'>

");
#nullable restore
#line 59 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                 if (ListProductHot.Count() > 0)
                {
                    foreach (var item in ListProductHot)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"product product-style-2 equal-elem \">\r\n                            <div class=\"product-thumnail\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2663, "\"", 2698, 4);
            WriteAttributeValue("", 2670, "/san-pham/", 2670, 10, true);
#nullable restore
#line 65 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 2680, item.Url, 2680, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2689, "/", 2689, 1, true);
#nullable restore
#line 65 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 2690, item.Id, 2690, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2699, "\"", 2717, 1);
#nullable restore
#line 65 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 2707, item.Name, 2707, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <figure><img");
            BeginWriteAttribute("src", " src=\"", 2769, "\"", 2785, 1);
#nullable restore
#line 66 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 2775, item.Logo, 2775, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"800\" height=\"800\"");
            BeginWriteAttribute("alt", " alt=\"", 2811, "\"", 2827, 1);
#nullable restore
#line 66 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 2817, item.Name, 2817, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></figure>\r\n                                </a>\r\n");
#nullable restore
#line 68 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                 if (item.PriceDiscount > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"group-flash\">\r\n                                        <span class=\"flash-item sale-label\">sale</span>\r\n                                    </div>\r\n");
#nullable restore
#line 73 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"wrap-btn\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3308, "\"", 3343, 4);
            WriteAttributeValue("", 3315, "/san-pham/", 3315, 10, true);
#nullable restore
#line 75 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 3325, item.Url, 3325, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3334, "/", 3334, 1, true);
#nullable restore
#line 75 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 3335, item.Id, 3335, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"function-link\">quick view</a>\r\n                                    </div>\r\n                                </div>\r\n                            <div class=\"product-info\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3557, "\"", 3592, 4);
            WriteAttributeValue("", 3564, "/san-pham/", 3564, 10, true);
#nullable restore
#line 79 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 3574, item.Url, 3574, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3583, "/", 3583, 1, true);
#nullable restore
#line 79 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 3584, item.Id, 3584, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-name\"><span>");
#nullable restore
#line 79 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n");
#nullable restore
#line 80 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                 if (item.PriceDiscount > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"wrap-price\"><ins><p class=\"product-price\">");
#nullable restore
#line 82 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                                                                     Write(item.PriceDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></ins> <del><p class=\"product-price\">");
#nullable restore
#line 82 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                                                                                                                                 Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></del></div>\r\n");
#nullable restore
#line 83 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"wrap-price\"><ins><p class=\"product-price\">");
#nullable restore
#line 86 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                                                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></ins></div>\r\n");
#nullable restore
#line 87 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 91 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"

                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>

        <!--Latest Products-->
        <div class=""wrap-show-advance-info-box style-1"">
            <h3 class=""title-box"">Sản phẩm mới nhất</h3>
            <div class=""wrap-top-banner"">
                <a href=""#"" class=""link-banner banner-effect-2"">
                    <figure><img src=""/assets/images/digital-electronic-banner.jpg"" width=""1170"" height=""240""");
            BeginWriteAttribute("alt", " alt=\"", 4710, "\"", 4716, 0);
            EndWriteAttribute();
            WriteLiteral(@"></figure>
                </a>
            </div>
            <div class=""wrap-products"">
                <div class=""wrap-product-tab tab-style-1"">
                    <div class=""tab-contents"">
                        <div class=""tab-content-item active"" id=""digital_1a"">
                            <div class=""wrap-products slide-carousel owl-carousel style-nav-1 equal-container"" data-items=""5"" data-loop=""false"" data-nav=""true"" data-dots=""false"" data-responsive='{""0"":{""items"":""1""},""480"":{""items"":""2""},""768"":{""items"":""3""},""992"":{""items"":""4""},""1200"":{""items"":""5""}}'>

");
#nullable restore
#line 112 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                 if (ListProductNew.Count() > 0)
                                {
                                    foreach (var item in ListProductNew)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"product product-style-2 equal-elem \">\r\n                                            <div class=\"product-thumnail\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 5731, "\"", 5766, 4);
            WriteAttributeValue("", 5738, "/san-pham/", 5738, 10, true);
#nullable restore
#line 118 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 5748, item.Url, 5748, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5757, "/", 5757, 1, true);
#nullable restore
#line 118 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 5758, item.Id, 5758, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 5767, "\"", 5785, 1);
#nullable restore
#line 118 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 5775, item.Name, 5775, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <figure><img");
            BeginWriteAttribute("src", " src=\"", 5853, "\"", 5869, 1);
#nullable restore
#line 119 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 5859, item.Logo, 5859, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"800\" height=\"800\"");
            BeginWriteAttribute("alt", " alt=\"", 5895, "\"", 5911, 1);
#nullable restore
#line 119 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 5901, item.Name, 5901, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></figure>\r\n                                                </a>\r\n");
#nullable restore
#line 121 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                                 if (item.PriceDiscount > 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"group-flash\">\r\n                                                        <span class=\"flash-item sale-label\">sale</span>\r\n                                                    </div>\r\n");
#nullable restore
#line 126 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"wrap-btn\">\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 6528, "\"", 6563, 4);
            WriteAttributeValue("", 6535, "/san-pham/", 6535, 10, true);
#nullable restore
#line 128 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 6545, item.Url, 6545, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6554, "/", 6554, 1, true);
#nullable restore
#line 128 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 6555, item.Id, 6555, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""function-link"">quick view</a>
                                                </div>
                                            </div>
                                            <div class=""product-info"">
                                                <a");
            BeginWriteAttribute("href", " href=\"", 6833, "\"", 6868, 4);
            WriteAttributeValue("", 6840, "/san-pham/", 6840, 10, true);
#nullable restore
#line 132 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 6850, item.Url, 6850, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6859, "/", 6859, 1, true);
#nullable restore
#line 132 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 6860, item.Id, 6860, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-name\"><span>");
#nullable restore
#line 132 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n");
#nullable restore
#line 133 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                                 if (item.PriceDiscount > 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"wrap-price\"><ins><p class=\"product-price\">");
#nullable restore
#line 135 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                                                                                     Write(item.PriceDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></ins> <del><p class=\"product-price\">");
#nullable restore
#line 135 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                                                                                                                                                 Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></del></div>\r\n");
#nullable restore
#line 136 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"wrap-price\"><ins><p class=\"product-price\">");
#nullable restore
#line 139 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                                                                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></ins></div>\r\n");
#nullable restore
#line 140 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"

                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 144 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"

                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!--Product Categories-->
        <div class=""wrap-show-advance-info-box style-1"">
            <h3 class=""title-box"">Tin tức</h3>
            <div class=""wrap-top-banner"">
                <a href=""#"" class=""link-banner banner-effect-2"">
                    <figure><img src=""/assets/images/fashion-accesories-banner.jpg"" width=""1170"" height=""240""");
            BeginWriteAttribute("alt", " alt=\"", 8283, "\"", 8289, 0);
            EndWriteAttribute();
            WriteLiteral(@"></figure>
                </a>
            </div>
            <div class=""wrap-products"">
                <div class=""wrap-product-tab tab-style-1"">
                    <div class=""tab-contents"">
                        <div class=""tab-content-item active"" id=""digital_1a"">
                            <div class=""wrap-products slide-carousel owl-carousel style-nav-1 equal-container"" data-items=""5"" data-loop=""false"" data-nav=""true"" data-dots=""false"" data-responsive='{""0"":{""items"":""1""},""480"":{""items"":""2""},""768"":{""items"":""3""},""992"":{""items"":""4""},""1200"":{""items"":""5""}}'>

");
#nullable restore
#line 169 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                 if (ListNews.Count() > 0)
                                {
                                    foreach (var item in ListNews)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"product product-style-2 equal-elem \">\r\n                                            <div class=\"product-thumnail\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 9292, "\"", 9326, 4);
            WriteAttributeValue("", 9299, "/tin-tuc/", 9299, 9, true);
#nullable restore
#line 175 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 9308, item.Url, 9308, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9317, "/", 9317, 1, true);
#nullable restore
#line 175 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 9318, item.Id, 9318, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 9327, "\"", 9345, 1);
#nullable restore
#line 175 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 9335, item.Name, 9335, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <figure><img");
            BeginWriteAttribute("src", " src=\"", 9413, "\"", 9429, 1);
#nullable restore
#line 176 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 9419, item.Logo, 9419, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"800\" height=\"800\"");
            BeginWriteAttribute("alt", " alt=\"", 9455, "\"", 9471, 1);
#nullable restore
#line 176 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 9461, item.Name, 9461, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></figure>\r\n                                                </a>\r\n                                                <div class=\"wrap-btn\">\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 9664, "\"", 9698, 4);
            WriteAttributeValue("", 9671, "/tin-tuc/", 9671, 9, true);
#nullable restore
#line 179 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 9680, item.Url, 9680, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9689, "/", 9689, 1, true);
#nullable restore
#line 179 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 9690, item.Id, 9690, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""function-link"">quick view</a>
                                                </div>
                                            </div>
                                            <div class=""product-info"">
                                                <a");
            BeginWriteAttribute("href", " href=\"", 9968, "\"", 10002, 4);
            WriteAttributeValue("", 9975, "/tin-tuc/", 9975, 9, true);
#nullable restore
#line 183 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 9984, item.Url, 9984, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9993, "/", 9993, 1, true);
#nullable restore
#line 183 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
WriteAttributeValue("", 9994, item.Id, 9994, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-name\"><span>");
#nullable restore
#line 183 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"
                                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 186 "D:\nghia\DoAnTotNghiep2022\Độ\WebTivi\Tivi\Views\Home\Index.cshtml"

                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
