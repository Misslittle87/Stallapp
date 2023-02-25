using XCalendar.Core.Models;
using XCalendar.Core.Extensions;

namespace Stallapp.ViewModel
{
    class CalendarViewModel : BaseViewModel
    {
        public Calendar<CalendarDay> MyCalendar { get; set; } = new Calendar<CalendarDay>();

    }
}
