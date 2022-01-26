using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SegundosEntidad
    {
        
        public SegundosEntidad()
        {
        }

        public SegundosEntidad(int idSegundo, string nomSegundo, byte[] imgSegundo, string ingSegundo)
        {
            IdSegundo = idSegundo;
            NomSegundo = nomSegundo;
            ImgSegundo = imgSegundo;
            IngSegundo = ingSegundo;
        }

        public int IdSegundo { get; set; }
        public string NomSegundo { get; set; }
        public byte[] ImgSegundo{ get; set; }
        public string IngSegundo { get; set; }
    }
}
