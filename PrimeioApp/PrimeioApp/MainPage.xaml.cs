namespace PrimeioApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void btnClique(object sender, EventArgs e)
    {
		DisplayAlert("Atenção", 
			"Conteudo: " + txtTexto.Text, 
			"Ok");
	}
}

