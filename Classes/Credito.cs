using System;
namespace POO_Abstracao.classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;
        public float Limite{
            get{return limite;}
            set{limite = value;}
        }

        public void Pagar(float valor, int parcela){
            if(parcela <= 6){
                Console.WriteLine($"Você pagará 5% de juros no valor total. seu produto ficou num valor de: RS{valor + valor*0.05}");
            }else if(parcela >= 7 && parcela <=12){
                Console.WriteLine($"Você pagará 8% de juros no valor total. seu produto ficou num valor de: RS{valor + valor*0.08}");
            }else{
                Console.WriteLine("Só é possível parcelar em até 12 vezes.");
            }
        }
    }
}