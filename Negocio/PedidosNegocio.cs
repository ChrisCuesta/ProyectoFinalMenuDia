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
    /// clase para el negocio de pedidos
    /// </summary>
    public static class PedidosNegocio
    {
        /// <summary>
        /// Guardars the specified pedido.
        /// </summary>
        /// <param name="pedido">The pedido.</param>
        /// <returns>return the PedidosEntidad</returns>
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
