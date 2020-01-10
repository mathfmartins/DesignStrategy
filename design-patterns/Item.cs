namespace patterns { 
    public class Item {
        public Item(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }
 
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}