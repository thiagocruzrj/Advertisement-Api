using Microsoft.AspNetCore.Mvc;

namespace WebAdvertisement.Web.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}