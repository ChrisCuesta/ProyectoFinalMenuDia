using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DatosLinq;

namespace Negocio
{
    public static class PedidosNegocio
    {

        public static PedidosEntidad Guardar(PedidosEntidad pedido)
        {
            if (pedido.Id == 0)
            {
                return PedidosDatos.Nuevo(pedido);
            }
            else
            {
                return PedidosDatos.Actualizar(pedido);
            }
        }
    }
}
