using ArtigoXUnitTestes.Domain.Entities;
using ArtigoXUnitTestes.Infrastructure.Models;

namespace ArtigoXUnitTestes.Infrastructure.Services
{
    public interface INotificacaoService
    {
        RespostaNotificacaoViewModel Notificar(ContaCorrente contaCorrente);
    }
}
