using XCalendar.Core.Models;
using Stallapp.Model;


namespace Stallapp.Model
{
    public class EventCalendar : Calendar<EventDay>
    {
        public XCalendar.Core.Models.ObservableRangeCollection<Event> Events { get; set; } = new XCalendar.Core.Models.ObservableRangeCollection<Event>();

        public override void UpdateDay(EventDay day, DateTime newDateTime)
        {
            base.UpdateDay(day, newDateTime);
            day.Events.ReplaceRange(Events.Where(x => x.DateTime.Date == newDateTime.Date));
        }
    }
}
