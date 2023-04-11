using System.Security.Principal;

namespace ElearnTemp.Models
{
    public class Course:BaseEntity
    {
        public int Price  { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Sale { get; set; }

        public ICollection<CourseImage> CourseImages { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }


    }
}
