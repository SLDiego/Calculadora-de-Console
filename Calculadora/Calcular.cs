using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calcular
    {

        public static double Operacao(double num1, double num2, string op)
        {
            
            // O valor padrão é "não um número", que usamos se uma operação, como divisão, puder resultar em um erro.
            double resultado = double.NaN; 
            
            
            // instrução switch para fazer as contas.
            switch (op)
            {
                case "a":
                    resultado = num1 + num2;
                    break;
                case "s":
                    resultado = num1 - num2;
                    break;
                case "m":
                    resultado = num1 * num2;
                    break;
                case "d":

                    // condição para o usuário inserir um divisor diferente de zero.
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    break;

                // Retorne o texto para uma entrada de opção incorreta.
                default:
                    break;
            }

            return resultado;
        }





    }
}
