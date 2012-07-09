using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OpenId;
using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;
using DotNetOpenAuth.OpenId.RelyingParty;

namespace AviTimeTracker.Web.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult LogOn()
        {
            var openId = new OpenIdRelyingParty();
            IAuthenticationResponse response = openId.GetResponse();

            if (response != null)
            {
                switch (response.Status)
                {
                    case AuthenticationStatus.Authenticated:
                        FormsAuthentication.RedirectFromLoginPage(response.ClaimedIdentifier, false);
                        break;
                    case AuthenticationStatus.Canceled:
                        ModelState.AddModelError("loginIdentifier", "Login was cancelled at the provider");
                        break;
                    case AuthenticationStatus.Failed:
                        ModelState.AddModelError("loginIdentifier", "Login failed using the provided OpenId identifier");
                        break;
                }
            }

            return View();
        }

        [HttpPost]
        public ActionResult LogOn(string loginIdentifier)
        {
            if (!Identifier.IsValid(loginIdentifier))
            {
                ModelState.AddModelError("loginIdentifier","the specified login identifier is invalid.");
                return View();
            }
            else
            {
                var openId = new OpenIdRelyingParty();
                IAuthenticationRequest request = openId.CreateRequest(Identifier.Parse(loginIdentifier));

                //require some additional data
                request.AddExtension(new ClaimsRequest
                                         {
                                             BirthDate = DemandLevel.NoRequest,
                                             Email = DemandLevel.Require,
                                             FullName = DemandLevel.Require
                                         });

                return request.RedirectingResponse.AsActionResult();   
            }
        }
    }
}