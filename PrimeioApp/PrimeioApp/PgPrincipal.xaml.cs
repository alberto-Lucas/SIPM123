namespace PrimeioApp;

public partial class PgPrincipal : ContentPage
{
	public PgPrincipal()
	{
		InitializeComponent();
	}

    private void btnVoltar(object sender, EventArgs e)
    {
		Navigation.PopModalAsync();
    }
}