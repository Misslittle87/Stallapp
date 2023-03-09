using XCalendar.Core.Models;
using System.Windows.Input;
using XCalendar.Core.Enums;
using Stallapp.Model;
using XCalendar.Core.Extensions;

namespace Stallapp.ViewModel
{
    public partial class CalendarViewModel : BaseViewModel
    {
        public Calendar<CalendarDay> MyCalendar { get; set; } = new Calendar<CalendarDay>()
        {
            SelectionAction = SelectionAction.Replace,
            SelectionType = SelectionType.Single
        };

        public CalendarDay OutsideCalendarDay { get; set; } = new CalendarDay();

        public CalendarViewModel()
        {
            MyCalendar.DaysUpdated += Calendar_DaysUpdated;
            MyCalendar.UpdateDay(OutsideCalendarDay, MyCalendar.NavigatedDate);
        }
        public List<string> CommonFunctionalities { get; } = new List<string>()
        {
            "None",
            "Single",
            "Multiple",
            "Range"
        };

        [RelayCommand]
        public void NavigateCalendar(int amount)
        {
            DateTime targetDateTime = MyCalendar.NavigatedDate.AddMonths(amount);
            MyCalendar.Navigate(targetDateTime - MyCalendar.NavigatedDate);
        }

        [RelayCommand]
        public void ChangeDateSelection(DateTime dateTime)
        {
            MyCalendar?.ChangeDateSelection(dateTime);
        }
        [RelayCommand]
        public async void ShowSelectionTypeDialog()
        {
            MyCalendar.SelectionType = await PopupHelper.ShowSelectItemDialogAsync(MyCalendar.SelectionType, PopupHelper.AllSelectionTypes);
        }
        [RelayCommand]
        public async void ShowSelectionActionDialog()
        {
            MyCalendar.SelectionAction = await PopupHelper.ShowSelectItemDialogAsync(MyCalendar.SelectionAction, PopupHelper.AllSelectionActions);
        }
        [RelayCommand]
        public async void ShowCommonFunctionalityDialog()
        {
            string commonFunctionality = await PopupHelper.ShowSelectItemDialogAsync(CommonFunctionalities[1], CommonFunctionalities);

            switch (commonFunctionality)
            {
                case "None":
                    MyCalendar.SelectionType = SelectionType.None;
                    break;

                case "Single":
                    MyCalendar.SelectionType = SelectionType.Single;
                    MyCalendar.SelectionAction = SelectionAction.Replace;
                    break;

                case "Multiple":
                    MyCalendar.SelectionType = SelectionType.Single;
                    MyCalendar.SelectionAction = SelectionAction.Modify;
                    break;

                case "Range":
                    MyCalendar.SelectionType = SelectionType.Range;
                    MyCalendar.SelectionAction = SelectionAction.Replace;
                    break;
            }
        }

        public void Calendar_DaysUpdated(object sender, EventArgs e)
        {
            MyCalendar.UpdateDay(OutsideCalendarDay, MyCalendar.NavigatedDate);
        }
    }

}
