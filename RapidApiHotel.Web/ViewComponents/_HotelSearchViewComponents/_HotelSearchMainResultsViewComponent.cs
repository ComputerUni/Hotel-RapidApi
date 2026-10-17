using Microsoft.AspNetCore.Mvc;
using RapidApiHotel.Web.Models;

namespace RapidApiHotel.Web.ViewComponents._HotelSearchViewComponents
{
    public class _HotelSearchMainResultsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(HotelListViewModel data, int currentPage = 1)
        {
            ViewBag.CurrentPage = currentPage;
            return View(data);
        }
    }
}
