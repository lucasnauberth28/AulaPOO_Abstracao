using System;
using POO_Abstracao.classes;

namespace POO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto bol = new Boleto();

            Credito cre = new Credito();

            Debito deb = new Debito();

            string resposta = "";


            do
            {

                Console.WriteLine("Bem vindo(a) ao nosso sitema, o que o(a) senhor(a) deseja fazer?");
                Console.WriteLine("[1] - Salvar cartão\n[2] - Registrar boleto\n[3] - Pagar\n[4] - Cancelar o pagamento\n[5] - Mostrar dados\n[0] - Sair");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Qual cartão deseja salvar?\n[1] - Crédito\n[2] - Débito");
                        int escolha2 = int.Parse(Console.ReadLine());
                        switch (escolha2)
                        {
                            case 1:
                                Console.Write("Digite a bandeira: ");
                                cre.bandeira = Console.ReadLine();
                                Console.Write("Digite o número do cartão: ");
                                cre.numero = Console.ReadLine();
                                Console.Write("Digite o nome do titular do cartão: ");
                                cre.titular = Console.ReadLine();
                                Console.Write("Digite o cvv: ");
                                cre.cvv = Console.ReadLine();

                                Console.WriteLine("Seu cartão foi salvo no sistema!");
                                Console.WriteLine("Deseja voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();
                                break;

                            case 2:
                                Console.Write("Digite a bandeira: ");
                                deb.bandeira = Console.ReadLine();
                                Console.Write("Digite o número do cartão: ");
                                deb.numero = Console.ReadLine();
                                Console.Write("Digite o nome do titular do cartão: ");
                                deb.titular = Console.ReadLine();
                                Console.Write("Digite o cvv: ");
                                deb.cvv = Console.ReadLine();

                                Console.WriteLine("Seu cartão foi salvo no sistema!");
                                Console.WriteLine("Deseja voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");

                                Console.WriteLine("Deseja voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();
                                break;
                        }
                        break;

                    case 2:
                        Console.Write("Insira a linha digitável do seu boleto: ");
                        bol.CodigoDeBarras = Console.ReadLine();
                        Console.WriteLine("Seu boleto foi registrado!");

                        Console.WriteLine("Deseja voltar para o menu? [s/n] ");
                        resposta = Console.ReadLine();

                        break;

                    case 3:
                        Console.WriteLine("Deseja comprar como?\n[1] - Boleto\n[2] - Crédito\n[3] - Débito");
                        int compra = int.Parse(Console.ReadLine());
                        switch (compra)
                        {
                            case 1:
                                Console.WriteLine("Qual o valor do produto?");
                                int valor = int.Parse(Console.ReadLine());

                                Console.WriteLine(bol.Desconto(valor));

                                Console.WriteLine("Deseja voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();
                                break;

                            case 2:
                                Console.WriteLine("Qual o valor do produto?");
                                int valor2 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Deseja parcelar em quantas vezes?");
                                int parcela = int.Parse(Console.ReadLine());

                                cre.Pagar(valor2, parcela);

                                Console.WriteLine("Deseja voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();                             
                                break;

                            case 3:
                                Console.WriteLine("Qual o valor do produto?");
                                int valor1 = int.Parse(Console.ReadLine());

                                deb.Pagar(valor1);

                                Console.WriteLine("Deseja voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();
                            break;
                            default:
                                break;
                        }
                        
                        break;

                    case 4:
                        Console.WriteLine(deb.Cancelar());

                        Console.WriteLine("Deseja voltar para o menu? [s/n] ");
                        resposta = Console.ReadLine();

                        break;

                    case 5:
                        Console.WriteLine("Deseja exibir os dados do cartão de crédito ou débito?\n[1] - Crédito\n[2] - Débito");
                        int escolha3 = int.Parse(Console.ReadLine());

                        switch (escolha3)
                        {
                            case 1:
                                Console.WriteLine(cre.SalvarCartao());
                                Console.WriteLine($"Limite: {cre.Limite}");

                                Console.WriteLine("Deseja voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine(deb.SalvarCartao());
                                Console.WriteLine($"Saldo: {deb.SaldoEmConta}");

                                Console.WriteLine("Deseja voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");

                                Console.WriteLine("Deseja voltar para o menu? [s/n] ");
                                resposta = Console.ReadLine();
                                break;
                        }
                        break;

                    case 0:
                        Console.WriteLine("Encerrando o programa, agradecemos a preferência!");
                        break;
                    default:
                        break;
                }
            } while (resposta == "s");

        }
    }
}