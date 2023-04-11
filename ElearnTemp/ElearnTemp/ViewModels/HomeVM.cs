using ElearnTemp.Models;

namespace ElearnTemp.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }

        public IEnumerable<Author> Authors { get; set; }
        public IEnumerable<Course> Courses { get; set; }

        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<LatestNews> LatestNewss { get; set; }

        public IEnumerable<LatestNewsAuthor> LatestNewsAuthors { get; set; }


    }
}
