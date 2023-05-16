namespace CaraCoroa;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    bool caraCoroa = true;

    private void ativaBotao(ImageButton img)
    {
        img.BackgroundColor =
            Color.FromHex("#0000FF");
    }

    private void desativaBotao(ImageButton img)
    {
        img.BackgroundColor =
            Color.FromHex("#FFFFFF");
    }

    private void btnSelecaoClicked(object sender, EventArgs e)
    {
        if(sender == btnCara)
        {
            caraCoroa = true;
            lblSelecao.Text = "Cara";
            ativaBotao(btnCara);
            desativaBotao(btnCoroa);
        }
        else
        {
            caraCoroa = false;
            lblSelecao.Text = "Coroa";
            ativaBotao(btnCoroa);
            desativaBotao(btnCara);
        }
    }

    private void btnJogarClicked(object sender, EventArgs e)
    {
        if (lblSelecao.Text == "-----")
        {
            DisplayAlert("Atenção!",
                "Selecione uma das opções.",
                "OK");
        }
        else
        {
            Random random = new Random();
            bool valorAleatorio =
                random.Next(2) == 0;
            neutro();
            animacaoImagem(caraCoroa == valorAleatorio);
        }
    }

    private void neutro()
    {
        lblResultado.Text = "-----";
        lblResultado.TextColor =
            Color.FromHex("#FFFFFF");
    }

    private void ganhouPerdeu(bool resultado)
    {
        if (resultado)
        {
            lblResultado.Text = "Ganhou!!";
            lblResultado.TextColor =
                Color.FromHex("#00FF00");
        }
        else
        {
            lblResultado.Text = "Perdeu!!";
            lblResultado.TextColor =
                Color.FromHex("#FF0000");
        }
    }

    private async void animacaoImagem(bool resultado)
    {
        //Definir valores iniciais
        double inicia = 0;
        double termina = 360;

        //Definir tempo da animação em milissegundos
        uint duracao = 2000;

        //Função de interpolação linear
        Easing easing = Easing.Linear;

        //Iniciar a animação
        await imgCoin.RotateYTo(termina,
            duracao, easing);

        //Resetar o valor de rotação
        imgCoin.RotationY = inicia;

        //Girar infinitamente
        //chamar a propria função
        //animacaoImagem();

        ganhouPerdeu(resultado);
    }
}

