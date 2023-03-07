using Stallapp.ViewModel;

namespace Stallapp.View;

public partial class HorseDetailPage : ContentPage
{
	public HorseDetailPage(HorseDetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}