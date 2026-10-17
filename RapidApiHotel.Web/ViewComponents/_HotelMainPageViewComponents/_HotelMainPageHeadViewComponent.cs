using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotel.Web.ViewComponents._HotelMainPageViewComponents
{
    public class _HotelMainPageHeadViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
