namespace Zarrin.Web.TagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("bread-crumb")]
    public class BreadcrumbTagHelper : TagHelper
    {
        [HtmlAttributeName("title")]
        public string Title { get; set; }
        [HtmlAttributeName("master-name")]
        public string MasterTitle { get; set; }

        [HtmlAttributeName("slave-name")]
        public string SlaveTitle { get; set; }

        [HtmlAttributeName("master-icon")]
        public string MasterIcon { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string tag = $@"<section class='content-header'><h1>{Title}</h1>
             <ol class='breadcrumb'>
            <li><a href = '#' ><i class='fa fa-{MasterIcon}'></i>{MasterTitle}</a></li>
            <li class='active'>{SlaveTitle}</li>
        </ol>
    </section>";


            output.PreContent.SetHtmlContent(tag);
        }
    }
}
