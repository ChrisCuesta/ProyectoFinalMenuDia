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
    /// Clase para el negocio de bebidas
    /// </summary>
    public static class BebidasNegocio
    {
        /// <summary>
        /// Guardars the specified bebidas.
        /// </summary>
        /// <param name="bebidas">The bebidas.</param>
        /// <returns>return bebidas entity</returns>
        public static BebidasEntidad Guardar(BebidasEntidad bebidas)
        {
            if (bebidas.IdBebida == 0)
            {
                return BebidasDatos.Nuevo(bebidas);
            }
            else
            {
                return BebidasDatos.Actualizar(bebidas);
            }
        }
        /// <summary>
        /// Devolvers the lista bebidas.
        /// </summary>
        /// <returns>return the lista bebidas.</returns>
        public static List<BebidasEntidad> DevolverListaBebidas()
        {
            return BebidasDatos.DevolverBebidas();
        }
        /// <summary>
        /// Devolvers the bebidas por identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>return the bebidas por identifier.</returns>
        public static BebidasEntidad DevolverBebidasPorId(int id)
        {
            return BebidasDatos.DevolverBebidaPorId(id);
        }
        /// <summary>
        /// Devolvers the ingredientes bebidas por identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>return the ingredientes bebidas por identifier.</returns>
        public static BebidasEntidad DevolverIngredientesBebidasPorId(int id)
        {
            return BebidasDatos.DevolverIngredientesBebidaPorId(id);
        }
        /// <summary>
        /// Eliminars the bebida.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns> Eliminars the bebida.</returns>
        public static bool EliminarBebida(int id)
        {
            return BebidasDatos.EliminarBebidas(id);
        }
    }
}
