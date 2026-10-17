using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotel.Web.ViewComponents._HotelMainPageViewComponents
{
    public class _HotelMainPageHeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
