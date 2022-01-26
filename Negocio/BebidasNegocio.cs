using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DatosLinq;
namespace Negocio
{
    public static class BebidasNegocio
    {
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
        public static List<BebidasEntidad> DevolverListaBebidas()
        {
            return BebidasDatos.DevolverBebidas();
        }
        public static BebidasEntidad DevolverBebidasPorId(int id)
        {
            return BebidasDatos.DevolverBebidaPorId(id);
        }
        public static BebidasEntidad DevolverIngredientesBebidasPorId(int id)
        {
            return BebidasDatos.DevolverIngredientesBebidaPorId(id);
        }
        public static bool EliminarBebida(int id)
        {
            return BebidasDatos.EliminarBebidas(id);
        }
    }
}
