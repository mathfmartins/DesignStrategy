namespace patterns
{
    public class CalculadorDesconto  {
        public decimal Calcular(Orcamento orcamento) {
            IDesconto desconto_1 = new DescontoCincoItens();
            IDesconto desconto_2 = new DescontoMaisQueQuinhentosReais();
            IDesconto desconto_3 = new SemDesconto();

            desconto_1.Proximo = desconto_2;
            desconto_2.Proximo = desconto_3;
            
            return desconto_1.Descontar(orcamento);

        }
    }
}