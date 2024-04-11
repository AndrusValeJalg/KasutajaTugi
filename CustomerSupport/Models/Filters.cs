namespace CustomerSupport.Models
{
    public class Filters
    {
        public Filters(string filterstring)
        {
            FilterString = filterstring ?? "all-all";
            string[] filters = FilterString.Split('-');
            Due = filters[0];
            StatusId = filters[1];
        }
        public string FilterString { get; }
        public string StatusId { get; }
        public string Due { get; }
        public bool HasDue => Due.ToLower() != "all";
        public bool HasStatus => StatusId.ToLower() != "all";
        public static Dictionary<string, string> DueFilterValues =>
            new Dictionary<string, string> {
            {"future", "Future"},
            {"past", "Past" },
            {"today", "Today" }
        };

        public bool IsPast => Due.ToLower() == "past";
        public bool IsFuture => Due.ToLower() == "future";
        //IsInAnHour needed for Project
        public bool IsToday => Due.ToLower() == "today";
    }
}
