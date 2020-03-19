using ArtigoXUnitTestes.Infrastructure.Models;

namespace ArtigoXUnitTestes.UnitTests.Application.Factories
{
    public static class RespostaNotificacaoViewModelFactory
    {
        public static RespostaNotificacaoViewModel ObterRespostaSucesso()
        {
            return new RespostaNotificacaoViewModel(true, string.Empty);
        }

        public static RespostaNotificacaoViewModel ObterRespostaFalha()
        {
            return new RespostaNotificacaoViewModel(false, "Serviço fora do ar");
        }
    }
}
