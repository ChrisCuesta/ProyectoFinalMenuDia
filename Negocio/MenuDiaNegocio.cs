using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DatosLinq;

namespace Negocio
{
    public static class MenuDiaNegocio
    {
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
        public static List<MenuDiaEntidad> DevolverListaMenuDia()
        {
            return MenuDiaDatos.DevolverMenuDia();
        }
        public static List<MenuDiaJoin> DevolverListaMenuDiaJoin()
        {
            return MenuDiaDatos.DevolverMenuDiaJoin();
        }
        public static MenuDiaEntidad DevolverMenuDiaPorId(int id)
        {
            return MenuDiaDatos.DevolverMenuDiaPorId(id);
        }
        public static bool EliminarMenuDia(int id)
        {
            return MenuDiaDatos.EliminarMenuDia(id);
        }
        public static List<MenuDiaEntidad> DevolverMenuDiaPorFecha(DateTime date)
        {
            return MenuDiaDatos.DevolverMenuDiaPorFecha(date);
        }
    }
}
