namespace ElearnTemp.Models
{
    public class Event:BaseEntity
    {
        public string Header { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
