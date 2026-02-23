using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
