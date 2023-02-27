using Stallapp.ViewModel;

namespace Stallapp.View;

public partial class PointsPage : ContentPage
{
	public PointsPage(PointsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}