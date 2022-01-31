using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DatosLinq;

namespace Negocio
{
    /// <summary>
    /// clase para el negocio de las entradas
    /// </summary>
    public static class EntradasNegocio
    {
        /// <summary>
        /// Guardars the specified entrada.
        /// </summary>
        /// <param name="entrada">The entrada.</param>
        /// <returns>return entradas entity</returns>
        public static EntradasEntidad Guardar(EntradasEntidad entrada)
        {
            if (entrada.IdEntrada == 0)
            {
                return EntradasDatos.Nuevo(entrada);
            }
            else
            {
                return EntradasDatos.Actualizar(entrada);
            }
        }
        /// <summary>
        /// Devolvers the lista entrada.
        /// </summary>
        /// <returns>return the lista entrada.</returns>
        public static List<EntradasEntidad> DevolverListaEntrada()
        {
            return EntradasDatos.DevolverEntradas();
        }
        /// <summary>
        /// Devolvers the entradas por identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>return the entradas por identifier.</returns>
        public static EntradasEntidad DevolverEntradasPorId(int id)
        {
            return EntradasDatos.DevolverEntradaPorId(id);
        }
        /// <summary>
        /// Devolvers the ingredientes entradas por identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>return the ingredientes entradas por identifier.</returns>
        public static EntradasEntidad DevolverIngredientesEntradasPorId(int id)
        {
            return EntradasDatos.DevolverIngredientesEntradaPorId(id);
        }
        /// <summary>
        /// Eliminars the entrada.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Eliminars the entrada.</returns>
        public static bool EliminarEntrada(int id)
        {
            return EntradasDatos.EliminarEntrada(id);
        }
    }
}
