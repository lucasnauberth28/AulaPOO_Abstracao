using System;

namespace POO_Abstracao.classes
{
    public abstract class Pagamentos
    {
        private DateTime data;
        protected float valor;

        public string Cancelar(){
            return $"Cancelamento feito!!";
        }

        public abstract string Desconto(float valor);


    }
}
