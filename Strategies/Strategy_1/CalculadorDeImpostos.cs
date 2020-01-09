namespace Strategy_1
{
    public class CalculadorDeImpostos {
        public decimal RealizarCalculo(Orcamento orcamento, IImposto imposto) {
            return imposto.CalcularImposto(orcamento);
        }

    }
}