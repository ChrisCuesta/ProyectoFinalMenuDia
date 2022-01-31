using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PedidosEntidad
    {
        /// <summary>
        /// Se encapsulan los atributos de la clase
        /// </summary>
        public int Id { get; set; }
        public int CantidadPedido { get; set; }
        public string NombreCliente { get; set; }
        public int IdPedPer { get; set; }
    }
}
