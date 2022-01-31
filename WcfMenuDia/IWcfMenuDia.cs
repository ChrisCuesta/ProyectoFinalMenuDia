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
        /// <summary>
        /// Método para guardar el menú del día
        /// </summary>
        /// <param name="menuDia">Menú del día</param>
        /// <returns>Retorna la entidad MenuDia</returns>
        [OperationContract]
        MenuDiaEntidad GuardarMenuDia(MenuDiaEntidad menuDia);
        /// <summary>
        /// Método para listar menús
        /// </summary>
        /// <returns>Retorna lista de menús</returns>
        [OperationContract]
        List<MenuDiaEntidad> DevolverListaMenuDia();
        /// <summary>
        /// Método para devolver lista de menúsJoin
        /// </summary>
        /// <returns>Retorna lista de menús Join</returns>
        [OperationContract]
        List<MenuDiaJoin> DevolverListaMenuDiaJoin();
        /// <summary>
        /// Método para devolver menú del día por su Id
        /// </summary>
        /// <param name="id">Id del menú</param>
        /// <returns>Retorna el menú al que se refiere el id</returns>
        [OperationContract]
        MenuDiaEntidad DevolverMenuDiaPorId(int id);
        /// <summary>
        /// Método para eliminar el menú del día por el Id
        /// </summary>
        /// <param name="id">Id del menú</param>
        /// <returns>Retorna un booleano al eliminar el menú</returns>
        [OperationContract]
        bool EliminarMenuDia(int id);
        /// <summary>
        /// Método para devolver el menú del día por su fecha
        /// </summary>
        /// <param name="date">Fecha del menú</param>
        /// <returns>Retorna lista de menús de la fecha</returns>
        [OperationContract]
        List<MenuDiaEntidad> DevolverMenuDiaPorFecha(DateTime date);
        //Sopas
        /// <summary>
        /// Método para guardar una sopa
        /// </summary>
        /// <param name="sopaDia">Entidad sopa a guardar</param>
        /// <returns>Retorna una SopaEntidad</returns>
        [OperationContract]
        SopasEntidad GuardarSopa(SopasEntidad sopaDia);
        /// <summary>
        /// Método para listar las sopas
        /// </summary>
        /// <returns>Retorna lista de sopas</returns>
        [OperationContract]
        List<SopasEntidad> DevolverListaSopas();
        /// <summary>
        /// Método para obtener sopa por su Id
        /// </summary>
        /// <param name="id">Id de la sopa</param>
        /// <returns>Retorna la SopasEntidad</returns>
        [OperationContract]
        SopasEntidad DevolverSopasPorId(int id);
        /// <summary>
        /// Método para eliminar la Sopa
        /// </summary>
        /// <param name="id">Id de la sopa</param>
        /// <returns>Retorna un booleano al eliminar la sopa</returns>
        [OperationContract]
        bool EliminarSopa(int id);
        /// <summary>
        /// Método para obtener ingredientes de la sopa por su Id
        /// </summary>
        /// <param name="id">Id de la sopa</param>
        /// <returns>Retorna los ingredientes de la sopa</returns>
        [OperationContract]
        SopasEntidad DevolverIngredientesSopasPorId(int id);
        //Segundos
        /// <summary>
        /// Método para guardar un segundo
        /// </summary>
        /// <param name="segundo">Entidad Segundo a guardar</param>
        /// <returns>Retorna un SegundosEntidad</returns>
        [OperationContract]
        SegundosEntidad GuardarSegundo(SegundosEntidad segundo);
        /// <summary>
        /// Método para listar los Segundos
        /// </summary>
        /// <returns>Retorna lista de segundos</returns>
        [OperationContract]
        List<SegundosEntidad> DevolverListaSegundos();
        /// <summary>
        /// Método para obtener un segundo por su Id
        /// </summary>
        /// <param name="id">Id del segundo</param>
        /// <returns>Retorna un SegundosEntidad</returns>
        [OperationContract]
        SegundosEntidad DevolverSegundosPorId(int id);
        /// <summary>
        /// Método para eliminar un segundo por su Id
        /// </summary>
        /// <param name="id">Id del segundo</param>
        /// <returns>Retorna un booleano del segundo eliminado</returns>
        [OperationContract]
        bool EliminarSegundo(int id);
        /// <summary>
        /// Método para obtener ingredientes del segundo por su Id
        /// </summary>
        /// <param name="id">Id del segundo</param>
        /// <returns>Retorna los ingredientes del segundo</returns>
        [OperationContract]
        SegundosEntidad DevolverIngredientesSegundoPorId(int id);
        //Bebidas
        /// <summary>
        /// Método para guardar una bebida
        /// </summary>
        /// <param name="bebidas">Entidad bebida a guardar</param>
        /// <returns>Retorna un BebidasEntidad</returns>
        [OperationContract]
        BebidasEntidad GuardarBebida(BebidasEntidad bebidas);
        /// <summary>
        /// Método para listar bebidas
        /// </summary>
        /// <returns>Retorna una lista de bebidas</returns>
        [OperationContract]
        List<BebidasEntidad> DevolverListaBebidas();
        /// <summary>
        /// Método para devolver bebidas por su Id
        /// </summary>
        /// <param name="id">Id de la bebida</param>
        /// <returns>Retorna un BebidasEntidad</returns>
        [OperationContract]
        BebidasEntidad DevolverBebidasPorId(int id);
        /// <summary>
        /// Método para eliminar bebida por su Id
        /// </summary>
        /// <param name="id">Id de la bebida</param>
        /// <returns>Retorna un booleano de la bebida eliminada</returns>
        [OperationContract]
        bool EliminarBebida(int id);
        /// <summary>
        /// Método para obtener ingredientes de la bebida
        /// </summary>
        /// <param name="id">Id de la bebida</param>
        /// <returns>Retorna los ingredientes de la bebida</returns>
        [OperationContract]
        BebidasEntidad DevolverIngredientesBebidaPorId(int id);

        //Entradas
        /// <summary>
        /// Método para guardar una Entrada
        /// </summary>
        /// <param name="entrada">Entidad Entrada a guardar</param>
        /// <returns>Retorna un EntradasEntidad</returns>
        [OperationContract]
        EntradasEntidad GuardarEntrada(EntradasEntidad entrada);
        /// <summary>
        /// Método para listar Entradas
        /// </summary>
        /// <returns>Retorna lista de entradas</returns>
        [OperationContract]
        List<EntradasEntidad> DevolverListaEntrada();
        /// <summary>
        /// Método para devolver entrada por su Id
        /// </summary>
        /// <param name="id">Id de la entrada</param>
        /// <returns>Retorna un EntradasEntidad</returns>
        [OperationContract]
        EntradasEntidad DevolverEntradasPorId(int id);
        /// <summary>
        /// Método para eliminar una entrada por su Id
        /// </summary>
        /// <param name="id">Id de la Entrada</param>
        /// <returns>Retorna un booleano de la entrada eliminada</returns>
        [OperationContract]
        bool EliminarEntrada(int id);
        /// <summary>
        /// Método para obtener ingredientes de la entrada
        /// </summary>
        /// <param name="id">Id de la entrada</param>
        /// <returns>Retorna los ingredientes de la entrada</returns>
        [OperationContract]
        EntradasEntidad DevolverIngredientesEntradaPorId(int id);
        //pedidos
        /// <summary>
        /// Método para guardar pedido
        /// </summary>
        /// <param name="pedido">Entidad Pedido a guardar</param>
        /// <returns>Retorna un PedidosEntidad</returns>
        [OperationContract]
        PedidosEntidad GuardarPedido(PedidosEntidad pedido);
    }
}
