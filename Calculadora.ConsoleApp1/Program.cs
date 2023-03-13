namespace Calculadora.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Academia do programador - Leonardo Andrade");

            int opcao;

            List<string> historicoCalculadora = new List<string>();
            string[] options = { "soma", "subtracao", "multiplicacao", "divisao" };

            do
            {
                Console.Clear();
                Console.WriteLine(" -----= Menu =----- \n\n [1] - Soma \n [2] - Subtração \n [3] - Multiplicação \n [4] - Divisão \n [5] - Tabuada \n [6] - Sair e Imprimir histórico \n\n -----=      =----- \n");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1 || opcao == 2 || opcao == 3 || opcao == 4)
                {
                    decimal resultado = todosCalculos(historicoCalculadora, options[opcao - 1]);
                    Console.WriteLine($" \n O resultado da conta é {resultado} \n");
                    Console.ReadLine();
                    continue;
                } else if (opcao == 5)
                {
                    Console.WriteLine("Informe um número para gerar a tabuada: ");
                    int numeroTabuada = int.Parse(Console.ReadLine());

                    for (int i = 0; i <= 10; i++)
                    {
                        Console.WriteLine($" {i} x {numeroTabuada} = {i * numeroTabuada}");
                    }

                    historicoCalculadora.Add($"Tabuada: A tabuada do {numeroTabuada} foi gerada");
                    Console.ReadLine();
                    continue;
                }
                else if (opcao == 6)
                {
                    Console.WriteLine(" \n Saindo da aplicação e imprimindo histórico ...");

                    Console.WriteLine("\n\n -----= Histórico Calculadora =----- \n");

                    foreach (string operacao in historicoCalculadora)
                    {
                        Console.WriteLine("\t --> " + operacao);
                    }

                    Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("\n\nOpção inválida. Enter para tentar novamente \n\n");
                    Console.ReadLine();
                    continue;
                }
            } while (opcao != 6);

        }

        static decimal todosCalculos( List<string> historicoCalculadora, string type)
        {
            Console.Write(" \n Digite o primeiro número:  ");
            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());
            Console.Write(" \n Digite o segundo número:  ");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

            if (type == "soma")
            {
                decimal resultado = primeiroNumero + segundoNumero;
                historicoCalculadora.Add($"Soma: {primeiroNumero} + {segundoNumero} =  {resultado}");
                return resultado;

            }
            else if (type == "subtracao")
            {
                decimal resultado = primeiroNumero - segundoNumero;
                historicoCalculadora.Add($"Subtração: {primeiroNumero} - {segundoNumero} =  {resultado}");
                return resultado;

            }
            else if (type == "multiplicacao")
            {
                decimal resultado = primeiroNumero * segundoNumero;
                historicoCalculadora.Add($"Multiplicação: {primeiroNumero} * {segundoNumero} =  {resultado}");
                return resultado;

            }
            else if (type == "divisao")
            {
                while (segundoNumero == 0)
                {
                    Console.WriteLine("O número não pode ser igual a zero");
                    Console.WriteLine("Digite o segundo número novamente: ");
                    segundoNumero = Convert.ToDecimal(Console.ReadLine());
                }

                decimal resultado = primeiroNumero / segundoNumero;
                historicoCalculadora.Add($"Divisão: {primeiroNumero} / {segundoNumero} =  {resultado}");
                return resultado;
            }
            else
            {
                Console.WriteLine("Operação inválida");
                return 0;
            }

        }
    } 


}