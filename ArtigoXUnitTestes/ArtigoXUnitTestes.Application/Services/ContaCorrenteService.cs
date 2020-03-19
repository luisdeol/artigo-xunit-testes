using ArtigoXUnitTestes.Domain.Repositories;
using ArtigoXUnitTestes.Infrastructure.Services;

namespace ArtigoXUnitTestes.Application.Services
{
    public class ContaCorrenteService
    {
        private readonly INotificacaoService _notificacaoService;
        private readonly IContaCorrenteRepository _contaCorrenteRepository;
        public ContaCorrenteService(INotificacaoService notificacaoService, IContaCorrenteRepository contaCorrenteRepository)
        {
            _notificacaoService = notificacaoService;
            _contaCorrenteRepository = contaCorrenteRepository;
        }

        public bool NotificarContaCorrente(string documento)
        {
            var contaCorrente = _contaCorrenteRepository.ObterPorDocumento(documento);

            if (contaCorrente == null)
            {
                return false;
            }

            var respostaNotificacao = _notificacaoService.Notificar(contaCorrente);

            return respostaNotificacao.Sucesso;
        }
    }
}
