using patterns;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculador = new CalculadorDesconto();
            var orcamento = new Orcamento(500);
            orcamento.AdicionarItem(new Item("Coca-Cola", 8.72m));
            orcamento.AdicionarItem(new Item("Arroz", 21.00m));
            orcamento.AdicionarItem(new Item("Notebook", 3499));
            orcamento.AdicionarItem(new Item("Churrasqueira", 500));
            orcamento.AdicionarItem(new Item("Fogão", 500));
            orcamento.AdicionarItem(new Item("Smart TV", 1900));
            
            decimal desconto = calculador.Calcular(orcamento);
            System.Console.WriteLine(desconto);
        }
    }
}
