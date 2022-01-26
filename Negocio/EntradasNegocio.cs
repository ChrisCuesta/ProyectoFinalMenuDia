using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DatosLinq;

namespace Negocio
{
    public static class EntradasNegocio
    {
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
        public static List<EntradasEntidad> DevolverListaEntrada()
        {
            return EntradasDatos.DevolverEntradas();
        }
        public static EntradasEntidad DevolverEntradasPorId(int id)
        {
            return EntradasDatos.DevolverEntradaPorId(id);
        }
        public static EntradasEntidad DevolverIngredientesEntradasPorId(int id)
        {
            return EntradasDatos.DevolverIngredientesEntradaPorId(id);
        }
        public static bool EliminarEntrada(int id)
        {
            return EntradasDatos.EliminarEntrada(id);
        }
    }
}
