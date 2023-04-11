namespace Atividade1;

public partial class pgLogin : ContentPage
{
	public pgLogin()
	{
		InitializeComponent();
	}

    private void btnEntrar_Clicked(object sender, EventArgs e)
    {
		if(ValidarLogin(txtLogin.Text, txtSenha.Text))
		{
			//atribuindo a instancia a variavel
			var usuarioLogado = UsuarioLogado.Instancia;
			//atribuindo valores aos atributos da
			//classe singleton
			usuarioLogado.IdUsuario = 1;
			usuarioLogado.NomeUsuario = txtLogin.Text;

			Navigation
				.PushModalAsync
				(new pgMenu(txtLogin.Text));
		}
		else
            //DisplayAlert("titulo", "Conteudo", "Botao");"
            DisplayAlert("Atenção",
						 "Login ou Senha inválido.",
						 "Ok");
    }

	private bool ValidarLogin(string login, string senha)
	{
		//if(login == "admin" && senha == "123")
        if (senha == "123")
            return true;
		else 
			return false;
	}
}