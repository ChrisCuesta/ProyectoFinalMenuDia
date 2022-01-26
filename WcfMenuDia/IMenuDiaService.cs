using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Negocio;
using Entidades;
using System.ServiceModel.Web;

namespace WcfMenuDia
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMenuDiaService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMenuDiaService
    {
        //Menu dia
        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GuardarMenuDia/")]
        MenuDiaEntidad GuardarMenuDia(MenuDiaEntidad menuDia);
        [OperationContract]
        [WebGet(UriTemplate = "/ListaMenu", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<MenuDiaEntidad> DevolverListaMenuDia();
        [OperationContract]
        [WebGet(UriTemplate = "/ListaMenuJoin", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<MenuDiaJoin> DevolverListaMenuDiaJoin();
        [OperationContract]
        [WebGet(UriTemplate = "/Menu?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        MenuDiaEntidad DevolverMenuDiaPorId(int id);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/EliminarMenuDia?id={id}",
           ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        bool EliminarMenuDia(int id);
        [OperationContract]
        [WebGet(UriTemplate = "/MenuFecha?date={date}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<MenuDiaEntidad> DevolverMenuDiaPorFecha(DateTime date);
        //Sopas
        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GuardarSopa/")]
        SopasEntidad GuardarSopa(SopasEntidad sopaDia);
        [OperationContract]
        [WebGet(UriTemplate = "/ListaSopas", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<SopasEntidad> DevolverListaSopas();
        [OperationContract]
        [WebGet(UriTemplate = "/Sopa?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        SopasEntidad DevolverSopasPorId(int id);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/EliminarSopa?id={id}",
           ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        bool EliminarSopa(int id);
        [OperationContract]
        [WebGet(UriTemplate = "/SopaIngredientes?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        SopasEntidad DevolverIngredientesSopasPorId(int id);
        //Segundos
        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GuardarSegundo/")]
        SegundosEntidad GuardarSegundo(SegundosEntidad segundo);
        [OperationContract]
        [WebGet(UriTemplate = "/ListaSegundos", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<SegundosEntidad> DevolverListaSegundos();
        [OperationContract]
        [WebGet(UriTemplate = "/Segundo?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        SegundosEntidad DevolverSegundosPorId(int id);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/EliminarSegundo?id={id}",
           ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        bool EliminarSegundo(int id);
        [OperationContract]
        [WebGet(UriTemplate = "/SegundoIngredientes?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        SegundosEntidad DevolverIngredientesSegundoPorId(int id);
        //Bebidas
        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GuardarBebida/")]
        BebidasEntidad GuardarBebida(BebidasEntidad bebidas);
        [OperationContract]
        [WebGet(UriTemplate = "/ListaBebidas", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<BebidasEntidad> DevolverListaBebidas();
        [OperationContract]
        [WebGet(UriTemplate = "/Bebida?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        BebidasEntidad DevolverBebidasPorId(int id);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/EliminarBebida?id={id}",
           ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        bool EliminarBebida(int id);
        [OperationContract]
        [WebGet(UriTemplate = "/BebidaIngredientes?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        BebidasEntidad DevolverIngredientesBebidaPorId(int id);

        //Entradas
        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GuardarEntrada/")]
        EntradasEntidad GuardarEntrada(EntradasEntidad entrada);
        [OperationContract]
        [WebGet(UriTemplate = "/ListaEntrada", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<EntradasEntidad> DevolverListaEntrada();
        [OperationContract]
        [WebGet(UriTemplate = "/Entrada?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        EntradasEntidad DevolverEntradasPorId(int id);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/EliminarEntrada?id={id}",
           ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        bool EliminarEntrada(int id);
        [OperationContract]
        [WebGet(UriTemplate = "/EntradaIngredientes?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        EntradasEntidad DevolverIngredientesEntradaPorId(int id);
        //pedidos
        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GuardarPedido/")]
        PedidosEntidad GuardarPedido(PedidosEntidad pedido);

    }
}
