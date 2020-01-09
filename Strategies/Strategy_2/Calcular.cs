namespace Strategy_2 {
    public class Calcular {
        public Calcular(Calculadora calculadora)
        {
            Calculadora = calculadora;
        }

        public Calculadora Calculadora {get; set;}
        
        public void CalcularOperacao(double a, double b) {
            System.Console.WriteLine(Calculadora.Operacao(a, b));
        }
    }
}   