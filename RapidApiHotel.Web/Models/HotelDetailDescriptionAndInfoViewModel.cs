namespace RapidApiHotel.Web.Models
{
    public class HotelDetailDescriptionAndInfoViewModel
    {

        public bool status { get; set; }
        public string message { get; set; }
        public long timestamp { get; set; }
        public List<Datum> data { get; set; }


        public class Datum
        {
            public int descriptiontype_id { get; set; }
            public string languagecode { get; set; }
            public string description { get; set; }
            public string hotel_id { get; set; }
        }

    }
}
