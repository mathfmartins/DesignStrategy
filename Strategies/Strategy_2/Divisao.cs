using System;

namespace Strategy_2 {
    public class Divisao : Calculadora
    {
        public override double Operacao(double a, double b)
        {
            if (b == 0)
                throw new InvalidOperationException();
            return a / b;
        }
    }
}