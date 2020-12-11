using System;
namespace POO_Abstracao.classes
{
    public class Debito : Cartao
    {
        private float saldo = 600;
        public float SaldoEmConta{
            get{return saldo;}
            set{saldo = value;}
        }

        public void Pagar(float valor)
        {
            Console.WriteLine($"Você fez um pagamento de R${valor}");
        }
    }
}
