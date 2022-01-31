using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MenuDiaJoin
    {
        /// <summary>
        /// Se crea el constructor vacio de la entidad MenuDiaJoin
        /// </summary>
        public MenuDiaJoin()
        {
        }
        /// <summary>
        /// Se crea el constructor con parámetros de la entidad MenuDiaJoin
        /// </summary>
        /// <param name="numero">El número de menú</param>
        /// <param name="sopa">La sopa del menú</param>
        /// <param name="segundo">El segundo del menú</param>
        /// <param name="bebida">La bebida del menú</param>
        /// <param name="entrada">La entrada del menú</param>
        /// <param name="fecha">La fecha que se ofrece el menú</param>
        public MenuDiaJoin(int numero, string sopa, string segundo, string bebida, string entrada, DateTime fecha)
        {
            Numero = numero;
            Sopa = sopa;
            Segundo = segundo;
            Bebida = bebida;
            Entrada = entrada;
            Fecha = fecha;
        }
        /// <summary>
        /// Se encapsulan los atributos de la clase
        /// </summary>
        public int Numero { get; set; }
        public string Sopa { get; set; }
        public string Segundo { get; set; }
        public string Bebida { get; set; }
        public string Entrada { get; set; }
        public DateTime Fecha { get; set; }
    }
}
