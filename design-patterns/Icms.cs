namespace patterns {
    public class Icms : IImposto {
        public decimal CalcularImposto(Orcamento orcamento) {
            return orcamento.Valor * 0.01m;
        }
    }
}