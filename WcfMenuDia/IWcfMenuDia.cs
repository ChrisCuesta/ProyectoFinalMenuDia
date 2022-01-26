using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
namespace WcfMenuDia
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWcfMenuDia" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWcfMenuDia
    {
        //Menu dia
        [OperationContract]
        MenuDiaEntidad GuardarMenuDia(MenuDiaEntidad menuDia);
        [OperationContract]
        List<MenuDiaEntidad> DevolverListaMenuDia();
        [OperationContract]
        List<MenuDiaJoin> DevolverListaMenuDiaJoin();
        [OperationContract]
        MenuDiaEntidad DevolverMenuDiaPorId(int id);
        [OperationContract]
        bool EliminarMenuDia(int id);
        [OperationContract]
        List<MenuDiaEntidad> DevolverMenuDiaPorFecha(DateTime date);
        //Sopas
        [OperationContract]
        SopasEntidad GuardarSopa(SopasEntidad sopaDia);
        [OperationContract]
        List<SopasEntidad> DevolverListaSopas();
        [OperationContract]
        SopasEntidad DevolverSopasPorId(int id);
        [OperationContract]
        bool EliminarSopa(int id);
        [OperationContract]
        SopasEntidad DevolverIngredientesSopasPorId(int id);
        //Segundos
        [OperationContract]
        SegundosEntidad GuardarSegundo(SegundosEntidad segundo);
        [OperationContract]
        List<SegundosEntidad> DevolverListaSegundos();
        [OperationContract]
        SegundosEntidad DevolverSegundosPorId(int id);
        [OperationContract]
        bool EliminarSegundo(int id);
        [OperationContract]
        SegundosEntidad DevolverIngredientesSegundoPorId(int id);
        //Bebidas
        [OperationContract]
        BebidasEntidad GuardarBebida(BebidasEntidad bebidas);
        [OperationContract]
        List<BebidasEntidad> DevolverListaBebidas();
        [OperationContract]
        BebidasEntidad DevolverBebidasPorId(int id);
        [OperationContract]
        bool EliminarBebida(int id);
        [OperationContract]
        BebidasEntidad DevolverIngredientesBebidaPorId(int id);

        //Entradas
        [OperationContract]
        EntradasEntidad GuardarEntrada(EntradasEntidad entrada);
        [OperationContract]
        List<EntradasEntidad> DevolverListaEntrada();
        [OperationContract]
        EntradasEntidad DevolverEntradasPorId(int id);
        [OperationContract]
        bool EliminarEntrada(int id);
        [OperationContract]
        EntradasEntidad DevolverIngredientesEntradaPorId(int id);
        //pedidos
        [OperationContract]
        PedidosEntidad GuardarPedido(PedidosEntidad pedido);
    }
}
