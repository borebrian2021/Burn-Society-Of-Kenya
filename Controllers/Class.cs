using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Website.Controllers;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
using Umbraco.Cms.Web.Common.PublishedModels;

public class LoginPageSurfaceController : SurfaceController
{
    public LoginPageSurfaceController(
        IUmbracoContextAccessor umbracoContextAccessor,
        IUmbracoDatabaseFactory databaseFactory,
        ServiceContext services,
        AppCaches appCaches,
        IProfilingLogger profilingLogger,
        IPublishedUrlProvider publishedUrlProvider) : base(
            umbracoContextAccessor,
            databaseFactory,
            services,
            appCaches,
            profilingLogger,
            publishedUrlProvider)
    {

    }
}

//    [HttpPost]
//    [ValidateAntiForgeryToken]
//    public IActionResult HandleSubmit(ContactUS contactus)
//    {
//        if (ModelState.IsValid)
//        {
//            TempData["tinubu"] = "Tinubu Ok see:" + contactus.FirstName;

//        }
//        else
//        {
//            TempData["tinubu"] = "Tinubu Not Ok" + contactus.FirstName;
//            var test = contactus.FirstName;
//        }
//        return Redirect("/contact-page-content");
//        //return RedirectToCurrentUmbracoUrl();
//        //return Content("Ok");
//    }
//}
