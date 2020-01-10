namespace patterns {
    public class Iss : IImposto {
        public decimal CalcularImposto(Orcamento orcamento) {
            return orcamento.Valor * 0.06m;
        }
    }
} 