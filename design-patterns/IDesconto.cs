namespace patterns { 
    public interface IDesconto {
        IDesconto Proximo { get; set; }
        decimal Descontar(Orcamento orcamento);
     }
}