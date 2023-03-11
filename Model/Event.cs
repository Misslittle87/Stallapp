using Stallapp.Model;
using XCalendar.Core.Models;

namespace Stallapp.Model
{
    public class Event : BaseObservableModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Today;
        public Color Color { get; set; }
    }
}
