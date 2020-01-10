using System.Collections.Generic;

namespace patterns
{
    public class Orcamento {
        public decimal Valor {get; private set;}
        public List<Item> Itens { get; set; }
        
        public Orcamento(decimal valor) {
            Valor = valor;
            Itens = new List<Item>();
        }
        
        public void AdicionarItem(Item item) {
            Itens.Add(item);
        }
    }
}