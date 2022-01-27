using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DatosLinq;
//
namespace Negocio
{
    public static class SopaNegocio
    {
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
        public static List<SopasEntidad> DevolverListaSopas()
        {
            return SopasDatos.DevolverSopas();
        }
        public static SopasEntidad DevolverSopasPorId(int id)
        {
            return SopasDatos.DevolverSopasPorId(id);
        }
        public static SopasEntidad DevolverIngredientesSopasPorId(int id)
        {
            return SopasDatos.DevolverIngredientesSopasPorId(id);
        }
        public static bool EliminarSopa(int id)
        {
            return SopasDatos.EliminarSopa(id);
        }
    }
    
}
