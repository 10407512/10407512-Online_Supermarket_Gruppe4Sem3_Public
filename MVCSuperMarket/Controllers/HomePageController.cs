using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCSuperMarket.Controllers
{
    public class HomePageController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
