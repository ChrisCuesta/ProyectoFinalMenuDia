using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MenuDiaEntidad
    {
        /// <summary>
        /// Se crea el constructor vacio para la entidad MenuDia
        /// </summary>
        public MenuDiaEntidad()
        {
        }
        /// <summary>
        /// Se crea el constructor con parámetros para la entidad MenuDia
        /// </summary>
        /// <param name="numMen">El número de menú</param>
        /// <param name="idSopaPer">El id de la sopa para el menú</param>
        /// <param name="idSegPer">El id del segundo para el menú</param>
        /// <param name="idBebPer">El id de la bebida para el menú</param>
        /// <param name="idEntPer">El id de la entrada para el menú</param>
        /// <param name="fecMen">La fecha que se ofrece este menú</param>
        public MenuDiaEntidad(int numMen, int idSopaPer, int idSegPer, int idBebPer, int idEntPer, DateTime fecMen)
        {
            NumMen = numMen;
            IdSopaPer = idSopaPer;
            IdSegPer = idSegPer;
            IdBebPer = idBebPer;
            IdEntPer = idEntPer;
            FecMen = fecMen;
        }
        /// <summary>
        /// Se encapsulan los atributos de la clase
        /// </summary>
        public int NumMen { get; set; }
        public int IdSopaPer { get; set; }
        public int IdSegPer { get; set; }
        public int IdBebPer { get; set; }
        public int IdEntPer { get; set; }
        public DateTime FecMen { get; set; }

    }
}
