using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiHotel.Web.Models;
using System.Text.Json.Serialization;

namespace RapidApiHotel.Web.Controllers
{
    public class HotelController : Controller
    {
        private async Task<string> GetDestinationIdAsync(string city_name)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query={city_name}"),
                Headers =
            {
                { "x-rapidapi-key", "" },
                { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
            },

            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<HotelDestinationViewModel>(body);
                var city = result.data.FirstOrDefault(x => x.search_type == "city");
                return city?.dest_id ?? result.data[0].dest_id;
            }
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string city_name, string search_type, string arrival_date, string departure_date, int adults, string children_age, int room_qty, string currency_code)
        {
            var destId = await GetDestinationIdAsync(city_name);

            return RedirectToAction("Search", new { dest_id = destId, arrival_date, departure_date, adults, children_age, room_qty, currency_code });
        }


        public async Task<IActionResult> Search(string dest_id, string search_type, string arrival_date, string departure_date, int adults, string children_age, int room_qty, string currency_code)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id={dest_id}&search_type=CITY&arrival_date={arrival_date}&departure_date={departure_date}&adults={adults}&children_age={children_age}&room_qty={room_qty}&currency_code={currency_code}"),
                Headers =
            {
                { "x-rapidapi-key", "" },
                { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
            },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<HotelListViewModel>(body);
                ViewBag.ArrivalDate = arrival_date;
                ViewBag.DepartureDate = departure_date;
                ViewBag.Adults = adults;
                ViewBag.RoomQty = room_qty;
                ViewBag.HotelCount = result?.data?.hotels?.Count ?? 0;
                return View(result);
            }
        }
    }
}
