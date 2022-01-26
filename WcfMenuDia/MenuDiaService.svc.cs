using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Negocio;

namespace WcfMenuDia
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "MenuDiaService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione MenuDiaService.svc o MenuDiaService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class MenuDiaService : IMenuDiaService
    {
        public BebidasEntidad DevolverBebidasPorId(int id)
        {
            return BebidasNegocio.DevolverBebidasPorId(id);
        }

        public EntradasEntidad DevolverEntradasPorId(int id)
        {
            return EntradasNegocio.DevolverEntradasPorId(id);
        }

        public List<BebidasEntidad> DevolverListaBebidas()
        {
            return BebidasNegocio.DevolverListaBebidas();
        }

        public List<EntradasEntidad> DevolverListaEntrada()
        {
            return EntradasNegocio.DevolverListaEntrada();
        }

        public List<MenuDiaEntidad> DevolverListaMenuDia()
        {
            return MenuDiaNegocio.DevolverListaMenuDia();
        }

        public List<MenuDiaJoin> DevolverListaMenuDiaJoin()
        {
            return MenuDiaNegocio.DevolverListaMenuDiaJoin();
        }

        public List<SegundosEntidad> DevolverListaSegundos()
        {
            return SegundoNegocio.DevolverListaSegundos();
        }

        public List<SopasEntidad> DevolverListaSopas()
        {
            return SopaNegocio.DevolverListaSopas();
        }

        public MenuDiaEntidad DevolverMenuDiaPorId(int id)
        {
            return MenuDiaNegocio.DevolverMenuDiaPorId(id);
        }

        public SegundosEntidad DevolverSegundosPorId(int id)
        {
            return SegundoNegocio.DevolverSegundosPorId(id);
        }

        public SopasEntidad DevolverSopasPorId(int id)
        {
            return SopaNegocio.DevolverSopasPorId(id);
        }

        public bool EliminarBebida(int id)
        {
            return BebidasNegocio.EliminarBebida(id);
        }

        public bool EliminarEntrada(int id)
        {
            return EntradasNegocio.EliminarEntrada(id);
        }

        public bool EliminarMenuDia(int id)
        {
            return MenuDiaNegocio.EliminarMenuDia(id);
        }

        public bool EliminarSegundo(int id)
        {
            return SegundoNegocio.EliminarSegundo(id);
        }

        public bool EliminarSopa(int id)
        {
            return SopaNegocio.EliminarSopa(id);
        }

        public MenuDiaEntidad GuardarMenuDia(MenuDiaEntidad menuDia)
        {
            return MenuDiaNegocio.Guardar(menuDia);
        }

        public SopasEntidad GuardarSopa(SopasEntidad sopaDia)
        {
            return SopaNegocio.Guardar(sopaDia);
        }

        public SegundosEntidad GuardarSegundo(SegundosEntidad segundo)
        {
            return SegundoNegocio.Guardar(segundo);
        }

        public BebidasEntidad GuardarBebida(BebidasEntidad bebidas)
        {
            return BebidasNegocio.Guardar(bebidas);
        }

        public EntradasEntidad GuardarEntrada(EntradasEntidad entrada)
        {
            return EntradasNegocio.Guardar(entrada);
        }

        public SopasEntidad DevolverIngredientesSopasPorId(int id)
        {
            return SopaNegocio.DevolverIngredientesSopasPorId(id);
        }

        public SegundosEntidad DevolverIngredientesSegundoPorId(int id)
        {
            return SegundoNegocio.DevolverIngredientesSegundosPorId(id);
        }

        public BebidasEntidad DevolverIngredientesBebidaPorId(int id)
        {
            return BebidasNegocio.DevolverIngredientesBebidasPorId(id);
        }

        public EntradasEntidad DevolverIngredientesEntradaPorId(int id)
        {
            return EntradasNegocio.DevolverIngredientesEntradasPorId(id);
        }

        public List<MenuDiaEntidad> DevolverMenuDiaPorFecha(DateTime date)
        {
            return MenuDiaNegocio.DevolverMenuDiaPorFecha(date);
        }

        public PedidosEntidad GuardarPedido(PedidosEntidad pedido)
        {
            return PedidosNegocio.Guardar(pedido);
        }
    }
}
