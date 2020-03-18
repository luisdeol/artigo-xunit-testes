using ArtigoXUnitTestes.Domain.Entities;

namespace ArtigoXUnitTestes.Domain.Repositories
{
    public interface IContaCorrenteRepository
    {
        ContaCorrente ObterPorDocumento(string documento);
    }
}
