namespace RapidApiHotel.Web.Models
{
    public class HotelReviewScoresViewModel
    {

        public bool status { get; set; }
        public object message { get; set; }
        public long timestamp { get; set; }
        public List<Datum> data { get; set; }


        public class Datum
        {
            public List<Score_Percentage> score_percentage { get; set; }
            public List<Score_Distribution> score_distribution { get; set; }
            public List<Score_Breakdown> score_breakdown { get; set; }
            public int hotel_id { get; set; }
        }

        public class Score_Percentage
        {
            public string score_word { get; set; }
            public int count { get; set; }
            public int score_start { get; set; }
            public int percent { get; set; }
            public float score_end { get; set; }
        }

        public class Score_Distribution
        {
            public float percent { get; set; }
            public int score { get; set; }
            public int count { get; set; }
        }

        public class Score_Breakdown
        {
            public int count { get; set; }
            public string average_score { get; set; }
            public int from_year { get; set; }
            public List<Question> question { get; set; }
            public string customer_type { get; set; }
        }

        public class Question
        {
            public int score_comparison_to_ufi_average { get; set; }
            public int count { get; set; }
            public object score { get; set; }
            public string localized_question { get; set; }
            public string question { get; set; }
        }

    }
}
