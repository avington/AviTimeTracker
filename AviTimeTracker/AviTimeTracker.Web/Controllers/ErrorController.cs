using System.Net;
using System.Web.Mvc;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Web.Controllers
{
    public class ErrorController :Controller
    {
        public ActionResult NotFound(string url)
        {
            Response.StatusCode = (int)HttpStatusCode.NotFound;
            var view = new NotFoundViewModel
            {
                RequestUrl = url,
                ReferrerUrl = Request.UrlReferrer != null &&
                              Request.UrlReferrer.OriginalString != url
                                  ? Request.UrlReferrer.OriginalString
                                  : null
            };
            return View("NotFound", view);
        }

        public ActionResult ServerError()
        {
            Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            return View();
        }

        public ActionResult NotAuthorized()
        {
            return View();
        }
    }
}