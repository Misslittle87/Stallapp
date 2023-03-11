using XCalendar.Core.Models;
using System.Windows.Input;
using XCalendar.Core.Enums;
using Stallapp.Model;
using XCalendar.Core.Extensions;
using System.Collections.Specialized;

namespace Stallapp.ViewModel
{
    public partial class CalendarViewModel : BaseViewModel
    {
        public Calendar<EventDay> EventCalendar { get; set; } = new Calendar<EventDay>()
        {
            SelectedDates = new XCalendar.Core.Models.ObservableRangeCollection<DateTime>(),
            SelectionAction = SelectionAction.Modify,
            SelectionType = SelectionType.Single
        };
        public static readonly Random Random = new Random();
        public List<Color> Colors { get; } = new List<Color>() { Microsoft.Maui.Graphics.Colors.Red, Microsoft.Maui.Graphics.Colors.Orange, Microsoft.Maui.Graphics.Colors.Yellow, Color.FromArgb("#00A000"), Microsoft.Maui.Graphics.Colors.Blue, Color.FromArgb("#8010E0") };
        public XCalendar.Core.Models.ObservableRangeCollection<Event> Events { get; } = new XCalendar.Core.Models.ObservableRangeCollection<Event>()
        {
            new Event() { Title = "Bowling", Description = "Bowling with friends" }
        };
        public XCalendar.Core.Models.ObservableRangeCollection<Event> SelectedEvents { get; } = new XCalendar.Core.Models.ObservableRangeCollection<Event>();
        public CalendarViewModel()
        {
            foreach (Event @event in Events)
            {
                @event.DateTime = DateTime.Today.AddDays(Random.Next(-20, 21)).AddSeconds(Random.Next(86400));
                @event.Color = Colors[Random.Next(6)];
            }

            EventCalendar.SelectedDates.CollectionChanged += SelectedDates_CollectionChanged;
            EventCalendar.DaysUpdated += EventCalendar_DaysUpdated;
            foreach (var day in EventCalendar.Days)
            {
                day.Events.ReplaceRange(Events.Where(x => x.DateTime.Date == day.DateTime.Date));
            }
        }
        private void EventCalendar_DaysUpdated(object sender, EventArgs e)
        {
            foreach (var day in EventCalendar.Days)
            {
                day.Events.ReplaceRange(Events.Where(x => x.DateTime.Date == day.DateTime.Date));
            }
        }
        private void SelectedDates_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            SelectedEvents.ReplaceRange(Events.Where(x => EventCalendar.SelectedDates.Any(y => x.DateTime.Date == y.Date)).OrderByDescending(x => x.DateTime));
        }
        [RelayCommand]
        public void NavigateCalendar(int amount)
        {
            if (EventCalendar.NavigatedDate.TryAddMonths(amount, out DateTime targetDate))
            {
                EventCalendar.Navigate(targetDate - EventCalendar.NavigatedDate);
            }
            else
            {
                EventCalendar.Navigate(amount > 0 ? TimeSpan.MaxValue : TimeSpan.MinValue);
            }
        }
        [RelayCommand]
        public void ChangeDateSelection(DateTime dateTime)
        {
            EventCalendar?.ChangeDateSelection(dateTime);
        }

    }

}
