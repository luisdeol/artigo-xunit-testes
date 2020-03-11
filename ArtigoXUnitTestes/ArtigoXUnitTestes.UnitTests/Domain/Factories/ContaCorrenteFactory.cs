using ArtigoXUnitTestes.Domain.Entities;

namespace ArtigoXUnitTestes.UnitTests.Domain.Factories
{
    public static class ContaCorrenteFactory
    {
        public static ContaCorrente GetContaOrigemValida()
        {
            return new ContaCorrente("Luis", 1234, 5, 98765);
        }

        public static ContaCorrente ObterContaDestinoValida()
        {
            return new ContaCorrente("Felipe", 5678, 9, 43210);
        }
    }
}
