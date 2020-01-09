using System;

namespace Strategy {
    public class CalculadorDeImpostos {
        public decimal RealizarCalculo(Orcamento orcamento, IImposto imposto) {
            return imposto.CalcularImposto(orcamento);
        }

    }
}