namespace Atividade1;

public partial class pgFutebol : ContentPage
{
	public pgFutebol()
	{
		InitializeComponent();
	}

    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
		Navigation.PopModalAsync();
    }
}