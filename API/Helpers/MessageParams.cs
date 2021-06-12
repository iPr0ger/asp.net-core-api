namespace API.Helpers
{
    public class MessageParams
    {
        public string Username { get; set; }
        public string Container { get; set; } = "unread";
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
    }
}