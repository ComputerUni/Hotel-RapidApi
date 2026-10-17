using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotel.Web.ViewComponents._HotelDetailViewComponents
{
    public class _HotelDetailHeadViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
