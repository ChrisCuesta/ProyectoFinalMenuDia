using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MenuDiaEntidad
    {
        public MenuDiaEntidad()
        {
        }

        public MenuDiaEntidad(int numMen, int idSopaPer, int idSegPer, int idBebPer, int idEntPer, DateTime fecMen)
        {
            NumMen = numMen;
            IdSopaPer = idSopaPer;
            IdSegPer = idSegPer;
            IdBebPer = idBebPer;
            IdEntPer = idEntPer;
            FecMen = fecMen;
        }

        public int NumMen { get; set; }
        public int IdSopaPer { get; set; }
        public int IdSegPer { get; set; }
        public int IdBebPer { get; set; }
        public int IdEntPer { get; set; }
        public DateTime FecMen { get; set; }

    }
}
