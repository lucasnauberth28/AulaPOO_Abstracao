namespace POO_Abstracao.classes
{
    public class Boleto : Pagamentos
    {
        private string codigoDeBarras;
        public string CodigoDeBarras{
            get{return codigoDeBarras;}
            set{codigoDeBarras = value;}
        }
        public void Registro(string valor){
            this.codigoDeBarras = valor;
        }

        public override string Desconto(float valor)
        {
            return $"Você terá R${valor*0.12} de desconto.\nO preço final com desconto é de R${valor - valor*0.12}";
        }    
    }
}