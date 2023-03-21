using System.Collections.ObjectModel;

namespace Stallapp.Control;

public partial class CalendarView : StackLayout
{
    public static readonly BindableProperty SelectedDateProperty = BindableProperty.Create(
    nameof(SelectedDate),
    typeof(DateTime),
    declaringType: typeof(CalendarView),
    defaultBindingMode: BindingMode.TwoWay,
    defaultValue: DateTime.Now
    );
    public DateTime SelectedDate
    {
        get => (DateTime)GetValue(SelectedDateProperty);
        set => SetValue(SelectedDateProperty, value);
    }
    private DateTime _monthDate;
    public ObservableCollection<CalendarModel> Dates { get; set; } = new ObservableCollection<CalendarModel>();
    public CalendarView()
	{
		InitializeComponent();
        BindDates(DateTime.Now);
	}
    private void BindDates(DateTime date)
    {
        Dates.Clear();
        int daysCount = DateTime.DaysInMonth(date.Year, date.Month);
        for (int day = 1; day <= daysCount; day++)
        {
            Dates.Add(new CalendarModel
            {
                Date = new DateTime(date.Year, date.Month, day),
            });
        }
        var selectedDate = Dates.Where(d => d.Date.Date == SelectedDate.Date).FirstOrDefault();
        if (selectedDate != null)
        {
            selectedDate.IsCurrentDate = true;
            _monthDate = selectedDate.Date;
        }
    }
    [RelayCommand]
    public void CurrentDate(CalendarModel currentDate)
    {
        _monthDate = currentDate.Date;
        SelectedDate = currentDate.Date;        
        Dates.ToList().ForEach(d => d.IsCurrentDate = false);
        currentDate.IsCurrentDate = true;
    }
    [RelayCommand]
    public void NextMonth()
    {
        _monthDate = _monthDate.AddMonths(1);
        BindDates(_monthDate);
    }
    [RelayCommand]
    public void PrevMonth()
    {
        _monthDate = _monthDate.AddMonths(-1);
        BindDates(_monthDate);
    }
}