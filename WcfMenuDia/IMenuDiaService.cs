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
        /// <summary>
        /// Método para guardar el menú del día
        /// </summary>
        /// <param name="menuDia">Menú del día</param>
        /// <returns>Retorna la entidad MenuDia</returns>
        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GuardarMenuDia/")]
        MenuDiaEntidad GuardarMenuDia(MenuDiaEntidad menuDia);
        /// <summary>
        /// Método para listar menús
        /// </summary>
        /// <returns>Retorna lista de menús</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/ListaMenu", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<MenuDiaEntidad> DevolverListaMenuDia();
        /// <summary>
        /// Método para devolver lista de menúsJoin
        /// </summary>
        /// <returns>Retorna lista de menús Join</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/ListaMenuJoin", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<MenuDiaJoin> DevolverListaMenuDiaJoin();
        /// <summary>
        /// Método para devolver menú del día por su Id
        /// </summary>
        /// <param name="id">Id del menú</param>
        /// <returns>Retorna el menú al que se refiere el id</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/Menu?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        MenuDiaEntidad DevolverMenuDiaPorId(int id);
        /// <summary>
        /// Método para eliminar el menú del día por el Id
        /// </summary>
        /// <param name="id">Id del menú</param>
        /// <returns>Retorna un booleano al eliminar el menú</returns>
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/EliminarMenuDia?id={id}",
           ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        bool EliminarMenuDia(int id);
        /// <summary>
        /// Método para devolver el menú del día por su fecha
        /// </summary>
        /// <param name="date">Fecha del menú</param>
        /// <returns>Retorna lista de menús de la fecha</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/MenuFecha?date={date}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<MenuDiaEntidad> DevolverMenuDiaPorFecha(DateTime date);
        //Sopas
        /// <summary>
        /// Método para guardar una sopa
        /// </summary>
        /// <param name="sopaDia">Entidad sopa a guardar</param>
        /// <returns>Retorna una SopaEntidad</returns>
        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GuardarSopa/")]
        SopasEntidad GuardarSopa(SopasEntidad sopaDia);
        /// <summary>
        /// Método para listar las sopas
        /// </summary>
        /// <returns>Retorna lista de sopas</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/ListaSopas", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<SopasEntidad> DevolverListaSopas();
        /// <summary>
        /// Método para obtener sopa por su Id
        /// </summary>
        /// <param name="id">Id de la sopa</param>
        /// <returns>Retorna la SopasEntidad</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/Sopa?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        SopasEntidad DevolverSopasPorId(int id);
        /// <summary>
        /// Método para eliminar la Sopa
        /// </summary>
        /// <param name="id">Id de la sopa</param>
        /// <returns>Retorna un booleano al eliminar la sopa</returns>
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/EliminarSopa?id={id}",
           ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        bool EliminarSopa(int id);
        /// <summary>
        /// Método para obtener ingredientes de la sopa por su Id
        /// </summary>
        /// <param name="id">Id de la sopa</param>
        /// <returns>Retorna los ingredientes de la sopa</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/SopaIngredientes?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        SopasEntidad DevolverIngredientesSopasPorId(int id);
        //Segundos
        /// <summary>
        /// Método para guardar un segundo
        /// </summary>
        /// <param name="segundo">Entidad Segundo a guardar</param>
        /// <returns>Retorna un SegundosEntidad</returns>
        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GuardarSegundo/")]
        SegundosEntidad GuardarSegundo(SegundosEntidad segundo);
        /// <summary>
        /// Método para listar los Segundos
        /// </summary>
        /// <returns>Retorna lista de segundos</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/ListaSegundos", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<SegundosEntidad> DevolverListaSegundos();
        /// <summary>
        /// Método para obtener un segundo por su Id
        /// </summary>
        /// <param name="id">Id del segundo</param>
        /// <returns>Retorna un SegundosEntidad</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/Segundo?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        SegundosEntidad DevolverSegundosPorId(int id);
        /// <summary>
        /// Método para eliminar un segundo por su Id
        /// </summary>
        /// <param name="id">Id del segundo</param>
        /// <returns>Retorna un booleano del segundo eliminado</returns>
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/EliminarSegundo?id={id}",
           ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        bool EliminarSegundo(int id);
        /// <summary>
        /// Método para obtener ingredientes del segundo por su Id
        /// </summary>
        /// <param name="id">Id del segundo</param>
        /// <returns>Retorna los ingredientes del segundo</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/SegundoIngredientes?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        SegundosEntidad DevolverIngredientesSegundoPorId(int id);
        //Bebidas
        /// <summary>
        /// Método para guardar una bebida
        /// </summary>
        /// <param name="bebidas">Entidad bebida a guardar</param>
        /// <returns>Retorna un BebidasEntidad</returns>
        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GuardarBebida/")]
        BebidasEntidad GuardarBebida(BebidasEntidad bebidas);
        /// <summary>
        /// Método para listar bebidas
        /// </summary>
        /// <returns>Retorna una lista de bebidas</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/ListaBebidas", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<BebidasEntidad> DevolverListaBebidas();
        /// <summary>
        /// Método para devolver bebidas por su Id
        /// </summary>
        /// <param name="id">Id de la bebida</param>
        /// <returns>Retorna un BebidasEntidad</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/Bebida?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        BebidasEntidad DevolverBebidasPorId(int id);
        /// <summary>
        /// Método para eliminar bebida por su Id
        /// </summary>
        /// <param name="id">Id de la bebida</param>
        /// <returns>Retorna un booleano de la bebida eliminada</returns>
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/EliminarBebida?id={id}",
           ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        bool EliminarBebida(int id);
        /// <summary>
        /// Método para obtener ingredientes de la bebida
        /// </summary>
        /// <param name="id">Id de la bebida</param>
        /// <returns>Retorna los ingredientes de la bebida</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/BebidaIngredientes?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        BebidasEntidad DevolverIngredientesBebidaPorId(int id);

        //Entradas
        /// <summary>
        /// Método para guardar una Entrada
        /// </summary>
        /// <param name="entrada">Entidad Entrada a guardar</param>
        /// <returns>Retorna un EntradasEntidad</returns>
        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GuardarEntrada/")]
        EntradasEntidad GuardarEntrada(EntradasEntidad entrada);
        /// <summary>
        /// Método para listar Entradas
        /// </summary>
        /// <returns>Retorna lista de entradas</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/ListaEntrada", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<EntradasEntidad> DevolverListaEntrada();
        /// <summary>
        /// Método para devolver entrada por su Id
        /// </summary>
        /// <param name="id">Id de la entrada</param>
        /// <returns>Retorna un EntradasEntidad</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/Entrada?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        EntradasEntidad DevolverEntradasPorId(int id);
        /// <summary>
        /// Método para eliminar una entrada por su Id
        /// </summary>
        /// <param name="id">Id de la Entrada</param>
        /// <returns>Retorna un booleano de la entrada eliminada</returns>
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/EliminarEntrada?id={id}",
           ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        bool EliminarEntrada(int id);
        /// <summary>
        /// Método para obtener ingredientes de la entrada
        /// </summary>
        /// <param name="id">Id de la entrada</param>
        /// <returns>Retorna los ingredientes de la entrada</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/EntradaIngredientes?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        EntradasEntidad DevolverIngredientesEntradaPorId(int id);
        //Pedidos
        /// <summary>
        /// Método para guardar pedido
        /// </summary>
        /// <param name="pedido">Entidad Pedido a guardar</param>
        /// <returns>Retorna un PedidosEntidad</returns>
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
