using System.Collections.ObjectModel;

namespace AppListView;

public partial class MainPage : ContentPage
{
	public class Pessoa
	{
        public string Nome { get; set; }
        public string Idade { get; set; }         
    }

    ObservableCollection<Pessoa> pessoas =
            new ObservableCollection<Pessoa>();

    public MainPage()
	{
		InitializeComponent();
        //Vincula da lista de Pessoas com a ListView
        lsvLista.ItemsSource = pessoas;
        pessoas.Add(
                new Pessoa
                {
                    Nome = "Lucas",
                    Idade = "00"
                }
            );
    }

    private void btnAdicionarClicked(object sender, EventArgs e)
    {
        string nome = txtNome.Text;
        string idade = txtIdade.Text;

        //String
        //IsNullOrEmpty - valida se o campo é nullo ou vazio

        if (!String.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(idade))
        {
            pessoas.Add(
                new Pessoa
                {
                    Nome = nome,
                    Idade = idade
                }
            );
            txtNome.Text = string.Empty;
            txtIdade.Text = string.Empty;
        }
        else
            DisplayAlert("Atenção",
                         "Por favor, preencha o nome e a idade.", "OK");
    }
}

