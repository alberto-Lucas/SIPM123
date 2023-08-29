namespace AulaScreenAnimation;

public partial class pgSplashScreen : ContentPage
{
	public pgSplashScreen()
	{
		InitializeComponent();
		AnimateImage();
    }

	async void AnimateImage()
	{
		await Task.Delay(2000); //2segundos
		imgMundo.Rotation = 0;
		imgMundo.RotateTo(360, 3000);
		imgMundo.Rotation = 0;
		await Task.Delay(2000);

		await imgMundo.ScaleTo(1.5, 2000, Easing.Linear);
		await imgMundo.ScaleTo(1, 1000, Easing.Linear);
		await imgMundo.ScaleTo(0.5, 1500, Easing.Linear);
		await imgMundo.ScaleTo(150, 1500, Easing.Linear);

		Application.Current.MainPage =
			new NavigationPage(new pgAnimacoes());
	}
}