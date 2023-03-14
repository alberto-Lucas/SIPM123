namespace PrimeioApp
{
    public class Utils
    {
        public string iif(Boolean condicao,
                    string verdadeira,
                    string falsa)
        {
            if (condicao)
                return verdadeira;
            else
                return falsa;
        }
    }
}
