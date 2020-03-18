namespace ArtigoXUnitTestes.Infrastructure.Models
{
    public class RespostaNotificacaoViewModel
    {
        public RespostaNotificacaoViewModel(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }

        public bool Sucesso { get; private set; }
        public string Mensagem { get; private set; }
    }
}
