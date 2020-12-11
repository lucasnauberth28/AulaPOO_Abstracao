namespace POO_Abstracao.classes
{
    public abstract class Cartao : Pagamentos
    {
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;

        public override string Desconto(float valor)
        {
            return "";
        }

        public string SalvarCartao(){
            return $"Bandeira: {bandeira}\nNúmero: {numero}\nTitular: {titular}\nCVV: {cvv}";
        }



    }
}
