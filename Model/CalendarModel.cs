using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stallapp.Model
{
    public class CalendarModel : ObservableObject
    {
        public DateTime Date { get; set; }
        private bool _isCurrentDate;
        public bool IsCurrentDate
        {
            get => _isCurrentDate;
            set => SetProperty(ref _isCurrentDate, value);
        }
    }
}
