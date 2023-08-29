namespace AulaScreenAnimation;

public partial class pgAnimacoes : ContentPage
{
	public pgAnimacoes()
	{
		InitializeComponent();
	}

    private void btnGirarVerticalClicked(object sender, EventArgs e)
    {
		imgMundo.RotationY = 0;
		imgMundo.RotateYTo(360, 2000);
    }

    private void btnGirarHorizontalClicked(object sender, EventArgs e)
    {
        imgMundo.RotationX = 0;
        imgMundo.RotateXTo(360, 2000);
    }

    private void btnZoomMaisClicked(object sender, EventArgs e)
    {
        imgMundo.ScaleTo(imgMundo.Scale + 0.5, 250);
    }

    private void btnZoomMenosClicked(object sender, EventArgs e)
    {
        imgMundo.ScaleTo(imgMundo.Scale - 0.5, 250);
    }

    private void btnTremerClicked(object sender, EventArgs e)
    {
        Tremer(50);
    }

    async void Tremer(uint tempo)
    {
        await imgMundo.TranslateTo(-15, 0, tempo);
        await imgMundo.TranslateTo(15, 0, tempo);
        await imgMundo.TranslateTo(-10, 0, tempo);
        await imgMundo.TranslateTo(10, 0, tempo);
        await imgMundo.TranslateTo(-5, 0, tempo);
        await imgMundo.TranslateTo(5, 0, tempo);
        imgMundo.TranslationX = 0;
    }

    private async void btnGirarZoomClicked(object sender, EventArgs e)
    {
        imgMundo.Rotation = 0;

        //cria uma tarefa em segundo plano
        //aguarda a execução da tarefa
        await Task.WhenAny<bool>
            (
                //programar a execução
                //girar por 2 segundos
                imgMundo.RotateTo(360, 4000),
                //no primeiro segundo ele vai da zoom
                imgMundo.ScaleTo(2, 2000)
            );
        //no ultimo segundo vai retirar o zoom
        await imgMundo.ScaleTo(1, 2000);

    }
}