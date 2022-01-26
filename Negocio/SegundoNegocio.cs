using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DatosLinq;
namespace Negocio
{
    public static class SegundoNegocio
    {
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
        public static List<SegundosEntidad> DevolverListaSegundos()
        {
            return SegundosDatos.DevolverSegundos();
        }
        public static SegundosEntidad DevolverSegundosPorId(int id)
        {
            return SegundosDatos.DevolverSegundoPorId(id);
        }
        public static SegundosEntidad DevolverIngredientesSegundosPorId(int id)
        {
            return SegundosDatos.DevolverIngredientesSegundosPorId(id);
        }
        public static bool EliminarSegundo(int id)
        {
            return SegundosDatos.EliminarSegundo(id);
        }
    }
}
