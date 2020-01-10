namespace patterns {
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public decimal Descontar(Orcamento orcamento)
        {
            return 0;
        }
    }
}