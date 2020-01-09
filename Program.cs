using System;
using Strategy;
using Strategy_2;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestarStrategy_1();
            TestarStrategy_2();
        }

        static void TestarStrategy_1() {
            var icms = new Icms();
            var iss = new Iss();

            var orcamento = new Orcamento(500);
            var calculador = new CalculadorDeImpostos();
            decimal impostoIcms = calculador.RealizarCalculo(orcamento, icms);
            decimal impostoIss = calculador.RealizarCalculo(orcamento, iss);
            System.Console.WriteLine($"Imposto ICMS: {impostoIcms}\nImposto ISS: {impostoIss}"); 
        }

        static void TestarStrategy_2() {
            var calcular = new Calcular(new Soma());
            calcular.CalcularOperacao(24, 18);

            calcular.Calculadora = new Subtracao();
            try {
                calcular.CalcularOperacao(89, 47);
            }
            catch { 
                System.Console.WriteLine("Erro na Operação");
            }
            calcular.Calculadora = new Multiplicacao();
            calcular.CalcularOperacao(21, 2);

            calcular.Calculadora = new Divisao();
            try {
                calcular.CalcularOperacao(210, 5);
            }
            catch (Exception ex){
                Console.WriteLine($"Erro na operação {ex.InnerException}");
            }
        }
    }
}
