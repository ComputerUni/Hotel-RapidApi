using System.Collections.Generic;

namespace RapidApiHotel.Web.Models
{
    public class HotelDetailViewModel
    {
        public bool status { get; set; }
        public string message { get; set; }
        public long timestamp { get; set; }
        public Data data { get; set; }

        public class Data
        {
            public int ufi { get; set; }
            public int hotel_id { get; set; }
            public string hotel_name { get; set; }
            public string hotel_name_trans { get; set; }
            public string url { get; set; }
            public string accommodation_type_name { get; set; }
            public string address { get; set; }
            public string city { get; set; }
            public string country_trans { get; set; }
            public string zip { get; set; }
            public float latitude { get; set; }
            public float longitude { get; set; }
            public float distance_to_cc { get; set; }
            public string arrival_date { get; set; }
            public string departure_date { get; set; }
            public string currency_code { get; set; }
            public int review_nr { get; set; }
            public int hotel_include_breakfast { get; set; }
            public int is_family_friendly { get; set; }
            public string[] spoken_languages { get; set; }

            public Product_Price_Breakdown product_price_breakdown { get; set; }
            public Facilities_Block facilities_block { get; set; }
            public List<Top_Ufi_Benefits> top_ufi_benefits { get; set; }
            public Wifi_Review_Score wifi_review_score { get; set; }
            public List<Block> block { get; set; }
            public List<Rawdata> rawData { get; set; }
        }

        public class Product_Price_Breakdown
        {
            public Gross_Amount gross_amount { get; set; }
            public Gross_Amount_Per_Night gross_amount_per_night { get; set; }
            public Net_Amount net_amount { get; set; }
            public Included_Taxes_And_Charges_Amount included_taxes_and_charges_amount { get; set; }
        }

        public class Gross_Amount
        {
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public float value { get; set; }
        }

        public class Gross_Amount_Per_Night
        {
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public float value { get; set; }
        }

        public class Net_Amount
        {
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public float value { get; set; }
        }

        public class Included_Taxes_And_Charges_Amount
        {
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public int value { get; set; }
        }

        public class Facilities_Block
        {
            public string name { get; set; }
            public List<Facility> facilities { get; set; }
        }

        public class Facility
        {
            public string name { get; set; }
            public string icon { get; set; }
        }

        public class Top_Ufi_Benefits
        {
            public string translated_name { get; set; }
            public string icon { get; set; }
        }

        public class Wifi_Review_Score
        {
            public float rating { get; set; }
        }

        public class Block
        {
            public string block_id { get; set; }
            public string name { get; set; }
            public string room_name { get; set; }
            public string name_without_policy { get; set; }
            public int room_surface_in_m2 { get; set; }
            public int nr_adults { get; set; }
            public int nr_children { get; set; }
            public string max_occupancy { get; set; }
            public int breakfast_included { get; set; }
            public int all_inclusive { get; set; }
            public int refundable { get; set; }
            public string refundable_until { get; set; }
            public Paymentterms paymentterms { get; set; }
        }

        public class Paymentterms
        {
            public Cancellation cancellation { get; set; }
        }

        public class Cancellation
        {
            public string type_translation { get; set; }
            public string description { get; set; }
        }
        
        public class Rawdata
        {
            public int id { get; set; }
            public string name { get; set; }
            public float reviewScore { get; set; }
            public string reviewScoreWord { get; set; }
            public int reviewCount { get; set; }
            public string[] photoUrls { get; set; }
            public Checkin checkin { get; set; }
            public Checkout checkout { get; set; }
        }

        public class Checkin
        {
            public string fromTime { get; set; }
            public string untilTime { get; set; }
        }

        public class Checkout
        {
            public string fromTime { get; set; }
            public string untilTime { get; set; }
        }
        
    }
}