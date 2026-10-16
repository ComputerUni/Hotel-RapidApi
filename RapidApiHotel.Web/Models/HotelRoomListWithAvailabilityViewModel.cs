using System.Collections.Generic;

namespace RapidApiHotel.Web.Models
{
    public class HotelRoomListWithAvailabilityViewModel
    {
        public bool status { get; set; }
        public long timestamp { get; set; }
        public List<Available> available { get; set; } = new();

        public class Available
        {
            public string room_name { get; set; }
            public int? nr_adults { get; set; }
            public int? nr_children { get; set; }
            public float? room_surface_in_m2 { get; set; }
            public int? breakfast_included { get; set; }
            public int? refundable { get; set; }
            public string refundable_until { get; set; }
            public string mealplan { get; set; }

            public Block_Text block_text { get; set; }
            public Paymentterms paymentterms { get; set; }
            public Product_Price_Breakdown product_price_breakdown { get; set; }
        }

        public class Block_Text
        {
            public List<Policy> policies { get; set; } = new();
        }

        public class Policy
        {
            public string content { get; set; }
        }

        public class Paymentterms
        {
            public Cancellation cancellation { get; set; }
            public Prepayment prepayment { get; set; }
        }

        public class Cancellation
        {
            public string type_translation { get; set; }
        }

        public class Prepayment
        {
            public string type_translation { get; set; }
        }

        public class Product_Price_Breakdown
        {
            public Gross_Amount gross_amount { get; set; }
        }

        public class Gross_Amount
        {
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public float? value { get; set; }
        }
    }
}