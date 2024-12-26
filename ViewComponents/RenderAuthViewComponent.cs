using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Strings;
using Umbraco.Cms.Core;

namespace BurnSociety.ViewComponents
{

    public class RenderAuthViewComponent : ViewComponent
    {
        private readonly IContentService _contentService;
        private readonly IPublishedContentQuery _contentQuery;

        public RenderAuthViewComponent(IContentService contentService, IPublishedContentQuery contentQuery)
        {
            _contentService = contentService;
            _contentQuery = contentQuery;
        }

        public IViewComponentResult Invoke(int nodeId)
        {
            var specificTypeNodes = _contentService.CountPublished();
            ViewBag.test ="Test"+ specificTypeNodes;


            return View();
        }
    }
}