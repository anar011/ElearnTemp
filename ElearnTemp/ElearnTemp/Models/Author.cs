namespace ElearnTemp.Models
{
    public class Author:BaseEntity
    {
        public string Name { get; set; }

        public string AuthorImage { get; set; }

        public ICollection<Course>  Courses { get; set; }
        
    }
}

