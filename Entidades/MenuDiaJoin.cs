using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MenuDiaJoin
    {
        
        public MenuDiaJoin()
        {
        }

        public MenuDiaJoin(int numero, string sopa, string segundo, string bebida, string entrada, DateTime fecha)
        {
            Numero = numero;
            Sopa = sopa;
            Segundo = segundo;
            Bebida = bebida;
            Entrada = entrada;
            Fecha = fecha;
        }

        public int Numero { get; set; }
        public string Sopa { get; set; }
        public string Segundo { get; set; }
        public string Bebida { get; set; }
        public string Entrada { get; set; }
        public DateTime Fecha { get; set; }
    }
}
