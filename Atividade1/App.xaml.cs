namespace Atividade1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        //Xamarin
        //MainPage =
        //  new NavigationPage(new pgLogin());
        //MAUI NÃO MEXE AQUI
        MainPage = new AppShell();
	}
}
