// Detta är viemodelen för mainpage där man ser datum.
// Här ska även läggas till så att man ska kunna se vem som tex har hand om stallet denna dagen (som är bokat i kalendern)

namespace Stallapp.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {        
        [ObservableProperty]
        DateTime currentDate = DateTime.Now;
    }
}
