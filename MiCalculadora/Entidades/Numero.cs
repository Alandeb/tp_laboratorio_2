using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        private string SetNumero
        {

            set { numero = ValidarNumero(value); }
        }
        public Numero()
        {
            SetNumero = Convert.ToString(0);
        }
        public Numero(double numero)
        {
            SetNumero = Convert.ToString(numero);
        }
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }

        private double ValidarNumero(string strNumero)
        {
            double numero;
            if (double.TryParse(strNumero, out numero))
            {
                return numero;
            }
            return 0;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return (n1.numero + n2.numero);
        }
        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return (n1.numero * n2.numero);
        }
        public static double operator /(Numero n1, Numero n2)
        {
            return (n1.numero / n2.numero);
        }

        public string BinarioDecimal(string binario)
        {
            
            double total = 0;
            double potencia = 0;
            int binarioInt;
            if (int.TryParse(binario, out binarioInt))
            {
                if(binarioInt < 0)
                {
                    binarioInt += -1;
                    binario = Convert.ToString(binarioInt);
                }
                    
                for (int i = binario.Length - 1; i >= 0; i--)
                {
                    if (binario[i] == '1')
                    {
                        total = total + (Math.Pow(2, potencia) * 1);
                        potencia++;
                    }
                    else if (binario[i] == '0')
                    {
                        potencia++;
                    }
                    else
                    {
                        return "Valor invalido";
                    }
                }
                return Convert.ToString(total);
            }
            return "Valor invalido";
        }
        public string DecimalBinario(double numero)
        {
            int numInt = (int)numero;
            if (numInt < 0)
            {
                numInt *= -1;
                return Convert.ToString(numInt, 2);
            }
            else if (numInt>0)
            {
                return Convert.ToString(numInt, 2);
            }

            return "Valor invalido";
        }
        public string DecimalBinario(string numero)
        {
            
            numero = DecimalBinario(Convert.ToDouble(numero));
            return numero;
        }
    }
}
