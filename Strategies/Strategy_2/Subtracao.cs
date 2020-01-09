using System;

namespace Strategy_2 {
    public class Subtracao : Calculadora
    {
        public override double Operacao(double a, double b)
        {
            if  (a < b)
                throw new InvalidOperationException();
            return a - b;
        }
    }
}