namespace patterns
{
    public class CalculadorImpostos {
        public decimal RealizarCalculo(Orcamento orcamento, IImposto imposto) {
            return imposto.CalcularImposto(orcamento);
        }
    }
}