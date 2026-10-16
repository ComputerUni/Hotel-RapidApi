using Microsoft.AspNetCore.Mvc;
using RapidApiHotel.Web.Models;

namespace RapidApiHotel.Web.ViewComponents._HotelDetailViewComponents
{
    public class _HotelDetailGalleryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(HotelDetailViewModel data)
        {
            return View(data);
        }
    }
}
