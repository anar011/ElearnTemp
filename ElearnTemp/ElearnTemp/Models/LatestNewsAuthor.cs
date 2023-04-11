namespace ElearnTemp.Models
{
    public class LatestNewsAuthor :BaseEntity
    {
        public string Name { get; set; }

        public ICollection<LatestNews> LatestNewss { get; set; }
    }
}
