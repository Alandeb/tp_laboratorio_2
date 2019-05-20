﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Changuito
    {
        private List<Producto> productos;
        private int espacioDisponible;
        /// <summary>
        /// Tipo de producto
        /// </summary>
        public enum ETipo
        {
            Dulce,
            Leche,
            Snacks,
            Todos
        }

        #region "Constructores"
        /// <summary>
        /// Instancia la lista
        /// </summary>
        private Changuito()
        {
            productos = new List<Producto>();
        }
        /// <summary>
        /// Inicializa la lista y le da un maximo permitido 
        /// </summary>
        /// <param name="espacioDisponible">maximo espacio disponible</param>
        public Changuito(int espacioDisponible): this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el Changuito y TODOS los Productos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Changuito.Mostrar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="c">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Mostrar(Changuito c, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", c.productos.Count, c.espacioDisponible);
            sb.AppendLine("");
            foreach (Producto p in c.productos)
            {
                switch(tipo)
                {
                    case ETipo.Snacks:
                        if(p is Snacks)
                            sb.AppendLine(p.Mostrar());
                        break;
                    case ETipo.Dulce:
                        if(p is Dulce)
                            sb.AppendLine(p.Mostrar());
                        break;
                    case ETipo.Leche:
                        if(p is Leche)
                            sb.AppendLine(p.Mostrar());
                        break;
                    case ETipo.Todos:
                        sb.AppendLine(p.Mostrar());
                        break;
                    default:
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns></returns>
        public static Changuito operator +(Changuito c, Producto p)
        {
            if(c.productos.Count < 6)
            {
                foreach (Producto product in c.productos)
                {
                    if (product == p)
                        return c;
                }
                c.productos.Add(p);
            }
            return c;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns></returns>
        public static Changuito operator -(Changuito c, Producto p)
        {
            foreach (Producto product in c.productos)
            {
                if (product == p)
                {
                    c.productos.Remove(p);
                    break;
                }
            }

            return c;
        }
        #endregion
    }
}
