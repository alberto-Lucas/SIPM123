using AppMVVM.ViewModels;

namespace AppMVVM.Views;

public partial class PrincipalView : ContentPage
{
	public PrincipalView()
	{
		InitializeComponent();
		//Vincular a View com a ViewModel
		this.BindingContext = 
			new PrincipalViewModel();
	}
}