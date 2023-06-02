using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppMVVM.ViewModels
{
    public class PrincipalViewModel : BaseNotifyViewModel
    {
        //Criar as propriedades dos componentes da tela
        public string Nome { get; set; }

        private string _retorno;
        public string Retorno
        {
            get { return _retorno; }
            set
            {
                _retorno = value;
                OnPropertyChanged();
            }
        }

        //Comando de execução do Botão
        //Iremos recuperar o conteudo do campo Nome
        //e atualizar a lblRetorno com o conteudo da 
        //propriedade Retorno
        public Command RetornoCommand
        {
            get
            {
                return new Command(() =>
                {
                    //Propriedade Retorno vai receber
                    //Uma nova string concatenada com a 
                    //propriedade Nome
                    Retorno = "Olá, " + Nome;
                });
            }
        }

        public ICommand ClienteCommand { get; set; }   
        
        private async void Cliente()
        {
            await Application.Current.MainPage.
                Navigation.PushAsync(new Views.CadClienteView());
        }

        public PrincipalViewModel()
        {
            this.ClienteCommand = new Command(this.Cliente);
        }

    }
}
