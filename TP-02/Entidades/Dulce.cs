using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Dulce : Producto
    {
        /// <summary>
        /// constructor de clase
        /// </summary>
        /// <param name="marca">Tipo de producto</param>
        /// <param name="codigo">cod</param>
        /// <param name="color"></param>
        public Dulce(EMarca marca, string codigo, ConsoleColor color) : base(codigo,marca,color)
        {
        }

        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get { return 80; }
        }
        /// <summary>
        /// Implementa StringBuilder para hacer una cadena 
        /// </summary>
        /// <returns>Cadena con las descripciones del dulce</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");
            return sb.ToString();
        }
    }
}
