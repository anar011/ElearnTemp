namespace ElearnTemp.Models
{
    public class LatestNews : BaseEntity
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }

        public string Image { get; set; }

        public int LatestNewsAuthorId { get; set; }
        public LatestNewsAuthor LatestNewsAuthor { get; set; }
    }
}
