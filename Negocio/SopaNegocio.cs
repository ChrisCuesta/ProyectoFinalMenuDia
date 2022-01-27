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
    /// clase para el negocio sopa
    /// </summary>
    public static class SopaNegocio
    {
        /// <summary>
        /// Guardars the specified sopa dia.
        /// </summary>
        /// <param name="sopaDia">The sopa dia.</param>
        /// <returns>return sopa dia</returns>
        public static SopasEntidad Guardar(SopasEntidad sopaDia)
        {
            if (sopaDia.IdSopa == 0)
            {
                return SopasDatos.Nuevo(sopaDia);
            }
            else
            {
                return SopasDatos.Actualizar(sopaDia);
            }
        }
        /// <summary>
        /// Devolvers the lista sopas.
        /// </summary>
        /// <returns>return the lista sopas.</returns>
        public static List<SopasEntidad> DevolverListaSopas()
        {
            return SopasDatos.DevolverSopas();
        }
        /// <summary>
        /// Devolvers the sopas por identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>return the sopas por identifier.</returns>
        public static SopasEntidad DevolverSopasPorId(int id)
        {
            return SopasDatos.DevolverSopasPorId(id);
        }
        /// <summary>
        /// Devolvers the ingredientes sopas por identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>return the ingredientes sopas por identifier.</returns>
        public static SopasEntidad DevolverIngredientesSopasPorId(int id)
        {
            return SopasDatos.DevolverIngredientesSopasPorId(id);
        }
        /// <summary>
        /// Eliminars the sopa.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Eliminars the sopa.</returns>
        public static bool EliminarSopa(int id)
        {
            return SopasDatos.EliminarSopa(id);
        }
    }
    
}
