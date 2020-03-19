using ArtigoXUnitTestes.Domain.Entities;

namespace ArtigoXUnitTestes.UnitTests.Domain.Factories
{
    public static class ContaCorrenteFactory
    {
        public static ContaCorrente GetContaOrigemValida()
        {
            return new ContaCorrente("Luis", "12345678910", 1234, 5, 98765, "luis@email.com", "1234-5678");
        }

        public static ContaCorrente ObterContaDestinoValida()
        {
            return new ContaCorrente("Felipe", "10987654321", 5678, 9, 43210, "felipe@email.com", "8765-4321");
        }
    }
}
