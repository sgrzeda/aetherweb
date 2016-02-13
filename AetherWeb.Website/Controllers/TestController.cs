using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using AetherWeb.Common.Authentication;
using AetherWeb.Services.Authentication.Web;
using AetherWeb.Services.Authentication.Web.Mvc;
using Microsoft.Practices.Unity;

namespace AetherWeb.Website.Controllers
{
    public class TestController : AsyncBaseController
    {
        private IUnityContainer _container;
        public TestController(IUnityContainer container)
        {
            _container = container;
        }
        //
        // GET: /Test/
        
        public async Task<ActionResult> Index()
        {

            ViewBag.wew = "ffff -";
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(string usernaem, string pass)
        {
            if (ModelState.IsValid)
            {
            }
            return View();
        }

        [AetherAuthorize(Authorization.Administrator)]
        public ActionResult Wew()
        {
            ViewBag.wew = "auth'd wew";
            //Services.Authentication.Web.User.CurrentUser.Account.Details.Email = new Random().Next(5000000).ToString();
           // Database.Contexts.AccountContext.Instance.SaveChangesAsync();
            //Database.Contexts.AccountContext.Instance.SaveChanges();
            //Services.Authentication.Web.User.Register("wewsir", "idol", "asdasdas@gjiag.com",
            //                                          "123.213.123.231");
            return View("Index");
        }
    }
}