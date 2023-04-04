namespace Atividade1;

public partial class pgMenu : ContentPage
{
	public pgMenu(string sParametro)
	{
		InitializeComponent();
        lblLogin.Text = 
            "Olá " + sParametro +
            ", Seja bem-vindo!";
	}

    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
		Navigation.PopModalAsync();
    }

    private void btnFutebol_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new pgFutebol());
    }
}