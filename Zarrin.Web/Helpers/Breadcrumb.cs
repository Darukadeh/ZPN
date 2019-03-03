using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarrin.Web.Helpers
{
    [HtmlTargetElement("bread-crumb")]
    public class BreadcrumbTagHelper : TagHelper
    {
        [HtmlAttributeName("asp-master-title")]
        public string MasterTitle { get; set; }

        [HtmlAttributeName("asp-slave-title")]
        public string SlaveTitle { get; set; }

        [HtmlAttributeName("asp-master-icon")]
        public string MasterIcon { get; set; }




        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.Add("class", "bread-crumb");
            var tag = $@"<section class='content-header'>
                       
                            <ol class='breadcrumb'>
                                <li><a href = '#' >< i class='fa {MasterIcon}'></i>{MasterTitle}</a></li>
                                <li class='active'>{SlaveTitle}</li>
                            </ol>
                       </section>";
            output.Content.SetHtmlContent(tag);

        }
        
        //public string BreadcrumbHelper(string masterLi, string nestedLi, string masterIcon = "fa fa-dashboard")
        //{
        //    return $@"<section class='content-header'>
                       
        //                    <ol class='breadcrumb'>
        //                        <li><a href = '#' >< i class='fa {masterIcon}'></i>{masterLi}</a></li>
        //                        <li class='active'>{nestedLi}</li>
        //                    </ol>
        //               </section>";
        //}
    }
}
