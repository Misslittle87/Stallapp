// Detta är viemodelen för mainpage där man ser datum.
// Här ska även läggas till så att man ska kunna se vem som tex har hand om stallet denna dagen (som är bokat i kalendern)

namespace Stallapp.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {  
        ObservableRangeCollection<UserInfoModel> _users {  get; set; }
        [ObservableProperty]
        DateTime currentDate = DateTime.Now;

        [ObservableProperty]
        public string loginName;
        public MainViewModel()
        {
            _users = new ObservableRangeCollection<UserInfoModel>();
        }
    }
}
