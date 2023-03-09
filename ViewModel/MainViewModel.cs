namespace Stallapp.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {
        [ObservableProperty]
        DateTime currentDate = DateTime.Now;
    }
}
