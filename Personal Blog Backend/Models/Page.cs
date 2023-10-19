namespace Personal_Blog_Backend.Models
{
    public class Page
    {
        public required string Id { get; set; }

        public string? Header { get; set; }

        public string? Content { get; set; }

        public string? Footer { get; set; }
    }
}
