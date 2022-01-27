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
    /// clase para el negocio de segundo
    /// </summary>
    public static class SegundoNegocio
    {
        /// <summary>
        /// Guardars the specified segundo.
        /// </summary>
        /// <param name="segundo">The segundo.</param>
        /// <returns>return entidad segundo</returns>
        public static SegundosEntidad Guardar(SegundosEntidad segundo)
        {
            if (segundo.IdSegundo == 0)
            {
                return SegundosDatos.Nuevo(segundo);
            }
            else
            {
                return SegundosDatos.Actualizar(segundo);
            }
        }
        /// <summary>
        /// Devolvers the lista segundos.
        /// </summary>
        /// <returns>return the lista segundos.</returns>
        public static List<SegundosEntidad> DevolverListaSegundos()
        {
            return SegundosDatos.DevolverSegundos();
        }
        /// <summary>
        /// Devolvers the segundos por identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>return the segundos por identifier.</returns>
        public static SegundosEntidad DevolverSegundosPorId(int id)
        {
            return SegundosDatos.DevolverSegundoPorId(id);
        }
        /// <summary>
        /// Devolvers the ingredientes segundos por identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns> return the ingredientes segundos por identifier.</returns>
        public static SegundosEntidad DevolverIngredientesSegundosPorId(int id)
        {
            return SegundosDatos.DevolverIngredientesSegundosPorId(id);
        }
        /// <summary>
        /// Eliminars the segundo.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Eliminars the segundo.</returns>
        public static bool EliminarSegundo(int id)
        {
            return SegundosDatos.EliminarSegundo(id);
        }
    }
}
