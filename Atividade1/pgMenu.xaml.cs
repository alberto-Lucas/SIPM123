namespace Atividade1;

public partial class pgMenu : ContentPage
{
	public pgMenu(string sParametro)
	{
		InitializeComponent();
        lblLogin.Text = 
            "Olá " + sParametro +
            ", Seja bem-vindo!";

        var usuarioLogado = UsuarioLogado.Instancia;

        lblSingleton.Text = usuarioLogado.NomeUsuario +
            " salvo na classe singleton";


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