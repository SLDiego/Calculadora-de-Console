using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            


            

                while (!endApp)
                {

                    Console.WriteLine("Calculadora de Console\r");
                    Console.WriteLine("----------------------\n");

                    // variáveis vazia.
                    string numInput1 = "";
                    string numInput2 = "";
                    double result = 0;

                    // digitar o primeiro número.
                    Console.Write("Digite um numero e tecle Enter: ");
                    numInput1 = Console.ReadLine();

                    double cleanNum1 = 0;
                    while (!double.TryParse(numInput1, out cleanNum1))
                    {
                        Console.Write("Essa entrada não é valida. Por favor entre com outro valor: ");
                        numInput1 = Console.ReadLine();
                    }

                    // digitar o Segundo número.
                    Console.Write("Digite o segundo numero e tecle Enter ");
                    numInput2 = Console.ReadLine();

                    double cleanNum2 = 0;
                    while (!double.TryParse(numInput2, out cleanNum2))
                    {
                        Console.Write("Digite outro numero e tecle Enter");
                        numInput2 = Console.ReadLine();
                    }



                    // Pergunta Qual Operação deseja fazer.
                    Console.WriteLine("Qual operação deseja:");
                    Console.WriteLine("\ta - Adição");
                    Console.WriteLine("\ts - Subtração");
                    Console.WriteLine("\tm - Multiplicação");
                    Console.WriteLine("\td - Divisão");
                    Console.Write("Escolha sua opção ");

                    string op = Console.ReadLine();

                    try
                    {
                        result = Calcular.Operacao(cleanNum1, cleanNum2, op);
                        if (double.IsNaN(result))
                        {
                            Console.WriteLine("Esta operação resultará em um erro matemático.\n");
                        }
                        else Console.WriteLine("Seu resultado {0:0.##}\n", result);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ah não! Ocorreu uma exceção ao tentar fazer as contas. \n - Detalhes:" + e.Message);
                    }

                    Console.WriteLine("------------------------\n");

                    // Aguarde a resposta do usuário antes de fechar.
                    Console.Write("Pressione 'n' e Enter para sair, ou pressione qualquer tecla e Enter para continuar: ");
                    if (Console.ReadLine() == "n") 
                    endApp = true;
                    
                    
                    Console.Clear();
                    Console.WriteLine("\n"); //Espaçamento de linha.
                }

        }
    }
}
