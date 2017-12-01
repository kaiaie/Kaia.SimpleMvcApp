using System.Web;
using System.Web.Mvc;

namespace SimpleMvcApp.Controllers
{
    public sealed class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}