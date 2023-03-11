using Stallapp.Model;
using XCalendar.Core.Interfaces;
using XCalendar.Core.Models;

namespace Stallapp.Model
{
    public class EventDay : BaseObservableModel, ICalendarDay
    {
        public DateTime DateTime { get; set; }
        public XCalendar.Core.Models.ObservableRangeCollection<Event> Events { get; } = new XCalendar.Core.Models.ObservableRangeCollection<Event>();
        public bool IsSelected { get; set; }
        public bool IsCurrentMonth { get; set; }
        public bool IsToday { get; set; }
        public bool IsInvalid { get; set; }
    }
}
