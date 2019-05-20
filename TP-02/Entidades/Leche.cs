using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Leche : Producto
    {
        /// <summary>
        /// Enum de tipo de leche
        /// </summary>
        public enum ETipo
        {
            Entera,
            Descremada
        }
        ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codigo, ConsoleColor color) : base(codigo, marca, color)
        {
            tipo = ETipo.Entera;
        }

        /// <summary>
        /// Contructor de clase
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Leche(EMarca marca, string codigo, ConsoleColor color,ETipo tipo) : base(codigo, marca, color)
        {
            this.tipo = tipo;
        }
        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get{ return 20; }
        }

        /// <summary>
        /// Implementa StringBuilder para hacer una cadena 
        /// </summary>
        /// <returns>Cadena con las descripciones de la leche</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("TIPO : " + tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");
            return sb.ToString();
        }
    }
}
