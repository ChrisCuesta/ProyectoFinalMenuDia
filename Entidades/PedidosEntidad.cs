using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PedidosEntidad
    {
        public int Id { get; set; }
        public int CantidadPedido { get; set; }
        public string NombreCliente { get; set; }
        public int IdPedPer { get; set; }
    }
}
