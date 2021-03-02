namespace ArtigoXUnitTestes.Domain.Entities
{
    public class OperacaoContaCorrente
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public TipoOperacaoEnum Tipo { get; set; }
    }
}
