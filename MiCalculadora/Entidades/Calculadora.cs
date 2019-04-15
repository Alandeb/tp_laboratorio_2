using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado=0;
            operador = ValidarOperador(operador);
            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    if (double.IsInfinity(resultado))
                    {
                        resultado = double.MinValue;
                    }
                    break;
                default:
                    break;
            }
            return resultado;
        }

        private static string ValidarOperador(string operador)
        {
            if (operador != "/" && operador != "+" && operador != "-" && operador != "*")
            {
                operador = "+";
            }

            return operador;
        }
    }
}
