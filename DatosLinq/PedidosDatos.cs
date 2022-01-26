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
