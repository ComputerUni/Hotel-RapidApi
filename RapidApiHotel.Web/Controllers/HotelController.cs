using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotel.Web.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
