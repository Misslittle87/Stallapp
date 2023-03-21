
// Alla viewmodels ärver från baseviewmodel som är ett ObervableObject. Det kommer från MVVMCommunitToolkit, som är ett paket jag använder.
// Här bla har jag haft problem med att !IsBusy inte finns. Startar jag om projektet så funkar det. I skrivande stund funkar den också.

namespace Stallapp.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        public BaseViewModel()
        {            
        }
        [ObservableProperty]
        //[NotifyPropertyChangedFor(nameof(IsNotBusy))]
        public bool isBusy;
        [ObservableProperty]
        string title;

        //public bool IsNotBusy => !IsBusy;
    }
}