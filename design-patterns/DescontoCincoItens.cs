namespace patterns
{
    public class DescontoCincoItens : IDesconto { 
        public IDesconto Proximo { get; set; }
        public decimal Descontar(Orcamento orcamento) { 
            if (orcamento.Itens.Count > 5) 
                return orcamento.Valor * 0.1m;
                
            return Proximo.Descontar(orcamento);
        }
    }
}