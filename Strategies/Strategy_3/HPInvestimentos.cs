using System;

namespace Strategy_3 {
    public class Conta {
        public Conta(decimal saldo, IInvestimento perfil)
        {
            Saldo = saldo;
            Perfil = perfil;
        }
        public IInvestimento Perfil { get; set; }
        public decimal Saldo { get; set; }
        public void Depositar(decimal valor) {
             Saldo += valor;
        }
    }

    public interface IInvestimento { 
        decimal Investir(Conta conta);
    }

    public class Conservador : IInvestimento
    {
        public decimal Investir(Conta conta)
        {
            return conta.Saldo * 0.008m;
        }
    }

    public class Moderado : IInvestimento
    {
        public Moderado() => random = new Random();
        private Random random{ get; }
        public decimal Investir(Conta conta)
        {
            if (random.Next(2) == 0)
                return conta.Saldo * 0.025m;
            else
                return conta.Saldo * 0.007m;
        }
    }

    public class Arrojado : IInvestimento {
        private Random random;

        public Arrojado() 
        {
        this.random = new Random();
        }    
        public decimal Investir(Conta conta) 
        {
            int chute = random.Next(10);
            if(chute >= 0 && chute <= 1)
                return conta.Saldo * 0.5m;
            else if (chute >= 2 && chute <= 4) 
                return conta.Saldo * 0.3m;
            else 
                return conta.Saldo * 0.006m;
        }
    }

    public class RealizadorDeInvestimentos { 
        const decimal IMPOSTO = 0.25m; 
        public void RealizarInvestimento(Conta conta) {
            decimal valorInvestimento = conta.Perfil.Investir(conta);
            conta.Depositar(valorInvestimento - (valorInvestimento * IMPOSTO));
            System.Console.WriteLine($"\nSaldo R$: {conta.Saldo.ToString("C2")}");
        }
    }
}