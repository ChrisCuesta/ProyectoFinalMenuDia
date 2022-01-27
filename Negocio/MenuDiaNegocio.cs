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
    /// clase para el negocio de menu del dia
    /// </summary>
    public static class MenuDiaNegocio
    {
        /// <summary>
        /// Guardars the specified menu dia.
        /// </summary>
        /// <param name="menuDia">The menu dia.</param>
        /// <returns>return MenuDiaEntidad</returns>
        public static MenuDiaEntidad Guardar(MenuDiaEntidad menuDia)
        {
            if (menuDia.NumMen == 0)
            {
                return MenuDiaDatos.Nuevo(menuDia);
            }
            else
            {
                return MenuDiaDatos.Actualizar(menuDia);
            }
        }
        /// <summary>
        /// Devolvers the lista menu dia.
        /// </summary>
        /// <returns>return the lista menu dia.</returns>
        public static List<MenuDiaEntidad> DevolverListaMenuDia()
        {
            return MenuDiaDatos.DevolverMenuDia();
        }
        /// <summary>
        /// Devolvers the lista menu dia join.
        /// </summary>
        /// <returns>return the lista menu dia join.</returns>
        public static List<MenuDiaJoin> DevolverListaMenuDiaJoin()
        {
            return MenuDiaDatos.DevolverMenuDiaJoin();
        }
        /// <summary>
        /// Devolvers the menu dia por identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>return the menu dia por identifier.</returns>
        public static MenuDiaEntidad DevolverMenuDiaPorId(int id)
        {
            return MenuDiaDatos.DevolverMenuDiaPorId(id);
        }
        /// <summary>
        /// Eliminars the menu dia.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Eliminars the menu dia.</returns>
        public static bool EliminarMenuDia(int id)
        {
            return MenuDiaDatos.EliminarMenuDia(id);
        }
        /// <summary>
        /// Devolvers the menu dia por fecha.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns>return the menu dia por fecha.</returns>
        public static List<MenuDiaEntidad> DevolverMenuDiaPorFecha(DateTime date)
        {
            return MenuDiaDatos.DevolverMenuDiaPorFecha(date);
        }
    }
}
