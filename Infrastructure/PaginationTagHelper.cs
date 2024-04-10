using INTEXteam5.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace INTEXteam5.Infrastructure
{
    [HtmlTargetElement("div", Attributes="page-model")]
    public class PaginationTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactyory;
        public PaginationTagHelper (IUrlHelperFactory temp)
        {
            urlHelperFactyory = temp;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext? ViewContext { get; set; }
        public string? PageAction { get; set; }
        public PaginationInfo PageModel { get; set; }

        public bool PageClassesEnabled { get; set; }
        public string PageClass { get; set; } = string.Empty;
        public string PageClassNormal {  get; set; } = string.Empty;
        public string PageClassSelected { get;  set; } = string.Empty;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (ViewContext != null && PageModel != null)
            {
                IUrlHelper urlHelper = urlHelperFactyory.GetUrlHelper(ViewContext);

                TagBuilder result = new TagBuilder("div");
                
                for (int i = 1; 1 <= PageModel.TotalNumPages; i++)
                {
                    TagBuilder tag = new TagBuilder("a");
                    tag.Attributes["href"] = urlHelper.Action(PageAction, new { pageNum = i });

                    if(PageClassesEnabled)
                    {
                        tag.AddCssClass(PageClass);
                        tag.AddCssClass(i == PageModel.CurrentPage ? PageClassSelected : PageClassNormal);
                    }

                    tag.InnerHtml.Append(i.ToString());

                    result.InnerHtml.AppendHtml(tag);
                }
                output.Content.AppendHtml(result.InnerHtml);
            }
        }
    }
}
