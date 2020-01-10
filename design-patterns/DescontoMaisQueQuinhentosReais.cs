namespace patterns { 
    public class DescontoMaisQueQuinhentosReais : IDesconto { 
        public IDesconto Proximo { get; set; }
        public decimal Descontar(Orcamento orcamento) { 
            if (orcamento.Valor > 500) 
                return orcamento.Valor * 0.07m;
            
            return Proximo.Descontar(orcamento);
        }
    }
}