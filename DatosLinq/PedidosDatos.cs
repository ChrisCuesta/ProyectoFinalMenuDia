using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DatosLinq
{
    public static class PedidosDatos
    {
        /// <summary>
        /// Se ingresara un nuevo pedido
        /// </summary>
        /// <param name="pedidoMenu">Variable donde se ingresa el pedido</param>
        /// <returns>Devuelve el pedido seleccionado del menu</returns>
        public static PedidosEntidad Nuevo(PedidosEntidad pedidoMenu)
        {
            PEDIDOS ped = new PEDIDOS();
            ped.ID_PED = pedidoMenu.Id;
            ped.CAN_PED = pedidoMenu.CantidadPedido;
            ped.NOM_CLI_PED = pedidoMenu.NombreCliente;
            ped.ID_MEN_PER = pedidoMenu.IdPedPer;
            using (DataClasses1DataContext contexto = new DataClasses1DataContext())
            {
                contexto.PEDIDOS.InsertOnSubmit(ped);
                contexto.SubmitChanges();
            }
            pedidoMenu.Id = ped.ID_PED;
            return pedidoMenu;
        }
        /// <summary>
        /// Se modificara el pedido realizado
        /// </summary>
        /// <param name="pedidoMenu">variable donde se ingresan los datos del pedido </param>
        /// <returns>Se devuelve el pedido del menu seleccionado junto a sus modificaciones</returns>
        public static PedidosEntidad Actualizar(PedidosEntidad pedidoMenu)
        {
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var ped  = contexto.PEDIDOS.FirstOrDefault(cc => cc.ID_PED == pedidoMenu.Id);
                    ped.ID_PED = pedidoMenu.Id;
                    ped.CAN_PED = pedidoMenu.CantidadPedido;
                    ped.NOM_CLI_PED = pedidoMenu.NombreCliente;
                    ped.ID_MEN_PER = pedidoMenu.IdPedPer;
                    contexto.SubmitChanges();
                }
                return pedidoMenu;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
