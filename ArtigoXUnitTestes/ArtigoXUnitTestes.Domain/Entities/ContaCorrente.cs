namespace ArtigoXUnitTestes.Domain.Entities
{
    public class ContaCorrente
    {
        private const decimal SALDO_INICIAL = 10000;
        private const decimal LIMITE_INICIAL = 20000;

        public ContaCorrente(string responsavel, int agencia, int digito, int numero)
        {
            Responsavel = responsavel;
            Agencia = agencia;
            Digito = digito;
            Numero = numero;
            Saldo = SALDO_INICIAL;
            Limite = LIMITE_INICIAL;
        }

        public string Responsavel { get; private set; }
        public int Agencia { get; private set; }
        public int Digito { get; private set; }
        public int Numero { get; private set; }
        public decimal Saldo { get; private set; }
        public decimal Limite { get; private set; }

        private bool TemLimite(decimal valor)
        {
            return Limite >= valor;
        }

        private bool TemSaldo(decimal valor)
        {
            return Saldo >= valor;
        }

        public bool PodeTransferir(decimal valor)
        {
            return TemLimite(valor) && TemSaldo(valor);
        }

        public void Debitar(decimal valor)
        {
            Saldo -= valor;
            Limite -= valor;
        }

        public void Creditar(decimal valor)
        {
            Saldo += valor;
        }
    }
}
