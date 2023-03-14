namespace PrimeioApp;

public partial class MainPage : ContentPage
{
	Utils utils = new Utils();

	public MainPage()
	{
		InitializeComponent();
	}

    private void btnClique(object sender, EventArgs e)
    {
		DisplayAlert("Atenção", 
			"Conteudo: " + txtTexto.Text + "\n" +
			"Mostrar senha: " + 
			utils.iif(ckbSenha.IsChecked, 
					"SIM", "NÃO") + "\n" +
			"Data curta: " + 
			dtpData.Date.ToShortDateString() + "\n" +
			"Data longa: " + 
			dtpData.Date.ToLongDateString(), 
			"Ok");
	}

    private void btnEntrar(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new PgPrincipal());
    }
}

